/*
 * Thomas Lewis
 * MSIS2203
 * August 28, 2018
 * Week 2 In Class Excersize 2
 */

using System;

namespace Week2ICE2
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//Ask for the name input and receive the string input with a var
			Console.WriteLine("What is your name?");
			var name = Console.ReadLine();
		
			//Ask for the beverage input and receive the string input with a var
			Console.WriteLine("What is your beverage of choice?");
			var beverage = Console.ReadLine();
			
			//Ask for the budget input and receive it using var
			Console.WriteLine("What is your budget?");
			//Convert from a string to a double for math purposes
			var budget = Convert.ToDouble(Console.ReadLine());
			
			//Ask for the price of the budget and receive it using var
			Console.WriteLine("What is the price of " + beverage + "?");
			//Convert from a string to a double for math purposes
			var price = Convert.ToDouble(Console.ReadLine());
			
			//use the Math function to round down to allow decimal input but whole integer output
			var quantity = (int)Math.Floor(budget / price);
			
			//Output the name, the quantity they can get and the beverage name
			Console.WriteLine(name + " can get " + quantity + " " + beverage + "(s)");
		}
	}
}