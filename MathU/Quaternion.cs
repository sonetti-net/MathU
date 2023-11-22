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

		// Operators

		public static Quaternion operator *(Quaternion left, Quaternion right)
		{
			Quaternion result = new Quaternion();
			

			result.x = (left.w * right.x) + (left.x * right.w) + (left.y * right.z) - (left.z * right.y);
			result.y = (left.w * right.y) + (left.y * right.w) + (left.z * right.x) - (left.x * right.z);
			result.z = (left.w * right.z) + (left.z * right.w) + (left.x * right.y) - (left.y * right.x);
			result.w = (left.w * right.w) - (left.x * right.x) - (left.y * right.y) - (left.z * right.z);


			return result;
		}

		public static Quaternion operator -(Quaternion left, Quaternion right)
		{
			Quaternion result = new Quaternion();
			



			return result;
		}

		public static Quaternion operator +(Quaternion left, Quaternion right)
		{
			Quaternion result = new Quaternion();




			return result;
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

		public Quaternion Inverse()
		{
			Quaternion result = Conjugate();

			result.w = w / this.Magnitude();
			result.x = x / this.Magnitude();
			result.y = y / this.Magnitude();
			result.z = z / this.Magnitude();

			return result;
		}

		public static Quaternion Identity()
		{
			return new Quaternion(1, 0, 0, 0);
		}

		public static Quaternion Euler(double x, double y, double z)
		{
			x = Operations.Rad(x) / 2;
			y = Operations.Rad(y) / 2;
			z = Operations.Rad(z) /2;

			Vector3 cos = new Vector3(MathF.Cos((float)x), MathF.Cos((float)y), MathF.Cos((float)z));
			Vector3 sin = new Vector3(MathF.Sin((float)x), MathF.Sin((float)y), MathF.Sin((float)z));


			//w = cos.x * cos.y * cos.z + sin.y * sin.z * sin.x
			//x = sin.x * ccos.y * cos.z - sin.y * sin.z * cos.x,
			//y = sin.y * cos.x * cos.z + sin.x * sin.z * cos.y,
			//z = sin.z * cos.x * cos.y - sin.x * sin.y * cos.z,

			Quaternion result = new Quaternion();

			result.w = cos.x * cos.y * cos.z + sin.x * sin.y * sin.z;

			result.x = sin.x * cos.y * cos.z - sin.y * sin.z * cos.x;
			result.y = sin.y * cos.x * cos.z + sin.x * sin.z * cos.y;
			result.z = sin.z * cos.x * cos.y - sin.x * sin.y * cos.z;


			return result;
		}

		public static Quaternion FromMatrix(Matrix m)
		{
			if (m.rows != 3 && m.cols != 3)
			{
				throw new Exception("Cannot convert");
			}

			Quaternion result = new Quaternion();

			result.w = Operations.Sqrt(m[0, 0] + m[1, 1] + m[2, 2] + 1);
			result.x = Operations.Sqrt(m[0, 0] - m[1, 1] - m[2, 2] + 1);
			result.y = Operations.Sqrt(-m[0,0] + m[1,1] - m[2, 2] + 1);
			result.z = Operations.Sqrt(-m[0, 0] - m[1, 1] + m[2, 2] + 1);

			return result;
		}

		public static Quaternion Rotate(float angle, Vector3 vector)
		{
			angle = MathUtils.Rad(angle);
			Quaternion result = new Quaternion();

			result.w = MathF.Cos(angle / 2);
			result.x = vector.x * MathF.Sin(angle / 2);
			result.y = vector.y * MathF.Sin(angle / 2);
			result.z = vector.z * MathF.Sin(angle / 2);


			return result;
		}
	}
}
