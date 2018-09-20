/*
 * Thomas Lewis
 * MSIS2203
 * September 20, 2018
 * Week 5 ICE 2
 */

using System;

namespace Week5ICE2
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//Set up arrays
			string[] mountains = new string[5];
			double[] heightsM = new double[5];
			double[] heightsF = new double[5];
			string[] difficulties = new string[5];
			
			//Ask for input
			Console.WriteLine("What mountains will you be skiing?");

			//Iterate through arrays to receive input
			for (int i = 0; i < 5; i++)
			{
				//Ask for and receive mountain name
				Console.Write("Mountain " + (i+1) + ": ");
				mountains[i] = Console.ReadLine();
				//Ask for and receive heights
				Console.Write(mountains[i] + " height in Meters: ");
				//Do all of my method calls in one line and get the meter height, the feet height, and the difficulty
				difficulties[i] =
					DifficultyCheck(heightsF[i] = MetersToFeet(heightsM[i] = Convert.ToDouble(Console.ReadLine())));
			}

			//Output City: tempC - tempF 
			Console.WriteLine("\nThe mountains and their heights and difficulties: ");
			for (int i = 0; i < 5; i++)
				Console.WriteLine(mountains[i] + " - Height: " + heightsF[i] + "f (" + heightsM[i] + "m)" 
				                  + " - " + difficulties[i]);
		}

		//Meters to feet, return inline
		private static double MetersToFeet(double h){ return h * 3.28; }

		//Difficulty check, return inline if
		private static string DifficultyCheck(double h){ return (h > 2000 ? "Difficult" : "Easy"); }
	}
}