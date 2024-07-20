using System;
using System.Drawing;

namespace MyApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double firstShortSide = 3;
			double secondShortSide = 4;
			double hypotenuse = 5;

			Console.WriteLine($"Hypotenuse is {Math.Sqrt(secondShortSide * secondShortSide + firstShortSide * firstShortSide)}");
			Console.WriteLine($"Unknown short side is {Math.Sqrt(hypotenuse * hypotenuse - secondShortSide * secondShortSide)}");
		}
	}
}