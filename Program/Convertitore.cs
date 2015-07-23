using System;
using System.Collections.Generic;
using System.Text;

namespace ita
{
    public static class Convertitore
    {
        private static List<string> str1 = new List<string>{  "0","1","2","3","4","5","6","7","8","9",
                                                        "A","B","C","D","E","F","G","H","I","J",
                                                        "K","L","M","N","O","P","Q","R","S","T",
                                                        "U","V","W","X","Y","Z","a","b","c","d",
                                                        "e","f","g","h","i","j","k","l","m","n",
                   	                                     "o","p","q","r","s","t","u","v","w","x",
                                                        "y","z"};
        private static long to10(string num, int bas)
        {
            List<string> str = new List<string>();
            for (int a = 0; a < bas; a++)
            {
                str.Add(str1[a]);
            }
            for (int a = 0; a < num.Length; a++)
            {
                if (!str.Contains(num.ToCharArray()[a].ToString()))
                {
                    Console.WriteLine("Base numero non valida.");
                    return -1;
                }
            }
            List<int> nums = new List<int>();
            for (int a = 0; a < num.Length; a++)
            {
                nums.Add(str.IndexOf(num.ToCharArray()[a].ToString()));
            }
            int l = num.Length - 1;
            long final = 0;
            for (int a = 0; a < num.Length; a++)
            {
                final += (long)(nums[a] * Math.Pow(bas, l - a));
            }
            return final;
        }

        private static void toOther(long num, int bas)
        {
            StringBuilder str = new StringBuilder();
            while (num > 1)
            {
                str.Append(str1[(int)(num % bas)]);
                num = (long)num / bas;
            }
            str.Append(str1[(int)(num % bas)]);
            StringBuilder ne = new StringBuilder();
            for (int a1 = str.Length - 1; a1 >= 0; a1--)
            {
                ne.Append(str.ToString().ToCharArray()[a1].ToString());
            }
            while (true)
            {
                if (ne.ToString().ToCharArray()[0].ToString() == "0")
                {
                    ne.Remove(0, 1);
                }
                else
                {
                    break;
                }
            }
            if (bas == 16) { Console.WriteLine("Base Esadecimale : {0}", ne); }
            else if (bas == 10) { Console.WriteLine("Base Decimale : {0}", ne); }
            else if (bas == 8) { Console.WriteLine("Base Ottale : {0}", ne); }
            else if (bas == 2)
            {
                Console.WriteLine("Base Binaria : {0}", ne);
            }
            else
            {
                Console.WriteLine("Base {0} : {1}", bas, ne);
            }
        }

        public static void conv1()
        {
            string num;
            int bas;
            while (true)
            {
                try
                {
                    Console.Write("Inserisci numero da convertire: ");
                    num = Console.ReadLine();
                    for (int a = 0; a < num.Length; a++)
                    {
                        if (!str1.Contains(num.ToCharArray()[a].ToString()))
                        {
                            Console.WriteLine("Formato Errato");
                            Console.ReadLine(); Console.Clear();
                            int h = 6 / (a - a);
                        }
                    }
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
                    Console.Write("Inserici base numero: ");
                    bas = int.Parse(Console.ReadLine());
                    if (bas > 1 && bas < 36)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                }
            }
            long s = (to10(num.ToUpper(), bas));
            StringBuilder num1 = new StringBuilder();
            List<string> allowed = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "," };
            while (true)
            {
                try
                {
                    Console.Write("Inserisi in quali basi convertire [ Separa con la virgola(,) ]: ");
                    num1.Append(Console.ReadLine());
                    for (int a = 0; a < num1.Length; a++)
                    {
                        if (char.IsWhiteSpace(num1.ToString().ToCharArray()[a]))
                        {
                            num1.Remove(a, 1);
                        }
                    }
                    for (int a = 0; a < num1.Length; a++)
                    {
                        if (!allowed.Contains(num1.ToString().ToCharArray()[a].ToString()))
                        {
                            Console.WriteLine("Formato Errato");
                            Console.ReadLine(); Console.Clear();
                            int h = 6 / (a - a);
                        }
                    }
                    break;
                }
                catch (Exception)
                {
                }
            }
            Console.Clear();
            if (num1.ToString() == "")
            {
                num1.Append("2,8,10,16");
            }
            List<int> o = new List<int>();
            for (int a = 0; a < num1.ToString().Split(",".ToCharArray()[0]).Length; a++)
            {
                try
                {
                    int l = int.Parse(num1.ToString().Split(",".ToCharArray()[0])[a]);
                    if (!o.Contains(l) && l > 1 && l < 36)
                    {
                        o.Add(l);
                    }
                }
                catch (Exception) { }
            }
            o.Sort();
            for (int a = 0; a < o.Count; a++)
            {
                toOther(s, o[a]);
            }
            Console.Write("\n\n00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void conv()
        {
            while (true) { Console.Clear(); conv1(); }
        }
    }
}