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
			int[] Start_Olympiad = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int[] End_Olympiad = Console.ReadLine().Split().Select(int.Parse).ToArray();
			#region Start
				int h1 = Start_Olympiad[0];				
				int m1 = Start_Olympiad[1];				
				int s1 = Start_Olympiad[2];				
			#endregion
			#region End
				int h2 = End_Olympiad[0];
				int m2 = End_Olympiad[1];				
				int s2 = End_Olympiad[2];				
			#endregion

			int hour = h2 - h1;
			int minute = m2 - m1;
			int second = s2 - s1;

			if(second < 0) {second += 60; minute--;}		
			if(minute < 0) {minute += 60; hour--;}		
		    Console.WriteLine($"{hour} {minute} {second}");
		}
	}
}