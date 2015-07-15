using System;
using System.Collections.Generic;
using System.Text;

namespace ita
{
	public static class Sudoku
	{
		private static List<int> create()
		{
			Random rnd = new Random();
			int k = 0;
			List<int> list = new List<int>();
			list.Add(0);

			while (list.Contains(0))
			{
				list.Clear();
				bool restart = false;
				for (int a = 0; a < 81; a++)
				{
					list.Add(0);
				}
				for (int a = 1; a < 10; a++)
				{
					List<int> rig1 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
					List<int> rig2 = new List<int> { 9, 10, 11, 12, 13, 14, 15, 16, 17 };
					List<int> rig3 = new List<int> { 18, 19, 20, 21, 22, 23, 24, 25, 26 };
					List<int> rig4 = new List<int> { 27, 28, 29, 30, 31, 32, 33, 34, 35 };
					List<int> rig5 = new List<int> { 36, 37, 38, 39, 40, 41, 42, 43, 44 };
					List<int> rig6 = new List<int> { 45, 46, 47, 48, 49, 50, 51, 52, 53 };
					List<int> rig7 = new List<int> { 54, 55, 56, 57, 58, 59, 60, 61, 62 };
					List<int> rig8 = new List<int> { 63, 64, 65, 66, 67, 68, 69, 70, 71 };
					List<int> rig9 = new List<int> { 72, 73, 74, 75, 76, 77, 78, 79, 80 };

					List<int> col1 = new List<int> { 0, 9, 18, 27, 36, 45, 54, 63, 72 };
					List<int> col2 = new List<int> { 1, 10, 19, 28, 37, 46, 55, 64, 73 };
					List<int> col3 = new List<int> { 2, 11, 20, 29, 38, 47, 56, 65, 74 };
					List<int> col4 = new List<int> { 3, 12, 21, 30, 39, 48, 57, 66, 75 };
					List<int> col5 = new List<int> { 4, 13, 22, 31, 40, 49, 58, 67, 76 };
					List<int> col6 = new List<int> { 5, 14, 23, 32, 41, 50, 59, 68, 77 };
					List<int> col7 = new List<int> { 6, 15, 24, 33, 42, 51, 60, 69, 78 };
					List<int> col8 = new List<int> { 7, 16, 25, 34, 43, 52, 61, 70, 79 };
					List<int> col9 = new List<int> { 8, 17, 26, 35, 44, 53, 62, 71, 80 };

					List<int> squ1 = new List<int> { 0, 1, 2, 9, 10, 11, 18, 19, 20 };
					List<int> squ2 = new List<int> { 3, 4, 5, 12, 13, 14, 21, 22, 23 };
					List<int> squ3 = new List<int> { 6, 7, 8, 15, 16, 17, 24, 25, 26 };
					List<int> squ4 = new List<int> { 27, 28, 29, 36, 37, 38, 45, 46, 47 };
					List<int> squ5 = new List<int> { 30, 31, 32, 39, 40, 41, 48, 49, 50 };
					List<int> squ6 = new List<int> { 33, 34, 35, 42, 43, 44, 51, 52, 53 };
					List<int> squ7 = new List<int> { 54, 55, 56, 63, 64, 65, 72, 73, 74 };
					List<int> squ8 = new List<int> { 57, 58, 59, 66, 67, 68, 75, 76, 77 };
					List<int> squ9 = new List<int> { 60, 61, 62, 69, 70, 71, 78, 79, 80 };
					for (int c = 0; c < 9; c++)
					{
						bool o = false;
						List<int> usable = new List<int>();
						for (int k1 = 0; k1 < 81; k1++)
						{
							if (list[k1] == 0)
							{
								if (rig1.Contains(k1) || rig2.Contains(k1) || rig3.Contains(k1) || rig4.Contains(k1) || rig5.Contains(k1) || rig6.Contains(k1) || rig7.Contains(k1) || rig8.Contains(k1) || rig9.Contains(k1))
								{
									if (col1.Contains(k1) || col2.Contains(k1) || col3.Contains(k1) || col4.Contains(k1) || col5.Contains(k1) || col6.Contains(k1) || col7.Contains(k1) || col8.Contains(k1) || col9.Contains(k1))
									{
										if (squ1.Contains(k1) || squ2.Contains(k1) || squ3.Contains(k1) || squ4.Contains(k1) || squ5.Contains(k1) || squ6.Contains(k1) || squ7.Contains(k1) || squ8.Contains(k1) || squ9.Contains(k1))
										{
											usable.Add(k1);
											o = true;
										}
									}
								}
							}
						}
						if (o)
						{
							k = usable[rnd.Next(usable.Count)];
						}
						else { restart = true; }
						if (!restart)
						{
							list[k] = a;
							if (rig1.Contains(k)) { rig1.Clear(); }
							else if (rig2.Contains(k)) { rig2.Clear(); }
							else if (rig3.Contains(k)) { rig3.Clear(); }
							else if (rig4.Contains(k)) { rig4.Clear(); }
							else if (rig5.Contains(k)) { rig5.Clear(); }
							else if (rig6.Contains(k)) { rig6.Clear(); }
							else if (rig7.Contains(k)) { rig7.Clear(); }
							else if (rig8.Contains(k)) { rig8.Clear(); }
							else if (rig9.Contains(k)) { rig9.Clear(); }
							if (col1.Contains(k)) { col1.Clear(); }
							else if (col2.Contains(k)) { col2.Clear(); }
							else if (col3.Contains(k)) { col3.Clear(); }
							else if (col4.Contains(k)) { col4.Clear(); }
							else if (col5.Contains(k)) { col5.Clear(); }
							else if (col6.Contains(k)) { col6.Clear(); }
							else if (col7.Contains(k)) { col7.Clear(); }
							else if (col8.Contains(k)) { col8.Clear(); }
							else if (col9.Contains(k)) { col9.Clear(); }
							if (squ1.Contains(k)) { squ1.Clear(); }
							else if (squ2.Contains(k)) { squ2.Clear(); }
							else if (squ3.Contains(k)) { squ3.Clear(); }
							else if (squ4.Contains(k)) { squ4.Clear(); }
							else if (squ5.Contains(k)) { squ5.Clear(); }
							else if (squ6.Contains(k)) { squ6.Clear(); }
							else if (squ7.Contains(k)) { squ7.Clear(); }
							else if (squ8.Contains(k)) { squ8.Clear(); }
							else if (squ9.Contains(k)) { squ9.Clear(); }
						}
						if (restart) { break; }
					}
					if (restart) { break; }
				}
			}
			return list;
		}



		private static void prin(List<int> list, List<int> lis, int num)
		{
			Console.Clear();
			List<string> str = new List<string>();
			for (int a = 0; a < list.Count; a++)
			{
				if (a + 1 > 9) { str.Add((a + 1).ToString()); }
				else { str.Add("0" + (a + 1).ToString()); }
			}
			for (int a = 0; a < 9; a++)
			{
				for (int b = 0; b < 9; b++)
				{
					if (lis[b + (9 * a)] != 0) { Console.ForegroundColor = ConsoleColor.Red; }
					if (b + (9 * a) == num) { Console.ForegroundColor = ConsoleColor.Green; }
					Console.Write(list[b + (9 * a)] + " ");
					if ((b + 1) % 3 == 0) { Console.Write("  "); }
					Console.ResetColor();
				}
				Console.Write("        ");
				for (int b = 0; b < 9; b++)
				{
					Console.Write(str[b + (9 * a)] + " ");
					if ((b + 1) % 3 == 0) { Console.Write("  "); }
				}
				Console.WriteLine();
				if ((a + 1) % 3 == 0) { Console.WriteLine(); }
			}
		}

		public static void sudo1()
		{
			Random rnd = new Random();
			Console.WriteLine("Generazione schema ...");
			List<int> list = new List<int> (create());
			int num;
			List<int> user1 = new List<int>();
			for (int a = 0; a < 81; a++)
			{
				user1.Add(0);
			}
			while (true)
			{
				try
				{
					Console.Write("Inserisci quante caselle mostrare [15:70]: ");
					num = int.Parse(Console.ReadLine());
					if (num > 14 && num < 71)
					{
						break;
					}
				}
				catch (Exception)
				{
				}
			}

			for (int a = 0; a < num; a++)
			{
				int k = 0;
				while (true)
				{
					k = rnd.Next(81);
					if (user1[k] == 0) { break; }
				}
				user1[k] = list[k];
			}
			List<int> user = new List<int>(user1);
			int mov = 0;
			while (true)
			{
				int n = 0;
				while (true)
				{
					try
					{
						prin(user, user1, -1);
						Console.Write("Inserisci dove cambiare: ");
						n = int.Parse(Console.ReadLine());
						if (n > 0 && n < 82 && user1[n - 1] == 0) { break; }
						else
						{
							Console.WriteLine("Numero non valido."); Console.ReadLine();
						}
					}
					catch (Exception)
					{
						Console.WriteLine("Numero non valido."); Console.ReadLine();
					}
				}
				n--;
				int n1 = 0;
				while (true)
				{
					try
					{
						prin(user, user1, n);
						Console.Write("Inserisci con cosa cambiare: ");
						n1 = int.Parse(Console.ReadLine());
						if (n1 >= 0 && n1 < 10) { break; }
						else
						{
							Console.WriteLine("Numero non valido."); Console.ReadLine();
						}
					}
					catch (Exception)
					{
						Console.WriteLine("Numero non valido."); Console.ReadLine();
					}
				}
				user[n] = n1;
				mov++;
				if (user == list) { break; }
			}
			Console.WriteLine("Hai vinto dopo {0} mosse!", mov);

			Console.Write("00 per tornare al menù o INVIO per continuare: ");
			string b = Console.ReadLine();
			if (b == "00") { Program.Main(); }
		}

		public static void sudo()
		{
			while (true) { Console.Clear(); sudo1(); }
		}
	}
}