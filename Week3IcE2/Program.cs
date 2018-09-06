/*
 * Thomas Lewis
 * MSIS2203
 * September 6, 2018
 * Week 3 In Class Excersize 2
 */

using System;

namespace Week3IcE2
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//Ask for name
			Console.WriteLine("What is your name?");
			var yourname = Console.ReadLine();
			
			//Ask for amount due, convert to int
			Console.WriteLine("Amount due?");
			var dueamount = Convert.ToInt32(Console.ReadLine());
			
			//Ask for amount paid, convert to int
			Console.WriteLine("How many $20 bills did you give?");
			var noofbills = Convert.ToInt32(Console.ReadLine());

			//Get change amount
			var amountpaid = noofbills * 20;
			var change = amountpaid - dueamount;

			//Output amount due and paid
			Console.WriteLine(yourname + " your due amount is $" + dueamount +
			                  "\nYou paid $" + amountpaid);
			
			//Output change amount based on value
			if (change > 0)
			{
				Console.WriteLine("Your change would be $" + change);
			}else if (change == 0)
			{
				Console.WriteLine("You have no change");
			}
			else
			{
				Console.WriteLine("You need more cash");
			}
			
		}
	}
}