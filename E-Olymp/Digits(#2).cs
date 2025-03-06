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
			Console.WriteLine(FirstWay(n));
			Console.WriteLine(FirstWay(n));
			Console.WriteLine(ThridWay(n));
		}
		static int FirstWay(int n)
		{
			int count = 0;
			if(n == 0)
			{
				return 1;
			}
			else if(n < 0)
			{
				n = Math.Abs(n);
			}
			while(n > 0)
			{
				n/=10;
				count++;
			}
			return count;
		}
		static int SecondWay(int n)
		{
			string input = n.ToString();
			return input.Length;
		}
		static int ThridWay(int n)
		{
			if(n == 0)
			{
				return 1;
			}
			else if (n < 0)
			{
				n = Math.Abs(n);
			}
			string NumberFormatString = n.ToString();
			int NumberLength = NumberFormatString.Length;
			int ten = 1, k = 0;
			while(k < NumberLength - 1)
			{
				ten *= 10;
				k++;
			}
			int[] arr = new int[NumberLength];
			
			for(int i=0; i < arr.Length; i++)
			{
				arr[i] = n/ten;
				n%=ten;
				ten/=10;
			}
			
			return arr.Length;
		}
	}
}
