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
			Console.WriteLine("----New Way!----");
			SeconWay(n);
		}
		static void FirstWay(int n)
		{
			string input = n.ToString();
			int FirstDigit = int.Parse(input[0].ToString());
			int LastDigit = int.Parse(input[input.Length - 1].ToString());
			
			if(FirstDigit > LastDigit)
			{
				Console.WriteLine(FirstDigit);
			}
			else if(FirstDigit < LastDigit)
			{
				Console.WriteLine(LastDigit);
			}
			else
			{
				Console.WriteLine("=");
			}
		}
		static void SeconWay(int n)
		{
			int current = n;
			int ten = 1;
			while(current > 0)
			{
				ten*=10;
				current/=10;
			}
			ten/=10;
			int FirstDigit = n/ten;
			int LastDigit = n%10;
			
			if(FirstDigit > LastDigit)
			{
				Console.WriteLine(FirstDigit);
			}
			else if(FirstDigit < LastDigit)
			{
				Console.WriteLine(LastDigit);
			}
			else
			{
				Console.WriteLine("=");
			}
		}
	}
}
