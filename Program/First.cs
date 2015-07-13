using System;

namespace ita
{
    public static class First
    {
        public static void first1()
        {
            Console.Write("Scrivi qualcosa: ");
            string a = Console.ReadLine();

            Console.WriteLine("Hai scritto " + a + ".");

            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void first()
        {
            while (true) { Console.Clear(); first1(); }
        }
    }
}