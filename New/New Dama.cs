using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ita
{
	public static class New_Dama
	{
		private static int whereUpRight(int a)
		{
			switch (a)
			{
			case 4: return 1;
			case 5: return 2;
			case 6: return 3;
			case 8: return 4;
			case 9: return 5;
			case 10: return 6;
			case 11: return 7;
			case 12: return 9;
			case 13: return 10;
			case 14: return 11;
			case 16: return 12;
			case 17: return 13;
			case 18: return 14;
			case 19: return 15;
			case 20: return 17;
			case 21: return 18;
			case 22: return 19;
			case 24: return 20;
			case 25: return 21;
			case 26: return 22;
			case 27: return 23;
			case 28: return 25;
			case 29: return 26;
			case 30: return 27;
			default: return 99;
			}
		}
		private static int whereUpLeft(int a)
		{
			switch (a)
			{
			case 4: return 0;
			case 5: return 1;
			case 6: return 2;
			case 7: return 3;
			case 9: return 4;
			case 10: return 5;
			case 11: return 6;
			case 12: return 8;
			case 13: return 9;
			case 14: return 10;
			case 15: return 11;
			case 17: return 12;
			case 18: return 13;
			case 19: return 14;
			case 20: return 16;
			case 21: return 17;
			case 22: return 18;
			case 23: return 19;
			case 25: return 20;
			case 26: return 21;
			case 27: return 22;
			case 28: return 24;
			case 29: return 25;
			case 30: return 26;
			case 31: return 27;
			default: return 99;
			}
		}
		private static int whereDownRight(int a)
		{
			switch (a)
			{
			case 0: return 4;
			case 1: return 5;
			case 2: return 6;
			case 3: return 7;
			case 4: return 9;
			case 5: return 10;
			case 6: return 11;
			case 8: return 12;
			case 9: return 13;
			case 10: return 14;
			case 11: return 15;
			case 12: return 17;
			case 13: return 18;
			case 14: return 19;
			case 16: return 20;
			case 17: return 21;
			case 18: return 22;
			case 19: return 23;
			case 20: return 25;
			case 21: return 26;
			case 22: return 27;
			case 24: return 28;
			case 25: return 29;
			case 26: return 30;
			case 27: return 31;
			default: return 99;
			}
		}
		private static int whereDownLeft(int a)
		{
			switch (a)
			{
			case 1: return 4;
			case 2: return 5;
			case 3: return 6;
			case 4: return 8;
			case 5: return 9;
			case 6: return 10;
			case 7: return 11;
			case 9: return 12;
			case 10: return 13;
			case 11: return 14;
			case 12: return 16;
			case 13: return 17;
			case 14: return 18;
			case 15: return 19;
			case 17: return 20;
			case 18: return 21;
			case 19: return 22;
			case 20: return 24;
			case 21: return 25;
			case 22: return 26;
			case 23: return 27;
			case 25: return 28;
			case 26: return 29;
			case 27: return 30;
			default: return 99;
			}
		}
		private static void prin(List<string> list,int where,List<int> eat,List<int> eaten,bool turn)
		{
			Console.Clear();
			int olda=0;
			Console.WriteLine("┌--┬--┬--┬--┬--┬--┬--┬--┐");
			for(int b=0;b<8;b++){
				for(int a=0;a<4;a++){
					if(b%2==0){
						Console.Write("|");

						#region Color
						if (olda + a == where) {
							Console.ForegroundColor = ConsoleColor.Black;
							Console.BackgroundColor = ConsoleColor.White;
						}
						if (turn) {
							if (eat.Contains (olda + a)) {
								Console.ForegroundColor = ConsoleColor.Black;
								Console.BackgroundColor = ConsoleColor.Green;	
								if (eaten [eat.IndexOf (olda + a)] != -1) {
									Console.ForegroundColor = ConsoleColor.Black;
									Console.BackgroundColor = ConsoleColor.Cyan;
								}
							}
							if (eaten.Contains (olda + a)) {
								Console.ForegroundColor = ConsoleColor.Black;
								Console.BackgroundColor = ConsoleColor.Red;
							}

						} else {
							if (eat.Contains (olda + a)) {
								Console.ForegroundColor = ConsoleColor.Black;
								Console.BackgroundColor = ConsoleColor.Gray;	
								if (eaten [eat.IndexOf (olda + a)] != -1) {
									Console.ForegroundColor = ConsoleColor.Black;
									Console.BackgroundColor = ConsoleColor.DarkGray;
								}
							}
							if (eaten.Contains (olda + a)) {
								Console.ForegroundColor = ConsoleColor.Black;
								Console.BackgroundColor = ConsoleColor.DarkYellow;
							}
						}
						#endregion

						Console.Write(	list[a+olda]);
						Console.ResetColor();
						Console.Write("|  ");}
					else{Console.Write("|  |");
						#region Color
						if (olda + a == where) {
							Console.ForegroundColor = ConsoleColor.Black;
							Console.BackgroundColor = ConsoleColor.White;
						}
						if (turn) {
							if (eat.Contains (olda + a)) {
								Console.ForegroundColor = ConsoleColor.Black;
								Console.BackgroundColor = ConsoleColor.Green;	
								if (eaten [eat.IndexOf (olda + a)] != -1) {
									Console.ForegroundColor = ConsoleColor.Black;
									Console.BackgroundColor = ConsoleColor.Cyan;
								}
							}
							if (eaten.Contains (olda + a)) {
								Console.ForegroundColor = ConsoleColor.Black;
								Console.BackgroundColor = ConsoleColor.Red;
							}

						} else {
							if (eat.Contains (olda + a)) {
								Console.ForegroundColor = ConsoleColor.Black;
								Console.BackgroundColor = ConsoleColor.Gray;	
								if (eaten [eat.IndexOf (olda + a)] != -1) {
									Console.ForegroundColor = ConsoleColor.Black;
									Console.BackgroundColor = ConsoleColor.DarkGray;
								}
							}
							if (eaten.Contains (olda + a)) {
								Console.ForegroundColor = ConsoleColor.Black;
								Console.BackgroundColor = ConsoleColor.DarkYellow;
							}
						}
						#endregion
						Console.Write(list[a+olda]);}
					Console.ResetColor();
				}
				olda+=4;
				if(b!=7){
					Console.WriteLine("|\n├--┼--┼--┼--┼--┼--┼--┼--┤");}
			}
			Console.WriteLine("|\n└--┴--┴--┴--┴--┴--┴--┴--┘");

		}
		private static void prin2(List<string> list,int where,List<int> eaten,int pos)
		{
			Console.Clear();
			int olda=0;
			Console.WriteLine("┌--┬--┬--┬--┬--┬--┬--┬--┐");
			for(int b=0;b<8;b++){
				for(int a=0;a<4;a++){
					if(b%2==0){
						Console.Write("|");

						if(olda+a==eaten[pos]){
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.BackgroundColor = ConsoleColor.Red;
						}

						if (olda + a == where) {
							Console.ForegroundColor = ConsoleColor.Black;
							Console.BackgroundColor = ConsoleColor.White;
						}


						Console.Write(	list[a+olda]);
						Console.ResetColor();
						Console.Write("|  ");}
					else{Console.Write("|  |");

						if(olda+a==eaten[pos]){
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.BackgroundColor = ConsoleColor.Red;
						}

						if (olda + a == where) {
							Console.ForegroundColor = ConsoleColor.Black;
							Console.BackgroundColor = ConsoleColor.White;
						}

						Console.Write(list[a+olda]);}
					Console.ResetColor();
				}
				olda+=4;
				if(b!=7){
					Console.WriteLine("|\n├--┼--┼--┼--┼--┼--┼--┼--┤");}
			}
			Console.WriteLine("|\n└--┴--┴--┴--┴--┴--┴--┴--┘");

		}
		private static List<string> turn(bool turn,List<string>list){
			string norm,dama,nnorm,ndama;
			int where=0;
			List<int> eat=new List<int>();
			List<int> eaten=new List<int>();
			if(turn){norm="O ";dama="OO";nnorm="X ";ndama="XX";}     
			else{norm="X ";dama="XX";nnorm="O ";ndama="OO";}
			for(int a=0;a<32;a++){if(list[a]==norm||list[a]==dama){where=a;break;}}

			ConsoleKeyInfo cki=new ConsoleKeyInfo();
			while(true){
				bool check=false;
				if(list[where]==norm||list[where]==dama){check=true;}
				eaten.Clear();
				eat.Clear();
				for(int a=0;a<4;a++){eaten.Add(-1);}
				string x=list[where];
				eat.Add(whereUpLeft(where));
				eat.Add(whereUpRight(where));
				eat.Add(whereDownLeft(where));
				eat.Add(whereDownRight(where));
				if(x=="  "){eat[0]=eat[1]=eat[2]=eat[3]=99;}
				if(x=="O "){eat[0]=eat[1]=99;}
				if(x=="X "){eat[2]=eat[3]=99;}
				for(int a=0;a<4;a++){
					int o=eat[a];
					if(o!=99){
						if(list[where]==list[o]){eat[a]=99;}

						if(list[where]==norm||list[where]==dama){
							if(list[o]==norm||list[o]==dama){eat[a]=99;}
						}
						else if(list[where]==nnorm||list[where]==ndama){
							if(list[o]==nnorm||list[o]==ndama){eat[a]=99;}
						}

						if(list[o]=="  "){}
						else
						{

							if(list[where]==norm||list[where]==dama){
								if(list[o]==nnorm||list[o]==ndama){
									if(a==0){try{if(list[whereUpLeft(o)]=="  "){eaten[0]=o;eat[0]=whereUpLeft(o);}else{eat[a]=99;}}catch(ArgumentOutOfRangeException){}}
									else if(a==1){try{if(list[whereUpRight(o)]=="  "){eaten[1]=o;eat[1]=whereUpRight(o);}else{eat[a]=99;}}catch(ArgumentOutOfRangeException){}}
									else if(a==2){try{if(list[whereDownLeft(o)]=="  "){eaten[2]=o;eat[2]=whereDownLeft(o);}else{eat[a]=99;}}catch(ArgumentOutOfRangeException){}}
									else if(a==3){try{if(list[whereDownRight(o)]=="  "){eaten[3]=o;eat[3]=whereDownRight(o);}else{eat[a]=99;}}catch(ArgumentOutOfRangeException){}}
								}
							}

							if(list[where]==nnorm||list[where]==ndama){
								if(list[o]==norm||list[o]==dama){
									if(a==0){try{if(list[whereUpLeft(o)]=="  "){eaten[0]=o;eat[0]=whereUpLeft(o);}else{eat[a]=99;}}catch(ArgumentOutOfRangeException){}}
									else if(a==1){try{if(list[whereUpRight(o)]=="  "){eaten[1]=o;eat[1]=whereUpRight(o);}else{eat[a]=99;}}catch(ArgumentOutOfRangeException){}}
									else if(a==2){try{if(list[whereDownLeft(o)]=="  "){eaten[2]=o;eat[2]=whereDownLeft(o);}else{eat[a]=99;}}catch(ArgumentOutOfRangeException){}}
									else if(a==3){try{if(list[whereDownRight(o)]=="  "){eaten[3]=o;eat[3]=whereDownRight(o);}else{eat[a]=99;}}catch(ArgumentOutOfRangeException){}}
								}
							}
							}
					}
				}
			
				prin(list,where,eat,eaten,check);
				cki=Console.ReadKey();
				if(cki.Key==ConsoleKey.UpArrow){
					if(where-4>=0){where-=4;}
				}
				else if(cki.Key==ConsoleKey.DownArrow){
					if(where+4<32){where+=4;}
				}
				else if(cki.Key==ConsoleKey.LeftArrow){
					if(where-1>=0){where--;}
				}
				else if(cki.Key==ConsoleKey.RightArrow){
					if(where+1<32){where++;}
				}
				else if(cki.Key==ConsoleKey.Enter){
					if(list[where]==dama||list[where]==norm){
						bool k=false;
						for(int a=0;a<4;a++){if(eat[a]!=99){k=true;}}
						if(k){break;}
						}
				}

			}
			int pos=0;
			for(int a=0;a<4;a++){if(eat[a]!=99){pos=a;break;}}
			while(true){
				prin2(list,eat[pos],eaten,pos);
				cki=Console.ReadKey();
				if(cki.Key==ConsoleKey.UpArrow){
					if(pos==2&&eat[0]!=99){pos=0;}
					if(pos==3&&eat[1]!=99){pos=1;}
				}
				else if(cki.Key==ConsoleKey.DownArrow){
					if(pos==0&&eat[2]!=99){pos=2;}
					if(pos==1&&eat[3]!=99){pos=3;}
				}
				else if(cki.Key==ConsoleKey.LeftArrow){
					if(pos==1&&eat[0]!=99){pos=0;}
					if(pos==3&&eat[2]!=99){pos=2;}
				}
				else if(cki.Key==ConsoleKey.RightArrow){
					if(pos==0&&eat[1]!=99){pos=1;}
					if(pos==2&&eat[3]!=99){pos=3;}
				}
				else if(cki.Key==ConsoleKey.Enter){
					list[eat[pos]]=list[where];list[where]="  ";
					if(eaten[pos]!=-1){list[eaten[pos]]="  ";}
					break;
				}

			}



			return list;
		}
		public static void dam1(){
			int final=0;
			int tu=0;
			List<string> list=new List<string>();
			for(int a=0;a<32;a++){
				if (a < 12) { list.Add("O "); }
				else if (a < 20) { list.Add("  "); }
				else { list.Add("X "); }
			}
			while(true){
			list=turn(false,list);
				for(int a=0;a<4;a++){
					if(list[a]=="X "){list[a]="XX";}
				}
				bool win=true;
				for(int a=0;a<32;a++){
					if(list[a]=="O "||list[a]=="OO"){win=false;}
				}
				if(win){final=1;break;}
			list=turn(true,list);
				for(int a=28;a<32;a++){
					if(list[a]=="O "){list[a]="OO";}
				}
				bool win2=true;
				for(int a=0;a<32;a++){
					if(list[a]=="X "||list[a]=="XX"){win=false;}
				}
				if(win2){final=2;break;}
				if(tu==30){final=0;break;}
				tu++;
			}
			Console.Clear();
			if(final==0){Console.WriteLine("30 mosse.\nI 2 giocatori hanno pareggiato.");}
			if(final==1){Console.WriteLine("Il giocatore X ha vinto.");}
			if(final==2){Console.WriteLine("Il giocatore O ha vinto.");}
			Console.Write("00 per tornare al menù o INVIO per continuare: ");
			string b = Console.ReadLine();
			if (b == "00") { Program.Main(); }

		}

		public static void dam()
		{
			while (true) { Console.Clear(); dam1(); }
		}
	}
}