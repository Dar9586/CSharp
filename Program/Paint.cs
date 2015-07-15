using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ita
{
	public static class Paint
	{
		
		private static void subprint(List<ConsoleColor> list,int hei){
			Console.SetCursorPosition(0,hei);
			Console.BackgroundColor=ConsoleColor.Black;Console.Write(" ");
			for(int a=0;a<list.Count;a++){
				Console.BackgroundColor=list[a];
				Console.Write(" ");
			}
			Console.ResetColor();
		}
		private static int select(List<ConsoleColor> li,bool l){
			Console.Clear();
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




		private static void prin(List<ConsoleColor> list,int b,int h){
			Console.Clear();
			Console.WriteLine();
			int old=0;
			for (int c = 0; c < h; c++) {
				Console.Write(" ");
				for (int a = 0; a < b; a++) {
					Console.BackgroundColor = list[old+a];
					Console.Write(" ");
				}
				old=old+b;
				Console.ResetColor ();
				Console.WriteLine ();
			}

		} 

		private static int ww=Console.WindowWidth;
		private static int wh=Console.WindowHeight;

		public static void pain1()
		{
			
			Console.SetWindowSize(ww,wh);
			Console.SetBufferSize(ww,300);
			int hei=Console.LargestWindowHeight;
			int wid=Console.LargestWindowWidth;
			ConsoleColor s=new ConsoleColor();
			List<int> undotop = new List<int> ();
			List<int> undoleft = new List<int> ();
			List<ConsoleColor> undocol = new List<ConsoleColor> ();
			int j = 2;bool h1;
			List<ConsoleColor> list = new List<ConsoleColor> ();
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
			int b,h;b=h=1;
			String line="";
			bool open=true;
			string o="";
			while(o!="S"&&o!="N"){
				Console.Clear();
				Console.Write("Aprire un file [S/N]: ");
				o=Console.ReadLine();
				o=o.ToUpper();
			}
			string ssss="";
			if(o=="S"){
				ssss=Utility.getFile(".pcs");
				open=true;
			}
			else{open=false;}
			if (open) {try{
				try{
					using (StreamReader sr = new StreamReader(ssss)){
						line = sr.ReadToEnd();}
				}catch (Exception){}
				int k=0;
				while(true){
					try{int.Parse(line.ToCharArray()[k].ToString());k++;}catch(Exception){break;}
				}
				b=int.Parse(line.Substring(0,k));
				int oldk=k+1;
				k=0;
				while(true){
					try{int.Parse(line.ToCharArray()[oldk+k].ToString());k++;}catch(Exception){break;}
				}
				h=int.Parse(line.Substring(oldk,k));
				k = oldk + k + 1;
				line = line.Substring (k);
				string[] p = new string[b * h];
				p = line.Split (',');
				if (p.Length == b * h) {
					for (int a = 0; a < p.Length; a++) {
						list.Add (li [int.Parse (p [a])]);
					}
				} else {
						int l = 0;int ji = 6 / l;}}catch(Exception){
					Console.WriteLine ("Impossibile utilizzare il savataggio.");Console.ReadLine ();Console.Clear ();
					open = false;}
			}
			if(!open){
			while (true)
			{
				try
				{
					Console.Write("Inserisci lunghezza tela [5:{0}]: ",wid-4);
					b = int.Parse(Console.ReadLine());
					if (b > 4 && b < wid-3)
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
					Console.Write("Inserisci altezza tela [5:{0}]: ",hei-4);
					h = int.Parse(Console.ReadLine());
					if (h > 4 && h < hei-3)
					{
						break;
					}
				}
				catch (Exception)
				{
				}
				}
				Console.WriteLine ("Scegli il colore di sfondo:");
				j = select (li, false);
				h1=true;
				if(j!=17){s=li[j-1];}
				else{h1=false;}
				for (int a = 0; a < b * h; a++) {
					if (h1) {
						list.Add (s);
					} else {

						int l = rnd.Next (16);
						list.Add (li [l]);
					}
				}
			
			}
		



			Console.CursorSize=100;
			ConsoleKeyInfo cki = new ConsoleKeyInfo();
			if(h>Console.WindowHeight&&b>Console.WindowWidth){
				Console.SetWindowSize(b+2,h+2);}
			else if(h>Console.WindowHeight){
				Console.SetWindowSize(Console.WindowWidth,h+2);
			}
			else if(b>Console.WindowWidth){
				Console.SetWindowSize(b+2,Console.WindowHeight);
			}
			try{
				Console.SetBufferSize(Console.WindowWidth,Console.WindowHeight);}catch(ArgumentOutOfRangeException){
			}
			int j1=2;
			prin (list,b,h);
			subprint(list.GetRange(list.Count-b-1,b),h-1);
			int x,y;x=y=1;
			Console.SetCursorPosition(1,1);
			s=ConsoleColor.Black;
			bool ch=false;
			while(cki.Key!=ConsoleKey.X){
				if(j1!=17){
				Console.Title="X per finire, S per cambiare colore, Z per annullare.       "+li[j1-1];}else{
				Console.Title="X per finire, S per cambiare colore, Z per annullare.       Random";
				}
				cki=Console.ReadKey();
				try{
					ch=false;
				if(cki.Key==ConsoleKey.UpArrow){
						if(y>1){
							y--;}ch=true;
						
				}
				else if(cki.Key==ConsoleKey.DownArrow){
						if(y<h){
							y++;}ch=true;
				}
					else if(cki.Key==ConsoleKey.LeftArrow){
						if(x>1){
							x--;}ch=true;
							
				}
				else if(cki.Key==ConsoleKey.RightArrow){
						if(x<b){
							x++;}ch=true;
					}
				else if(cki.Key==ConsoleKey.S){
						int k=select(li,true);
						if(k!=0){j1=k;}
						prin (list,b,h);
				}
					else if(cki.Key==ConsoleKey.Enter){
						undocol.Add(list[y*b+x]);
						undotop.Add(y);
						undoleft.Add(x);
						if(j1!=17){
							
							list[(y-1)*b+(x-1)]=li[j1-1];
							subprint(list.GetRange(b*(y-1),b),y);

						}else{
							int r=rnd.Next(16);
							list[(y-1)*b+(x-1)]=li[r];
							subprint(list.GetRange(b*(y-1),b),y);
						}

					}
					else if(cki.Key==ConsoleKey.Z){
						int num2,num3;
						ConsoleColor num1=undocol[undocol.Count-1];
						num2=undotop[undotop.Count-1];
						num3=undoleft[undoleft.Count-1];
						list[(num2-1)*b+(num3-1)]=num1;

						subprint(list.GetRange(b*(num2-1),b),num2);
						undocol.RemoveAt(undocol.Count-1);
						undotop.RemoveAt(undotop.Count-1);
						undoleft.RemoveAt(undoleft.Count-1);

					}


				}catch(ArgumentOutOfRangeException){}
				if(ch){
					try{
				Console.SetCursorPosition(Console.CursorLeft-1,Console.CursorTop);
					Console.BackgroundColor=list[(Console.CursorTop-1)*b+(Console.CursorLeft-1)];Console.Write(" ");Console.ResetColor();
					}catch(ArgumentOutOfRangeException){}
				}

				Console.SetCursorPosition(x,y);
			} 

			prin (list,b,h);
			int o1=Console.CursorLeft;
			int o2=Console.CursorTop;
			string o3="";
			while(o3!="S"&&o3!="N"){
				Console.SetCursorPosition(o1,o2);
				Console.Write("                                                       ");
				Console.SetCursorPosition(o1,o2);
			Console.Write("Salvare i file [S/N]: ");
				o3=Console.ReadLine();
				o3=o3.ToUpper();
			}
			if(o3=="S"){
				Console.Clear();
				string path=Utility.createPath(".pcs");
				try{
						using (StreamWriter sw = File.AppendText(path))
						{
						sw.Write(b+"!"+h+"|");
						for(int a=0;a<list.Count;a++){
							sw.Write(li.IndexOf(list[a]));
							if(a+1<list.Count){sw.Write(",");}
							}
						sw.Close();
						}}catch(ArgumentException){}
				

				prin (list,b,h);
			}
			else if(o3=="N"){
				Console.SetCursorPosition(o1,o2);
				Console.Write("                                                       ");
				Console.SetCursorPosition(o1,o2);
			}
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