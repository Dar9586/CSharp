
using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ita
{
	public static class New_Password
	{
		private static string createPath(){
			
			string path=@"C:\";
			bool end=false;
			string[] st=new string[999];
				while(true){
				Console.Clear();
				while(true){

					st=Directory.GetDirectories(path);
					for(int a=0;a<st.Length;a++){
						string s="";
						s=(a+1).ToString();
							Console.WriteLine("{0}. {1}",s,st[a]);
						}
					Console.WriteLine("\nInserisci cartella dove andare \nInserire // per andare alla cartella dove si trova questo file\nInserire .. per tornare indietro di una cartella\noppure Inserisci il nome del file [Deve finire con .txt]:");
					string l=Console.ReadLine();
					Console.Clear();
					try{
						if(l.Substring(l.Length-4,4)==".txt"&&path!=@"C:\"){path=Path.Combine(path,l);end=true;break;}}catch(ArgumentOutOfRangeException){}catch(NullReferenceException){}
					try{
						if(l=="//"){path=Directory.GetCurrentDirectory();break;}}catch(ArgumentOutOfRangeException){}catch(NullReferenceException){}
					try{
						if(l==".."&&path!=@"C:"){
							int o=0;
							for(int a=path.Length-1;a>=0;a--){if(path.ToCharArray()[a].ToString()==@"\"){o=a;break;}}
							path=path.Substring(0,o);
							if(path=="C:"){path="C:\\";}
							break;}}catch(ArgumentOutOfRangeException){}catch(NullReferenceException){}
					try{
						int k=int.Parse(l);
						if(k>0&&k<st.Length){string[] st1=Directory.GetDirectories(st[k-1]);
							path=st[k-1];
							break;}
					}catch(UnauthorizedAccessException){Console.WriteLine("Impossibile Accedere alla cartella.");Console.ReadLine();break;}
					catch(FormatException){Console.WriteLine("Numero ,percorso o nome file non valido.");Console.ReadLine();break;}
					

				}
				if(end){break;}
			}


			return path;
		}


		private static void prin2(bool x,bool change,string s){
			if(change){Console.BackgroundColor=ConsoleColor.White;
				Console.ForegroundColor=ConsoleColor.Black;}
			if(s==""||s=="0"){s=" ";}
			if(x){Console.Write(s);}
			else{Console.Write("X");}
			Console.ResetColor();
		}
		private static void prin(int what,bool num,bool upp,bool low,bool spe,bool save,string use,string path,int len,int how){
			Console.Clear();
			Console.Write("Usare Numeri: ");
			prin2(num,what==0,"V");
			Console.Write("                       Caratteri Speciali: ");
			prin2(spe,what==1,"V");
			Console.Write("\n\nUsare Lettere Maiuscole: ");
			prin2(upp,what==2,"V");
			Console.Write("            Usare Lettere minuscole: ");
			prin2(low,what==3,"V");
			Console.Write("\n\nInserire Caratteri personali: ");
			prin2(true,what==4,use);
			Console.Write("\n\nInserisci Lunghezza: ");
			prin2(true,what==5,len.ToString());
			Console.Write("\n\nInserisci qunte password generare: ");
			prin2(true,what==6,how.ToString());
			Console.Write("\n\nSalvare I File: ");
			prin2(save,what==7,"V");
			if(save){
			Console.Write("\n\nInserisci Percorso: ");
				prin2(save,what==8,path);}
			Console.WriteLine("\n");
			if(what==9){
			Console.BackgroundColor=ConsoleColor.White;
				Console.ForegroundColor=ConsoleColor.Black;}
				Console.WriteLine("Fine");
			Console.ResetColor();

		}
		private static void met1()
		{
			Console.Clear();
			bool num, upp, low, spe, save;
			num=true;
			upp=low=spe=save=false;
			int what=0;
			int len=3, how=1;
			String nume = "0123456789";
			String uppe = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			String lowe = "abcdefghijklmnopqrstuvwxyz";
			String spec = "!#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~";
			string use="";
			string path = "";
			ConsoleKeyInfo cki = new ConsoleKeyInfo();

			while(true){
				prin(what,num,upp,low,spe,save,use,path,len,how);
				Thread.Sleep(1);
				cki = Console.ReadKey(true);
				if(cki.Key==ConsoleKey.UpArrow){
					if(save && what==9){what=8;}
					else if(!save && what==9){what=7;}
					else if(what==8){what=7;}
					else if(what==7){what=6;}
					else if(what==6){what=5;}
					else if(what==5){what=4;}
					else if(what==4){what=2;}
					else if(what==3){what=1;}
					else if(what==2){what=0;}
				}
				else if(cki.Key==ConsoleKey.DownArrow){
					if(save && what==7){what=8;}
					else if(!save && what==7){what=9;}
					else if(what==8){what=9;}
					else if(what==6){what=7;}
					else if(what==5){what=6;}
					else if(what==4){what=5;}
					else if(what==3){what=4;}
					else if(what==2){what=4;}
					else if(what==1){what=3;}
					else if(what==0){what=2;}
				}
				else if(cki.Key==ConsoleKey.RightArrow){
					if(what==0){what=1;}
					else if(what==2){what=3;}
				}
				else if(cki.Key==ConsoleKey.LeftArrow){
					if(what==1){what=0;}
					else if(what==3){what=2;}
				}
				if(cki.Key==ConsoleKey.Enter){
					if(what==0){if(num){if(upp||low||spe||use!=""){num=false;}}else{num=true;}}
					if(what==1){if(spe){if(upp||low||num||use!=""){spe=false;}}else{spe=true;}}
					if(what==2){if(upp){if(num||low||spe||use!=""){upp=false;}}else{upp=true;}}
					if(what==3){if(low){if(upp||num||spe||use!=""){low=false;}}else{low=true;}}
					if(what==4){
						ConsoleKeyInfo cki2 = new ConsoleKeyInfo();
						string st="";
						while(true){
							prin(what,num,upp,low,spe,save,st,path,len,how);
							Console.SetCursorPosition(30+st.Length,4);
							cki2=Console.ReadKey();
							if(cki2.Key==ConsoleKey.Enter){break;}
							st=st+cki2.KeyChar.ToString();
							if(st.Length>25){
								st=st.Substring(0,25);}
						}
						use=st;

						Console.ResetColor();}
					if(what==5){
						ConsoleKeyInfo cki2 = new ConsoleKeyInfo();
						string st="0";
						while(true){
							if(st.Length>0){
								prin(what,num,upp,low,spe,save,use,path,int.Parse(st),how);}
							else{prin(what,num,upp,low,spe,save,use,path,0,how);}
							Console.SetCursorPosition(20+st.Length,6);
							cki2=Console.ReadKey();
							if(cki2.Key==ConsoleKey.Enter){break;}
							if(cki2.Key==ConsoleKey.Backspace&&st.Length>0){st=st.Substring(0,st.Length-1);}
							try{
								int.Parse(cki2.KeyChar.ToString());
								st=st+cki2.KeyChar.ToString();}catch(Exception){}
							
							if(st.Length>3){
								st=st.Substring(0,3);}
						}
						if(st==""||st=="0"){st="3";}
						len=int.Parse(st);
					}
					if(what==6){
						

						ConsoleKeyInfo cki2 = new ConsoleKeyInfo();
						string st="0";
						while(true){
							if(st.Length>0){
								prin(what,num,upp,low,spe,save,use,path,len,int.Parse(st));}
							else{prin(what,num,upp,low,spe,save,use,path,len,0);}
							Console.SetCursorPosition(34+st.Length,8);
							cki2=Console.ReadKey();
							if(cki2.Key==ConsoleKey.Enter){break;}
							if(cki2.Key==ConsoleKey.Backspace&&st.Length>0){st=st.Substring(0,st.Length-1);}
							try{
								int.Parse(cki2.KeyChar.ToString());
								st=st+cki2.KeyChar.ToString();}catch(Exception){}

							if(st.Length>4){
								st=st.Substring(0,4);}
						}
						if(st==""||st=="0"){st="1";}
						how=int.Parse(st);
					}
					if(what==7){if(save){save=false;}else{save=true;}}
					if(what==8){
						path=createPath();

					}
					if(what==9){break;}
				}
			} 


			Console.Clear();
			StringBuilder str = new StringBuilder();
			Random rnd = new Random();
			for (int b = 0; b < how; b++)
			{
				str.Clear();
				while (str.Length < len)
				{
					int k = rnd.Next(5);
					if (k == 1 && num)
					{
						int k1 = rnd.Next(nume.Length);
						str.Append(nume.ToCharArray()[k1]);
					}
					else if (k == 2 && upp)
					{
						int k1 = rnd.Next(uppe.Length);
						str.Append(uppe.ToCharArray()[k1]);
					}
					else if (k == 3 && low)
					{
						int k1 = rnd.Next(lowe.Length);
						str.Append(lowe.ToCharArray()[k1]);
					}
					else if (k == 4 && spe)
					{
						int k1 = rnd.Next(spec.Length);
						str.Append(spec.ToCharArray()[k1]);
					}
					else if (k == 5 && use.Length != 0)
					{
						int k1 = rnd.Next(use.Length);
						str.Append(use.ToCharArray()[k1]);
					}
				}
				int l = how.ToString().Length;
				string s = "";
				for (int a = (b + 1).ToString().Length; a < l; a++)
				{
					s = s + "0";
				}
				s = s + (b + 1).ToString();
				Console.WriteLine(s + ". " + str.ToString());
				if (save)
				{try{
					using (StreamWriter sw = File.AppendText(path))
					{
						sw.WriteLine(s + ". " + str.ToString());
						sw.Close();
						}}catch(ArgumentException){}
				}
			}
		}

		private static void prin3(int what,string fina,bool save){
			Console.Clear();
			Console.Write("     ");
			prin2(true,what==0,"Numeri (n)");
			Console.Write("              ");
			prin2(true,what==1,"Caratteri Speciali (s)");
			Console.WriteLine("\n");
			prin2(true,what==2,"Lettere maiuscole (u)");
			Console.Write("        ");
			prin2(true,what==3,"Lettere minuscole (l)");
			Console.WriteLine("\n");
			prin2(true,what==4,"Caratteri personali (c)");
			Console.Write("        ");
			prin2(true,what==5,"Separatore (o)");
			Console.Write("\n\n  Salvare i file: ");
			prin2(save,what==6,"V");
			Console.Write("                 ");
			prin2(true,what==7,"Fine");
			Console.WriteLine("\n\n{0}\n\n",fina);
		}
		private static void prin4(bool save,bool use,bool sep,string save1,string use1,string sep1,int what,int how){
			Console.Clear();
			if(save){
				Console.WriteLine("Inserisci percorso:");
				prin2(true,what==0,save1);
				Console.WriteLine("\n");
			}
			if(use){
				Console.Write("Inserisci caratteri personali: ");
				prin2(true,what==1,use1);
				Console.WriteLine("\n");
			}
			if(sep){
				Console.Write("Inserisci separatore: ");
				prin2(true,what==2,sep1);
				Console.WriteLine("\n");
			}
			Console.Write("Inserisci quante password generare: ");
			prin2(true,what==3,how.ToString());
			Console.WriteLine("\n");
			prin2(true,what==4,"Fine");
			Console.WriteLine("\n\n");
		}

		private static void met2()
		{
			Console.Clear();
			List<string> numer = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
			List<int> listnum = new List<int> ();
			List<string> listchar = new List<string> ();

			String nume = "0123456789";
			String uppe = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			String lowe = "abcdefghijklmnopqrstuvwxyz";
			String spec = "!#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~";
			string use = "", sep = "-",path="";
			int what=0,cache=0;
			string fina="",cach="";
			bool num,upp,low,spe,us,se,first,save;
			num=upp=low=spe=us=se=first=save=false;
			ConsoleKeyInfo cki = new ConsoleKeyInfo();
			while(true){
				prin3(what,fina+cach,save);
				Thread.Sleep(1);
			cki = Console.ReadKey(true);
			if(cki.Key==ConsoleKey.UpArrow){
					if(what==2){what=0;}
					else if(what==3){what=1;}
					else if(what==4){what=2;}
					else if(what==5){what=3;}
					else if(what==6){what=4;}
					else if(what==7){what=5;}

			}
			if(cki.Key==ConsoleKey.DownArrow){
					if(what==0){what=2;}
					else if(what==1){what=3;}
					else if(what==2){what=4;}
					else if(what==3){what=5;}
					else if(what==4){what=6;}
					else if(what==5){what=7;}
			}
			if(cki.Key==ConsoleKey.RightArrow){
					if(what==0){what=1;}
					else if(what==2){what=3;}
					else if(what==4){what=5;}
					else if(what==6){what=7;}
			}
			if(cki.Key==ConsoleKey.LeftArrow){
					if(what==1){what=0;}
					else if(what==3){what=2;}
					else if(what==5){what=4;}
					else if(what==7){what=6;}
			}
			if(cki.Key==ConsoleKey.Enter){
					if(what==0){
						if(num){
							cache++;
							cach=cache.ToString()+"n";
						}
						else{
							if(first){
							listnum.Add(cache);
								listchar.Add(cach.ToCharArray()[cach.Length-1].ToString());}
							first=true;
							fina+=cach;
							cache=1;
							num=true;
							cach="1n";

							upp=spe=low=us=se=false;
						}}
					else if(what==1){
						if(spe){
							cache++;
							cach=cache.ToString()+"s";
						}
						else{
							if(first){
								listnum.Add(cache);
								listchar.Add(cach.ToCharArray()[cach.Length-1].ToString());}
							first=true;
							fina+=cach;
							cache=1;
							spe=true;
							cach="1s";
							upp=low=num=us=se=false;
						}}
					else if(what==2){
						if(upp){
							cache++;
							cach=cache.ToString()+"u";
						}
						else{
							if(first){
								listnum.Add(cache);
								listchar.Add(cach.ToCharArray()[cach.Length-1].ToString());}
							first=true;
							fina+=cach;
							cache=1;
							upp=true;
							cach="1u";
							num=low=spe=us=se=false;
						}}
					else if(what==3){
						if(low){
							cache++;
							cach=cache.ToString()+"l";
						}
						else{
							if(first){
								listnum.Add(cache);
								listchar.Add(cach.ToCharArray()[cach.Length-1].ToString());}
							first=true;
							fina+=cach;
							cache=1;
							low=true;
							cach="1l";
							upp=num=spe=us=se=false;
						}}
					else if(what==4){
						if(us){
							cache++;
							cach=cache.ToString()+"c";
						}
						else{
							if(first){
								listnum.Add(cache);
								listchar.Add(cach.ToCharArray()[cach.Length-1].ToString());}
							first=true;
							fina+=cach;
							cache=1;
							us=true;
							cach="1c";
							upp=low=spe=num=se=false;
						}}
					else if(what==5){
						if(se){
							cache++;
							cach=cache.ToString()+"o";
						}
						else{
							if(first){
								listnum.Add(cache);
								listchar.Add(cach.ToCharArray()[cach.Length-1].ToString());}
							first=true;
							fina+=cach;
							cache=1;
							se=true;
							cach="1o";
							upp=low=spe=us=num=false;
						}}
					else if(what==6){
						save=!save;
					}
					else if(what==7){
						if(first){
							listnum.Add(cache);
							listchar.Add(cach.ToCharArray()[cach.Length-1].ToString());}
						fina=fina+cach;break;
					}
				}
			
			}
			bool u=listchar.Contains("c");
			bool uu=listchar.Contains("o");
			int how=1;
			int what1=0;
			if(save){what1=0;}
			else if(u){what1=1;}
			else if(uu){what1=2;}
			else{what1=3;}
			while(fina!=""){
					prin4(save,u,uu,path,use,sep,what1,how);
					Thread.Sleep(1);
					cki = Console.ReadKey(true);
					if(cki.Key==ConsoleKey.UpArrow){
					if(what1==1){if(save){what1=0;}}
					else if(what1==2){if(u){what1=1;}else if(save){what1=0;}}
					else if(what1==3){if(uu){what1=2;}else if(u){what1=1;}else if(save){what1=0;}}
					else if(what1==4){what1=3;}
					}
					else if(cki.Key==ConsoleKey.DownArrow){
					if(what1==1){if(uu){what1=2;}else{what1=3;}}
					else if(what1==0){if(u){what1=1;}else if(uu){what1=2;}else {what1=3;}}
					else if(what1==2){what1=3;}
					else if(what1==3){what1=4;}
					}
					else if(cki.Key==ConsoleKey.Enter){
					if(what1==0){path=createPath();}
					else if(what1==1){ConsoleKeyInfo cki2 = new ConsoleKeyInfo();
						string st="";
						while(true){
							prin4(save,u,uu,path,st,sep,what1,how);
							if(save){
								Console.SetCursorPosition(31+st.Length,3);}
							else{Console.SetCursorPosition(31+st.Length,0);}
							cki2=Console.ReadKey();
							if(cki2.Key==ConsoleKey.Enter){break;}
							if(cki2.Key==ConsoleKey.Backspace&&st.Length>0){st=st.Substring(0,st.Length-1);}
							st=st+cki2.KeyChar.ToString();
							if(st.Length>25){
								st=st.Substring(0,25);}
						}
						use=st;

						Console.ResetColor();}
					else if(what1==2){ConsoleKeyInfo cki2 = new ConsoleKeyInfo();
						string st="";
						while(true){
							prin4(save,u,uu,path,use,st,what1,how);
							if(save&&u){
								Console.SetCursorPosition(22+st.Length,5);}
							else if(save){Console.SetCursorPosition(22+st.Length,3);}
							else if(u){Console.SetCursorPosition(22+st.Length,2);}
							cki2=Console.ReadKey();
							if(cki2.Key==ConsoleKey.Enter){break;}
							if(cki2.Key==ConsoleKey.Backspace&&st.Length>0){st=st.Substring(0,st.Length-1);}
							st=st+cki2.KeyChar.ToString();
							if(st.Length>1){
								st=st.Substring(0,1);}
						}
						sep=st;

						Console.ResetColor();}
					else if(what1==3){ConsoleKeyInfo cki2 = new ConsoleKeyInfo();
						string st="0";
						while(true){
							if(st.Length>0){
								prin4(save,u,uu,path,use,sep,what1,int.Parse(st));}
							else{prin4(save,u,uu,path,use,sep,what1,0);}
							if(save&&u&&uu){
								Console.SetCursorPosition(35+st.Length,7);}
							else if((save&&u)||(save&&uu)){Console.SetCursorPosition(35+st.Length,5);}
							else if(save){Console.SetCursorPosition(35+st.Length,3);}
							else if(uu||u){Console.SetCursorPosition(35+st.Length,2);}

							cki2=Console.ReadKey();
							if(cki2.Key==ConsoleKey.Enter){break;}
							if(cki2.Key==ConsoleKey.Backspace&&st.Length>0){st=st.Substring(0,st.Length-1);}
							try{
								int.Parse(cki2.KeyChar.ToString());
								st=st+cki2.KeyChar.ToString();}catch(Exception){}

							if(st.Length>4){
								st=st.Substring(0,4);}
						}
						if(st==""||st=="0"){st="1";}
						how=int.Parse(st);}
					else if(what1==4){break;}
				}
				
			}
			Console.Clear();
			if(path==""){save=false;}
			if(sep==""){sep="-";}

			int len=0;
			for(int a=0;a<listnum.Count;a++){len+=listnum[a];}
			if(fina==""&&len<251){Console.WriteLine("Formato errato.");Console.ReadLine();}
			else{

				Random rnd = new Random();
				StringBuilder str11 = new StringBuilder();
				for (int l = 0; l < how; l++)
				{
					str11.Clear();
					for (int b = 0; b < listnum.Count; b++)
					{
						for (int a = 0; a < listnum[b]; a++)
						{
							string k = listchar[b];
							if (k == "n")
							{
								str11.Append(nume.ToCharArray()[rnd.Next(nume.Length)]);
							}
							else if (k == "u")
							{
								str11.Append(uppe.ToCharArray()[rnd.Next(uppe.Length)]);
							}
							else if (k == "o")
							{
								str11.Append(sep);
							}
							else if (k == "l")
							{
								str11.Append(lowe.ToCharArray()[rnd.Next(lowe.Length)]);
							}
							else if (k == "s")
							{
								str11.Append(spec.ToCharArray()[rnd.Next(spec.Length)]);
							}
							else if (k == "c"&&use.Length!=0)
							{
								str11.Append(use.ToCharArray()[rnd.Next(use.Length)]);
							}
						}
					}
					if (l + 1 < 10)
					{
						Console.WriteLine("00{0}. {1}", l + 1, str11);
						if (save)
						{
							using (StreamWriter sw = File.AppendText(path))
							{
								sw.WriteLine("00" + (l + 1).ToString() + ". " + str11.ToString());
								sw.Close();
							}
						}
					}
					else if (l + 1 < 100)
					{
						Console.WriteLine("0{0}. {1}", l + 1, str11);
						if (save)
						{
							using (StreamWriter sw = File.AppendText(path))
							{
								sw.WriteLine("0" + (l + 1).ToString() + ". " + str11.ToString());
								sw.Close();
							}
						}
					}
					else
					{
						Console.WriteLine("{0}. {1}", l + 1, str11);
						if (save)
						{
							using (StreamWriter sw = File.AppendText(path))
							{
								sw.WriteLine((l + 1).ToString() + ". " + str11.ToString());
								sw.Close();
							}
						}
					}
				}
			}

		}


		public static void pass1()
		{
			string num;
			Console.WriteLine("1 = Casuale");
			Console.WriteLine("2 = Schema");
			Console.Write("Inserisci quale metodo usare: ");
			num = Console.ReadLine();
			Console.Clear();
			if (num == "1") { met1(); }
			if (num == "2") { met2(); }
			Console.Write("00 per tornare al menù o INVIO per continuare: ");
			string b = Console.ReadLine();
			if (b == "00") { Program.Main(); }
		}

		public static void pass()
		{
			while (true) { Console.Clear(); pass1(); }
		}
	}
}