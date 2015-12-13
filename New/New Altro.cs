using System;

namespace ita
{
	public static class New_Altro
	{
        private static void sel(int x) {
            Console.Clear();
            Console.WriteLine("Scegli Programma:\n");
            Program.recolor("New Menù",x==0);
            Program.recolor("New Password",x==1);
        }
		private static void menu1()
		{
			Console.CursorVisible=false;
            ConsoleKeyInfo cki=new ConsoleKeyInfo();
            int h=1;sel(1);
            while(true) {
                cki=Console.ReadKey();
                if((cki.Key==ConsoleKey.DownArrow||cki.Key==ConsoleKey.S)&&h<1) {h++;sel(h); }
                else if((cki.Key==ConsoleKey.UpArrow||cki.Key==ConsoleKey.W)&&h>0) {h--;sel(h); }
                else if(cki.Key==ConsoleKey.Enter||cki.Key==ConsoleKey.Spacebar) {break;}
                else if(cki.Key==ConsoleKey.M) {Admin.menu ();}
                else if(cki.Key==ConsoleKey.Backspace) {Test.test ();}
            }
            if(h==0){New.menu();}
            else if(h==1){New_Password.pass();}
}

		public static void menu()
		{
			while (true) { Console.Clear(); menu1(); }
		}
	}
}