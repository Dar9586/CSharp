using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ita
{
	public static class Simon
	{
		private static List<ConsoleColor>col=new List<ConsoleColor>{ConsoleColor.DarkBlue,ConsoleColor.DarkYellow,ConsoleColor.DarkRed,ConsoleColor.DarkGreen};
		private static void prinseq(List<int>list){
			List<ConsoleColor>col1=new List<ConsoleColor>();
			for(int a=0;a<list.Count;a++){
				col1.Clear();
				col1.AddRange(col);
				Thread.Sleep(300);
				if(list[a]==0){col1[0]=ConsoleColor.Blue;}
				if(list[a]==1){col1[1]=ConsoleColor.Yellow;}
				if(list[a]==2){col1[2]=ConsoleColor.Red;}
				if(list[a]==3){col1[3]=ConsoleColor.Green;}
				prin(col1);
				Thread.Sleep(300);
				prin(col);
			}

		}
		private static void prin(List<ConsoleColor>col){
			Console.SetCursorPosition(0,0);
			for(int a=0;a<5;a++){Console.BackgroundColor=col[0];Console.WriteLine("        ");Console.ResetColor();}
			Console.WriteLine("\n");
			for(int a=0;a<5;a++){Console.BackgroundColor=col[2];Console.WriteLine("        ");Console.ResetColor();}

			for(int a=0;a<12;a++){
				if(a<5){Console.BackgroundColor=col[1];}
				else if(a<7){Console.ResetColor();}
				else{Console.BackgroundColor=col[3];}
			Console.SetCursorPosition(10,a);
				Console.Write("        ");
			}
			Console.ResetColor();
			Console.WriteLine("\n\n");
			}


		public static void simo1()
		{
			ConsoleKeyInfo cki=new ConsoleKeyInfo();

			Console.Title="Punteggio: 0";
			prin(col);
			while(!Console.KeyAvailable){Thread.Sleep(5);}
			Thread.Sleep(300);
			int pos=0;
			Random rnd=new Random();
			for(int a=0;a<500;a++){rnd.Next(9846684);}
			List<int>seq=new List<int>();
			List<int>user=new List<int>();
			bool end=true;
			while(end){
				pos=0;
				int ac=0;
				user.Clear();
				for(int a=0;a<rnd.Next(rnd.Next(6544))+500;a++){rnd.Next(9846684);}
				seq.Add(rnd.Next(4));
				Console.Title="Punteggio: "+(seq.Count-1).ToString();
				prin(col);
				Thread.Sleep(300);
				prinseq(seq);
				Thread.Sleep(300);
				Console.ReadKey();

				while(ac<seq.Count){
					
					List<ConsoleColor>col1=new List<ConsoleColor>(col);
					if(pos==0){col1[0]=ConsoleColor.Blue;}
					if(pos==1){col1[1]=ConsoleColor.Yellow;}
					if(pos==2){col1[2]=ConsoleColor.Red;}
					if(pos==3){col1[3]=ConsoleColor.Green;}
					prin(col1);
					cki=Console.ReadKey();
					if(cki.Key==ConsoleKey.UpArrow){if(pos==2){pos=0;}else if(pos==3){pos=1;}}
					else if(cki.Key==ConsoleKey.DownArrow){if(pos==0){pos=2;}else if(pos==1){pos=3;}}
					else if(cki.Key==ConsoleKey.RightArrow){if(pos==0){pos=1;}else if(pos==2){pos=3;}}
					else if(cki.Key==ConsoleKey.LeftArrow){if(pos==1){pos=0;}else if(pos==3){pos=2;}}
					else if(cki.Key==ConsoleKey.Enter){
						if(seq[ac]==pos){ac++;}else{end=false;break;}
					}
				}
			}
			Console.WriteLine("Hai sbagliato.");
			Console.Write("00 per tornare al menù o INVIO per continuare: ");
			string b = Console.ReadLine();
			if (b == "00") { Program.Main(); }
		}

		public static void simo()
		{
			while (true) { Console.Clear(); simo1(); }
		}
	}
}