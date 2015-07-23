using System;

namespace ita
{
	public static class New_Altro
	{
		public static void menu()
		{


			#region Select
			Console.WriteLine ("1 = Password");

			Console.WriteLine ();
			Console.Write ("Scegli: ");
			#endregion

			string h = Console.ReadLine();
			#region Menu
			if (h == "1") {
				New_Password.pass ();
			} else if (h == "0") {
				New.menu ();
			} else if (h == "99") {
				Admin.menu ();
			} else {
				Console.Write ("Programma non trovato.");
				Console.ReadLine ();
			}
			#endregion
}

		public static void menu1()
		{
			while (true) { Console.Clear(); menu(); }
		}
	}
}