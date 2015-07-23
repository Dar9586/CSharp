using System;

namespace ita
{
	public static class Matematica
	{
		public static void menu1()
		{
			#region Select
			Console.WriteLine ("0 = Menù Principale");
			Console.WriteLine ("1 = Calcolatrice");
			Console.WriteLine ("2 = MCD e mcm");
			Console.WriteLine ("3 = Scomposizione");
			Console.WriteLine ("4 = Semplificazione");
			Console.WriteLine ("5 = Notazione scientifica");
			Console.WriteLine ("6 = Proporzioni");
			Console.WriteLine ("7 = Convertitore Basi");
			Console.WriteLine ("8 = Password");
			Console.WriteLine ("9 = Espressioni");
			Console.WriteLine ("10 = No Limiti");
			Console.WriteLine ();
			Console.Write ("Scegli: ");
			#endregion

			string h = Console.ReadLine();
			#region Menu
			if (h == "1") {
				Calcolatrice.calc ();
			} else if (h == "2") {
				MCD.mcm ();
			} else if (h == "3") {
				Scomposizione.scom ();
			} else if (h == "4") {
				Semplificazione.semp ();
			} else if (h == "5") {
				Notazione.nota ();
			} else if (h == "6") {
				Proporzioni.prop ();
			} else if (h == "7") {
				Convertitore.conv ();
			} else if (h == "8") {
				Password.pass ();
			} else if (h == "9") {
				Espressioni.espr ();
			} else if (h == "99") {
				Admin.menu ();
			} else if (h == "10") {
				NoLimit.noli ();
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