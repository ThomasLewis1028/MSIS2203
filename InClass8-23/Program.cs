/*
 * This file is for the in class activity on August 23rd, 2019.
 * It outputs to console a few lines using WriteLine and closes the console on user input.
 * I already have experiene in C#, so I'm using JetBrains Rider over Visual Studio because it's faster, prettier, more
 * lightweight, etc etc.
 */

using System;

namespace InClass8_23
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//These lines output to the console
			Console.WriteLine("Hello World\n" + 
			                  "Thanos did nothing wrong\n" +
			                  "Perfectly balanced, as all things should be.\n\n" +
			                  "JetBrains Rider > Visual Studio");
			Console.ReadLine();
		}
	}
}