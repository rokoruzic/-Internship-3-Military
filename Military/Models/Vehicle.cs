using System;
using System.Collections.Generic;
using System.Text;
using Military.Enums;

namespace Military
{
	public abstract  class Vehicle
	{
		protected Guid  ID { get; set;}
		protected Weight Weight { get; set; }
		protected AverageSpeed AverageSpeed { get; set; }
		protected double FuelConsumption { get; set; }
		protected int Capacity { get; set; }

		public override string ToString()
		{
			return $"ID: {ID} | Weight: {(int) Weight} kg | Average speed: {(int) AverageSpeed} km/h | Capacity: {Capacity}";
		}
		public virtual  int NumberOfRides(int numberOfSoldiers)
		{
				var numberOfRides = 1;
				if (numberOfSoldiers == 0)
					numberOfRides = 0;
				while (numberOfSoldiers > Capacity)
				{
					numberOfRides+=2;
					numberOfSoldiers -= Capacity;
				}
				return numberOfRides;
		}
	}
}
