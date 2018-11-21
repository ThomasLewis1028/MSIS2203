namespace Week13HW
{
	class ParkingSpot
	{
		public ParkingSpot(ParkingLot lot, int spot)
		{
			Lot = lot;
			Spot = spot;
		}

		public ParkingLot Lot { get; set; }

		public int Spot { get; set; }

		public bool Filled()
		{
			return Car != null;
		}

		public Car Car { get; set; }
	}
}