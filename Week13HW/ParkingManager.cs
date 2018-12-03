using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Week13HW
{
	class ParkingManager
	{
		public void RunManager()
		{
			List<ParkingLot> lots = new List<ParkingLot>();
			lots.Add(new ParkingLot("A"));
			lots.Add(new ParkingLot("B"));
			lots.Add(new ParkingLot("C"));
			lots.Add(new ParkingLot("D"));
			lots.Add(new ParkingLot("E"));

			AddSpots(lots[0], 20);
			AddSpots(lots[1], 10);
			AddSpots(lots[2], 38);
			AddSpots(lots[3], 40);
			AddSpots(lots[4], 15);

			FillRandom(lots[0]);
			FillRandom(lots[1]);
			FillRandom(lots[2]);
			FillRandom(lots[3]);
			FillRandom(lots[4]);

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
						SetPaymentType(myCar);
						var openLots = OpenLots(lots);

						if (!openLots.Any())
						{
							Console.WriteLine("No spots are available in any lots");
							done = true;
							break;
						}
						
						

						Console.WriteLine("Open Lots:");
						foreach (ParkingLot l in openLots)
						{
							Console.WriteLine("Lot {0}: {1}", l.Lot, OpenCount(l));
						}

						ParkingLot lot = null;
						bool done2 = false;
						while (!done2)
						{
							Console.Write("Select a lot: ");
							string lotString = Console.ReadLine().ToLower();

							if (lotString.Equals("exit"))
								break;

							lot = (lots.Find(A => A.Lot.ToLower().Equals(lotString)));
							if (lot != null)
							{
								done2 = true;
								break;
							}

							Console.WriteLine("Selection invalid.");
						}


						if (lot != null)
							ParkCar(myCar, lot);

						break;
					case "going":
					case "g":
						LeaveSpot(myCar);
						ChargeFee(myCar, CalcPrice(myCar.TimeStamp));
						break;
					case "exit":
						done = true;
						break;

					case "print":
						foreach (ParkingLot lot2 in lots)
						{
							Console.WriteLine("Lot {0}", lot2.Lot);
							foreach (ParkingSpot spot in lot2.Spots)
							{
								Console.WriteLine("\tSpot {0} - {1}", spot.Spot,
									(spot.Car != null ? spot.Car.TagNumber : null));
							}
						}

						break;
					default:
						Console.WriteLine("Please follow the format.");
						break;
				}
			}
		}

		private void ParkCar(Car car, ParkingLot lot)
		{
			List<ParkingSpot> openSpots = OpenSpots(lot);

			Console.WriteLine("Open spots in Lot {0}:", lot.Lot);
			foreach (ParkingSpot spot in openSpots)
			{
				Console.WriteLine("\t{0}", spot.Spot);
			}

			bool done = false;
			while (!done)
			{
				Console.WriteLine("Select a parking spot");
				int spotNum = Int32.Parse(Console.ReadLine());

				foreach (ParkingSpot spot in openSpots)
				{
					if (spot.Spot == spotNum)
					{
						FillSpot(lot, spotNum, car);
						Console.WriteLine("Car with tag {0} parked in {1}:{2}", car.TagNumber, lot.Lot, spot.Spot);
						car.TimeStamp = DateTime.Now;
						done = true;
					}
				}
			}
		}

		public void FillSpot(ParkingLot lot, int n, Car car)
		{
			if (n > lot.Spots.Count)
			{
				Console.WriteLine("{0}:{1} does not exist", lot.Lot, n);
			}
			else if (lot.Spots[n - 1].Filled())
			{
				Console.WriteLine("{0}:{1} is currently filled", lot.Lot, n);
			}
			else
			{
				lot.Spots[n - 1].Car = car;
				car.Spot = lot.Spots[n - 1];
			}
		}

		public void LeaveSpot(Car car)
		{
			Console.WriteLine("You are leaving {0}:{1}", car.Spot.Lot.Lot, car.Spot.Spot);
			car.Spot.Car = null;
			car.Spot = null;
		}

		public void AddSpots(ParkingLot lot, int n)
		{
			for (int i = 1; i <= n; i++)
			{
				lot.Spots.Add(new ParkingSpot(lot, i));
			}
		}

		public List<ParkingSpot> OpenSpots(ParkingLot lot)
		{
			return lot.Spots.Where(A => !A.Filled()).ToList();
		}

		public int OpenCount(ParkingLot lot)
		{
			return lot.Spots.Count(A => !A.Filled());
		}

		public List<ParkingLot> OpenLots(List<ParkingLot> list)
		{
			return (from l in list where l.Spots.Any(a => !a.Filled()) select l).ToList();
		}

		private void FillRandom(ParkingLot lot)
		{
			Random fill = new Random();
			foreach (ParkingSpot spot in lot.Spots)
			{
				if (fill.Next(0, 100) > 30)
				{
					var g = Guid.NewGuid();
					FillSpot(lot, spot.Spot, new Car(g.ToString().Substring(0, 6).ToUpper()));
				}
			}
		}

		private double CalcPrice(DateTime time)
		{
			int total = (DateTime.Now.Date - time.Date).Minutes;
			double price;

			if (total <= 60)
			{
				price = .75;
			}
			else if (total <= 120)
			{
				price = .75 * total;
			}
			else
			{
				price = .75 * 120 + total * .5;
			}


			return price;
		}

		private void ChargeFee(Car car, double price)
		{
			if (car.StudentID != null)
			{
				//TODO: Add ability to charge to a bursar account
				Console.WriteLine("{0} charged to account {1}", price, car.StudentID);
			}
			else
			{
				//TODO: Add ability to charge to a real card
				Console.WriteLine("{0} charged to card ending in {1}", price, car.Card.CardNumber.ToString().Substring(12));
			}
		}

		private void SetPaymentType(Car car)
		{
			Console.WriteLine("[B]ursar or [C]ard?");
			switch (Console.ReadLine().ToLower())
			{
				case "bursar":
				case "b":
					string id;
					do
					{
						Console.WriteLine("Enter Student ID: ");
						id = Console.ReadLine();
					} while (!(new Regex("^[a-z|A-Z][0-9]{8}$").IsMatch(id)));

					car.StudentID = id;
					break;
				case "card":
				case "c":
					string cardN, secN;
					car.Card = new Card();

					do
					{
						Console.WriteLine("Enter Card Number: ");
						cardN = Console.ReadLine();
					} while (!(new Regex("^[0-9]{16}$").IsMatch(cardN)));

					car.Card.CardNumber = long.Parse(cardN);

					Console.WriteLine("Enter Name on Card: ");
					car.Card.Name = Console.ReadLine();

					do
					{
						Console.WriteLine("Enter Security Number: ");
						secN = Console.ReadLine();
					} while (!(new Regex("^[0-9]{3}$").IsMatch(secN)));

					car.Card.SecurityNumber = Int32.Parse(secN);
					break;
			}
		}
	}
}