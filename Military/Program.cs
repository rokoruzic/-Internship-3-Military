using System;

namespace Military
{
	class Program
	{
		static void Main(string[] args)
		{
			var tank1 = new Tank();
			Console.WriteLine(tank1.ToString());
			var amfibia1=new Amfibia();
			Console.WriteLine(amfibia1.Move(300)
			);
			Console.WriteLine(amfibia1.Swim(150));
			
		}
		
	}
}
