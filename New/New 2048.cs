using System;
using System.Threading;
using System.Collections.Generic;

namespace ita
{
	public static class New_2048
	{
		private static void prin(List<int> list)
		{
			List<string> lis1 = new List<string> { "    ", " 02 ", " 04 ", " 08 ", " 16 ", " 32 ", " 64 ", "0128", "0256", "0512", "1024", "2048", "4096", "8192" };
			List<string> lis = new List<string>();
			for (int a = 0; a < 16; a++)
			{
				lis.Add(lis1[list[a]]);
			}
			Console.Clear();
			Console.WriteLine("{0}||{1}||{2}||{3}", lis[0], lis[1], lis[2], lis[3]);
			Console.WriteLine("----------------------");
			Console.WriteLine("{0}||{1}||{2}||{3}", lis[4], lis[5], lis[6], lis[7]);
			Console.WriteLine("----------------------");
			Console.WriteLine("{0}||{1}||{2}||{3}", lis[8], lis[9], lis[10], lis[11]);
			Console.WriteLine("----------------------");
			Console.WriteLine("{0}||{1}||{2}||{3}", lis[12], lis[13], lis[14], lis[15]);
		}

		private static List<int> move(List<int> list, int num1, int num2)
		{
			if (list[num2] == 0 && list[num1] != 0)
			{
				list[num2] = list[num1];
				list[num1] = 0;
			}
			else if (list[num2] == list[num1] && list[num1] != 0)
			{
				list[num2] = list[num1] + 1;
				list[num1] = 0;
			}
			return list;
		}

		private static List<int> moveUp(List<int> list)
		{
			for (int a = 0; a < 5; a++)
			{
				list = move(list, 4, 0);
				list = move(list, 5, 1);
				list = move(list, 6, 2);
				list = move(list, 7, 3);
				list = move(list, 8, 4);
				list = move(list, 9, 5);
				list = move(list, 10, 6);
				list = move(list, 11, 7);
				list = move(list, 12, 8);
				list = move(list, 13, 9);
				list = move(list, 14, 10);
				list = move(list, 15, 11);
			}
			return list;
		}

		private static List<int> moveDown(List<int> list)
		{
			for (int a = 0; a < 5; a++)
			{
				list = move(list, 8, 12);
				list = move(list, 9, 13);
				list = move(list, 10, 14);
				list = move(list, 11, 15);
				list = move(list, 4, 8);
				list = move(list, 5, 9);
				list = move(list, 6, 10);
				list = move(list, 7, 11);
				list = move(list, 0, 4);
				list = move(list, 1, 5);
				list = move(list, 2, 6);
				list = move(list, 3, 7);
			}
			return list;
		}

		private static List<int> moveLeft(List<int> list)
		{
			for (int a = 0; a < 5; a++)
			{
				list = move(list, 1, 0);
				list = move(list, 5, 4);
				list = move(list, 9, 8);
				list = move(list, 13, 12);
				list = move(list, 2, 1);
				list = move(list, 6, 5);
				list = move(list, 10, 9);
				list = move(list, 14, 13);
				list = move(list, 3, 2);
				list = move(list, 7, 6);
				list = move(list, 11, 10);
				list = move(list, 15, 14);
			}
			return list;
		}

		private static List<int> moveRight(List<int> list)
		{
			for (int a = 0; a < 5; a++)
			{
				list = move(list, 2, 3);
				list = move(list, 6, 7);
				list = move(list, 10, 11);
				list = move(list, 14, 15);
				list = move(list, 1, 2);
				list = move(list, 5, 6);
				list = move(list, 9, 10);
				list = move(list, 13, 14);
				list = move(list, 0, 1);
				list = move(list, 4, 5);
				list = move(list, 8, 9);
				list = move(list, 12, 13);
			}
			return list;
		}

		public static void gam1()
		{
			List<int> list = new List<int>();
			for (int a = 0; a < 16; a++)
			{
				list.Add(0);
			}
			bool bool1 = false, bool2 = false, bool3 = false;
			bool use1 = true, use2 = true, use3 = true;
			int moves = 0;
			bool ppp=true;
			ConsoleKeyInfo cki=new ConsoleKeyInfo();
			while (list.Contains(0) || moveDown(list).Contains(0) || moveUp(list).Contains(0) || moveLeft(list).Contains(0) || moveRight(list).Contains(0))
			{
				if(ppp){
				Random rnd = new Random();
				if (rnd.Next(2 ^ 31) % 10 != 0 && list.Contains(0))
				{
					while (true)
					{
						int h = rnd.Next(16);
						if (list[h] == 0) { list[h] = 1; break; }
					}
				}}else{ppp=true;}
				prin(list);
				cki=Console.ReadKey();

				List<int> old=new List<int>(list);
				if (cki.Key==ConsoleKey.UpArrow) { list = moveUp(list); }
				if (cki.Key==ConsoleKey.DownArrow) { list = moveDown(list); }
				if (cki.Key==ConsoleKey.LeftArrow) { list = moveLeft(list); }
				if (cki.Key==ConsoleKey.RightArrow) { list = moveRight(list); }
				if(list!=old){moves++;}else{ppp=false;}
				if (list.Contains(11) && use1)
				{
					use1 = false;
					bool1 = true;
				}
				if (list.Contains(12) && use2)
				{
					use2 = false;
					bool2 = true;
				}
				if (list.Contains(13) && use3)
				{
					use3 = false;
					bool3 = true;
				}
				if (list.Contains(11) && bool1)
				{
					Console.WriteLine("Hai Raggiunto 2048 dopo {0} mosse!", moves); Console.ReadLine();
					bool1 = false;
				}
				if (list.Contains(12) && bool2)
				{
					Console.WriteLine("Hai Raggiunto 4096 dopo {0} mosse!", moves); Console.ReadLine();
					bool2 = false;
				}
				if (list.Contains(13) && bool3)
				{
					break;
				}
			}
			if (bool3)
			{
				Console.WriteLine("Hai Raggiunto 8192 dopo {0} mosse!", moves);
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Hai perso dopo {0} mosse!", moves);
				Console.ReadLine();
			}

			Console.Write("00 per tornare al menù o INVIO per continuare: ");
			string b = Console.ReadLine();
			if (b == "00") { Program.Main(); }
		}

		public static void gam()
		{
			while (true) { Console.Clear(); gam1(); }
		}
	}
}