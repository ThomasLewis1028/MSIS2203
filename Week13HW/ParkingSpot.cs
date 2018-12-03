namespace Week13HW
{
	class ParkingSpot
	{
		public ParkingSpot(ParkingLot lot, int spot)
		{
			Lot = lot;
			Spot = spot;
		}

		public ParkingLot Lot { get; }

		public int Spot { get; }

		public bool Filled()
		{
			return Car != null;
		}

		public Car Car { get; set; }
	}
}