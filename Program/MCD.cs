using System;

namespace ita
{
    public static class MCD
    {
        public static void nummcm()
        {
            long num1, num2;
            while (true)
            {
                try
                {
                    Console.Write("Inserisci primo numero: ");
                    num1 = long.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Inserisci secondo numero: ");
                    num2 = long.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                }
            }
            mcmCalc(num1, num2);
        }

        public static void mcmCalc(long num1, long num2)
        {
            long num3;
            if (num1 < num2)
            {
                num3 = num1;
            }
            else
            {
                num3 = num2;
            }
            while (num1 % num3 != 0 || num2 % num3 != 0)
            {
                num3--;
            }
            Console.WriteLine("L' MCD tra {0} e {1} = {2}", num1, num2, num3);
            if (num1 > num2)
            {
                num3 = num1;
            }
            else
            {
                num3 = num2;
            }
            while (num3 % num1 != 0 || num3 % num2 != 0)
            {
                num3++;
            }
            Console.WriteLine("L' mcm tra {0} e {1} = {2}", num1, num2, num3);

            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void mcm()
        {
            while (true) { Console.Clear(); nummcm(); }
        }
    }
}