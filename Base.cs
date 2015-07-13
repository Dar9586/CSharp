using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace ita
{
    public static class Base
    {
        public static void NOME1()
        {
            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void NOME()
        {
            while (true) { Console.Clear(); NOME1(); }
        }
    }
}