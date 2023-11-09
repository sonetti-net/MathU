using MathU;

namespace Debug
{
	class Program
	{
		public static void Q1()
		{
			Matrix a = new Matrix(5, 1);
			Matrix b = new Matrix(5, 1);
			Matrix c = new Matrix(5, 1);

			a.data[0, 0] = 1;
			a.data[1, 0] = 2;
			a.data[2, 0] = 3;
			a.data[3, 0] = 4;
			a.data[4, 0] = 5;

			b.data[0, 0] = -2;
			b.data[1, 0] = -1;
			b.data[2, 0] = 0;
			b.data[3, 0] = 2;
			b.data[4, 0] = 6;

			c.data[0, 0] = 0;
			c.data[1, 0] = 10;
			c.data[2, 0] = 20;
			c.data[3, 0] = 30;
			c.data[4, 0] = 40;

			Console.WriteLine((a + b).ToString());
			Console.WriteLine((b - a).ToString());
			Console.WriteLine((a + b - c).ToString());
		}
		public static void Q2()
		{
			Matrix a = new Matrix(3, 1);
			Matrix b = new Matrix(5, 1);
			Matrix c = new Matrix(4, 1);

			a.data[0, 0] = 1;
			a.data[1, 0] = 2;
			a.data[2, 0] = 3;

			b.data[0, 0] = -2;
			b.data[1, 0] = -1;
			b.data[2, 0] = 0;
			b.data[3, 0] = 2;
			b.data[4, 0] = 6;

			c.data[0, 0] = 0;
			c.data[1, 0] = 10;
			c.data[2, 0] = 20;
			c.data[3, 0] = 30;

			Console.WriteLine(a.Magnitude());
			Console.WriteLine(b.Magnitude());
			Console.WriteLine(c.Magnitude());
		}

		public static void Q3()
		{
			Console.WriteLine("Q3");
			Matrix a = new Matrix(3, 1);
			Matrix b = new Matrix(5, 1);
			Matrix c = new Matrix(4, 1);

			a.data[0, 0] = 1;
			a.data[1, 0] = 2;
			a.data[2, 0] = 3;

			b.data[0, 0] = -2;
			b.data[1, 0] = -1;
			b.data[2, 0] = 0;
			b.data[3, 0] = 2;
			b.data[4, 0] = 6;

			c.data[0, 0] = 0;
			c.data[1, 0] = 10;
			c.data[2, 0] = 20;
			c.data[3, 0] = 30;

			Console.WriteLine(a.Unit().ToString());
			Console.WriteLine(b.Unit().ToString());
			Console.WriteLine(c.Unit().ToString());
		}

		public static void Q4()
		{
			Console.WriteLine("Q4");
			Matrix a = new Matrix(5, 1);
			a.data[0, 0] = 1;
			a.data[1, 0] = 2;
			a.data[2, 0] = 3;
			a.data[3, 0] = 4;
			a.data[4, 0] = 5;

			Matrix b = new Matrix(5, 1);
			b.data[0, 0] = -2;
			b.data[1, 0] = -1;
			b.data[2, 0] = 0;
			b.data[3, 0] = 2;
			b.data[4, 0] = 6;

			Console.WriteLine(Matrix.Dot(a, b));
			Console.WriteLine((a * b).ToString());

			Vector3 A = new Vector3(1, 2, 3);
			Vector3 B = new Vector3(-2, -1, 0);

			Console.WriteLine(Vector3.Dot(A, B));
			Console.WriteLine(Vector3.Cross(A, B).ToString());

		}

		public static void Q5()
		{
			Matrix a = new Matrix(2, 3);
			a.data[0, 0] = 1;
			a.data[0, 1] = 3;
			a.data[0, 2] = 6;
			a.data[1, 0] = 2;
			a.data[1, 1] = 4;
			a.data[1, 2] = 0;

			Matrix b = new Matrix(3, 3);
			b.data[0, 0] = -1;
			b.data[0, 1] = 0;
			b.data[0, 2] = 1;
			b.data[1, 0] = 2;
			b.data[1, 1] = 2;
			b.data[1, 2] = 2;
			b.data[2, 0] = 4;
			b.data[2, 1] = 3;
			b.data[2, 2] = 2;

			Console.WriteLine($"a = {a.ToString()}\nb = {b.ToString()}");
			Console.WriteLine($"ab = {(a * b).ToString()}");
			Console.WriteLine(a.Transpose().ToString());


		}

		public static void KhanAcademyDemo()
		{
			Vector2 a = new Vector2(3, 2);
			Vector2 b = new Vector2(-3, 2);
			Vector2 c = new Vector2(3, -2);


			Console.WriteLine($"a\n{a.ToString()}\nb\n{b.ToString()}\nc\n{c.ToString()}");

			Vector2 transform = new Vector2(-1, 2);

			Console.WriteLine($"Transform\n{transform.ToString()}");

			Matrix identity = Matrix.Identity(2);
			Console.WriteLine($"Identity\n{identity.ToString()}");

			//Console.WriteLine($"{(identity*transform).ToString()}");
			Console.WriteLine($"{(Matrix.Transform(transform, identity)).ToString()}");

		}
		static int Main()
		{
			Console.WriteLine("AAYO");

			//Q1();
			//Q2();
			//Q3();
			//Q4();
			//Q5();

			KhanAcademyDemo();
			//Matrix identity = Matrix.Identity(3);

			//Console.WriteLine(identity.ToString());
			//Console.WriteLine(1 + (1 - 1 % 5));



			int n = 499;

			int result = n - 5 * ((n - 1) / 5);

			Console.WriteLine(result);

			return (0);
		}
	}
}