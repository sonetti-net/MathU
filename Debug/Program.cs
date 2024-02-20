using MathU;
using MathU.Calculus;

namespace Debug
{
	class Program
	{

		static float[] pop(int num)
		{
			float[] result = new float[num];
			
			for (int i = 0; i < num; i++)
			{
				result[i] = MathU.Misc.Random.Range(0, 100);
			}

			return result;
		}

		static void Lagrange()
		{

			Vector3 a = new Vector3(1, 2, 5);
			Vector3 b = new Vector3(3, 4, 6);
			Vector3 c = new Vector3(5, 6, 7);

			// Triple Cross Product

			// Lagrange Formula a x (b x c) = (a • c)b - (a • b)c

			// Cross Product part
			Console.WriteLine(Vector3.Cross(a, Vector3.Cross(b, c)).ToString());

			// Dot product part
			float AC = (float)Vector3.Dot(a, c);
			float AB = (float)Vector3.Dot(a, b);

			Vector3 p1 = b * AC;
			Vector3 p2 = c * AB;

			Vector3 result = p1 - p2;

			Console.WriteLine(result.ToString());
			
		}

		static int Main()
		{
			Lagrange();

			return (0);
		}
	}
}