using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace ita {
	public class Creator2 {
		public static void crea(string path) {
			int l=0;
			bool can=true;
			while(true){
				Random rnd=new Random();
				int k=rnd.Next(50);
				string[] Files = Directory.GetFiles(path);

				string[] Files1=Directory.GetDirectories(path);
				if(Files.Length+Files1.Length>=50){return;}
				if(k==49){return;}
				else if(k%2==0||!can){
					try{
						try{
							l+=rnd.Next(9999);}catch(Exception){l=rnd.Next(9999);}
						string s=path+"\\"+l.ToString()+".txt";
						var f=File.Create(s);
						f.Close();

					}catch(Exception){Console.WriteLine("Fail.");return;}
				}
				else if(k%2==1&&can){
					try{
						try{
							l+=rnd.Next(9999);}catch(Exception){l=rnd.Next(9999);}
						string s=path+"\\"+l.ToString();
						if(s.Length<55){
							Console.WriteLine("Creando Directory: "+s);
							Directory.CreateDirectory(s);
						crea(s);}else{can=false;}}catch(Exception){Console.WriteLine("Massimo raggiunto.");can=false;}
				}

			}

		}
		public static void menu() {

			Console.WriteLine("Inserisci percorso:");
			string s=Console.ReadLine();	
			crea(s);
		}

	}
}