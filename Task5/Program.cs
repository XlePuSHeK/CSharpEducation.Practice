using System;

namespace MyApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter your first string: ");
			string firstString = Console.ReadLine();
			Console.Write("Please enter your second string: ");
			string secondString = Console.ReadLine();
			Console.WriteLine($"{firstString} {secondString}");
		}
	}
}