using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
	public abstract  class Vehicle
	{
		public Guid  ID { get; set; }
		public double Weight { get; set; }
		public double AverageSpeed { get; set; }
		public double FuelConsumption { get; set; }
		public int Capacity { get; set; }
		public override string ToString()
		{
			return $"ID: {ID} | Weight : {Weight} Average speed: {AverageSpeed} |Capacity: {Capacity}";

		}
	}
}
