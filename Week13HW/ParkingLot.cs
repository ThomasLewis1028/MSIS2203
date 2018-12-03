using System.Collections.Generic;

namespace Week13HW
{
	class ParkingLot
	{
		public ParkingLot(string lot)
		{
			Lot = lot;
		}
		
		public string Lot { get;  }
		
		public List<ParkingSpot> Spots { get; } = new List<ParkingSpot>();
	}
}