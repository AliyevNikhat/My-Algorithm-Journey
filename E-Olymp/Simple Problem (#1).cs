using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problem
{
	class E_OlympProblem
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			FirstWay(n);
			SecondWay(n);
		}
		static void FirstWay(int n)
		{
			Console.WriteLine($"{n/10} {n%10}");
		}
		static void SecondWay(int n)
		{
			string result = "";
			while(n>0)
			{
				result = " " + (n%10) + result;
				n/=10;
			}
			Console.WriteLine(result.Trim());
		}
	}
}
