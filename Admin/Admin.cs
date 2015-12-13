
using System;

namespace ita
{
	public static class Admin
	{
        private static void sel(int x) {
            Console.Clear();
            Console.WriteLine("Scegli Programma:\n");
            Program.recolor("Menù Principale",x==0);
            Program.recolor("Generatore File",x==1);
			Program.recolor("Crea File",x==2);
			Program.recolor("Delete",x==3);
			Program.recolor("Crea Struttura",x==4);
			Program.recolor("Generatore Cartelle",x==5);
        }
		private static void menu1()
		{
			
			Console.CursorVisible=false;
            ConsoleKeyInfo cki=new ConsoleKeyInfo();
            int h=1;sel(1);
            while(true) {
                cki=Console.ReadKey();
                if((cki.Key==ConsoleKey.DownArrow||cki.Key==ConsoleKey.S)&&h<5) {h++;sel(h); }
                else if((cki.Key==ConsoleKey.UpArrow||cki.Key==ConsoleKey.W)&&h>0) {h--;sel(h); }
                else if(cki.Key==ConsoleKey.Enter||cki.Key==ConsoleKey.Spacebar) {break;}
                else if(cki.Key==ConsoleKey.Backspace) {Test.test ();}
            }
			if(h==0){ Program.Main();}
            else if(h==1){Generatore.gene();}
            else if(h==2){Creator.crea();}
            else if(h==3){Delet.dele();}
            else if(h==4){Creator2.menu();}
            else if(h==5){Creator3.crea();}

}

		public static void menu()
		{
			while (true) { Console.Clear(); menu1(); }
		}
	}
}