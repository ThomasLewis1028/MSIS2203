namespace Week13HW
{
	class ParkingSpot
	{
		private Car _car;

		public ParkingSpot(ParkingLot lot, int spot)
		{
			Lot = lot;
			Spot = spot;
		}

		public ParkingLot Lot { get; set; }
		private int Spot { get; set; }
		public bool Filled { get; set; }
		public Car Car { get; set; }
	}
}