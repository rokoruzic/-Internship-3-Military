using System;
using System.Collections.Generic;
using System.Text;
using Military.Enums;

namespace Military
{
	public class Tank:Vehicle, IDriveable
	{
		public Tank()
		{
			ID=Guid.NewGuid();
			Capacity = 6;
			FuelConsumption = 30;
			AverageSpeed = AverageSpeed.Tank;
			Weight = Weight.Tank;
		}
		private int _NumberOfSoldiers { get; set; }
		public int NumberOfSoldiers
		{
			get { return _NumberOfSoldiers; }
			set { _NumberOfSoldiers = value; }
		}
		private int _MoveDistance { get; set; }

		public int MoveDistance
		{
			get { return _MoveDistance; }

			set { _MoveDistance = value; }
		}
		public override string ToString()
		{
			return base.ToString() + $" | Fuel consumption: {FuelOnGivenDistance(Move(MoveDistance), NumberOfRides(NumberOfSoldiers))}"; ;
		}
		private double FuelOnGivenDistance(int moveDistance, int numberOfRides)
		{
			return (double)moveDistance * numberOfRides * 0.3;
		}
		public int Move(int distance)
		{
			var slowingDownCount = distance / 10;
			while (slowingDownCount > 0)
			{
				slowingDownCount--;
				Random random = new Random();
				int randomNumber = random.Next(0, 100);
				if (randomNumber < 30)
				{
					distance += 5;
					if (distance % 2 == 0) slowingDownCount++;
				}
			}
			return distance;
		}
		private int NumberOfRides(int numberOfSoldiers)
		{
			int numberOfRides = 1;
			if (numberOfSoldiers == 0)
				numberOfRides = 0;
			while (numberOfSoldiers > Capacity)
			{
				numberOfRides++;
				numberOfSoldiers -= Capacity;
			}
			return numberOfRides;
		}
	}
}
