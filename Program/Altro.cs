using System;

namespace ita
{
	public static class Altro
	{
		public static void menu1()
		{
			Console.WriteLine("0 = Menù Principale");
			Console.WriteLine("1 = First");
			Console.WriteLine("2 = Password");
			Console.WriteLine("3 = Paint");
			Console.WriteLine();
			Console.Write("Scegli: ");

			string h = Console.ReadLine();
			if (h == "1") { First.first(); }
			else if (h == "2") { Password.pass(); }
			else if (h == "3") { Paint.pain(); }
			else if (h == "99") { Admin.menu(); }
			else if (h == "0") { Program.Main(); }
			else { Console.Write("Programma non trovato."); Console.ReadLine(); }
}

		public static void menu()
		{
			while (true) { Console.Clear(); menu1(); }
		}
	}
}