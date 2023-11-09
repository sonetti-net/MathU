namespace MathU
{
	public struct Matrix
	{
		public int rows { get; set; }
		public int cols { get; set; }

		public float[,] data { get; set; }

		public Matrix(int rows, int cols)
		{
			this.rows = rows;
			this.cols = cols;
			this.data = new float[rows, cols];
		}

		public override string ToString()
		{
			string output = string.Empty;

			for (int x = 0; x < this.rows; x++)
			{
				for (int y = 0; y < this.cols; y++)
				{
					output += $"{this.data[x, y].ToString("0.00")}, ";
				}
				output += "\n";
			}

			return output;
		}

		public static Matrix operator *(Matrix A, Matrix B)
		{
			if (A.cols == B.rows)
			{
				Matrix result = new Matrix(A.rows, B.cols);
				for (int i = 0; i < A.rows; i++)
				{
					for ( int j = 0; j < B.cols; j++)
					{
						float sum = 0;
						for (int k = 0; k < A.cols; k++)
						{
							sum += A.data[i,k] * B.data[k, j];
						}
						result.data[i, j] = sum;
					}
				}

				return result;
			}
			else // Abort if mutiplication not possible.
			{
				// Multiplying a vector of n dimensions
				if (A.cols == 1 && A.rows == B.rows && A.cols == B.cols)
				{
					Matrix result = new Matrix(A.rows, 1);
					for (int i = 0; i < A.rows; i++)
					{
						result.data[i,0] = A.data[i, 0] * B.data[i,0];	
					}
					return result;
				}
				else
				{
					throw new Exception("Cannot multiply");
				}
			}
		}

		public static Matrix operator *(Matrix A, Vector2 right)
		{
			Matrix rightM = new Matrix(2, 1);
			rightM.data[0, 0] = right.x;
			rightM.data[1, 0] = right.y;
			return (A * rightM);
		}

		public static Matrix Transform(Vector2 left, Matrix right)
		{
			Matrix leftM = new Matrix(2, 1);
			leftM.data[0, 0] = left.x;
			leftM.data[1, 0] = left.y;

			Matrix result = new Matrix(2, right.rows);

			for (int col = 0; col < right.cols; col++)
			{
				for (int row = 0; row < right.rows; row++)
				{
					float l = leftM.data[row, 0];
					float r = right.data[row, col];
					result.data[col, row] = l * r;

					
				}
			}

			return result;
		}

		public static Matrix operator +(Matrix left, Matrix right)
		{
			if (left.rows == right.rows && left.cols == right.cols)
			{
				Matrix result = new Matrix(left.rows, left.cols);

				for (int i = 0; i < left.rows; i++)
				{
					for (int j = 0; j < left.cols; j++)
					{
						result.data[i, j] = left.data[i, j] + right.data[i, j]; ;
					}
				}
				return result;
			}
			else
			{
				throw new Exception("Cannot add");
			}
		}
		public static Matrix operator -(Matrix left, Matrix right)
		{
			if (left.rows == right.rows && left.cols == right.cols)
			{
				Matrix result = new Matrix(left.rows, left.cols);

				for (int i = 0; i < left.rows; i++)
				{
					for (int j = 0; j < left.cols; j++)
					{
						result.data[i, j] = left.data[i, j] - right.data[i, j];
					}
				}
				return result;
			}
			else
			{
				throw new Exception("Cannot add");
			}
		}

		public static float Dot(Matrix left, Matrix right)
		{
			float result = 0;
			if (left.cols == 1 && left.rows == right.rows && left.cols == right.cols)
			{
				for (int i = 0; i < left.rows; i++)
				{
					result = result + (left.data[i,0]*right.data[i,0]);
				}
			}


			return result;
		}

		public float Magnitude()
		{
			float sum = 0;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					sum += (this.data[i, j] * this.data[i, j]);
				}
			}

			return (float)Math.Sqrt(sum);
		}

		public Matrix Unit()
		{
			Matrix result = new Matrix(rows, cols);

			float mag = this.Magnitude();

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					result.data[i, j] = this.data[i,j] / mag;
				}
			}
			return result;
		}

		public static Matrix Identity(int n)
		{
			Matrix result = new Matrix(n, n);
			
			for (int i = 0; i < result.rows; i++)
			{
				for (int j = 0; j < result.cols; j++)
				{
					if (i == j)
					{
						result.data[i, j] = 1;
					}
					else
					{
						result.data[i, j] = 0;
					}
				}
			}
			return result;
		}

		public Matrix Transpose()
		{
			Matrix transposed = new Matrix(this.cols, this.rows);
			for (int row = 0; row < this.rows; row++)
			{
				for (int col = 0; col < this.cols; col++)
				{
					transposed.data[col, row] = this.data[row, col];
				}
			}

			return transposed;
		}
	}
}
