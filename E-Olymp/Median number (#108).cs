using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Problem
{
	class Program
	{
		static void Main()
		{
			int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int a = arr[0];
			int b = arr[1];
			int c = arr[2];
			System.Console.WriteLine(WithCompare(a,b,c));
			System.Console.WriteLine(WithMaxAndMinValue(a,b,c));
		}
		static int WithCompare(int a, int b, int c)
		{
			if((a >= b && a <= c) || (a <= b && a >= c)){return a;}
			else if((b >= a && b <= c) || (b <= a && b >= c)){return b;}
			else{return c;}
		}
		static int WithMaxAndMinValue(int a, int b, int c)
		{
			int MaxValue = Math.Max(a,Math.Max(b,c));
			int MinValue = Math.Min(a,Math.Min(b,c));
			int SumOfMinAndMaxValue = MaxValue + MinValue;
			int SumofDigits = a + b + c;
			return(SumofDigits - SumOfMinAndMaxValue);
		}
	}
}