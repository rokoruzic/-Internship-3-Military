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


	}
}
