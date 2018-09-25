/*
 * Thomas Lewis
 * MSIS2203
 * September 25, 2018
 * Week 6 ICE 1
 */

using System;

namespace Week6ICE1
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//Set up variables
			string user, pass1 = "_";
			string pass2 = "";
			
			//Ask for username even though it's unnecessary
			Console.Out.Write("Enter your username: ");
			user = Console.ReadLine();

			//Ask for first password input
			Console.Out.Write("Enter your password: ");
			pass1 = Console.ReadLine();
			
			//Ask for second password input
			Console.Out.Write("Enter your password again: ");
			//Run while loop to check pass1 against pass2
			while (!pass2.Equals(pass1))
			{
				//Get pass2 input
				pass2 = Console.ReadLine();
				
				//Check if they match to determine output and give user feedback
				if(!pass2.Equals(pass1))
					Console.Write("Passwords don't match, please enter again: ");
				else
					Console.WriteLine("Passwords match.");
			}
		}
	}
}