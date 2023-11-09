namespace MathU
{
	public struct Vector2
	{
		public float x;
		public float y;

		public Vector2(float _x, float _y)
		{
			x = _x;
			y = _y;
		}

		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x + b.x, a.y + b.y);
		}

		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			return new Vector2(a.x - b.x, a.y - b.y);
		}

		public static Vector2 operator /(Vector2 a, float divisor)
		{
			if (divisor == 0)
			{
				return new Vector2(0, 0);
			}
			return new Vector2(a.x / divisor, a.y / divisor);
		}

		public static Vector2 operator *(Vector2 a, float scalar)
		{
			return new Vector2(a.x * scalar, a.y * scalar);
		}

		public float Magnitude()
		{
			return (float)Operations.Sqrt(Operations.Square(x) + Operations.Square(y));
		}

		public static Vector2 Distance(Vector2 Origin, Vector2 Destination)
		{
			return new Vector2(Destination.x - Origin.x, Destination.y - Origin.y);
		}

		public Vector2 Normalized()
		{
			return new Vector2(this.x / this.Magnitude(), this.y / this.Magnitude());
		}

		public static float Dot(Vector2 left, Vector2 right)
		{
			float result = 0;

			result += left.x * right.x;
			result += left.y * right.y;

			return result;
		}

		public override string ToString()
		{
			return new string($"{x} {y}");
		}
	}
}
