using System;
using System.IO;
namespace ita
{
	public static class Delet
	{
		public static void dele1(string path,int save ,string name)
		{
			
			string[] st=Directory.GetDirectories(path);
			string[] st1=Directory.GetFiles(path);

			for(int a=0;a<st1.Length;a++){
				bool kl=false;
				try{
					Console.WriteLine("Eliminando {0}",st1[a]);
					File.Delete(st1[a]);	}catch(Exception)
				{Console.WriteLine("Fail");kl=true;}
				if (save == 1)
				{
					using (StreamWriter sw = File.AppendText(name))
					{
						sw.WriteLine("Eliminando {0}",st1[a]);
						if(kl){sw.WriteLine("Fail");}
					}
				}
			}






			for(int a=0;a<st.Length;a++){try{
					Console.WriteLine("Andando a {0}",st[a]);
					dele1(st[a],save,name);	}catch(Exception)
			{}
				if (save == 1)
				{
					using (StreamWriter sw = File.AppendText(name))
					{
						sw.WriteLine("Andando a {0}",st[a]);
					}
				}
			}
			try{Directory.Delete(path);
			if (save == 1)
			{
				using (StreamWriter sw = File.AppendText(name))
				{
					sw.WriteLine("Eliminando {0}",path);
				}
				}}catch(Exception){}
		}

		public static void dele()
		{
			Console.Clear();
			Console.WriteLine("Inserisci percorso:");
			string str=Console.ReadLine();
			 
			int save;
			while (true)
			{
				Console.Write("Salvare le password generate [1 = Si | 0 = No]: ");
				try
				{
					save = int.Parse(Console.ReadLine());
					if (save > -1 && save < 2)
					{
						break;
					}
				}
				catch (Exception)
				{
				}
			}
			string name = "";
			string pa=@"C:\Users\Antonio\Desktop\tes";
			if (save == 1)
			{
				while (name.Length == 0 && !File.Exists(name))
				{
					Console.Write("Inserisci nome file: ");
					name = Console.ReadLine();
				}
				name = name + ".txt";
				name=Path.Combine(pa,name);
				var f = File.Create(name);
				f.Close();
			}
			dele1(str,save,name); 
		}
	}
}