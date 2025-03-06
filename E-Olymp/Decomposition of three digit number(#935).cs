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
			int n = int.Parse(Console.ReadLine());
			FirstWay(n);
			Console.WriteLine("-----New Way!-----");
			SecondWay(n);
		}
		static void FirstWay(int n)
		{
			if(n < 0) {n = Math.Abs(n);}
			string input = n.ToString();
			for(int i=0; i<input.Length; i++)
			{
				Console.WriteLine(input[i]);
			}
		}
		static void SecondWay(int n)
		{
			if(n < 0) {n = Math.Abs(n);}
			Console.WriteLine(n/100);
			Console.WriteLine(n/10%10);
			Console.WriteLine(n%10);
		}
	}
}
