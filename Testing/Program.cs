using System;
using System.Collections.Generic;
using System.Text;
using StockComponents;

namespace Testing
{
	class Program
	{
		static void Main(string[] args) {
			Button testBtn = new Button();

			testBtn.FontSize = 10;

			Console.WriteLine( testBtn.FontSize );

			Console.ReadLine();
		}
	}
}
