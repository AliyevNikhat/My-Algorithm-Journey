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
			string input = Console.ReadLine();
			if(input[0] == '-' || input[0] == '+' || input[0] == '*'){input = input.Substring(1);}
			int count = 0;
			foreach(char item in input)
			{
				if(item == '+'){count++;}
				else if(item == '-'){count++;}
				else if(item == '*'){count++;}
			}
			Console.WriteLine(count);
		}
	}
}
