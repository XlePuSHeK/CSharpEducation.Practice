using System;

namespace MyApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const double PI = Math.PI;
			var radius = 4;
			Console.WriteLine($"Circle radius is {PI * radius* radius}");
		}
	}
}