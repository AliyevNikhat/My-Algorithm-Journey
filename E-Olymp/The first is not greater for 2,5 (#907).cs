using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Problem
{
	class Program
	{
		static void Main()
		{
			int CountOfArray = int.Parse(Console.ReadLine());
			string input = Console.ReadLine();
			string[] inputs = input.Split(' ');
			double[] arr = new double[CountOfArray];

			for (int i = 0; i < inputs.Length; i++)
			{
				arr[i] = double.Parse(inputs[i].ToString(), CultureInfo.InvariantCulture); // Səhv düzəldildi
			}
			int count = 0;
			double digit = 0;			
			foreach(double item in arr)
			{
				if(item <= 2.5)
				{
					System.Console.WriteLine($"{count + 1} {item.ToString("F2")}");
					return;
				}
				count++;
			}
			if(digit == 0){System.Console.WriteLine("Not Found");return;}
		}
	}
}