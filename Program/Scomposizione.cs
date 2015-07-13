using System;
using System.Collections.Generic;
using System.Text;

namespace ita
{
    public static class Scomposizione
    {
        public static void scom1()
        {
            long num = 0;

            while (true)
            {
                try
                {
                    Console.Write("Inserisci numero da scomporre: ");
                    num = long.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                }
            }
            long truenum = num;
            List<long> list = new List<long>();
            List<string> bass = new List<string>();
            List<string> numm = new List<string>();

            long bas = 2;
            bool neg = false;
            if (num < 0)
            {
                num = num * -1;
                neg = true;
            }
            if (num > 1)
            {
                while (num != 1)
                {
                    bas = 2;
                    while (num % bas != 0)
                    {
                        bas++;
                    }
                    numm.Add(num.ToString());
                    bass.Add(bas.ToString());
                    num = (long)num / bas;
                    list.Add(bas);
                }

                int len = numm[0].Length;

                for (int a = 0; a < numm.Count; a++)
                {
                    StringBuilder ca = new StringBuilder();
                    ca.Append(numm[a]);
                    int h = ca.Length;
                    for (int b = 0; b < (len - h); b++)
                    {
                        ca.Append(" ");
                    }
                    numm[a] = ca.ToString();
                }
                Console.WriteLine("\n\nScomposizione:\n");
                for (int a = 0; a < numm.Count; a++)
                {
                    Console.WriteLine("{0} | {1}", numm[a], bass[a]);
                }
                StringBuilder str = new StringBuilder();
                if (neg)
                {
                    str.Append("-1 * ");
                }
                List<long> list1 = new List<long>();
                List<long> only = new List<long>();

                int cache = 1;
                for (int a = 0; a < list.Count; a++)
                {
                    if (a > 0)
                    {
                        if (list[a] == list[a - 1])
                        {
                            cache++;
                        }
                        else
                        {
                            only.Add(list[a]);
                            list1.Add(cache);
                            cache = 1;
                        }
                    }
                    else
                    {
                        only.Add(list[a]);
                    }
                    if (a == list.Count - 1)
                    {
                        list1.Add(cache);
                    }
                }
                for (int a = 0; a < list1.Count; a++)
                {
                    if (list1[a] != 1)
                    {
                        str.Append(only[a]);
                        str.Append(" ^ ");
                        str.Append(list1[a]);
                        str.Append(" * ");
                    }
                    else
                    {
                        str.Append(only[a]);
                        str.Append(" * ");
                    }
                }
                Console.WriteLine("\n\nFattorizzazione:\n");
                string str1 = str.ToString().Substring(0, str.Length - 3);
                Console.WriteLine("La scomposizione di {0} è {1}.\n\n", truenum, str1);
            }
            else
            {
                Console.WriteLine("La scomposizione di {0} è {1}.\n\n", num, num);
            }

            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string bv = Console.ReadLine();
            if (bv == "00")
            {
                Program.Main();
            }
        }

        public static void scom()
        {
            while (true)
            {
                Console.Clear();
                scom1();
            }
        }
    }
}