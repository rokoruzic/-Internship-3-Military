using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Military
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please type distance between starting and final point for each vehicle");
			Console.WriteLine("Tank distance:");
			var tankDistance = Console.ReadLine();
			var tankDistanceInt=TryParse(tankDistance);
			Console.WriteLine("Warship distance:");
			var warshipDistance = Console.ReadLine();
			var warshipDistanceInt = TryParse(warshipDistance);
			Console.WriteLine("Amfibia land distance:");
			var amfibiaLandDistance = Console.ReadLine();
			var amfibiaLandDistanceInt = TryParse(amfibiaLandDistance);
			Console.WriteLine("Amfibia sea distance:");
			var amfibiaSeaDistance = Console.ReadLine();
			var amfibiaSeaDistanceInt = TryParse(amfibiaSeaDistance);
			while(amfibiaSeaDistanceInt + amfibiaLandDistanceInt >= warshipDistanceInt ||
			    amfibiaSeaDistanceInt + amfibiaLandDistanceInt >= tankDistanceInt)
			{
				Console.WriteLine("Amfibia total distance must be shortest, type again:");
				Console.WriteLine("Amfibia land distance:");
				amfibiaLandDistance = Console.ReadLine();
				amfibiaLandDistanceInt = TryParse(amfibiaLandDistance);
				Console.WriteLine("Amfibia sea distance:");
				amfibiaSeaDistance = Console.ReadLine();
				amfibiaSeaDistanceInt = TryParse(amfibiaSeaDistance);
			}
			Console.WriteLine("Our dear general, now please type number of soldiers for transfer");
			var soldiers = Console.ReadLine();
			var soldiersInt = TryParse(soldiers);
			var tank1 =new Tank();
			var warship1=new Warship();
			var amfibia1=new Amfibia();
			tank1.MoveDistance = tankDistanceInt;
			warship1.SwimDistance = warshipDistanceInt;
			amfibia1.MoveDistance = amfibiaLandDistanceInt;
			amfibia1.SwimDistance = amfibiaSeaDistanceInt;
			tank1.NumberOfSoldiers = soldiersInt;
			warship1.NumberOfSoldiers = soldiersInt;
			amfibia1.NumberOfSoldiers = soldiersInt;
			Console.WriteLine("Tank: " + "\n" + tank1.ToString());
			Console.WriteLine("Warship: " + "\n" + warship1.ToString());
			Console.WriteLine("Amfibia: " + "\n" + amfibia1.ToString());
			var amfibiaTotalFuel = amfibia1.FuelOnGivenDistance(amfibia1.Move(amfibia1.MoveDistance),
				amfibia1.Swim(amfibia1.SwimDistance), amfibia1.NumberOfRides(amfibia1.NumberOfSoldiers));
			var tankTotalFuel = tank1.FuelOnGivenDistance(tank1.Move(tank1.MoveDistance),
				tank1.NumberOfRides(tank1.NumberOfSoldiers));
			var warshipTotalFuel = warship1.FuelOnGivenDistance(warship1.Swim(warship1.SwimDistance),
				warship1.NumberOfRides(warship1.NumberOfSoldiers));
			if (tankTotalFuel < warshipTotalFuel && tankTotalFuel < amfibiaTotalFuel)
				Console.WriteLine("General, you should use tank, because it is most efficient vehicle");
			else if (warshipTotalFuel < tankTotalFuel && warshipTotalFuel < amfibiaTotalFuel)
				Console.WriteLine("General, you should use warship, because it is most efficient vehicle");
			else
				Console.WriteLine("General, you should use amfibia, because it is most efficient vehicle");
		}
		public static int TryParse(string distance)
		{
			var number = 0;
			var numberCheck = int.TryParse(distance, out number);
			while (!numberCheck)
			{
				Console.WriteLine("Distance must only contain numbers, please try again");
				distance = Console.ReadLine();
				numberCheck = int.TryParse(distance, out number);
			}
			return number;
		}
	}
}
