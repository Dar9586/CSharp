
using System;

namespace ita
{
	public static class Admin
	{
		public static void menu1()
		{
			#region Select
			Console.WriteLine ("Funzioni Extra");
			Console.WriteLine ("1 = Generatore");
			Console.WriteLine ("2 = Crea File");
			Console.WriteLine ("3 = Delete");
			Console.WriteLine ("4 = Crea Struttura");
			Console.WriteLine ("0 = Menù principale");
			Console.Write ("Scegli: ");
			#endregion

			string h = Console.ReadLine();
			#region Menu
			if (h == "0") {
				Program.Main ();
			} else if (h == "1") {
				Generatore.gene ();
			} else if (h == "2") {
				Creator.crea ();
			} else if (h == "3") {
				Delet.dele ();
			} else if (h == "4") {
				Creator2.menu ();
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