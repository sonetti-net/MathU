﻿using MathU;

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

			Console.WriteLine($"a = \n{a.ToString()}\nb = \n{b.ToString()}");

			Console.WriteLine($"ab = \n{(a * b).ToString()}");

			Console.WriteLine($"a^t = \n{a.Transpose().ToString()}");

			Console.WriteLine($"ba^t = \n{(b*(a.Transpose())).ToString()}");

		}

		public static void Q6()
		{
			/*
			Matrix mX = Matrix.Identity(3);
			Matrix mY = Matrix.Identity(3);
			Matrix mZ = Matrix.Identity(3);
			float angle = 51;
			mZ.data[0, 0] = MathF.Cos(MathUtils.Rad(angle));
			mZ.data[0, 1] = -MathF.Sin(MathUtils.Rad(angle));
			mZ.data[0, 2] = 0;
			mZ.data[1, 0] = MathF.Sin(MathUtils.Rad(angle));
			mZ.data[1, 1] = MathF.Cos(MathUtils.Rad(angle));
			mZ.data[1, 2] = 0;
			mZ.data[2, 0] = 0;
			mZ.data[2, 1] = 0;
			mZ.data[2, 2] = 1;

			mY.data[0, 0] = MathF.Cos(MathUtils.Rad(angle));
			mY.data[0, 1] = 0;
			mY.data[0, 2] = MathF.Sin(MathUtils.Rad(angle));
			mY.data[1, 0] = 0;
			mY.data[1, 1] = 1;
			mY.data[1, 2] = 0;
			mY.data[2, 0] = MathF.Sin(MathUtils.Rad(angle));
			mY.data[2, 1] = 0;
			mY.data[2, 2] = MathF.Cos(MathUtils.Rad(angle));

			mX.data[0, 0] = 1;
			mX.data[0, 1] = 0;
			mX.data[0, 2] = 0;
			mX.data[1, 0] = 0;
			mX.data[1, 1] = MathF.Cos(MathUtils.Rad(angle));
			mX.data[1, 2] = -MathF.Sin(MathUtils.Rad(angle));
			mX.data[2, 0] = 0;
			mX.data[2, 1] = MathF.Sin(MathUtils.Rad(angle));
			mX.data[2, 2] = MathF.Cos(MathUtils.Rad(angle));
			*/

			Matrix mX = Matrix.Rotation(MathUtils.Rad(51), "x");
			Matrix mY = Matrix.Rotation(MathUtils.Rad(51), "y");
			Matrix mZ = Matrix.Rotation(MathUtils.Rad(51), "z");

			Console.WriteLine($"X: \n{mX}\n\nY: \n{mY}\n\nZ: \n{mZ}");


			Console.WriteLine("Z * Y = \n" + (mZ * mY).ToString());

			Console.WriteLine("Z * Y * X = \n" + (mZ * mY * mX).ToString());

		}
		public static void Q7()
		{

		}
		public static void Q8()
		{

			float scale = 5;

			Vector3 nN = new Vector3(0.5, -0.1, 0.9);
			Vector3 n = nN.Normalized(); // normalize

			float mag = nN.Magnitude();
			Matrix P = Matrix.Project(n, 2);

			//	Construct a matrix to scale by a factor of 5 about the plane through the origin perpendicular to the vector [0.267 , − 0.535 , 0.802].


			Console.WriteLine($"Construct a matrix to scale by a factor of {scale} about the plane through the origin perpendicular to the vector.");
			Console.WriteLine("^n = " + n.ToString());
			Console.WriteLine("\n\nP = \n" + P.ToString());

			//	Construct a matrix to orthographically project onto the plane through the origin perpendicular to the vector [0.267 , − 0.535 , 0.802].

			P = Matrix.Project(n, 0);

			Console.WriteLine($"Construct a matrix to orthographically project onto the plane through the origin perpendicular to the vector.");
			Console.WriteLine("^n = " + n.ToString());
			Console.WriteLine("\n\nP = \n" + P.ToString());

			//	Construct a matrix to reflect orthographically project onto the plane through the origin perpendicular to the vector [0.267 , − 0.535 , 0.802].
			P = Matrix.Reflect(n);

			Console.WriteLine($"Construct a matrix to reflect orthographically project onto the plane through the origin perpendicular to the vector.");
			Console.WriteLine("^n = " + n.ToString());
			Console.WriteLine("\n\nP = \n" + P.ToString());
			//Console.WriteLine("\n\n"+ (P*S).ToString());

		}

		public static void Q9()
		{
			Vector3 v = new Vector3(0, 3, 4);

			Quaternion r = Quaternion.Rotate(70, v.Normalized());

			Console.WriteLine(r.ToString());
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

		public static void Determinants()
		{
			Matrix m = new Matrix(3, 3);
			m.data[0, 0] = 4;
			m.data[0, 1] = -1;
			m.data[0, 2] = 1;
			m.data[1, 0] = 4;
			m.data[1, 1] = 5;
			m.data[1, 2] = 3;
			m.data[2, 0] = -2;
			m.data[2, 1] = 0;
			m.data[2, 2] = 0;

			Matrix m4x4 = new Matrix(4, 4);
			m4x4.data[0, 0] = 1;
			m4x4.data[0, 1] = 2;
			m4x4.data[0, 2] = 3;
			m4x4.data[0, 3] = 4;
			m4x4.data[1, 0] = 1;
			m4x4.data[1, 1] = 0;
			m4x4.data[1, 2] = 2;
			m4x4.data[1, 3] = 0;
			m4x4.data[2, 0] = 0;
			m4x4.data[2, 1] = 1;
			m4x4.data[2, 2] = 2;
			m4x4.data[2, 3] = 3;
			m4x4.data[3, 0] = 2;
			m4x4.data[3, 1] = 3;
			m4x4.data[3, 2] = 0;
			m4x4.data[3, 3] = 0;

			double r = m4x4.Determinant();

			//Console.WriteLine(m4x4.ToString() + "\nDeterminant = " + m4x4.Determinant().ToString() + "\n\n");
			Console.WriteLine(m.ToString() + "\nDeterminant = " + m.Determinant().ToString());

			Console.WriteLine((m.Inverse()).ToString());

			//Console.WriteLine(m.Minors().ToString());
			//Console.WriteLine(m.Minors().Cofactor().ToString());

		}

		public static void SubMatrices()
		{

			Matrix C = new Matrix(3, 3);

			C.data[0, 0] = 0;
			C.data[0, 1] = 2;
			C.data[0, 2] = 2;
			C.data[1, 0] = 1;
			C.data[1, 1] = 1;
			C.data[1, 2] = 1;
			C.data[2, 0] = 0;
			C.data[2, 1] = 2;
			C.data[2, 2] = 0;

			Console.WriteLine(C.ToString() + "\n\n");

			Console.WriteLine(C.Inverse().ToString() + "\n\n");
		}
		static int Main()
		{
			Console.WriteLine("AAYO");

			CircleCollider c1 = new CircleCollider(new Vector2(2, 3), 3);
			CircleCollider c2 = new CircleCollider(new Vector2(4, 3), 3);

			Console.WriteLine(c1.Collides(c2));

			c2.Move(new Vector2(10, 15));
			Console.WriteLine(c1.Collides(c2));
			Vector2 p = new Vector2(2, 3);
			p = p.Rotate(90);

			//Q1();
			//Q2();
			//Q3();
			//Q4();
			//Q5();
			//Q6();
			//Q7();
			//Q8();
			//Q9();
			//Determinants();
			//SubMatrices();
			//KhanAcademyDemo();
			//Matrix identity = Matrix.Identity(3);

			//Console.WriteLine(identity.ToString());
			//Console.WriteLine(1 + (1 - 1 % 5));



			return (0);
		}
	}
}