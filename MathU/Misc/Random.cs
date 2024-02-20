using System;

namespace MathU.Misc
{
	public abstract class Random
	{
		public static ulong GetULong()
		{
			ulong seed = (ulong)DateTime.Now.Ticks;
			unchecked
			{
				object lockObj = new object();

				lock (lockObj)
				{
					ulong t = 0;

					t = seed;
					t ^= t >> 12;
					t ^= t >> 25;
					t ^= t >> 27;

					return t * 0x2545F4914F6CDD1D;
				}
			}
		}

		public static int Range(int min, int max)
		{
			ulong ulongValue = GetULong();
			double normalizedValue = (double)ulongValue / ulong.MaxValue; // 0 - 1
			int range = max - min + 1;

			int randomValue = (int)(normalizedValue * range) + min;

			return randomValue;
		}
	}
}
