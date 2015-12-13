using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ita
{
	public static class Test
	{
		public static void test1()
		{
            Console.SetWindowSize(50,40);
            Console.SetBufferSize(50,40);
			Console.BackgroundColor=ConsoleColor.White;Console.Clear();
			Letter.clearZone(2,2,38,38,ConsoleColor.Black);
			string b = Console.ReadLine();
			if (b == "00") { Program.Main(); }
		}

		public static void test()
		{
			while (true) { Console.Clear(); test1(); }
		}
	}
}