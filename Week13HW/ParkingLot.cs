using System;
using System.Collections.Generic;

namespace Week13HW
{
	class ParkingLot
	{
		private static List<ParkingSpot> _spots = new List<ParkingSpot>();

		public ParkingLot(string lot)
		{
			Lot = lot;
		}

		public void AddSpots(int n)
		{
			for (int i = 0; i < n; i++)
			{
				Spots.Add(new ParkingSpot(this, i));
			}
		}

		public void FillSpot(int n, Car car)
		{
			if (Spots.Count > n)
			{
				Console.WriteLine("{0}:{1} does not exist", Lot, n);
			}
			else if (Spots[n - 1].Filled)
			{
				Console.WriteLine("{0}:{1} is currently filled", Lot, n);
			}
			else
			{
				Spots[n - 1].Filled = true;
				Spots[n - 1].Car = car;
			}
		}

		public int OpenCount()
		{
			var count = 0;
			foreach (var spot in Spots)
			{
				if (!spot.Filled)
				{
					count++;
				}
			}

			return count;
		}

		public List<ParkingSpot> OpenSpots()
		{
			var spots = new List<ParkingSpot>();
			foreach (var spot in Spots)
			{
				if (!spot.Filled)
				{
					spots.Add(spot);
				}
			}

			return spots;
		}

		public static bool IsOpen()
		{
			var count = 0;

			foreach (var spot in _spots)
			{
				if (!spot.Filled)
				{
					count++;
				}
			}

			return count > 0;
		}

		public string Lot { get; private set; }

		public static List<ParkingSpot> Spots
		{
			get { return _spots; }
			set { _spots = value; }
		}


		public List<ParkingSpot> GetSpots()
		{
			return Spots;
		}
	}
}