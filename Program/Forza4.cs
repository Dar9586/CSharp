using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using System.Security.Cryptography;

namespace ita
{
	public class Forza4
	{
		private static List<int>top=new List<int>();
		private static List<int>left=new List<int>();
		private static List<int> scheme=new List<int>();
		private static int selected=0;
		private static void prinScheme(int x){
			Console.Write("\n\n\n  ");
			for(int a=0;a<6;a++){
				for(int b=0;b<7;b++){
					if(scheme[b+a*7]==0){Console.ForegroundColor=b==selected?ConsoleColor.Black:ConsoleColor.White;
						try{if(scheme[b+a*7+7]!=0&&b==selected){Console.ForegroundColor=ConsoleColor.Green;}}
						catch(Exception){if(b==selected){Console.ForegroundColor=ConsoleColor.Green;}}}
					else if(scheme[b+a*7]==1){Console.ForegroundColor=ConsoleColor.Red;}
					else if(scheme[b+a*7]==2){Console.ForegroundColor=ConsoleColor.Yellow;}
					Console.BackgroundColor=b==selected?ConsoleColor.White:ConsoleColor.Black;
					Console.Write("O");
					Console.ResetColor();
					Console.Write("  ");
				}
				Console.Write("\n\n  ");
			}
			if(x==1){Console.WriteLine("\n\nE' il turno del giocatore Rosso\n\n");}
			else if(x==2){Console.WriteLine("\n\nE' il turno del giocatore Giallo\n\n");}

		}

		private static void find(int x){
			int h=x/7;
			left.Add((x%7)*3+2);
			top.Add(3+h*2);
		}

		private static string createstring(int a,int b,int c,int d){
			return a.ToString()+b.ToString()+c.ToString()+d.ToString();
		}
		private static int checkWin(){
			//vittoria orizzontale
			for(int b=0;b<6;b++){
				for(int a=0;a<4;a++){
					if(createstring(scheme[b*7+a],scheme[b*7+1+a],scheme[b*7+2+a],scheme[b*7+3+a])=="1111"){
						find(b*7+a);find(b*7+a+1);find(b*7+a+2);find(b*7+a+3);
						Console.WriteLine("Il giocatore Rosso ha vinto!");return 1;}
					else if(createstring(scheme[b*7+a],scheme[b*7+1+a],scheme[b*7+2+a],scheme[b*7+3+a])=="2222"){
						find(b*7+a);find(b*7+a+1);find(b*7+a+2);find(b*7+a+3);
						Console.WriteLine("Il giocatore Giallo ha vinto!");return 2;}
				}
			}
			//vittoria verticale
			for(int b=0;b<7;b++){
				for(int a=0;a<3;a++){
					if(createstring(scheme[a*7+b],scheme[(a+1)*7+b],scheme[(a+2)*7+b],scheme[(a+3)*7+b])=="1111"){
						find(a*7+b);find((a+1)*7+b);find((a+2)*7+b);find((a+3)*7+b);
						Console.WriteLine("Il giocatore Rosso ha vinto!");return 1;}
					else if(createstring(scheme[a*7+b],scheme[(a+1)*7+b],scheme[(a+2)*7+b],scheme[(a+3)*7+b])=="2222"){
						find(a*7+b);find((a+1)*7+b);find((a+2)*7+b);find((a+3)*7+b);
						Console.WriteLine("Il giocatore Giallo ha vinto!");return 2;}
				}
			}
			//vittoria obliqua /
			for(int b=5;b>2;b--){
				for(int a=0;a<4;a++){
					if(createstring(scheme[b*7+a],scheme[(b*7+a)-6],scheme[(b*7+a)-12],scheme[(b*7+a)-18])=="1111"){
						find(b*7+a);find((b*7+a)-6);find((b*7+a)-12);find((b*7+a)-18);
						Console.WriteLine("Il giocatore Rosso ha vinto!");return 1;}
					else if(createstring(scheme[b*7+a],scheme[(b*7+a)-6],scheme[(b*7+a)-12],scheme[(b*7+a)-18])=="2222"){
						find(b*7+a);find((b*7+a)-6);find((b*7+a)-12);find((b*7+a)-18);
						find(a*7+b);find((a+1)*7+b);find((a+2)*7+b);find((a+3)*7+b);
						Console.WriteLine("Il giocatore Giallo ha vinto!");return 2;}
				}
			}
			//vittoria obliqua \
			for(int b=5;b>2;b--){
				for(int a=6;a>3;a--){
					if(createstring(scheme[b*7+a],scheme[(b*7+a)-8],scheme[(b*7+a)-16],scheme[(b*7+a)-24])=="1111"){
						find(b*7+a);find((b*7+a)-8);find((b*7+a)-16);find((b*7+a)-24);
						Console.WriteLine("Il giocatore Rosso ha vinto!");return 1;}
					else if(createstring(scheme[b*7+a],scheme[(b*7+a)-8],scheme[(b*7+a)-16],scheme[(b*7+a)-24])=="2222"){
						find(b*7+a);find((b*7+a)-8);find((b*7+a)-16);find((b*7+a)-24);
						Console.WriteLine("Il giocatore Giallo ha vinto!");return 2;}
				}
			}
			//nessuna vittoria
			return 0;
		}

		public static void forza1pl()
		{
			Random rnd=new Random(System.Environment.TickCount);
			selected=0;
			scheme.Clear();
			left.Clear();
			top.Clear();
			for(int a=0;a<42;a++){scheme.Add(0);}
			int what=rnd.Next(2);what++;
			ConsoleKeyInfo cki=new ConsoleKeyInfo();
			while(true){
				bool place=false;
				Console.Clear();
				prinScheme(what);
				cki=Console.ReadKey();
				if(cki.Key==ConsoleKey.RightArrow||cki.Key==ConsoleKey.D){if(selected<6){selected++;}}
				else if(cki.Key==ConsoleKey.LeftArrow||cki.Key==ConsoleKey.A){if(selected>0){selected--;}}
				else if(cki.Key==ConsoleKey.Enter){
					for(int a=5;a>=0;a--){if(scheme[selected+7*a]==0){scheme[selected+7*a]=what;place=true;break;}}
					if(place){what=what==2?1:2;
						Console.Clear();
						prinScheme(what);
						if(checkWin()==1||checkWin()==2){
							selected=-1;
							Console.Clear();prinScheme(what);
							string k=what==2?"Rosso":"Giallo";
							Console.SetCursorPosition(0,17);
							ConsoleColor s=new ConsoleColor();
							s=what==2?ConsoleColor.Red:ConsoleColor.Yellow;
							Console.ForegroundColor=s;Console.WriteLine("Ha vinto il giocatore "+k+"!    ");
							break;
						}
					}
					
				}

			}
			Console.ResetColor();
			Console.Write("\nESC per tornare al menù o INVIO per continuare: ");
			while(!Console.KeyAvailable){
				Thread.Sleep(150);
				for(int a=0;a<4;a++){Console.SetCursorPosition(left[a],top[a]);Console.ForegroundColor=ConsoleColor.Black;
					Console.Write(" ");}
				Thread.Sleep(150);
				ConsoleColor s=new ConsoleColor();
				s=what==2?ConsoleColor.Red:ConsoleColor.Yellow;
				for(int a=0;a<4;a++){Console.SetCursorPosition(left[a],top[a]);Console.ForegroundColor=s;
					Console.Write("O");}
			}

			cki=Console.ReadKey();Console.ResetColor(); if(cki.Key==ConsoleKey.Escape){Program.Main();}
		}

		public static void forza()
		{
			while (true) { Console.Clear(); forza1pl(); }
		}
	}
}

