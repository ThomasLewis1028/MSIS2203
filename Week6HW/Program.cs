/*
 * Thomas Lewis
 * MSIS2203
 * October 1, 2018
 * Week 6 HW
 */

using System;

namespace Week6HW
{
	internal class Program
	{
		public static double calcCart(double[] itemArr, double[] costArr)
		{
			double total = 0;

			for (int i = 0; i < itemArr.Length; i++)
				total += itemArr[i] * costArr[i];

			return total;
		}
		
		public static void Main(string[] args)
		{
			Console.Out.Write("Welcome to Justmart!\n" +
			                  "How much do you have to spend?\t");
			var money = Convert.ToDouble(Console.ReadLine());
			var total = (double) 0;

			double[] costArr = {2.98, 5.45, 3.99};
			string[] itemArr = {"Gum", "Milk", "Rice"};
			double[] cartArr = {0, 0, 0};

			Console.Out.WriteLine("Items in stock: \n" +
			                      itemArr[0] + ": \t$" + costArr[0] + "\n" +
			                      itemArr[1] + ": \t$" + costArr[1] + "\n" +
			                      itemArr[2] + ": \t$" + costArr[2] + "\n");

			while (total <= money)
			{
				Console.Out.Write("Select an item (\"exit\" to exit): ");
				var itemInput = Console.ReadLine().ToLower();
				if (itemInput.Equals("exit"))
					break;
				
				Console.Out.Write("Enter your quantity: ");
				var quantity = Convert.ToDouble(Console.ReadLine());

				switch (itemInput)
				{
					case "gum":
						cartArr[0] += quantity;
						break;
					case "milk":
						cartArr[1] += quantity;
						break;
					case "rice":
						cartArr[2] += quantity;
						break;
					default: 
						Console.Out.WriteLine("Item unavailable");
						continue;
				}

				if (calcCart(cartArr, costArr) > money)
				{
					Console.Out.WriteLine("Cart total is more than your budget.");
					break;
				}
				
				Console.Out.WriteLine("Cart total: $" + calcCart(cartArr, costArr) + "\n" +
				                      itemArr[0] + ": \t" + cartArr[0] + "\n" +
				                      itemArr[1] + ": \t" + cartArr[1] + "\n" +
				                      itemArr[2] + ": \t" + cartArr[2]);
			}
		}

	}
}