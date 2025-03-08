using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem
{
	class Program
	{
		static void Main()
		{
			double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
			double l = arr[0];
			double k = arr[1];
			int count = -1;
			bool check = false;
			while(l != 1.0)
			{
				check = true;
				if(l < 1.0){break;}
				l /= k;
				count++;
			}
			if(check) {System.Console.WriteLine(count); return;}
			System.Console.WriteLine(0);
		}
	}
}
