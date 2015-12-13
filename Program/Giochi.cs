using System;

namespace ita
{
	public static class Giochi
	{
        private static void sel(int x) {
            Console.Clear();
            Console.WriteLine("Scegli Programma:\n");
            Program.recolor("Menù Principale",x==0);
            Program.recolor("Tris",x==1);
			Program.recolor("Switch",x==2);
			Program.recolor("Memory",x==3);
			Program.recolor("49 Tiles",x==4);
			Program.recolor("2048",x==5);
			Program.recolor("BlackJack",x==6);
			Program.recolor("Scopa",x==7);
			Program.recolor("Sudoku",x==8);
			Program.recolor("Dama",x==9);
        }
		private static void menu1()
		{
			Console.CursorVisible=false;
            ConsoleKeyInfo cki=new ConsoleKeyInfo();
            int h=1;sel(1);
            while(true) {
                cki=Console.ReadKey();
                if((cki.Key==ConsoleKey.DownArrow||cki.Key==ConsoleKey.S)&&h<9) {h++;sel(h); }
                else if((cki.Key==ConsoleKey.UpArrow||cki.Key==ConsoleKey.W)&&h>0) {h--;sel(h); }
                else if(cki.Key==ConsoleKey.Enter||cki.Key==ConsoleKey.Spacebar) {break;}
                else if(cki.Key==ConsoleKey.M) {Admin.menu ();}
                else if(cki.Key==ConsoleKey.Backspace) {Test.test ();}
            }
			if(h==0){Program.Main();}
            else if(h==1){Tris.tris();}
            else if(h==2){Switch.swit();}
            else if(h==3){Memory.mem();}
            else if(h==4){Tiles.tile();}
            else if(h==5){Game2048.gam();}
            else if(h==6){BlackJack.jack();}
            else if(h==7){Scopa.scop();}
            else if(h==8){Sudoku.sudo();}
            else if(h==9){Dama.dam();}
}

		public static void menu()
		{
			while (true) { Console.Clear(); menu1(); }
		}
	}
}