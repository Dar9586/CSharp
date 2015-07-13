using System;

namespace ita
{
    public static class Calcolatrice
    {
        public static void calc1()
        {
            int segno = 0;
            double num1, num2;
            Console.WriteLine("1 = Addizione");
            Console.WriteLine("2 = Sottrazione");
            Console.WriteLine("3 = Moltiplicazione");
            Console.WriteLine("4 = Divisione");
            Console.WriteLine("5 = Potenza");
            Console.WriteLine("6 = Radice");
            while (segno < 1 || segno > 6)
            {
                Console.Write("Inserici operazione: ");
                int.TryParse(Console.ReadLine(), out segno);
            }
            while (true)
            {
                try
                {
                    Console.Write("Inserici primo numero: ");
                    num1 = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception) { }
            }
            while (true)
            {
                try
                {
                    Console.Write("Inserici secondo numero: ");
                    num2 = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception) { }
            }
            if (num2 == 0) { Console.WriteLine("Divisione per 0 impossibile"); }
            else
            {
                if (segno == 1) { Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2); }
                if (segno == 2) { Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2); }
                if (segno == 3) { Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2); }
                if (segno == 4) { Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2); }
                if (segno == 5) { Console.WriteLine("{0} ^ {1} = {2}", num1, num2, Math.Pow(num1, num2)); }
                if (segno == 6) { Console.WriteLine("{0} √ {1} = {2}", num1, num2, Math.Pow(num1, (1 / num2))); }
            }

            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void calc()
        {
            while (true) { Console.Clear(); calc1(); }
        }
    }
}