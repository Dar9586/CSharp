using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace ita
{
	public static class New_Switch
	{
		private static StringBuilder rev(StringBuilder str)
		{
			char[] array = str.ToString().ToCharArray();
			Array.Reverse(array);
			str.Remove(0, str.Length);
			str.Append(array);
			return str;
		}

		private static void prinscheme(int b, int h, List<string> user,int where)
		{
			Console.Clear();
			int old=0;
			for(int c=0;c<h;c++){
				for(int a=0;a<b;a++){
					if(old+a==where){Console.ForegroundColor=ConsoleColor.Black;
						Console.BackgroundColor=ConsoleColor.White;}
					Console.Write(user[a+old]);
					Console.ResetColor();
					if(a+1!=b){
						Console.Write(" ");}
				}
				Console.WriteLine();
				old+=b;
			}

		}

		public static void swit1()
		{
			int h=Console.WindowHeight;
			int w=Console.WindowWidth;
			int hei=Console.LargestWindowHeight;
			int wid=Console.LargestWindowWidth/2;
			Random rnd = new Random();
			int bas = 0, alt = 0;
			while (bas * alt < 4)
			{
				while (true)
				{
					try
					{
						Console.Write("Inserisci lunghezza schema [1:{0}]: ",wid-2);
						bas = int.Parse(Console.ReadLine());
						if (bas > 0 && bas < wid-1)
						{
							break;
						}
					}
					catch (Exception)
					{
					}
				}
				while (true)
				{
					try
					{
						Console.Write("Inserisci altezza tela [1:{0}]: ",hei-2);
						alt = int.Parse(Console.ReadLine());
						if (alt > 0 && alt < hei-1)
						{
							break;
						}
					}
					catch (Exception)
					{
					}
				}
				}
				if (bas * alt < 4)
				{
					Console.WriteLine("Schema troppo piccolo, INVIO per rincominciare.");
					Console.ReadLine();
					Console.Clear();
				}

			List<string> list = new List<string>();
			Console.Write("Inserisci carattere casella piena: ");
			char ch;
			try
			{
				ch = Console.ReadLine().ToCharArray()[0];
				if (String.IsNullOrWhiteSpace(ch.ToString())) { ch = "X".ToCharArray()[0]; }
			}
			catch (Exception)
			{
				ch = "X".ToCharArray()[0];
			}
			Console.WriteLine("Verrà utilizzato il carattere {0} per le caselle piene.", ch.ToString());
			Console.Write("Inserisci carattere casella vuota: ");
			char ch1;
			try
			{
				ch1 = Console.ReadLine().ToCharArray()[0];
			}
			catch (Exception)
			{
				ch1 = "-".ToCharArray()[0];
				if (String.IsNullOrWhiteSpace(ch1.ToString())) { ch1 = "-".ToCharArray()[0]; }
			}
			Console.WriteLine("Verrà utilizzato il carattere {0} per le caselle vuote.", ch1.ToString());
			for (int a = 0; a < bas * alt; a++)
			{
				if (rnd.Next(2) == 1)
				{
					list.Add(ch.ToString());
				}
				else
				{
					list.Add(ch1.ToString());
				}
			}
			Console.ReadLine();
			if(alt>h&&bas*2>w){
				Console.SetWindowSize(bas*2,alt+1);}
			else if(alt>h){
				Console.SetWindowSize(w,alt+1);
			}
			else if(bas*2>w){
				Console.SetWindowSize(bas*2,h);
			}
			prinscheme(bas, alt, list,0);
			int moves = 0;
			int where=0;
			ConsoleKeyInfo cki=new ConsoleKeyInfo();
			while (list.Contains(ch1.ToString()) && list.Contains(ch.ToString()))
			{
				
				while(true){
					prinscheme(bas, alt, list,where);
					Thread.Sleep(1);
					cki=Console.ReadKey();
					if(cki.Key==ConsoleKey.UpArrow){if(where-bas>=0){where-=bas;}}
					else if(cki.Key==ConsoleKey.DownArrow){if(where+bas<bas*alt){where+=bas;}}
					else if(cki.Key==ConsoleKey.LeftArrow){if(where-1>=0){where--;}}
					else if(cki.Key==ConsoleKey.RightArrow){if(where+1<bas*alt){where++;}}
					else if(cki.Key==ConsoleKey.Enter){break;}
				}
				if (list[where] == ch.ToString()) { list[where] = ch1.ToString(); } else { list[where] = ch.ToString(); }
				try { if (where % bas != 0) { if (list[where - 1] == ch.ToString()) { list[where - 1] = ch1.ToString(); } else { list[where - 1] = ch.ToString(); } } } catch (ArgumentOutOfRangeException) { }
				try { if ((where + 1) % bas != 0) { if (list[where + 1] == ch.ToString()) { list[where + 1] = ch1.ToString(); } else { list[where + 1] = ch.ToString(); } } } catch (ArgumentOutOfRangeException) { }
				try { if (list[where + bas] == ch.ToString()) { list[where + bas] = ch1.ToString(); } else { list[where + bas] = ch.ToString(); } } catch (ArgumentOutOfRangeException) { }
				try { if (list[where - bas] == ch.ToString()) { list[where - bas] = ch1.ToString(); } else { list[where - bas] = ch.ToString(); } } catch (ArgumentOutOfRangeException) { }

				prinscheme(bas, alt, list,where);
				moves++;
			}
			Console.WriteLine("Hai vinto dopo {0} mosse\n\n", moves);

			Console.Write("00 per tornare al menù o INVIO per continuare: ");
			string bv = Console.ReadLine();
			if (bv == "00") { Program.Main(); }
		}

		public static void swit()
		{
			while (true) { Console.Clear(); swit1(); }
		}
	}
}