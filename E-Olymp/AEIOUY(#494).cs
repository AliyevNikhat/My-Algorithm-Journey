using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem
{
	class Program
	{
		static void Main()
		{
			string Text = Console.ReadLine();
			int count = 0;
			for(int i=0; i<Text.Length; i++)
			{
				if(Text[i] == 'A' || Text[i] == 'E' || Text[i] == 'I' || Text[i] == 'O' || Text[i] == 'U' || Text[i] == 'Y')
				{
					count++;
				}
			}
			System.Console.WriteLine(count);
		}
	}
}
