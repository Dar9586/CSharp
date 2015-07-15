using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ita
{
	public class Utility
	{
		public static string createPath (string ext)
		{

			string path = @"C:\";
			bool end = false;
			string[] st = new string[999];
			while (true) {
				Console.Clear ();
				while (true) {

					st = Directory.GetDirectories (path);
					for (int a = 0; a < st.Length; a++) {
						string s = "";
						s = (a + 1).ToString ();
						Console.WriteLine ("{0}. {1}", s, st [a]);
					}
					Console.WriteLine ("\nInserisci cartella dove andare \nInserire // per andare alla cartella dove si trova questo file\nInserire .. per tornare indietro di una cartella\noppure Inserisci il nome del file [Deve finire con {0}]:", ext);
					string l = Console.ReadLine ();
					Console.Clear ();
					try {
						if (l.Substring (l.Length - ext.Length, ext.Length) == ext && path != @"C:\") {
							path = Path.Combine (path, l);
							end = true;
							break;
						}
					} catch (ArgumentOutOfRangeException) {
					} catch (NullReferenceException) {
					}
					try {
						if (l == "//") {
							path = Directory.GetCurrentDirectory ();
							break;
						}
					} catch (ArgumentOutOfRangeException) {
					} catch (NullReferenceException) {
					}
					try {
						if (l == ".." && path != @"C:") {
							int o = 0;
							for (int a = path.Length - 1; a >= 0; a--) {
								if (path.ToCharArray () [a].ToString () == @"\") {
									o = a;
									break;
								}
							}
							path = path.Substring (0, o);
							if (path == "C:") {
								path = "C:\\";
							}
							break;
						}
					} catch (ArgumentOutOfRangeException) {
					} catch (NullReferenceException) {
					}
					try {
						int k = int.Parse (l);
						if (k > 0 && k < st.Length) {
							string[] st1 = Directory.GetDirectories (st [k - 1]);
							path = st [k - 1];
							break;
						}
					} catch (UnauthorizedAccessException) {
						Console.WriteLine ("Impossibile Accedere alla cartella.");
						Console.ReadLine ();
						break;
					} catch (FormatException) {
						Console.WriteLine ("Numero ,percorso o nome file non valido.");
						Console.ReadLine ();
						break;
					}


				}
				if (end) {
					break;
				}
			}


			return path;
		}
		public static string getFile (string ext)
		{
			bool ok = true;
			string path = @"C:\";
			bool end = false;
			int wh = -1;
			string[] st = new string[999];
			string[] st1 = new string[999];
			while (true) {
				ok = true;
				Console.Clear ();
				while (true) {
					wh = -1;
					st = Directory.GetDirectories (path);
					st1 = Directory.GetFiles (path);
					for (int a = 0; a < st.Length; a++) {
						string s = "";
						s = (a + 1).ToString ();
						Console.WriteLine ("{0}. {1}", s, st [a]);
					}
					for (int a = 0; a < st1.Length; a++) {
						string s = "";
						s = (a + 1 + st.Length).ToString ();
						Console.WriteLine ("{0}. {1}", s, st1 [a]);
					}
					Console.WriteLine ("\nInserisci cartella dove andare \nInserire // per andare alla cartella dove si trova questo file\nInserire .. per tornare indietro di una cartella\nIl nome del file deve finire con {0}:", ext);

					string l = Console.ReadLine ();
					Console.Clear ();
					try {
						if (l == "//") {
							path = Directory.GetCurrentDirectory ();
							break;
						}
					} catch (ArgumentOutOfRangeException) {
					} catch (NullReferenceException) {
					}
					try {
						if (l == ".." && path != @"C:") {
							int o = 0;
							for (int a = path.Length - 1; a >= 0; a--) {
								if (path.ToCharArray () [a].ToString () == @"\") {
									o = a;
									break;
								}
							}
							path = path.Substring (0, o);
							if (path == "C:") {
								path = "C:\\";
							}
							break;
						}
					} catch (ArgumentOutOfRangeException) {
					} catch (NullReferenceException) {
					}
					try {
						wh = int.Parse (l);
					} catch (FormatException) {
						ok = false;
					}
					if (ok) {
						if (wh < st.Length) {
							try {
								int k = int.Parse (l);
								if (k > 0 && k < st.Length) {
									string[] st2 = Directory.GetDirectories (st [k - 1]);
									path = st [k - 1];
									break;
								}
							} catch (UnauthorizedAccessException) {
								Console.WriteLine ("Impossibile Accedere alla cartella.");
								Console.ReadLine ();
								break;
							} catch (FormatException) {
								Console.WriteLine ("Numero ,percorso o nome file non valido.");
								Console.ReadLine ();
								break;
							}
						} else {
							wh = wh - st.Length - 1;
							if (st1 [wh].Substring (st1 [wh].Length - ext.Length, ext.Length) == ext) {
								return st1 [wh];
							} else {
								Console.WriteLine ("Nome file non valido.{0}", st1 [wh]);
								Console.ReadLine ();
								break;
							}
						}

					}

				}
				if (end) {
					break;
				}
			}


			return path;
		}
		public static StringBuilder rev(StringBuilder str)
		{
			char[] array = str.ToString().ToCharArray();
			Array.Reverse(array);
			str.Remove(0, str.Length);
			str.Append(array);
			return str;
		}

	}
}