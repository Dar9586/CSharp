using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ita
{
	public static class New_Giochi
	{
        private static void sel(int x) {
            Console.Clear();
            Console.WriteLine("Scegli Programma:\n");
            Program.recolor("New Menù",x==0);
            Program.recolor("Sudoku",x==1);
			Program.recolor("Switch",x==2);
			Program.recolor("2048",x==3);
			Program.recolor("Memory",x==4);
			Program.recolor("Snake",x==5);
			Program.recolor("Simon",x==6);
			Program.recolor("Tris",x==7);
			Program.recolor("49 Tiles",x==8);
			Program.recolor("Dama",x==9);
			Program.recolor("Forza 4",x==10);
			Program.recolor("Galattron",x==11);
        }

		private static void menu1()
		{
			Console.CursorVisible=false;
            ConsoleKeyInfo cki=new ConsoleKeyInfo();
            int h=1;sel(1);
            while(true) {
                cki=Console.ReadKey();
                if((cki.Key==ConsoleKey.DownArrow||cki.Key==ConsoleKey.S)&&h<11) {h++;sel(h); }
                else if((cki.Key==ConsoleKey.UpArrow||cki.Key==ConsoleKey.W)&&h>0) {h--;sel(h); }
                else if(cki.Key==ConsoleKey.Enter||cki.Key==ConsoleKey.Spacebar) {break;}
                else if(cki.Key==ConsoleKey.M) {Admin.menu ();}
                else if(cki.Key==ConsoleKey.Backspace) {Test.test ();}
            }
			if(h==0){New.menu();}
            else if(h==1){New_Sudoku.sudo();} 
            else if(h==2){New_Switch.swit();} 
            else if(h==3){New_2048.gam();} 
            else if(h==4){New_Memory.mem();} 
            else if(h==5){Snake.snak();} 
            else if(h==6){Simon.simo();} 
            else if(h==7){New_Tris.tris();}
            else if(h==8){New_Tiles.tile();}
            else if(h==9){New_Dama.dam();}
            else if(h==10){Forza4.forza();}
            else if(h==11){Galattron.gala();}
		}

		public static void menu()
		{
			while (true) { Console.Clear(); menu1(); }
		}
	}
}