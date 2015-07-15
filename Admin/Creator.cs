using System;
using System.IO;
namespace ita
{
	public static class Creator
	{
		public static void crea1()
		{
			Console.WriteLine("Inserisci perscorso:");
			string path=@Console.ReadLine();
			int a=0;
			while(true){
				var f = File.Create(Path.Combine(path,a.ToString()+".txt"));
				f.Close();
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