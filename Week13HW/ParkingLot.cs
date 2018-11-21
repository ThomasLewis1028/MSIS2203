using System;
using System.Collections.Generic;

namespace Week13HW
{
	class ParkingLot
	{
		public ParkingLot(string lot)
		{
			Lot = lot;
		}
		
		public string Lot { get; private set; }
		
		public List<ParkingSpot> Spots { get; set; } = new List<ParkingSpot>();
	}
}