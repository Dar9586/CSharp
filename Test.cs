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
			Console.CursorSize=100;
			Console.Write("00 per tornare al menù o INVIO per continuare: ");
			string b = Console.ReadLine();
			if (b == "00") { Program.Main(); }
		}

		public static void test()
		{
			while (true) { Console.Clear(); test1(); }
		}
	}
}