using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem
{
	class Program
	{
		static void Main()
		{
			int number = int.Parse(Console.ReadLine());
			int count = 0;
			while(number != 1)
			{
				if(number%2 == 0)
				{
					number /= 2;
					count++;
				}
				else
				{
					number++;
					count++;					
				}
			}
			System.Console.WriteLine(count);
		}
	}
}
