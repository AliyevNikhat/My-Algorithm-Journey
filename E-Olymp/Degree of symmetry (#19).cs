using System;

namespace Problem
{
	class Program
	{
		static void Main()
		{
			string input = Console.ReadLine();
			System.Console.WriteLine(TwoPointers(input, 0, input.Length - 1));
		}
		static int TwoPointers(string input, int start, int end)
		{
			int count = 0;
			while(start <= end)
			{
				if(input[start] == input[end]) {count++;}
				start++;end--;
			}
			return count;
		}
	}
}