/*
 * Thomas Lewis
 * MSIS2203
 * September 4, 2018
 * Week 3 In Class Excersize 1
 */

using System;

namespace Week3ICE1
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
			
			//Output the quantity they can get based on their budget and the price
			if (quantity > 1)
			{
				Console.WriteLine(name + " can get " + quantity + " " + beverage + "s");
			}else if (quantity < 1)
			{
				Console.WriteLine(name + " cannot afford " + beverage);
			}
			else
			{
				Console.WriteLine(name + " can get " + quantity + " " + beverage);
			}

			//Readline for people using the command prompt instead of an integrated console
			Console.ReadLine();
		}
	}
}