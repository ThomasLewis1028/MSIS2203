/*
 * Thomas Lewis
 * MSIS 2203
 * Week 2 Homework 2
 *
 * Take input for X1, X2, Y1, Y2 and then find the midpoint for them to find the location to destroy the Death Star
 */

using System;

namespace Week2HW2
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//Ask for and receive X1 and X2, using vars becuase Rider yells at me using ints
			Console.WriteLine("X Wing 2-D plane Co-ordinates: X co-ordinates");
			Console.Write("X1: ");
			//Conversion on every var to turn them into ints
			var x1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("X2: ");
			var x2 = Convert.ToInt32(Console.ReadLine());
			
			//Ask for and receive Y1 and Y2
			Console.WriteLine("X Wing 2-D plane Co-ordinates: Y co-ordinates");
			Console.Write("Y1: ");
			var y1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Y2: ");
			var y2 = Convert.ToInt32(Console.ReadLine());
			
			//Get Xa and Ya using averages
			var xa = (x1 + x2) / 2;
			var ya = (y1 + y2) / 2;
			
			//Output Xa and Ya
			Console.WriteLine("The proton toepedioes must be shot at " + xa + ", " + ya + " to destroy the Death Star");
		}
	}
}