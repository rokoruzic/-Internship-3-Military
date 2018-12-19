using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Military.Enums;

namespace Military
{
	public class Warship:Vehicle,ISwimmable
	{
		public Warship()
		{
			ID = Guid.NewGuid();
			Capacity = 50;
			FuelConsumption = 200;
			AverageSpeed = AverageSpeed.Warship;
			Weight = Weight.Warship;
		}
		public override string ToString()
		{
			return base.ToString();
		}
		public int Swim(int distance)
		{
			return distance += 3;
		}
	}
}
