using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace ita
{
	public static class New_Memory
	{
		

		private static void prinscheme(int b, int h, List<string> user,int where,int num1,int num2,bool success,bool finish)
		{
			Console.Clear();
			int old=0;
			for(int c=0;c<h;c++){
				for(int a=0;a<b;a++){
					if(a+old==where){
						Console.BackgroundColor=ConsoleColor.White;}
					if(finish){Console.ForegroundColor=ConsoleColor.White;}
					else if(old+a==num1&&num2==-1){Console.ForegroundColor=ConsoleColor.Cyan;}
					else if(num2!=-1){
						if(success){
							if(old+a==num1){Console.ForegroundColor=ConsoleColor.Green;}
							if(old+a==num2){Console.ForegroundColor=ConsoleColor.Green;}
						}
						else{
							if(old+a==num1){Console.ForegroundColor=ConsoleColor.Red;}
							if(old+a==num2){Console.ForegroundColor=ConsoleColor.Red;}
						}
					}
					else if(a+old==where){Console.ForegroundColor=ConsoleColor.Black;}
					else if(a+old!=num1&&a+old!=num2&&user[a+old]!="X"){Console.ForegroundColor=ConsoleColor.DarkYellow;}
					Console.Write(user[a+old]);
					Console.ResetColor();
					Console.Write(" ");
				}
				Console.WriteLine();
				old+=b;
			}
			Console.WriteLine();
		}

		public static void mem1()
		{
			int mem1 = 1, mem2 = 1;
			while (mem1 * mem2 % 2 == 1 || mem1 * mem2 < 3)
			{
				while (true)
				{
					try
					{
						Console.Write("Inserisci base [1:13]: ");
						mem1 = int.Parse(Console.ReadLine());
						if (mem1 > 0 && mem1 < 14)
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
						int k = 182 / mem1;
						bool h = false;
						if (mem1 % 2 == 1 && k % 2 == 1) { Console.Write("Inserisci altezza [1:{0}]: ", k - 1); h = true; }
						else
						{
							Console.Write("Inserisci altezza [1:{0}]: ", k);
						}
						mem2 = int.Parse(Console.ReadLine());
						if (h) { k--; }
						if (mem2 > 0 && mem2 <= k)
						{
							break;
						}
					}
					catch (Exception)
					{
					}
				}
				if (mem1 * mem2 % 2 == 1 || mem1 * mem2 < 3)
				{
					Console.WriteLine("Almeno uno dei 2 numeri deve essere pari.");
					Console.ReadLine();
					Console.Clear();
				}
			}

			/*Console.OutputEncoding = System.Text.Encoding.Unicode;
			Console.Write("\u00AE");
			Console.Write("\u20A4");
			Console.Write("\u2640");
			Console.Write("\u2642");
			Console.Write("\u263A");
			Console.ReadLine();*/
			String[] let ={"a","b","c","d","e","f","g",
				"h","i","j","k","l","m","n","o",
				"p","q","r","s","t","u","v","w",
				'"'.ToString(),"y","z","A","B","C","D","E",
				"F","G","H","I","J","K","L","M",
				"N","O","P","Q","R","S","T","U",
				"V","W","Y","Z","1","2","3","à",
				"4","5","6","7","8","9","0","/",
				"*","-","+","!","£","$","%","&",
				"(",")","=","?","'","^","[","]",
				"{","}","#",".","~","@","\\","°",
				"§","_",":",";"};
			Random rnd = new Random();
			for(int a=0;a<200;a++){int k=rnd.Next(9889768);}
			List<String> user = new List<String>();
			for (int a = 0; a < ((mem1 * mem2)/2); a++)
			{
				int k =rnd.Next(let.Length);
				for(int h=0;h<2;h++){
					user.Add(let[k]);
				}
			}
			List<String> scheme = new List<String>();
			while (user.Count != 0)
			{
				int k = rnd.Next(user.Count ^ 3);
				try
				{
					scheme.Add(user[k]);
					user.Remove(user[k]);
				}
				catch (Exception)
				{
				}
			}
			for (int a = 0; a < ((mem1 * mem2)); a++)
			{
				user.Add("X");
			}
			int moves = 0;
			int where=0, where1;
			ConsoleKeyInfo cki=new ConsoleKeyInfo();
			while (user.Contains("X"))
			{
				while(true){
					prinscheme(mem1, mem2, user,where,-1,-1,false,false);
				Thread.Sleep(1);
				cki=Console.ReadKey();
				if(cki.Key==ConsoleKey.UpArrow){if(where-mem1>=0){where-=mem1;}}
				else if(cki.Key==ConsoleKey.DownArrow){if(where+mem1<mem1*mem2){where+=mem1;}}
				else if(cki.Key==ConsoleKey.LeftArrow){if(where-1>=0){where--;}}
				else if(cki.Key==ConsoleKey.RightArrow){if(where+1<mem1*mem2){where++;}}
					else if(cki.Key==ConsoleKey.Enter){if(user[where]=="X"){break;}}
				}
				user[where] = scheme[where];
				where1=where;
				while(true){
					prinscheme(mem1, mem2, user,where1,where,-1,false,false);
					Thread.Sleep(1);
					cki=Console.ReadKey();
					if(cki.Key==ConsoleKey.UpArrow){if(where1-mem1>=0){where1-=mem1;}}
					else if(cki.Key==ConsoleKey.DownArrow){if(where1+mem1<mem1*mem2){where1+=mem1;}}
					else if(cki.Key==ConsoleKey.LeftArrow){if(where1-1>=0){where1--;}}
					else if(cki.Key==ConsoleKey.RightArrow){if(where1+1<mem1*mem2){where1++;}}
					else if(cki.Key==ConsoleKey.Enter){if(user[where1]=="X"){break;}}
				}
					
				user[where1] = scheme[where1];
				bool f = scheme[where] == scheme[where1];
				prinscheme(mem1, mem2, user,-1,where,where1,f,false);
				if (!f)
				{
					Console.WriteLine("Hai sbagliato.");
					user[where] = "X";
					user[where1] = "X";
				}
				else
				{
					Console.WriteLine("Hai trovato una coppia.");
				}
				Console.ReadLine();
					where=where1;
				moves++;
			}
			Console.Clear();
			prinscheme(mem1, mem2, user,-1,-1,-1,false,true);
			Console.WriteLine("Hai vinto dopo {0} mosse\n\n", moves);

			Console.Write("00 per tornare al menù o INVIO per continuare: ");
			string b = Console.ReadLine();
			if (b == "00") { Program.Main(); }
		}

		public static void mem()
		{
			while (true) { Console.Clear(); mem1(); }
		}
	}
}