using System;
using System.Collections.Generic;
using System.Linq;

namespace Week13HW
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			List<ParkingLot> lots = new List<ParkingLot>();
			lots.Add(new ParkingLot("Lot A"));
			lots.Add(new ParkingLot("Lot B"));
			lots.Add(new ParkingLot("Lot C"));
			lots.Add(new ParkingLot("Lot D"));
			lots.Add(new ParkingLot("Lot E"));

			lots[0].AddSpots(20);
			lots[1].AddSpots(10);
			lots[2].AddSpots(38);
			lots[3].AddSpots(40);
			lots[4].AddSpots(15);

			foreach (var lot in lots)
			{
				Console.WriteLine(lot.Lot);
				foreach (var spot in lot.GetSpots())
				{
					Console.WriteLine("\t" + spot.Lot.Lot);
				}
			}

			return;
			Console.WriteLine("Enter your tag number: ");
			Car myCar = new Car(Console.ReadLine());

			bool done = false;
			while (!done)
			{
				Console.WriteLine("Are you [p]arking or [g]oing? (exit to exit)");
				switch (Console.ReadLine().ToLower())
				{
					case "parking":
					case "p":
						List<ParkingLot> openLots = new List<ParkingLot>();
						foreach (ParkingLot l in lots)
						{
							if (ParkingLot.IsOpen())
								openLots.Add(l);
						}

						if (!openLots.Any())
						{
							Console.WriteLine("No spots are available in any lots");
							done = true;
							break;
						}

						int lotCount = openLots.Count;

						Console.WriteLine("Open Lots:");
						foreach (ParkingLot l in openLots)
						{
							Console.WriteLine("{0}: {1}", l.Lot, l.OpenCount());
						}

						Parking(myCar);
						break;
					case "going":
					case "g":

						break;
					case "exit":
						done = true;
						break;
					default:
						Console.WriteLine("Please follow the format.");
						break;
				}
			}
		}

		private static void Parking(Car c)
		{
		}
	}
}