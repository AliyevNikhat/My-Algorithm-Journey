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
			if(n>=1 && n<=3){Console.WriteLine("Initial");}
			else if(n>=4 && n<=6){Console.WriteLine("Average");}
			else if(n>=7 && n<=9){Console.WriteLine("Sufficient");}
			else if(n>=10 && n<=12){Console.WriteLine("High");}
		}
	}
}
