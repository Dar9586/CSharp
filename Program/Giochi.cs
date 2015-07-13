using System;

namespace ita
{
	public static class Giochi
	{
		public static void menu1()
		{
			Console.WriteLine("0 = Menù Principale");
			Console.WriteLine("1 = Tris vs pc");
			Console.WriteLine("2 = Tris vs player");
			Console.WriteLine("3 = Switch");
			Console.WriteLine("4 = Memory");
			Console.WriteLine("5 = 49 Tiles");
			Console.WriteLine("6 = 2048");
			Console.WriteLine("7 = BlackJack");
			Console.WriteLine("8 = Scopa");
			Console.WriteLine("9 = Sudoku");
			Console.WriteLine("10 = Dama");
			Console.WriteLine();
			Console.Write("Scegli: ");

			string h = Console.ReadLine();
			if (h == "1") { TrisPc.trispc(); }
			else if (h == "2") { TrisPl.trispl(); }
			else if (h == "3") { Switch.swit(); }
			else if (h == "4") { Memory.mem(); }
			else if (h == "5") { Tiles.tile(); }
			else if (h == "6") { Game2048.gam(); }
			else if (h == "7") { BlackJack.jack(); }
			else if (h == "8") { Scopa.scop(); }
			else if (h == "9") { Sudoku.sudo(); }
			else if (h == "10") { Dama.dam(); }
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