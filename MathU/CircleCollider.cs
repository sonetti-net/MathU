namespace MathU
{
	public class CircleCollider
	{
		public Vector2 point;
		public float radius;

		public CircleCollider(Vector2 point, float radius)
		{
			this.point = point;
			this.radius = radius;
		}

		public bool Collides(CircleCollider other)
		{
			float x = other.point.x - point.x;
			float y = other.point.y - point.y;
			float d = MathF.Sqrt((x * x) + (y * y));

			if (d < this.radius + other.radius)
			{
				return true;
			}

			return false;
		}

		public void Move(Vector2 pos)
		{
			this.point = pos;
		}
	}
}
