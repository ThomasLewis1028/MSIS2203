/*
 * Thomas Lewis
 * MSIS2203
 * November 15, 2018
 * Week 13 ICE 1 & 2
 */

using System;
using System.Linq;

namespace Week13ICE1_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Week 4 ICE 2");
            Week4ICE2.Program.Week4Ice2();
            
            Console.WriteLine("\nWeek 5 ICE 2");
            Week5ICE2.Program.Week5Ice2();
        }
    }
}

namespace Week4ICE2
{
    internal class Program
    {
        public static void Week4Ice2()
        {
            //Set up arrays because I don't want to have a ton of if statements
            string[] grades = new string[5];
            string[] courses = new string[5];
            int[] qp = new int[5];
			
            //Ask for and receive name as a string
            Console.WriteLine("What is your name?");
            var yourname = Console.ReadLine();

            //Iterate through arrays receiving course names and grades
            for (int i = 0; i < courses.Length; i++)
            {
                Console.Write("Course " + (i+1) + ": ");
                courses[i] = Console.ReadLine();

                //Receive grade and convert letter to upper for ease of use
                Console.Write("Grade " + (i+1) + ": ");
                grades[i] = Console.ReadLine().ToUpper();
            }

            //Iterate through arrays to apply QPs from grades array
            for (int i = 0; i < qp.Length; i++)
            {
                //Switch statements to get QP for each grade. Default to F
                switch (grades[i])
                {
                    case "A": qp[i] = 12;
                        break;
                    case "B": qp[i] = 9;
                        break;
                    case "C": qp[i] = 6;
                        break;
                    case "D": qp[i] = 3;
                        break;
                    case "F": qp[i] = 0;
                        break;
                    default:
                        qp[i] = 0;
                        break;
                }
            }
            
            //Create GPA as double by casting QP as doubles, divide by 9 credit hours (assumed)
            var gpa = ((double)qp.Sum()) / 15; 
			
            //Display if they qualify, or don't qualify for the scholarship
            if (gpa >= 3)
                Console.WriteLine(yourname + ", your GPA is " + gpa + ". You qualify for this scholarship!");
            else
                Console.WriteLine(yourname + ", your GPA is " + gpa + ". You do not qualify for this scholarship.\n");
            
            Console.WriteLine("Here is your grade breakdown:");

            //Go through the arrays I created and output the course name followed by the respective grade
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine("Course: " + courses[i] + "\tGrade: " + grades[i]);
            }
        }
    }
}

namespace Week5ICE2
{
    internal class Program
    {
        public static void Week5Ice2()
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