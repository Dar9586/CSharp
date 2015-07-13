using System;
using System.Collections.Generic;
using System.Text;

namespace ita
{
	public static class NoLimit
	{
		private static StringBuilder rev (StringBuilder str)
		{
			char[] array = str.ToString ().ToCharArray ();
			Array.Reverse (array);
			str.Remove (0, str.Length);
			str.Append (array);
			return str;
		}
		private static void divi (long num1, long num2)
		{
			int num;
			while (true) {
				try {
					Console.Write ("Inserisci cifre decimali dopo la virgola [Max. 50]: ");
					num = int.Parse (Console.ReadLine ());
					if (num > 0 && num < 51)
						break;
				} catch (Exception) {
				}
			}
			int dec = (int)(num1 / num2);
			StringBuilder str = new StringBuilder ();
			str.Append (dec.ToString () + ".");
			num += str.Length;
			long cache = num1 % num2;
			while (str.Length < num) {
				cache = long.Parse (cache.ToString () + "0");
				dec = (int)(cache / num2);
				str.Append (dec.ToString ());
				cache = cache % num2;
			}
			Console.Clear ();
			Console.WriteLine ("{0} / {1} = {2}", num1, num2, str.ToString ());
		}

		private static string addi (string num1, string num2, bool pri)
		{
			StringBuilder nu1 = new StringBuilder (num1);
			StringBuilder nu2 = new StringBuilder (num2);
			if (nu1.Length < nu2.Length) {
				int k = nu2.Length - nu1.Length;
				for (int a = 0; a < k; a++) {
					nu1 = rev (rev (nu1).Append ("0"));
				}
			} else {
				int k = nu1.Length - nu2.Length;
				for (int a = 0; a < k; a++) {
					nu2 = rev (rev (nu2).Append ("0"));
				}
			}
			string st1 = nu1.ToString ();
			string st2 = nu2.ToString ();
			int cache = 0;
			bool repo = false;
			StringBuilder final = new StringBuilder ();
			for (int a = nu1.Length - 1; a >= 0; a--) {
				cache = (int.Parse (st1.ToCharArray () [a].ToString ()) + int.Parse (st2.ToCharArray () [a].ToString ()));
				if (repo) {
					cache++;
				}
				if (cache > 9) {
					repo = true;
					cache -= 10;
				} else {
					repo = false;
				}
				final = rev (rev (final).Append (cache.ToString ()));
			}
			if (repo) {
				final = rev (rev (final).Append ("1"));
			}
			if (pri) {
				Console.WriteLine ("{0} + {1} = {2}", num1, num2, final);
			}
			return final.ToString ();
		}

		private static void sott (string num1, string num2)
		{
			string n1 = num1, n2 = num2;
			List<int> nu1 = new List<int> ();
			List<int> nu2 = new List<int> ();

			if (num1.Length < num2.Length) {
				int k = num2.Length - num1.Length;
				for (int a = 0; a < k; a++) {
					num1 = "0" + num1;
				}
			} else {
				int k = num1.Length - num2.Length;
				for (int a = 0; a < k; a++) {
					num2 = "0" + num2;
				}
			}
			bool can = true;

			for (int a = 0; a < num1.Length; a++) {
				nu1.Add (int.Parse (num1.ToCharArray () [a].ToString ()));
				nu2.Add (int.Parse (num2.ToCharArray () [a].ToString ()));
			}
			if (nu1.Equals (nu2)) {
				can = false;
			} else {
				for (int a = 0; a < nu1.Count; a++) {
					if (nu1 [a] < nu2 [a]) {
						break;
					} else if (nu1 [a] > nu2 [a]) {
						can = false;
						break;
					}
				}
			}
			if (can) {
				nu1.Clear ();
				nu2.Clear ();
				for (int a = 0; a < num1.Length; a++) {
					nu2.Add (int.Parse (num1.ToCharArray () [a].ToString ()));
					nu1.Add (int.Parse (num2.ToCharArray () [a].ToString ()));
				}
			}
			string final = "";

			for (int a = nu1.Count - 1; a >= 0; a--) {
				if ((nu1 [a] - nu2 [a]) < 0) {
					for (int b = a - 1; b >= 0; b--) {
						if (nu1 [b] > 0) {
							nu1 [b] = nu1 [b] - 1;
							nu1 [a] = nu1 [a] + 10;
							for (int c = b + 1; c != a; c++) {
								nu1 [c] = 9;
							}
						}
					}

				}
				final = (nu1 [a] - nu2 [a]).ToString () + final;
			}
			StringBuilder str = new StringBuilder (final);
			while (true) {
				if (str.ToString ().ToCharArray () [0].ToString () == "0") {
					str.Remove (0, 1);
				} else {
					break;
				}
			}
			final = str.ToString ();
			if (can) {
				final = "- " + final;
			}
			Console.WriteLine ("{0} - {1} = {2}", n1, n2, final);
		}

		private static string molt (string num, long num2, string real, bool prin)
		{
			for (int a = 0; a < num2 - 1; a++) {
				num = addi (real, num, false);
			}
			if (prin) {
				Console.WriteLine ("{0} * {1} = {2}", real, num2, num);
			}
			return num;
		}

		private static void pote (string num, long num2, string real)
		{
			for (int a = 0; a < num2 - 1; a++) {
				num = molt (num, long.Parse (real), num, false);
			}
			Console.WriteLine ("{0} ^ {1} = {2}", real, num2, num);
		}

		public static void noli1 ()
		{
			int ope = 0;
			while (true) {
				Console.Clear ();
				Console.WriteLine ("1 = Addizione");
				Console.WriteLine ("2 = Sottrazione");
				Console.WriteLine ("3 = Moltiplicazione");
				Console.WriteLine ("4 = Divisione");
				Console.WriteLine ("5 = Potenza");
				Console.WriteLine ();
				Console.Write ("Scegli: ");
				try {
					ope = int.Parse (Console.ReadLine ());
					if (ope > 0 && ope < 6) {
						break;
					}
				} catch (Exception) {
				}
			}

			long num1, num2;
			while (true) {
				try {
					Console.Write ("Inserisci primo numero: ");
					num1 = long.Parse (Console.ReadLine ());
					break;
				} catch (Exception) {
				}
			}
			while (true) {
				try {
					Console.Write ("Inserisci secondo numero: ");
					num2 = long.Parse (Console.ReadLine ());
					break;
				} catch (Exception) {
				}
			}


			if (ope == 1) {
				addi (num1.ToString (), num2.ToString (), true);
			} else if (ope == 2) {
				sott (num1.ToString (), num2.ToString ());
			} else if (ope == 3) {
				molt (num1.ToString (), num2, num1.ToString (), true);
			} else if (ope == 4) {
				divi (num1, num2);
			} else if (ope == 5) {
				pote (num1.ToString (), num2, num1.ToString ());
			}


			Console.Write ("00 per tornare al menù o INVIO per continuare: ");
			string b = Console.ReadLine ();
			if (b == "00") {
				Program.Main ();
			}
		}

		public static void noli ()
		{
			while (true) {
				Console.Clear ();
				noli1 ();
			}
		}
	}
}