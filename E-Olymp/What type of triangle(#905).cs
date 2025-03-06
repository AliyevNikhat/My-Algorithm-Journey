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
			int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int a = arr[0];
			int b = arr[1];
			int c = arr[2];
			if(a == b && b == c)
			{
				Console.WriteLine(2);
			}
			else if((a == b && c!=b) || (a==c && b!=c) || (b == c && a!=c))
			{
				Console.WriteLine(1);
			}
			else
			{
				Console.WriteLine(3);
			}
		}
	}
}
