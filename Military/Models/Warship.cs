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
		private int _NumberOfSoldiers { get; set; }
		public int NumberOfSoldiers
		{
			get { return _NumberOfSoldiers; }
			set { _NumberOfSoldiers = value; }
		}
		private int _SwimDistance { get; set; }
		public int SwimDistance
		{
			get { return _SwimDistance; }
			set { _SwimDistance = value; }
		}
		public override string ToString()
		{
			return base.ToString() + $" | Fuel consumption: { FuelOnGivenDistance(Swim(SwimDistance), NumberOfRides(NumberOfSoldiers))}"; ;
		}
		public  double FuelOnGivenDistance( int swimDistance, int numberOfRides)
		{
			return (double)swimDistance* numberOfRides * (FuelConsumption / 100);
		}
		public int Swim(int distance)
		{
			var travelTimeCount = (double)(distance / (int)AverageSpeed) * 6;
			while (travelTimeCount >= 1)
			{
				travelTimeCount--;
				var random = new Random();
				var randomNumber = random.Next(0, 100);
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
