using System;

namespace ita
{
	public static class New
	{
        private static void sel(int x) {
            Console.Clear();
            Console.WriteLine("Scegli Categoria:\n");
            Program.recolor("Menù Principale",x==0);
            Program.recolor("Giochi",x==1);
			Program.recolor("Altro",x==2);
        }
		private static void menu1()
		{
            Console.CursorVisible=false;
            ConsoleKeyInfo cki=new ConsoleKeyInfo();
            int h=1;sel(1);
            while(true) {
                cki=Console.ReadKey();
                if((cki.Key==ConsoleKey.DownArrow||cki.Key==ConsoleKey.S)&&h<2) {h++;sel(h); }
                else if((cki.Key==ConsoleKey.UpArrow||cki.Key==ConsoleKey.W)&&h>0) {h--;sel(h); }
                else if(cki.Key==ConsoleKey.Enter||cki.Key==ConsoleKey.Spacebar) {break;}
                else if(cki.Key==ConsoleKey.M) {Admin.menu ();}
                else if(cki.Key==ConsoleKey.Backspace) {Test.test ();}
            }
            if(h==0){Program.Main();}
            else if(h==1){New_Giochi.menu();}
            else if(h==2){New_Altro.menu();} 
}

		public static void menu()
		{
			while (true) { Console.Clear(); menu1(); }
		}
	}
}