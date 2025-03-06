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
			Console.WriteLine(SecondWay(n));
			Console.WriteLine(RecursiveWay(n));
		}
		static int FirstWay(int n)
		{
			if(n < 0) {n = Math.Abs(n);}
			string input = n.ToString();
			int productOfDigits = 1;
			for(int i=0; i<input.Length; i++)
			{
				productOfDigits *= int.Parse(input[i].ToString());
			} 
			return productOfDigits;
		}
		static int SecondWay(int n)
		{
			if(n < 0) {n = Math.Abs(n);}
			int productOfDigits = 1;
			while(n>0)
			{
				productOfDigits *= n%10;
				n/=10;
			}
			return productOfDigits;
		}
		static int RecursiveWay(int n)
		{
			if(n<0){n = Math.Abs(n);}
			if(n<10){return n;}
			
			return (n%10) * RecursiveWay(n/10);
		}
	}
}
