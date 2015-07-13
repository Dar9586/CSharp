using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ita
{
    public static class Generatore
    {
        private static void gener(int num, int len)
        {
            StringBuilder k1 = new StringBuilder();
            for (int a = 0; a < len; a++)
            {
                k1.Append(num.ToString());
            }
            List<int> lst1 = new List<int>();
            List<List<int>> depo = new List<List<int>>();
            for (int a = 0; a < num; a++)
            {
                lst1.Add(a);
            }
            long k = long.Parse(k1.ToString());
            for (int a = 0; a < k; a++)
            {
                List<int> lst = new List<int>();
                for (int z = 0; z < a.ToString().Length; z++)
                {
                    lst.Add(int.Parse(a.ToString().ToCharArray()[z].ToString()));
                }
                lst.Sort();
                bool ok = true;
                if (lst.ToList().Distinct().Count() == lst.ToList().Count())
                {
                    for (int b = 0; b < lst.Count; b++)
                    {
                        if (!lst1.Contains(lst[b]))
                        {
                            ok = false;
                        }
                    }
                    if (ok)
                    {
                        bool ko = true;
                        for (int c = 0; c < depo.Count; c++)
                        {
                            if (lst == (depo[c]))
                            {
                                ko = false;
                            }
                        }
                        if (ko)
                        {
                            depo.Add(lst);
                        }
                    }
                }
            }
            List<List<int>> depo1 = new List<List<int>>(depo.Distinct().ToList());
            for (int a = 0; a < depo1.Count; a++)
            {
                for (int b = 0; b < depo1[a].Count; b++)
                {
                    Console.Write("{0} ", depo1[a][b]);
                }
                Console.WriteLine();
            }
        }

        public static void gene1()
        {
            int num1, num2;
            while (true)
            {
                try
                {
                    Console.Write("Inserisci primo numero: ");
                    num1 = int.Parse(Console.ReadLine());
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
                    num2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                }
            }
            gener(num1, num2);
            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void gene()
        {
            while (true) { Console.Clear(); gene1(); }
        }
    }
}