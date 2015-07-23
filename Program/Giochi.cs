using System;

namespace ita
{
	public static class Giochi
	{
		public static void menu1()
		{
			#region Select
			Console.WriteLine ("0 = Menù Principale");
			Console.WriteLine ("1 = Tris");
			Console.WriteLine ("2 = Switch");
			Console.WriteLine ("3 = Memory");
			Console.WriteLine ("4 = 49 Tiles");
			Console.WriteLine ("5 = 2048");
			Console.WriteLine ("6 = BlackJack");
			Console.WriteLine ("7 = Scopa");
			Console.WriteLine ("8 = Sudoku");
			Console.WriteLine ("9 = Dama");
			Console.WriteLine ();
			Console.Write ("Scegli: ");
			#endregion

			string h = Console.ReadLine();

			#region Menu
			if (h == "1") {
				Tris.tris ();
			} else if (h == "2") {
				Switch.swit ();
			} else if (h == "3") {
				Memory.mem ();
			} else if (h == "4") {
				Tiles.tile ();
			} else if (h == "5") {
				Game2048.gam ();
			} else if (h == "6") {
				BlackJack.jack ();
			} else if (h == "7") {
				Scopa.scop ();
			} else if (h == "8") {
				Sudoku.sudo ();
			} else if (h == "9") {
				Dama.dam ();
			} else if (h == "99") {
				Admin.menu ();
			} else if (h == "0") {
				Program.Main ();
			} else {
				Console.Write ("Programma non trovato.");
				Console.ReadLine ();
			}
			#endregion
}

		public static void menu()
		{
			while (true) { Console.Clear(); menu1(); }
		}
	}
}