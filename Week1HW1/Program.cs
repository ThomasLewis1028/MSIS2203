/*
 * Thomas Lewis
 * MSIS 2203
 * Week 1 Homework 1
 * This is the exact same thing that we did in Class on Thursday. The only major change is that it says the first
 * three lines from my introduction, rather than the "Hello, World" or "Thanos did nothing wrong" comments I made
 * in the in-class assignment.
 *
 * I actually already know C# and actually had an internship in 2017 where I programmed
 * entirely in C#.
 */

using System;

namespace Week1HW1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //This is the main change. I used a single WriteLine function with newline characters, not another function
            Console.WriteLine("My name is Thomas Lewis, I'm a junior in Computer Science with a minor in " +
                              "Management Information Systems and the plan for a Master's in Business " +
                              "Administration.\n" +
                              "I have programmed before in Java, C++, C#, Python, Javascript, and some minor " +
                              "experience with SQL.\n" +
                              "I used Java in Android Studio for robotics development, two semesters worth of Java " +
                              "at school, two semesters of C++, and then a semester of Python.");
            Console.ReadLine();
        }
    }
}