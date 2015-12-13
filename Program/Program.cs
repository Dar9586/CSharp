using System;

namespace ita
{
    public static class Program
    {
        public static void recolor(string x,bool y) {
        if(y) { 
            Console.BackgroundColor=ConsoleColor.White;
            Console.ForegroundColor=ConsoleColor.Black;}
            Console.WriteLine(x);
            Console.ResetColor();
        }
        private static void sel(int x) {
            Console.Clear();
            Console.WriteLine("Scegli Categoria:\n");
			recolor("Giochi",x==1);
			recolor("Matematica",x==2);
			recolor("Altro",x==3);
			recolor("New",x==4);
        }

        private static void menu1()
        {
            Console.CursorVisible=false;
            ConsoleKeyInfo cki=new ConsoleKeyInfo();
            int h=1;sel(1);
            while(true) {
                cki=Console.ReadKey();
                if((cki.Key==ConsoleKey.DownArrow||cki.Key==ConsoleKey.S)&&h<4) {h++;sel(h); }
                else if((cki.Key==ConsoleKey.UpArrow||cki.Key==ConsoleKey.W)&&h>1) {h--;sel(h); }
                else if(cki.Key==ConsoleKey.Enter||cki.Key==ConsoleKey.Spacebar) {break;}
                else if(cki.Key==ConsoleKey.M) {Admin.menu ();}
                else if(cki.Key==ConsoleKey.Backspace) {Test.test ();}
            }
			if(h==1){Giochi.menu();}
			else if(h==2){Matematica.menu();}
			else if(h==3){Altro.menu();} 
			else if(h==4){New.menu();}
        }

        public static void Main()
        {
            while (true) { Console.Clear(); menu1(); }
        }
    }
}