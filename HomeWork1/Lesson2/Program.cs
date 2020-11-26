using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
	class Program
	{
		static void Main(string[] args)
		{
			var daysInMarch = new int[31];

			var rand = new Random();

			Console.WriteLine("Март количество осадков:");
			for (var i = 0; i < 31; i++)
			{
				daysInMarch[i] = rand.Next(0, 50);
				Console.Write("{0}-{1}  ", i + 1, daysInMarch[i]);
			}

			var sumDaysRain = 0;
			for (int i = 0; i < 31; i++)
			{
				if (daysInMarch[i] > 0)
				{
					sumDaysRain++;
				}
			}

			Console.WriteLine();
			Console.WriteLine("Количество дождливых дней: {0}", sumDaysRain);
			Console.ReadKey();
		}
	}
}
