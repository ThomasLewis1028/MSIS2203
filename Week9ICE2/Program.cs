using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Week9ICE2
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			int i = 0;

			List<string> name = new List<string>();
			List<string> inst = new List<string>();

			name.Add("James Hetfield");
			name.Add("Lars Ulrich");
			name.Add("Kirk Hammett");
			name.Add("Robert Trujilio");

			inst.Add("Rhythm Guitar/Vocals");
			inst.Add("Drums");
			inst.Add("Lead Guitar");
			inst.Add("Bass Guitar");

			var csv = new StringBuilder();
			var file = "C:\\Users\\thoma\\RiderProjects\\MSIS2203\\Week9ICE2\\Week9ICE2.csv";

			for (i = 0; i < name.Count; i++)
			{
				var newLine = string.Format("{0},{1}", name[i], inst[i]);
				csv.AppendLine(newLine);
			}

			File.AppendAllText(file, csv.ToString());
		}
	}
}