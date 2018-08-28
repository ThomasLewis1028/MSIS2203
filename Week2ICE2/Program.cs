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
			Console.WriteLine("What is your name?");
			var name = Console.ReadLine();
		
			Console.WriteLine("What is your beverage of choice?");
			var beverage = Console.ReadLine();
			
			Console.WriteLine("What is your budget?");
			//Convert from a string to a double
			var budget = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("What is the price of " + beverage + "?");
			var price = Convert.ToDouble(Console.ReadLine());
			
			//use the Math function to round down to allow decimal input but whole integer output
			var quantity = (int)Math.Floor(budget / price);
			
			//Output
			Console.WriteLine(name + " got " + quantity + " " + beverage + "(s)");
		}
	}
}