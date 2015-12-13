using System;
using System.Collections.Generic;

namespace ita
{
	public static class New_Tiles
	{
		private static void prin(List<string> list, List<int> usable, List<int> allusable, int num,int actual)
		{
			Console.Clear();
			int old=0;
			bool ok=true;
			Console.Write(" ");
			for(int b=0;b<7;b++){
				for(int a=0;a<7;a++){
					if(old+a==num){Console.BackgroundColor=ConsoleColor.White;}
					if(usable.Contains(old+a)){Console.ForegroundColor=ConsoleColor.Green;Console.Write("XX");ok=false;}
					else if(allusable.Contains(old+a)){Console.ForegroundColor=ConsoleColor.Red;}
					if(old+a==actual){Console.ForegroundColor=ConsoleColor.Blue;}
					if(ok){
						Console.Write(list[old+a]);}
					ok=true;

					Console.ResetColor();
					if(a!=6){
						Console.Write(" | ");}
				}
				old+=7;if(b!=6){Console.Write("\n-----------------------------------\n ");}
			}

			Console.WriteLine("\n");
		}

		private static String where(int num)
		{
			if (num == 0){return "09,15";}
			else if (num == 1){return "10,14,16";}
			else if (num == 2){return "07,11,15,17";}
			else if (num == 3){return "08,12,16,18";}
			else if (num == 4){return "13,09,17,19";}
			else if (num == 5){return "10,18,20";}
			else if (num == 6){return "11,19";}
			else if (num == 7){return "02,16,22";}
			else if (num == 8){return "03,17,21,23";}
			else if (num == 9){return "00,04,14,18,22,24";}
			else if (num == 10){return "01,05,15,19,23,25";}
			else if (num == 11){return "02,06,16,20,24,26";}
			else if (num == 12){return "03,17,25,27";}
			else if (num == 13){return "04,18,26";}
			else if (num == 14){return "01,09,23,29";}
			else if (num == 15){return "00,02,10,24,28,30";}
			else if (num == 16){return "01,03,07,11,21,25,29,31";}
			else if (num == 17){return "02,04,08,12,22,26,30,32";}
			else if (num == 18){return "03,05,09,13,23,27,31,33";}
			else if (num == 19){return "04,06,10,24,32,34";}
			else if (num == 20){return "05,11,25,33";}
			else if (num == 21){return "08,16,30,36";}
			else if (num == 22){return "07,09,17,31,35,37";}
			else if (num == 23){return "08,10,14,18,28,32,36,38";}
			else if (num == 24){return "09,11,15,19,29,33,37,39";}
			else if (num == 25){return "10,12,16,20,30,34,38,40";}
			else if (num == 26){return "11,13,17,31,39,41";}
			else if (num == 27){return "12,18,32,40";}
			else if (num == 28){return "15,23,37,43";}
			else if (num == 29){return "14,16,24,38,42,44";}
			else if (num == 30){return "15,17,21,25,35,39,43,45";}
			else if (num == 31){return "16,18,22,26,36,40,44,46";}
			else if (num == 32){return "17,19,23,27,37,41,45,47";}
			else if (num == 33){return "18,20,24,38,46,48";}
			else if (num == 34){return "19,25,39,47";}
			else if (num == 35){return "22,30,44";}
			else if (num == 36){return "21,23,31,45";}
			else if (num == 37){return "22,24,28,32,42,46";}
			else if (num == 38){return "23,25,29,33,43,47";}
			else if (num == 39){return "24,26,30,34,44,48";}
			else if (num == 40){return "25,27,31,45";}
			else if (num == 41){return "26,32,46";}
			else if (num == 42){return "29,37";}
			else if (num == 43){return "28,30,38";}
			else if (num == 44){return "29,31,35,39";}
			else if (num == 45){return "30,32,36,40";}
			else if (num == 46){return "31,33,37,41";}
			else if (num == 47){return "32,34,38";}
			else if (num == 48){return "33,39";}
			else{return "";}
		}


		private static List<int> where1(int num){
			List<int> str = new List<int>();

			str.Add(num-15);
			str.Add(num-13);
			str.Add(num-9);
			str.Add(num-5);
			str.Add(num+5);
			str.Add(num+9);
			str.Add(num+13);
			str.Add(num+15);

			for(int a=0;a<8;a++){
				if(str[a]<0){str[a]=-1;}
				else if(str[a]>48){str[a]=-1;}
			}
			if((str[0]+1)%7==0){str[0]=-1;}
			if((str[1])%7==0){str[1]=-1;}
			if((str[2]+1)%7==0||(str[2]+2)%7==0){str[2]=-1;}
			if((str[3])%7==0||(str[3]-1)%7==0){str[3]=-1;}
			if((str[4]+1)%7==0||(str[4]+2)%7==0){str[4]=-1;}
			if((str[5])%7==0||(str[5]-1)%7==0){str[5]=-1;}
			if((str[6]+1)%7==0){str[6]=-1;}
			if((str[7])%7==0){str[7]=-1;}
			return str;
		}


		public static void  tile1()
		{
			List<string> str = new List<string>();
			ConsoleKeyInfo cki=new ConsoleKeyInfo();
			for (int a = 0; a < 49; a++)
			{
				str.Add("  ");
			}
			Random rnd = new Random();
			int ac= rnd.Next(49);
			int nn = 1;

			str[ac] = "01";
			int oldac=ac;
			List<int> usable = new List<int>();
			List<int> allusable = new List<int>();

			while (true)
			{
				nn++;
				usable.Clear();
				allusable.Clear();
				allusable=where1(ac);
				for (int a = 0; a < 8; a++)
				{
					if (allusable[a]!=-1 && str[allusable[a]] == "  ") { usable.Add(allusable[a]); }
				}
				if(usable.Count==0){break;}
				ac=usable[0];
				while(true){
				prin(str, usable, allusable, ac,oldac);
					cki=Console.ReadKey();
					try{
						if(cki.Key==ConsoleKey.UpArrow){
							if(ac==allusable[2]&&allusable[0]!=-1){ac=allusable[0];}
							else if(ac==allusable[3]&&allusable[1]!=-1){ac=allusable[1];}
							else if(ac==allusable[4]&&allusable[2]!=-1){ac=allusable[2];}
							else if(ac==allusable[5]&&allusable[3]!=-1){ac=allusable[3];}
							else if(ac==allusable[6]&&allusable[4]!=-1){ac=allusable[4];}
							else if(ac==allusable[7]&&allusable[5]!=-1){ac=allusable[5];}
						}
						else if(cki.Key==ConsoleKey.DownArrow){
							if(ac==allusable[0]&&allusable[2]!=-1){ac=allusable[2];}
							else if(ac==allusable[1]&&allusable[3]!=-1){ac=allusable[3];}
							else if(ac==allusable[2]&&allusable[4]!=-1){ac=allusable[4];}
							else if(ac==allusable[3]&&allusable[5]!=-1){ac=allusable[5];}
							else if(ac==allusable[4]&&allusable[6]!=-1){ac=allusable[6];}
							else if(ac==allusable[5]&&allusable[7]!=-1){ac=allusable[7];}
						}
						else if(cki.Key==ConsoleKey.RightArrow){
							if(ac==allusable[0]&&allusable[1]!=-1){ac=allusable[1];}
							else if(ac==allusable[1]&&allusable[3]!=-1){ac=allusable[3];}
							else if(ac==allusable[2]&&allusable[0]!=-1){ac=allusable[0];}
							else if(ac==allusable[4]&&allusable[6]!=-1){ac=allusable[6];}
							else if(ac==allusable[6]&&allusable[7]!=-1){ac=allusable[7];}
							else if(ac==allusable[7]&&allusable[5]!=-1){ac=allusable[5];}
						}
						else if(cki.Key==ConsoleKey.LeftArrow){
							if(ac==allusable[0]&&allusable[2]!=-1){ac=allusable[2];}
							else if(ac==allusable[1]&&allusable[0]!=-1){ac=allusable[0];}
							else if(ac==allusable[3]&&allusable[1]!=-1){ac=allusable[1];}
							else if(ac==allusable[5]&&allusable[7]!=-1){ac=allusable[7];}
							else if(ac==allusable[6]&&allusable[4]!=-1){ac=allusable[4];}
							else if(ac==allusable[7]&&allusable[6]!=-1){ac=allusable[6];}
						}
					else if(cki.Key==ConsoleKey.Enter && usable.Contains(ac)){break;}
					}catch(ArgumentOutOfRangeException){}}
				oldac=ac;
				str[ac] = nn < 10 ? "0" + nn.ToString() : nn.ToString();
			}
			prin(str, usable, allusable, -1,-1);
			if (str.Contains("  "))
			{
				Console.WriteLine("Hai perso dopo {0} mosse", nn-1);
			}
			else { Console.WriteLine("Hai vinto."); }

			Console.Write("00 per tornare al menù o INVIO per continuare: ");
			string b = Console.ReadLine();
			if (b == "00") { Program.Main(); }
		}

		public static void tile()
		{
			while (true) { Console.Clear(); tile1(); }
		}
	}
}