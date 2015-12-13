using System;

namespace ita
{
	public static class Matematica
	{
        private static void sel(int x) {
            Console.Clear();
            Console.WriteLine("Scegli Programma:\n");
            Program.recolor("Menù Principale",x==0);
            Program.recolor("Calcolatrice",x==1);
			Program.recolor("MCD e mcm",x==2);
			Program.recolor("Scomposizione",x==3);
			Program.recolor("Semplificazione",x==4);
			Program.recolor("Notazione scientifica",x==5);
			Program.recolor("Proporzioni",x==6);
			Program.recolor("Convertitore Basi",x==7);
			Program.recolor("Password",x==8);
			Program.recolor("Espressioni",x==9);
			Program.recolor("No Limiti",x==10);
        }
		private static void menu1()
		{

			Console.CursorVisible=false;
            ConsoleKeyInfo cki=new ConsoleKeyInfo();
            int h=1;sel(1);
            while(true) {
                cki=Console.ReadKey();
                if((cki.Key==ConsoleKey.DownArrow||cki.Key==ConsoleKey.S)&&h<10) {h++;sel(h); }
                else if((cki.Key==ConsoleKey.UpArrow||cki.Key==ConsoleKey.W)&&h>0) {h--;sel(h); }
                else if(cki.Key==ConsoleKey.Enter||cki.Key==ConsoleKey.Spacebar) {break;}
                else if(cki.Key==ConsoleKey.M) {Admin.menu ();}
                else if(cki.Key==ConsoleKey.Backspace) {Test.test ();}
            }
            if(h==0){Program.Main();}
            else if(h==1){Calcolatrice.calc();}
            else if(h==2){MCD.mcm();}
            else if(h==3){Scomposizione.scom();}
            else if(h==4){Semplificazione.semp();}
            else if(h==5){Notazione.nota();}
            else if(h==6){Proporzioni.prop();}
            else if(h==7){Convertitore.conv();}
            else if(h==8){Password.pass();}
            else if(h==9){Espressioni.espr();}
            else if(h==10){NoLimit.noli();}
		}

		public static void menu()
		{
			while (true) { Console.Clear(); menu1(); }
		}
	}
}