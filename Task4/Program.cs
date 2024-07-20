using System;

namespace MyApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter your frist name: ");
			string firstName = Console.ReadLine();
			Console.WriteLine($"Hello {firstName}!");
		}
	}
}