using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roller
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(diceRoll(3, 6));
			Console.WriteLine(diceRoll(3, 6));
			Console.WriteLine(diceRoll(3, 6));
			Console.WriteLine(diceRoll(3, 6));
			Console.WriteLine(diceRoll(3, 6));
			Console.WriteLine(diceRoll(3, 6));
			Console.WriteLine(diceRoll(3, 6));
			Console.WriteLine(diceRoll(3, 6));
			Console.WriteLine(diceRoll(3, 6));
			Console.WriteLine(diceRoll(3, 6));
			Console.WriteLine(diceRoll(3, 6));
			Console.WriteLine(diceRoll(3, 6));


			Console.ReadKey();
		}

		static int diceRoll(int n, int m)
		{
			Random rand = new Random();
			int sum = 0;

			for (int i = 0; i < n; i++)
				sum += rand.Next(1, m + 1);

			return sum;
		}
	}
}
