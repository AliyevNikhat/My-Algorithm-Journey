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
			int count = int.Parse(Console.ReadLine());
			List<int> arr = new List<int>();
			for(int i=0; i<count; i++)
			{
				arr.AddRange(Console.ReadLine().Split().Select(int.Parse));
			}
			for(int i=0; i<arr.Count; i+=2)
			{
				int current = arr[i] + arr[i+1];
				Console.WriteLine(current);
			}
		}
	}
}
