/*
 * Thomas Lewis
 * MSIS2203
 * September 18, 2018
 * Week 5 ICE 1
 */

using System;

namespace Week5ICE1
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//Set up arrays
			string[] cities = new string[5];
			double[] tempsc = new double[5];
			double[] tempsf = new double[5];
			
			//Ask for input
			Console.WriteLine("What cities will you be visitng?");

			//Iterate through arrays to receive input
			for (int i = 0; i < 5; i++)
			{
				//Ask for and receive city name
				Console.Write("City " + (i+1) + ": ");
				cities[i] = Console.ReadLine();
				//Ask for and receive temps
				Console.Write("Expected temperature in " + cities[i] + ": ");
				//Call CelcToFahr storing the C in tempsc and the converted F in tempsf
				tempsf[i] = CelcToFahr(tempsc[i] = Convert.ToDouble(Console.ReadLine()));
			}

			//Output City: tempC - tempF 
			Console.WriteLine("The expected temperatures will be: ");
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(cities[i] + ": " + tempsc[i] + "C - " + tempsf[i] + "F");
			}

		}

		//Set up CelcToFahr receiving our double c
		private static double CelcToFahr(double c)
		{
			//Return inline conversion I found on the internet
			return (c * 1.8) + 32;
		}
	}
}