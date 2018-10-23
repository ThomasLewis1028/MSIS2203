using System;

namespace Week10ICE1
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Student student = new Student();
			
			Console.Write("Enter your name: ");
			student.name = Console.ReadLine();
			
			Console.Write("Enter your GPA: ");
			student.gpa = double.Parse(Console.ReadLine());
			
			Console.Write("Enter your major: ");
			student.major = Console.ReadLine();
			
			Console.Write("Enter your year: ");
			student.class_standing = Console.ReadLine();
			
			Console.WriteLine(student.name + "\n" +
			                  "Year: " + student.class_standing + "\n" +
			                  "Major: " + student.major + "\n" +
			                  "GPA: " + student.gpa);
			
			
			if(student.gpa > 3)
				Console.Out.WriteLine("You're not failing (yet)!");
			
			if(student.major.ToLower() == "computer science")
				Console.WriteLine("CS? Why would you do that to yourself?");
			
			if(student.class_standing.ToLower() == "freshman" ||
			   student.class_standing.ToLower() == "sophomore")
				Console.WriteLine("Get off my campus");
		}
	}

	public class Student
	{
		public Student()
		{
		}

		public string name { get; set; }
		public string major { get; set; }
		public double gpa { get; set; }
		public string class_standing { get; set; }
	}
}