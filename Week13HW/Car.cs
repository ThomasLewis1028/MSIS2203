using System;

namespace Week13HW
{
	class Car
	{
		public Car(string tagNumber)
		{
			TagNumber = tagNumber;
		}

		public string TagNumber { get; set; }

		public ParkingSpot Spot { get; set; }

		public DateTime TimeStamp { get; set; }

		public string StudentID { get; set; }

		public Card Card { get; set; }
	}
}