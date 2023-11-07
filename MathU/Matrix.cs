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
				throw new Exception("Cannot multiply");
			}
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

		public static Matrix Dot(Matrix left, Matrix right)
		{
			if (left.rows == right.cols)
			{
				Matrix result = new Matrix(left.rows, right.cols);

				for (int i = 0; i < left.rows; i++)
				{
					for (int j = 0; j < right.cols; j++)
					{
						for (int k = 0; k < left.cols; k++)
						{

						}
					}
				}


				return result;
			}
			else
			{
				throw new Exception("Mismatched matrix");
			}
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


	}
}
