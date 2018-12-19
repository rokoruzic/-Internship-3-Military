using System;
using System.Collections.Generic;
using System.Text;
using Military.Enums;

namespace Military
{
	public class Amfibia : Vehicle, ISwimmable, IDriveable
	{
		public Amfibia()
		{
			ID = Guid.NewGuid();
			Capacity = 20;
			FuelConsumption = 70;
			AverageSpeed = AverageSpeed.Amfibia;
			Weight = Weight.Amfibia;
		}

		public override string ToString()
		{
			return base.ToString();
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

		public int Swim(int distance)
		{
			var travelTimeCount = (double)(distance / (int) AverageSpeed)*6;
			while (travelTimeCount >=1)
			{
				travelTimeCount--;
				Random random = new Random();
				int randomNumber = random.Next(0, 100);
				if (randomNumber < 50)
				{
					distance += 3;
					travelTimeCount += 0.5;
				}

			}
			return distance;
		}
	}
}






