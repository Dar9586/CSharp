using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ita
{
	public static class Snake
	{
		public static void snak1()
		{
			int len=5;
			int before=0;
		//	int bas,alt;

			Random rnd=new Random();
			for(int a=0;a<500;a++){rnd.Next(965984);}
			int x=rnd.Next(20)+11,y=rnd.Next(10)+5;
			int ax=rnd.Next(43)+1;
			int ay=rnd.Next(22)+1;
			int pos=1;
			Console.WriteLine("/////////////////////////////////////////////");
			for(int a=0;a<22;a++){
				Console.WriteLine("/                                           /");
			}
			Console.WriteLine("/////////////////////////////////////////////");
			ConsoleKeyInfo cki=new ConsoleKeyInfo();
			Console.Title="Punteggio: 0";
			Console.SetCursorPosition(ax,ay);Console.Write("X");
			bool end=true;
			List<int>snakleft=new List<int>{x};
			List<int>snaktop=new List<int>{y};
			Console.SetCursorPosition(x,y);
			Console.Write("0");
			while(!Console.KeyAvailable){Thread.Sleep(5);}
			cki=Console.ReadKey();
			if(cki.Key==ConsoleKey.LeftArrow){pos=2;}
			if(cki.Key==ConsoleKey.RightArrow){pos=4;}
			if(cki.Key==ConsoleKey.DownArrow){pos=3;}
			if(cki.Key==ConsoleKey.UpArrow){pos=1;}


			while(end){
				
				Thread.Sleep(75);
				if(Console.KeyAvailable){
					
					cki=Console.ReadKey();
					if(cki.Key==ConsoleKey.UpArrow||cki.Key==ConsoleKey.DownArrow||cki.Key==ConsoleKey.RightArrow||cki.Key==ConsoleKey.LeftArrow){}
					if(pos==2||pos==4){
						if(cki.Key==ConsoleKey.DownArrow){before=pos;pos=3;}
						else if(cki.Key==ConsoleKey.UpArrow){before=pos;pos=1;}
					}
					else if(pos==1||pos==3){
						if(cki.Key==ConsoleKey.LeftArrow){before=pos;pos=2;}
						else if(cki.Key==ConsoleKey.RightArrow){before=pos;pos=4;}
					}
				}




				if(pos==1){
						y--;
						Console.SetCursorPosition(x,y);
					Console.Write("▲");
				}

					else if(pos==2){
						x--;
						Console.SetCursorPosition(x,y);
					Console.Write("◄");
				}

					else if(pos==3){
						y++;
						Console.SetCursorPosition(x,y);
					Console.Write("▼");
				}

				else if(pos==4){
						x++;
						Console.SetCursorPosition(x,y);
					Console.Write("►");
					}
				if(snakleft.Contains(x)){
					for(int a=0;a<snakleft.Count;a++){
						if(snakleft[a]==x&&snaktop[a]==y){end=false;snakleft.Add(0);
							snaktop.Add(24);}
					}
				}
				snakleft.Add(x);
				snaktop.Add(y);
				if(snakleft.Count>5){
					for(int a=snakleft.Count-5;a<snakleft.Count-1;a++){Console.SetCursorPosition(snakleft[a],snaktop[a]);
						Console.Write("O");}}
				else{
						for(int a=0;a<snakleft.Count-1;a++){Console.SetCursorPosition(snakleft[a],snaktop[a]);
							Console.Write("O");}}
				Console.SetCursorPosition(x,y);
				if(snakleft.Contains(0)||snakleft.Contains(44)){end=false;snakleft.Add(0);
					snaktop.Add(24);}
				else if(snaktop.Contains(0)||snaktop.Contains(23)){end=false;snakleft.Add(0);
					snaktop.Add(24);}
				if(snakleft.Count>len){
					Console.SetCursorPosition(snakleft[0],snaktop[0]);
					Console.Write(" ");
					snakleft.RemoveAt(0);snaktop.RemoveAt(0);
					Console.SetCursorPosition(snakleft[snakleft.Count-1],snaktop[snaktop.Count-1]);
				}

				if(ax==x&&ay==y){len++;
					while(true){
						bool endw=true;
					ax=rnd.Next(43)+1;
						ay=rnd.Next(22)+1;
						if(snakleft.Contains(ax)){
							for(int a=0;a<snakleft.Count;a++){
								if(snakleft[a]==ax&&snaktop[a]==ay){endw=false;break;}}}
						if(endw){break;}
					}
					Console.SetCursorPosition(ax,ay);Console.Write("X");
					Console.SetCursorPosition(x,y);Console.Title="Punteggio: "+(len-5).ToString();}
			}


			Console.Write("00 per tornare al menù o INVIO per continuare: ");
			string b = Console.ReadLine();
			if (b == "00") { Program.Main(); }
		}

		public static void snak()
		{
			while (true) { Console.Clear(); snak1(); }
		}
	}
}