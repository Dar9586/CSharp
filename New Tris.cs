using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ita
{
	public static class New_Tris
	{
		private static string check(List<string> list,string str){
			string fin="";

			for(int a=0;a<3;a++){
				fin=fin+list[int.Parse(str.ToCharArray()[a].ToString())];
			}
			return fin;
		}
		private static int move(int wher,ConsoleKeyInfo cki){
			if (cki.Key == ConsoleKey.UpArrow) {
				if (wher == 3) {wher = 0;}
				else if (wher == 4) {wher = 1;}
				else if (wher == 5) {wher = 2;}
				else if (wher == 6) {wher = 3;}
				else if (wher == 7) {wher = 4;}
				else if (wher == 8) {wher = 5;}
			}
			else if (cki.Key == ConsoleKey.DownArrow) {
				if (wher == 0) {wher = 3;}
				else if (wher == 1) {wher = 4;}
				else if (wher == 2) {wher = 5;}
				else if (wher == 3) {wher = 6;}
				else if (wher == 4) {wher = 7;}
				else if (wher == 5) {wher = 8;}
			}
			else if (cki.Key == ConsoleKey.RightArrow) {
				if (wher == 0) {wher = 1;}
				else if (wher == 1) {wher = 2;}
				else if (wher == 3) {wher = 4;}
				else if (wher == 4) {wher = 5;}
				else if (wher == 6) {wher = 7;}
				else if (wher == 7) {wher = 8;}
			}
			else if (cki.Key == ConsoleKey.LeftArrow) {
				if (wher == 1) {wher = 0;}
				else if (wher == 2) {wher = 1;}
				else if (wher == 4) {wher = 3;}
				else if (wher == 5) {wher = 4;}
				else if (wher == 7) {wher = 6;}
				else if (wher == 8) {wher = 7;}
			}
			return wher;
		}
		private static void prin(string str,bool x){
			if(x){Console.BackgroundColor=ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.Black;}
			Console.Write (str);Console.ResetColor ();
		}
		private static void printris1(int s){
			Console.Clear();
			prin ("Tris Vs Giocatore", s == 1);
			Console.WriteLine ("\n");
			prin ("Tris Vs Computer", s == 2);
			Console.WriteLine ();
		}
		private static void prinScheme(List<string> list,int s)
		{
			Console.Clear();
			Console.Write ("\n\n   ");prin (list [0], s == 0);Console.Write (" | ");
			prin (list [1], s == 1);Console.Write (" | ");
			prin (list [2], s == 2);Console.Write ("\n");
			Console.WriteLine ("\n  -----------\n");
			Console.Write ("   ");prin (list [3], s == 3);Console.Write (" | ");
			prin (list [4], s == 4);Console.Write (" | ");
			prin (list [5], s == 5);Console.Write ("\n");
			Console.WriteLine ("\n  -----------\n");
			Console.Write ("   ");prin (list [6], s == 6);Console.Write (" | ");
			prin (list [7], s == 7);Console.Write (" | ");
			prin (list [8], s == 8);Console.Write ("\n");

		}
		private static void trispl()
		{
			Random rnd = new Random();
			bool who = true;
			int wher = 0;
			int wher1=0;
			ConsoleKeyInfo cki=new ConsoleKeyInfo();
			string win1="Il giocatore 1 ha vinto!",win2="Il giocatore 2 ha vinto!",final="";
			int who1 = rnd.Next(2);
			if (who1 == 1) { who = false; }
			if (who) { Console.Write("Inizia il giocatore 1"); Console.ReadLine(); }
			else { Console.Write("Inizia il giocatore 2"); Console.ReadLine(); }

			List<string>list=new List<string>();
			for(int a=0;a<9;a++){list.Add(" ");}
			prinScheme(list, wher);
			while (true)
			{
				if (who)
				{
					while (true) {
						prinScheme (list, wher);
						cki = Console.ReadKey ();
						wher=move(wher,cki);
						if(cki.Key == ConsoleKey.Enter && list[wher]==" "){break;}


					}
					list[wher] = "X";
				}
				who = true;
				wher1=wher;
				prinScheme(list, -1);
				if (check(list,"630")=="XXX") { final=win1; break; }
				else if (check(list,"741")=="XXX") { final=win1; break; }
				else if (check(list,"852")=="XXX") { final=win1; break; }
				else if (check(list,"012")=="XXX") { final=win1; break; }
				else if (check(list,"345")=="XXX") { final=win1; break; }
				else if (check(list,"678")=="XXX") { final=win1; break; }
				else if (check(list,"642")=="XXX") { final=win1; break; }
				else if (check(list,"840")=="XXX") { final=win1; break; }
				else if (!list.Contains(" "))
				{ final="Pareggio"; break; }


				while (true) {
					prinScheme (list, wher1);
					cki = Console.ReadKey ();
					wher1=move(wher1,cki);
					if(cki.Key == ConsoleKey.Enter && list[wher1]==" "){break;}


				}
				list[wher1] = "O";
				wher=wher1;
				prinScheme(list, -1);
				if (check(list,"630")=="OOO") { final=win2; break; }
				else if (check(list,"741")=="OOO") { final=win2; break; }
				else if (check(list,"852")=="OOO") { final=win2; break; }
				else if (check(list,"012")=="OOO") { final=win2; break; }
				else if (check(list,"345")=="OOO") { final=win2; break; }
				else if (check(list,"678")=="OOO") { final=win2; break; }
				else if (check(list,"642")=="OOO") { final=win2; break; }
				else if (check(list,"840")=="OOO") { final=win2; break; }
				else if (!list.Contains(" "))
				{ final="Pareggio"; break; }
			}
			prinScheme(list, -1);Console.WriteLine("\n\n"+final);Console.ReadLine();Console.Clear();
			Console.Write("00 per tornare al menù o INVIO per continuare: ");
			string b = Console.ReadLine();
			if (b == "00") { Program.Main(); }
		}
		private static void trispc()
		{
			string win1="Il giocatore ha vinto!",win2="Il computer ha vinto!",final="";
			Random rnd = new Random();
			bool who = true;
			ConsoleKeyInfo cki = new ConsoleKeyInfo ();
			int wher = 0;
			int who1 = rnd.Next(2);
			if (who1 == 1) { who = false; }
			if (who) { Console.Write("Inizia il giocatore"); Console.ReadLine(); }
			else { Console.Write("Inizia il computer"); Console.ReadLine(); }
			Console.Clear ();
			List<string>list=new List<string>();
			for(int a=0;a<9;a++){list.Add(" ");}
			while (true)
			{
				if (who)
				{
					while (true) {
						prinScheme (list, wher);
						cki = Console.ReadKey ();
						wher=move(wher,cki);
						if(cki.Key == ConsoleKey.Enter && list[wher]==" "){break;}


					}
					list[wher] = "X";
				}
				who = true;
				prinScheme(list, -1);



				if(check(list,"630")=="XXX") { final=win1; break; }
				else if(check(list,"741")=="XXX") { final=win1; break; }
				else if(check(list,"852")=="XXX") { final=win1; break; }
				else if(check(list,"012")=="XXX") { final=win1; break; }
				else if(check(list,"345")=="XXX") { final=win1; break; }
				else if(check(list,"678")=="XXX") { final=win1; break; }
				else if(check(list,"642")=="XXX") { final=win1; break; }
				else if(check(list,"840")=="XXX") { final=win1; break; }
				else if (!list.Contains(" "))
				{ final="Pareggio"; break; }
			#region AI
				if(check(list,"012")=="OO ") { list[2] = "O"; final=win2; break; }
				else if(check(list,"021")=="OO ") { list[1] = "O"; final=win2; break; }
				else if(check(list,"120")=="OO ") { list[0] = "O"; final=win2; break; }
				else if(check(list,"345")=="OO ") { list[5] = "O"; final=win2; break; }
				else if(check(list,"453")=="OO ") { list[3] = "O"; final=win2; break; }
				else if(check(list,"354")=="OO ") { list[4] = "O"; final=win2; break; }
				else if(check(list,"678")=="OO ") { list[8] = "O"; final=win2; break; }
				else if(check(list,"876")=="OO ") { list[6] = "O"; final=win2; break; }
				else if(check(list,"867")=="OO ") { list[7] = "O"; final=win2; break; }
				else if(check(list,"630")=="OO ") { list[0] = "O"; final=win2; break; }
				else if(check(list,"603")=="OO ") { list[3] = "O"; final=win2; break; }
				else if(check(list,"036")=="OO ") { list[6] = "O"; final=win2; break; }
				else if(check(list,"741")=="OO ") { list[1] = "O"; final=win2; break; }
				else if(check(list,"417")=="OO ") { list[7] = "O"; final=win2; break; }
				else if(check(list,"714")=="OO ") { list[4] = "O"; final=win2; break; }
				else if(check(list,"852")=="OO ") { list[2] = "O"; final=win2; break; }
				else if(check(list,"285")=="OO ") { list[5] = "O"; final=win2; break; }
				else if(check(list,"258")=="OO ") { list[8] = "O"; final=win2; break; }
				else if(check(list,"642")=="OO ") { list[2] = "O"; final=win2; break; }
				else if(check(list,"624")=="OO ") { list[4] = "O"; final=win2; break; }
				else if(check(list,"246")=="OO ") { list[6] = "O"; final=win2; break; }
				else if(check(list,"840")=="OO ") { list[0] = "O"; final=win2; break; }
				else if(check(list,"408")=="OO ") { list[8] = "O"; final=win2; break; }
				else if(check(list,"804")=="OO ") { list[4] = "O"; final=win2; break; }
				else if(check(list,"012")=="XX ") { list[2] = "O"; }
				else if(check(list,"021")=="XX ") { list[1] = "O"; }
				else if(check(list,"120")=="XX ") { list[0] = "O"; }
				else if(check(list,"345")=="XX ") { list[5] = "O"; }
				else if(check(list,"453")=="XX ") { list[3] = "O"; }
				else if(check(list,"354")=="XX ") { list[4] = "O"; }
				else if(check(list,"678")=="XX ") { list[8] = "O"; }
				else if(check(list,"876")=="XX ") { list[6] = "O"; }
				else if(check(list,"867")=="XX ") { list[7] = "O"; }
				else if(check(list,"630")=="XX ") { list[0] = "O"; }
				else if(check(list,"036")=="XX ") { list[6] = "O"; }
				else if(check(list,"741")=="XX ") { list[1] = "O"; }
				else if(check(list,"417")=="XX ") { list[7] = "O"; }
				else if(check(list,"714")=="XX ") { list[4] = "O"; }
				else if(check(list,"852")=="XX ") { list[2] = "O"; }
				else if(check(list,"285")=="XX ") { list[5] = "O"; }
				else if(check(list,"258")=="XX ") { list[8] = "O"; }
				else if(check(list,"642")=="XX ") { list[2] = "O"; }
				else if(check(list,"624")=="XX ") { list[4] = "O"; }
				else if(check(list,"246")=="XX ") { list[6] = "O"; }
				else if(check(list,"840")=="XX ") { list[0] = "O"; }
				else if(check(list,"408")=="XX ") { list[8] = "O"; }
				else if(check(list,"804")=="XX ") { list[4] = "O"; }
				else
				{
					while (true)
					{
						int k = rnd.Next(9);
						if(list[k]==" " ) { list[k] = "O"; break; }
					}
				}
				if (!list.Contains(" "))
				{ final="Pareggio"; break; }
				#endregion
			}
			prinScheme(list, -1);Console.WriteLine("\n\n"+final);Console.ReadLine();Console.Clear();
			Console.Write("00 per tornare al menù o INVIO per continuare: ");
			string b = Console.ReadLine();
			if (b == "00") { Program.Main(); }
		}
		private static void tris1(){
			int s=1;
			ConsoleKeyInfo cki = new ConsoleKeyInfo ();
			while(cki.Key!=ConsoleKey.Enter){
				printris1 (s);
				cki = Console.ReadKey ();
				if (cki.Key == ConsoleKey.DownArrow||cki.Key == ConsoleKey.UpArrow) {
					if (s == 1) {
						s = 2;
					} else {
						s = 1;}

				}


			}
			Console.Clear ();
			if (s == 1) {
				trispl ();
			} else {
				trispc ();}
		}
		public static void tris()
		{
			while (true) { Console.Clear(); tris1(); }
		}
	}
}