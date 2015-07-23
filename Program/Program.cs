using System;

namespace ita
{
    public static class Program
    {
        public static void menu()
        {

			#region Select
			Console.WriteLine ("1 = Giochi");
			Console.WriteLine ("2 = Matematica");
			Console.WriteLine ("3 = Altro");
			Console.WriteLine ("4 = New");
			Console.WriteLine ();
			Console.Write ("Scegli: ");
			#endregion

            string h = Console.ReadLine();
			#region Menu
			if (h == "1") {
				Giochi.menu ();
			} else if (h == "2") {
				Matematica.menu ();
			} else if (h == "3") {
				Altro.menu ();
			} else if (h == "4") {
				New.menu ();
			} else if (h == "99") {
				Admin.menu ();
			} else if (h == "98") {
				Test.test ();
			} else {
				Console.Write ("Programma non trovato.");
				Console.ReadLine ();
			}
			#endregion
        }

        public static void Main()
        {
            while (true) { Console.Clear(); menu(); }
        }
    }
}