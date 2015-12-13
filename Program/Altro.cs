using System;

namespace ita
{
	public static class Altro
	{
        private static void sel(int x) {
            Console.Clear();
            Console.WriteLine("Scegli Programma:\n");
            Program.recolor("Menù Principale",x==0);
			Program.recolor("First",x==1);
			Program.recolor("Password",x==2);
			Program.recolor("Paint",x==3);
			Program.recolor("Anagrammi",x==4);
        }
		private static void menu1()
		{
		
			Console.CursorVisible=false;
            ConsoleKeyInfo cki=new ConsoleKeyInfo();
            int h=1;sel(1);
            while(true) {
                cki=Console.ReadKey();
                if((cki.Key==ConsoleKey.DownArrow||cki.Key==ConsoleKey.S)&&h<4) {h++;sel(h); }
                else if((cki.Key==ConsoleKey.UpArrow||cki.Key==ConsoleKey.W)&&h>0) {h--;sel(h); }
                else if(cki.Key==ConsoleKey.Enter||cki.Key==ConsoleKey.Spacebar) {break;}
                else if(cki.Key==ConsoleKey.M) {Admin.menu ();}
                else if(cki.Key==ConsoleKey.Backspace) {Test.test ();}
            }
			if(h==0){Program.Main();}
            else if(h==1){First.first();}
            else if(h==2){Password.pass();}
            else if(h==3){Paint.pain();}
            else if(h==4){Anagram.anagram();}
}

		public static void menu()
		{
			while (true) { Console.Clear(); menu1(); }
		}
	}
}