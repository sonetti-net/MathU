using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathU
{
	public struct Quaternion
	{
		public float i, j, k, w;

		public Quaternion(float i, float j, float k, float w)
		{
			
			this.i = i;
			this.j = j;
			this.k = k;
			this.w = w;
		}

		public Quaternion(float value)
		{

			this.i = value;
			this.j = value;
			this.k = value;
			this.w = value;
		}
		//deep
		public override string ToString()
		{
			return $"({i}, {j}, {k}, {w}";
		}

		public static Quaternion operator +(Quaternion left, Quaternion right)
		{
			Quaternion result = new Quaternion(0);

			result.i = left.i + right.i;
			result.j = left.j + right.j;
			result.k = left.k + right.k;
			result.w = left.w + right.w;

			return result;
		}
	}
}
