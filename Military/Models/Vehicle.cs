using System;
using System.Collections.Generic;
using System.Text;
using Military.Enums;

namespace Military
{
	public abstract  class Vehicle
	{
		public Guid  ID { get; set;}
		public Weight Weight { get; set; }
		public AverageSpeed AverageSpeed { get; set; }
		public double FuelConsumption { get; set; }
		public int Capacity { get; set; }
		public override string ToString()
		{
			return $"ID: {ID} | Weight : {(int)Weight} | Average speed: {(int)AverageSpeed} | Capacity: {Capacity}";

		}
	}
}
