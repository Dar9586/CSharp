using System;

namespace ita
{
	public static class New_Giochi
	{
		public static void menu()
		{

			Console.WriteLine("1 = Sudoku");
			Console.WriteLine("2 = Switch");
			Console.WriteLine("3 = 2048");
			Console.WriteLine("4 = Memory");
			Console.WriteLine("5 = Snake");
			Console.WriteLine("6 = Simon");
			Console.WriteLine();
			Console.Write("Scegli: ");

			string h = Console.ReadLine();
			if (h == "1") { New_Sudoku.sudo(); }
			else if (h == "2") { New_Switch.swit(); }
			else if (h == "3") { New_2048.gam(); }
			else if (h == "4") { New_Memory.mem(); }
			else if (h == "5") { Snake.snak(); }
			else if (h == "6") { Simon.simo(); }
			else if (h == "99") { Admin.menu(); }
			else if (h == "0") { New.menu(); }
			else { Console.Write("Programma non trovato."); Console.ReadLine(); }
		}

		public static void menu1()
		{
			while (true) { Console.Clear(); menu(); }
		}
	}
}