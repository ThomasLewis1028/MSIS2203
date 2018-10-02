/*
 * Thomas Lewis
 * MSIS2203
 * October 2, 2018
 * Week 7 ICE 1
 */

using System;

namespace Week7ICE1
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//Allow for multiple inputs using while
			while (true)
			{
				Console.Out.Write("Enter the manufacture date (YYYY-MM-DD): ");
				
				//Break loop if "exit" is entered
				var input = Console.ReadLine();
				if (input.ToLower().Equals("exit"))
					break;
				
				//Convert to DateTime format
				DateTime date = DateTime.Parse(input);
				var days = (DateTime.Now.Date - date.Date).TotalDays;

				//Check if expired
				if (days >= 700)
				{
					Console.Out.WriteLine("I am expired!");
				}
				else if ((DateTime.Now.Date - date.Date).TotalDays < 700)
				{
					//Check if less than a week to live
					if (days == 700 - 7)
						Console.Out.WriteLine("I have only a week left to live");
					//Check if from the future
					else if (days < 0)
						Console.Out.WriteLine("I am from the fuuuutuuure!");
					//Output percentage using WriteLine formatter
					else
						Console.Out.WriteLine("I am at {0:P2} capacity!", days / 700);
				}

				//Output birthday
				if (days % 365 == 0)
					Console.Out.WriteLine("It's my birthday!");
			}
		}
	}
}