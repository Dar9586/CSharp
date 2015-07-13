using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ita
{
	public static class Paint
	{
		private static int select(List<ConsoleColor> li,bool l){
				int f=0;
				List<string> str=new List<string>();
				str.Add("Bianco ");
				str.Add("Nero");
				str.Add("Blu    ");
				str.Add("Blu Scuro");
				str.Add("Verde  ");
				str.Add("Verde Scuro");
				str.Add("Ciano  ");
				str.Add("Ciano Scuro");
				str.Add("Rosso  ");
				str.Add("Rosso Scuro");
				str.Add("Magenda");
				str.Add("Magenda Scuro");
				str.Add("Giallo ");
				str.Add("Giallo scuro");
				str.Add("Grigio ");
				str.Add("Grigio Scuro");
				for(int a=0;a<16;a++){
					string o=(a+1).ToString();
					if(a+1<10){o="0"+o;}
					Console.Write("{0})",o);
					Console.BackgroundColor=li[a];
					Console.Write("    ");
					Console.ResetColor();
					Console.Write(" = {0}",str[a]);
					if(a%2==0){Console.Write("        ");}
					else{Console.WriteLine();}
				}
			int num=0;
			Console.WriteLine("17 = Colori Casuali.");
			if(l){
				Console.WriteLine("0 per Annullare.");num=-1;}
			
			Console.WriteLine("\n");
				while(true){
					try{

						Console.WriteLine("Scegli: ");
						f=int.Parse(Console.ReadLine());
						if(f>num&&f<18){break;}
					else{f=0;int h=6/f;}
					}catch(Exception){Console.WriteLine("Numero invalido.");}}
			return f;
	
		}
		private static ConsoleColor reve(ConsoleColor s){
			if(s==ConsoleColor.Black){s=ConsoleColor.White;}
			else if(s==ConsoleColor.White){s=ConsoleColor.Black;}
			else if(s==ConsoleColor.DarkYellow){s=ConsoleColor.Blue;}
			else if(s==ConsoleColor.Yellow){s=ConsoleColor.DarkBlue;}
			else if(s==ConsoleColor.DarkMagenta){s=ConsoleColor.Green;}
			else if(s==ConsoleColor.Magenta){s=ConsoleColor.DarkGreen;}
			else if(s==ConsoleColor.DarkRed){s=ConsoleColor.Cyan;}
			else if(s==ConsoleColor.Red){s=ConsoleColor.DarkCyan;}
			else if(s==ConsoleColor.DarkCyan){s=ConsoleColor.Red;}
			else if(s==ConsoleColor.Cyan){s=ConsoleColor.DarkRed;}
			else if(s==ConsoleColor.DarkGreen){s=ConsoleColor.Magenta;}
			else if(s==ConsoleColor.Green){s=ConsoleColor.DarkMagenta;}
			else if(s==ConsoleColor.DarkBlue){s=ConsoleColor.Yellow;}
			else if(s==ConsoleColor.Blue){s=ConsoleColor.DarkYellow;}
			else if(s==ConsoleColor.DarkGray){s=ConsoleColor.Gray;}
			else if(s==ConsoleColor.Gray){s=ConsoleColor.DarkGray;}
			return s;
		}



		private static void prin(List<ConsoleColor> list,int pos,int b,int h){
			Console.Clear();
			int old=0;
			for (int c = 0; c < h; c++) {
				for (int a = 0; a < b; a++) {
					if(old+a==pos){Console.BackgroundColor=reve(list[old+a]);}
					else{Console.BackgroundColor = list[old+a];}
					Console.Write(" ");
				}
				old=old+b;
				Console.ResetColor ();
				Console.WriteLine ();
			}

		} 


		public static void pain1()
		{
			int hei=Console.LargestWindowHeight;
			int wid=Console.LargestWindowWidth;

			int om=2;
			List<ConsoleColor> li = new List<ConsoleColor> ();
			li.Add(ConsoleColor.White);
			li.Add(ConsoleColor.Black);
			li.Add(ConsoleColor.Blue);
			li.Add(ConsoleColor.DarkBlue);
			li.Add(ConsoleColor.Green);
			li.Add(ConsoleColor.DarkGreen);
			li.Add(ConsoleColor.Cyan);
			li.Add(ConsoleColor.DarkCyan);
			li.Add(ConsoleColor.Red);
			li.Add(ConsoleColor.DarkRed);
			li.Add(ConsoleColor.Magenta);
			li.Add(ConsoleColor.DarkMagenta);
			li.Add(ConsoleColor.Yellow);
			li.Add(ConsoleColor.DarkYellow);
			li.Add(ConsoleColor.Gray);
			li.Add(ConsoleColor.DarkGray);
			Random rnd=new Random();
			int b,h;
			while (true)
			{
				try
				{
					Console.Write("Inserisci lunghezza tela [5:{0}]: ",wid-2);
					b = int.Parse(Console.ReadLine());
					if (b > 4 && b < wid-1)
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
					Console.Write("Inserisci altezza tela [5:{0}]: ",hei-5);
					h = int.Parse(Console.ReadLine());
					if (h > 4 && h < hei-4)
					{
						break;
					}
				}
				catch (Exception)
				{
				}
			}
			ConsoleColor s=new ConsoleColor();
			List<int> undonum = new List<int> ();
			List<int> undotop = new List<int> ();
			List<int> undoleft = new List<int> ();
			List<ConsoleColor> undocol = new List<ConsoleColor> ();
			Console.WriteLine("Scegli il colore di sfondo:");
			int j=select(li,false);
			bool h1=true;
			if(j!=17){s=li[j-1];}
			else{h1=false;}
			List<ConsoleColor> list = new List<ConsoleColor> ();
			Console.CursorSize=100;
			for (int a = 0; a < b*h; a++) {
				if(h1){
					list.Add (s);}
				else{
					
					int l=rnd.Next(16);
					list.Add(li[l]);
				}}
			ConsoleKeyInfo cki = new ConsoleKeyInfo();
			int pos=0;
			bool use=false;
			if(h>Console.WindowHeight&&b*2>Console.WindowWidth){
				Console.SetWindowSize(b*2,Console.WindowHeight+1);}
			else if(h>Console.WindowHeight){
				Console.SetWindowSize(Console.WindowWidth,Console.WindowHeight+1);
			}
			else if(b*2>Console.WindowWidth){
				Console.SetWindowSize(b*2,Console.WindowHeight);
			}
			Console.Title="Z per finire, S per cambiare colore, Z per annullare.";
			prin (list,-1,b,h);
			Console.SetCursorPosition(0,0);
			while(cki.Key!=ConsoleKey.Z){
				cki=Console.ReadKey();
				if(cki.Key==ConsoleKey.UpArrow&&Console.CursorTop>0){
					Console.SetCursorPosition(Console.CursorLeft-1,Console.CursorTop-1);
				}
				else if(cki.Key==ConsoleKey.DownArrow&&Console.CursorTop<b){
					Console.SetCursorPosition(Console.CursorLeft-1,Console.CursorTop+1);
				}
				else if(cki.Key==ConsoleKey.LeftArrow&&Console.CursorLeft>0){
					Console.SetCursorPosition(Console.CursorLeft-2,Console.CursorTop);
				}
				else if(cki.Key==ConsoleKey.RightArrow&&Console.CursorLeft<h){
					Console.SetCursorPosition(Console.CursorLeft,Console.CursorTop);
				}


			} 

			prin (list,-1,b,h);
			Console.Write("00 per tornare al menù o INVIO per continuare: ");
			string bb = Console.ReadLine();
			if (bb == "00") { Program.Main(); }
		}

		public static void pain()
		{
			while (true) { Console.Clear(); pain1(); }
		}
	}
}