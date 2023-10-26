namespace MathU
{
	public class Matrix
	{
		public int rows { get; set; }
		public int cols { get; set; }

		public int[,] data { get; set; }

		public Matrix(int rows, int cols)
		{
			this.rows = rows;
			this.cols = cols;
			this.data = new int[rows, cols];
		}

		public override string ToString()
		{
			string output = string.Empty;

			for (int x = 0; x < this.rows; x++)
			{
				for (int y = 0; y < this.cols; y++)
				{
					output += $"{this.data[x, y]}, ";
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
						int sum = 0;
						for (int k = 0; k < A.cols; k++)
						{
							sum += A.data[i,k] * B.data[k, j];
						}
						result.data[i, j] = sum;
					}
				}

				return result;
			}
			else
			{
				throw new Exception("Cannot multiply");
			}
		}
	}
}
