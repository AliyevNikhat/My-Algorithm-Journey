using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E_OlympProblem
{
	class Program
	{
		static void Main()
		{
			string SameRow = Console.ReadLine();
			string[] input = SameRow.Split(' ');
			Console.WriteLine(FirstWay(input));
			Console.WriteLine(SecondWay(long.Parse(input[0]), long.Parse(input[1])));
		}
		static long FirstWay(string[] input)
		{
			long a = long.Parse(input[0].ToString());
			long b = long.Parse(input[1].ToString());
			long result = a * a + b * b;
			return result;
		}
		static long SecondWay(long a, long b) => a * a + b * b;
	}
}
