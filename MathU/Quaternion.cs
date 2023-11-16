using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathU
{
	public struct Quaternion
	{
		public double w, i, j, k;

		public Quaternion(double w, double i, double j, double k)
		{
			this.w = w;
			this.i = i;
			this.j = j;
			this.k = k;
			
		}

		public Quaternion(float value)
		{
			this.w = value;
			this.i = value;
			this.j = value;
			this.k = value;
		}
		//deep
		public override string ToString()
		{
			return $"({w}, ({i}, {j}, {k})";
		}

		public double Magnitude()
		{
			double result = (w * w) + (i * i) + (j * j) + (k * k);

			return Operations.Sqrt(result);
		}

		public Quaternion Conjugate()
		{
			Quaternion result = new Quaternion(w, -i, -j, -k);

			return result;
		}

		public Quaternion Inverse()
		{
			Quaternion result = Conjugate();

			result.w = w / this.Magnitude();
			result.i = i / this.Magnitude();
			result.j = j / this.Magnitude();
			result.k = k / this.Magnitude();

			return result;
		}
	}
}
