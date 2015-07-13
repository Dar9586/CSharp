using System;
using System.Text;

namespace ita
{
    public static class Semplificazione
    {
        public static void semp1()
        {
            long num1, num2, num3;
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
            num3 = num1 > num2 ? num3 = num2 : num3 = num1;
            while (num1 % num3 != 0 || num2 % num3 != 0)
            {
                num3--;
            }
            int l1 = num1.ToString().Length;
            int l2 = num2.ToString().Length;
            int l = l1 > l2 ? l1 : l2;
            StringBuilder str1 = new StringBuilder();
            StringBuilder str2 = new StringBuilder();
            StringBuilder str3 = new StringBuilder();
            for (int a = 0; a < l; a++)
            {
                str3.Append("-");
            }
            str1.Append(num1.ToString());
            str2.Append(num2.ToString());
            for (int a = 0; a < l - l1; a++)
            {
                str1.Append(" ");
            }
            for (int a = 0; a < l - l2; a++)
            {
                str2.Append(" ");
            }
            str3.Append("  =  ");
            str1.Append("     ");
            str2.Append("     ");
            long numb1, numb2;
            numb1 = (long)num1 / num3;
            numb2 = (long)num2 / num3;
            int lb1 = numb1.ToString().Length;
            int lb2 = numb2.ToString().Length;
            int lb = lb1 > lb2 ? lb1 : lb2;
            for (int a = 0; a < lb; a++)
            {
                str3.Append("-");
            }
            str1.Append(numb1.ToString());
            str2.Append(numb2.ToString());
            Console.WriteLine("\n{0}\n{1}\n{2}\n\nSemplificato per {3}.\n", str1, str3, str2, num3);

            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void semp()
        {
            while (true) { Console.Clear(); semp1(); }
        }
    }
}