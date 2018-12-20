﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
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
		private int _MoveDistance { get; set; }
		public int MoveDistance
		{
			get { return _MoveDistance; }
			set { _MoveDistance = value; }
		}
		public override string ToString()
		{
			return base.ToString() + $" | Fuel consumption: {FuelOnGivenDistance(Swim(SwimDistance),Move(MoveDistance),NumberOfRides(NumberOfSoldiers))}";
		}
		private double FuelOnGivenDistance(int moveDistance, int swimDistance, int numberOfRides)
		{
			return (double)((moveDistance + swimDistance) * numberOfRides) * 0.7;
		}
		private  int NumberOfRides(int numberOfSoldiers)
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






