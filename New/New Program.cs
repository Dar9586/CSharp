using System;

namespace ita
{
	public static class New
	{
		public static void menu1()
		{

			#region Select
			Console.WriteLine ("0 = Menù principale");
			Console.WriteLine ("1 = Giochi");
			Console.WriteLine ("2 = Altro");
			Console.Write ("\nScegli: ");
			#endregion

			string h = Console.ReadLine();
			#region Menu
			if (h == "1") {
				New_Giochi.menu1 ();
			} else if (h == "2") {
				New_Altro.menu1 ();
			} else if (h == "0") {
				Program.Main ();
			} else if (h == "99") {
				Admin.menu ();
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