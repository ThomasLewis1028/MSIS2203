/*
 * Thomas Lewis
 * MSIS2203
 * September 27, 2018
 * Week 6 In Class ICE 2
 */

using System;

namespace Week6ICE2
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//Output a string in all caps, toLower it, then output that
			var lowerString = "TESTING ONE TWO THREE";
			Console.Out.WriteLine(lowerString);
			var loweredString = lowerString.ToLower();
			Console.Out.WriteLine(loweredString);

			//Output a string then rip out a specific section of that string and output that
			var substr1 = "One two three four";
			Console.Out.WriteLine(substr1);
			var substr2 = substr1.Substring(4, 9);
			Console.Out.WriteLine(substr2);

			//Output a long string then replace random characters with other characters and output that
			var replaceString = "This is a long string of characters that mean basically nothing";
			Console.Out.WriteLine(replaceString);
			var replacedString = replaceString.Replace('a', 'x').Replace('s', 'z').Replace('t', 'p');
			Console.Out.WriteLine(replacedString);
		}
	}
}