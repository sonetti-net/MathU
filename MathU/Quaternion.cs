using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathU
{
	public struct Quaternion
	{
		public double w, x, y, z;

		public Quaternion(double w, double x, double y, double z)
		{
			this.w = w;
			this.x = x;
			this.y = y;
			this.z = z;
			
		}

		public Quaternion(float value)
		{
			this.w = value;
			this.x = value;
			this.y = value;
			this.z = value;
		}

		public Quaternion()
		{
			this.w = 0;
			this.x = 0;
			this.y = 0;
			this.z = 0;

		}

		//deep
		public override string ToString()
		{
			return $"{w}, ({x}, {y}, {z})";
		}

		public double Magnitude()
		{
			double result = (w * w) + (x * x) + (y * y) + (z * z);

			return Operations.Sqrt(result);
		}

		public Quaternion Conjugate()
		{
			Quaternion result = new Quaternion(w, -x, -y, -z);

			return result;
		}

		public static Quaternion Identity()
		{
			return new Quaternion(1, 0, 0, 0);
		}

		public Quaternion Inverse()
		{
			Quaternion result = Conjugate();

			result.w = w / this.Magnitude();
			result.x = x / this.Magnitude();
			result.y = y / this.Magnitude();
			result.z = z / this.Magnitude();

			return result;
		}
	}
}
