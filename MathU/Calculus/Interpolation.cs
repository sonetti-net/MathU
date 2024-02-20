using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathU.Calculus
{
	public abstract class Interpolation
	{
		// P(x) = Σn, i=0: yi * Li(x)
		// Li(x) = ∏n, j != i: (x-xj)/(xi-xj) 
		public static float Lagrangian(float x, float[] dataX, float[] dataY)
		{
			if (dataX.Length != dataY.Length)
				return 0;

			float result = 0;

			for (int i = 0; i < dataX.Length; i++)
			{
				float p = dataY[i];
				for (int j = 0; j < dataX.Length; j++)
				{
					if (i != j)
					{
						p *= ((x - dataX[j]) / (dataX[i] - dataX[j]));
					}
					result += p;
				}
			}

			return result;
		}
	}
}
