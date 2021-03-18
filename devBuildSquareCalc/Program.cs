using System;

namespace devBuildSquareCalc
{
	class Program
	{
		public int GetArea(int side)
		{
			int area = side * side;
			return area;
		}
		public int GetPerimeter(int side)
		{
			int perimeter = side * 4;
			return perimeter;
		}

		static void Main(string[] args)
		{
			Program pro = new Program();
			Console.WriteLine("Welcome to our Square Calculator.");
			Console.WriteLine("Tell me the length of a side: ");
			String input = Console.ReadLine();
			int side = int.Parse(input);
			Console.Write("The Area is:");
			Console.WriteLine(pro.GetArea(side));
			Console.Write("The Perimeter is:");
			Console.WriteLine(pro.GetPerimeter(side));
		}
	}
}
