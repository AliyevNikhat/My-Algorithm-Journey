using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem
{
	class Program
	{
		static void Main()
		{
			int amount = int.Parse(Console.ReadLine());
			int count = 0;
			if(amount >= 500)
			{
				count += amount / 500;
				amount %= 500;
			}
			bool check = false;
			while(amount != 0)
			{
				if(amount >= 200)
				{
					count += amount / 200;
					amount %= 200;
				}
				else if(amount >= 100)
				{
					count += amount / 100;
					amount %= 100;
				}
				else if(amount >= 50)
				{
					count += amount / 50;
					amount %= 50;
				}
				else if(amount >= 20)
				{
					count += amount / 20;
					amount %= 20;
				}
				else if(amount >= 10)
				{
					count += amount / 10;
					amount %= 10;
				}
				else if(amount < 10)
				{
					check = true;
					break;
				}
			}
			if(check) {System.Console.WriteLine(-1);}
			else{System.Console.WriteLine(count);}
		}
	}
}
