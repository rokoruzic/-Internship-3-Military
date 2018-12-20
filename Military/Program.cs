using System;

namespace Military
{
	class Program
	{
		static void Main(string[] args)
		{
			var tank1 = new Tank();
			var amfibia1=new Amfibia();
			tank1.MoveDistance = 400;
			var warship1 = new Warship();
			warship1.SwimDistance = 450;
			amfibia1.SwimDistance = 200;
			amfibia1.MoveDistance = 150;
			amfibia1.NumberOfSoldiers = 123;
			tank1.NumberOfSoldiers = 123;
			warship1.NumberOfSoldiers = 123;
			Console.WriteLine(amfibia1.ToString());
			Console.WriteLine(tank1.ToString());
			Console.WriteLine(warship1.ToString());




		}

	}
}
