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
		}
		static void FirstWay(int n)
		{
			int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int i=0;
			foreach(int item in arr)
			{
				if(item > 0 && item !=0)
				{
					arr[i] = item+2;
				}
				i++;
			}
			Console.WriteLine(string.Join(' ', arr));
		}
	}
}
