/*
 * Thomas Lewis
 * MSIS2203
 * September 10, 2018
 * Week 3 Homework
 */

using System;

namespace Week3HW
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//Set up arrays because I don't want to have a ton of if statements
			string[] grades = new string[3];
			int[] qp = new int[3];
			
			//Ask for and receive name as a string
			Console.WriteLine("What is your name?");
			var yourname = Console.ReadLine();

			//Ask for and receive the course names and grades
			Console.Write("Course 1: ");
			var course1 = Console.ReadLine();
			
			Console.Write("Grade 1: ");
			grades[0] = Console.ReadLine();
			
			Console.Write("Course 2: ");
			var course2 = Console.ReadLine();
			
			Console.Write("Grade 2: ");
			grades[1] = Console.ReadLine();

			Console.Write("Course 3: ");
			var course3 = Console.ReadLine();
			
			Console.Write("Grade 3: ");
			grades[2] = Console.ReadLine();
			//End course names and grades

			//Iterate through arrays to apply QPs from grades array
			for (int i = 0; i < 3; i++)
			{
				//Switch statements to allow upper and lowercase option for each grade. Default to F
				switch (grades[i])
				{
					case "A":
					case "a": qp[i] = 12;
						break;
					case "B":
					case "b": qp[i] = 9;
						break;
					case "C": 
					case "c": qp[i] = 6;
						break;
					case "D":
					case "d": qp[i] = 3;
						break;
					case "F":
					case "f": qp[i] = 0;
						break;
					default:
						qp[i] = 0;
						break;
				}
			}

			//Create GPA as double by casting QP's as doubles, divide by 9 credit hours (assumed)
			var gpa = ((double)qp[0] + (double)qp[1] + (double)qp[2]) / 9; 
			
			//Display if they qualify, or don't qualify for the scholarship
			if(gpa >= 3)
				Console.WriteLine(yourname + ", your GPA is " + gpa + ". You qualify for this scholarship!");
			else
				Console.WriteLine(yourname + ", your GPA is " + gpa + ". You do n ot qualify for this scholarship.");
		}
	}
}