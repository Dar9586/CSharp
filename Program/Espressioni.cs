using NCalc;
using System;

namespace ita
{
    public static class Espressioni
    {
        public static void espr1()
        {
            Console.WriteLine("Inserisci espressione:");
            try
            {
                Expression e = new Expression(Console.ReadLine());
                Console.WriteLine(e.Evaluate());
            }
            catch (Exception) { Console.WriteLine("Espressione invalida."); }

            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void espr()
        {
            while (true) { Console.Clear(); espr1(); }
        }
    }
}