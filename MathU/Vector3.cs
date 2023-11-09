namespace MathU
{
	public struct Vector3
	{
		public float x;
		public float y;
		public float z;

		public Vector3(float _x, float _y, float _z)
		{
			x = _x;
			y = _y;
			z = _z;
		}

		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
		}

		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		public static Vector3 operator /(Vector3 a, float divisor)
		{
			if (divisor == 0)
			{
				return new Vector3(0, 0, 0);
			}
			return new Vector3(a.x / divisor, a.y / divisor, a.z / divisor);
		}

		public static Vector3 operator *(Vector3 a, float scalar)
		{
			return new Vector3(a.x * scalar, a.y * scalar, a.z * scalar);
		}

		public float Magnitude()
		{
			return (float)Operations.Sqrt(Operations.Square(x) + Operations.Square(y) + Operations.Square(z));
		}

		public static Vector3 Distance(Vector3 Origin, Vector3 Destination)
		{
			return new Vector3(Destination.x - Origin.x, Destination.y - Origin.y, Destination.z - Origin.z);
		}

		public Vector3 Normalized()
		{
			return new Vector3(this.x / this.Magnitude(), this.y / this.Magnitude(), this.z / this.Magnitude());
		}

		public static float Dot(Vector3 left, Vector3 right)
		{
			float result = 0;

			result += left.x * right.x;
			result += left.y * right.y;
			result += left.z * right.z;

			return result;
		}
		public static Vector3 Cross(Vector3 left, Vector3 right)
		{
			Vector3 result = new Vector3();
			result.x = (left.y * right.z) - (left.z * right.y);
			result.y = (left.z * right.x) - (left.x * right.z);
			result.z = (left.x * right.y) - (left.y * right.x);

			return result;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>String representation of Vector3 x y z</returns>
		public override string ToString()
		{
			return new string($"{x} {y} {z}");
		}
	}
}
