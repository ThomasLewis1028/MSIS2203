/*
 * Thomas Lewis
 * MSIS2203
 * October 4, 2018
 * Week 7 ICE 2
 */

using System;

namespace Week7ICE2
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//Set up dateTime so IDE doesn't yell at me
			DateTime age = new DateTime(1990, 01, 01);
			do
			{
				//Ask for input
				Console.Out.WriteLine("Welcome to the RockWall. " +
				                      "Please enter your date of birth");
				//Receive and convert input to DateTime
				age = DateTime.Parse(Console.ReadLine());

				//Special check to account for the fact that leap years throw off year math, break if 21st year but not
				//21 yet based on day
				if (DateTime.Now.Year - age.Year== 21 
				    && age.Month - DateTime.Now.Month == 0
				    && age.Day - DateTime.Now.Day > 0)
					break;
				
				//Output if fine
				if((DateTime.Now.Date - age.Date).TotalDays > 21 * 365)
					Console.Out.WriteLine("Welcome in.");
			} while ((DateTime.Now.Date - age.Date).TotalDays > 21 * 365); //Do all that while this is true
			
			//Output when loop broken
			Console.Out.WriteLine("You are not 21, pleas wait for further assistance.");
		}
	}
}