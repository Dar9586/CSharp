using System;
using System.IO;
namespace ita
{
	public class Creator3
	{
			public static void crea1()
			{
				Console.WriteLine("Inserisci perscorso:");
				string path=@Console.ReadLine();
				int a=0;
			while(true){
				Directory.CreateDirectory(path+a.ToString());
					a++;
				}
			}

			public static void crea()
			{
				while (true) { Console.Clear(); 
					crea1(); }
			}
		}

}

