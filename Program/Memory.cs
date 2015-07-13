using System;
using System.Collections.Generic;
using System.Text;

namespace ita
{
    public static class Memory
    {
        private static StringBuilder rev(StringBuilder str)
        {
            char[] array = str.ToString().ToCharArray();
            Array.Reverse(array);
            str.Remove(0, str.Length);
            str.Append(array);
            return str;
        }

        private static void prinscheme(int b, int h, List<string> user, int change, int change2, bool combo)
        {
            Console.Clear();
            List<string> second = new List<string>();
            for (int a = 0; a < b * h; a++)
            {
                StringBuilder st = new StringBuilder();
                StringBuilder st1 = new StringBuilder();
                st.Append((a + 1).ToString());
                int sum = b * h;
                if (sum > 99)
                {
                    if (a + 1 < 10)
                    {
                        st1.Append(rev(rev(st).Append("00")));
                    }
                    else if (a + 1 < 100)
                    {
                        st1.Append(rev(rev(st).Append("0")));
                    }
                }
                else if (sum > 9)
                {
                    if (a + 1 < 10)
                    {
                        st1.Append(rev(rev(st).Append("0")));
                    }
                }
                second.Add(st.ToString());
            }
            int num = 0;
            for (int a = 0; a < h; a++)
            {
                for (int l = 0; l < b; l++)
                {
                    if (change2 == -1)
                    {
                        if (l + num == change)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                    }
                    else
                    {
                        if (combo)
                        {
                            if (l + num == change)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            if (l + num == change2)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }
                        else
                        {
                            if (l + num == change)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            if (l + num == change2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        }
                    }
                    Console.Write(user[l + num] + " ");

                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.Write(" ");
                for (int l = 0; l < b; l++)
                {
                    Console.Write(second[l + num] + " ");
                }
                num = num + b;
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void mem1()
        {
            int mem1 = 1, mem2 = 1;
            while (mem1 * mem2 % 2 == 1 || mem1 * mem2 < 3)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Inserisci base [1:13]: ");
                        mem1 = int.Parse(Console.ReadLine());
                        if (mem1 > 0 && mem1 < 14)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                while (true)
                {
                    try
                    {
                        int k = 182 / mem1;
                        bool h = false;
                        if (mem1 % 2 == 1 && k % 2 == 1) { Console.Write("Inserisci altezza [1:{0}]: ", k - 1); h = true; }
                        else
                        {
                            Console.Write("Inserisci altezza [1:{0}]: ", k);
                        }
                        mem2 = int.Parse(Console.ReadLine());
                        if (h) { k--; }
                        if (mem2 > 0 && mem2 <= k)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                if (mem1 * mem2 % 2 == 1 || mem1 * mem2 < 3)
                {
                    Console.WriteLine("Almeno uno dei 2 numeri deve essere pari.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            String[] let ={"a","b","c","d","e","f","g",
                "h","i","j","k","l","m","n","o",
                "p","q","r","s","t","u","v","w",
                "x","y","z","A","B","C","D","E",
                "F","G","H","I","J","K","L","M",
                "N","O","P","Q","R","S","T","U",
                "V","W","Y","Z","1","2","3","à",
                "4","5","6","7","8","9","0","/",
                "*","-","+","!","£","$","%","&",
                "(",")","=","?","'","^","[","]",
                "{","}","#",".","~","@","\\","°",
                "§","_",":",";"};
            List<String> user = new List<String>();
            for (int a = 0; a < ((mem1 * mem2)); a++)
            {
                int k = a / 2;
                user.Add(let[k]);
            }

            Random rnd = new Random();
            List<String> scheme = new List<String>();
            while (user.Count != 0)
            {
                int k = rnd.Next(user.Count ^ 3);
                try
                {
                    scheme.Add(user[k]);
                    user.Remove(user[k]);
                }
                catch (Exception)
                {
                }
            }
            for (int a = 0; a < ((mem1 * mem2)); a++)
            {
                user.Add("X");
            }
            int moves = 0;
            while (user.Contains("X"))
            {
                prinscheme(mem1, mem2, user, -1, -1, false);
                int where, where1;
                while (true)
                {
                    try
                    {
                        Console.Write("Inserisci primo numero [1:{0}]: ", mem1 * mem2);
                        where = int.Parse(Console.ReadLine());
                        if (where > 0 && where <= mem1 * mem2)
                        {
                            if (user[where - 1] == "X") { break; }
                            else { Console.WriteLine("Carattere già utilizzato"); }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                where--;
                user[where] = scheme[where];
                prinscheme(mem1, mem2, user, where, -1, false);
                while (true)
                {
                    try
                    {
                        Console.Write("Inserisci secondo numero [1:{0}]: ", mem1 * mem2);
                        where1 = int.Parse(Console.ReadLine());
                        if (where1 > 0 && where1 <= mem1 * mem2)
                        {
                            if (user[where1 - 1] == "X") { break; }
                            else { Console.WriteLine("Carattere già utilizzato"); }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                where1--;
                user[where1] = scheme[where1];
                bool f = scheme[where] == scheme[where1];
                prinscheme(mem1, mem2, user, where1, where, f);
                if (!f)
                {
                    Console.WriteLine("Hai sbagliato.");
                    user[where] = "X";
                    user[where1] = "X";
                }
                else
                {
                    Console.WriteLine("Hai trovato una coppia.");
                }
                Console.ReadLine();
                moves++;
            }
            prinscheme(mem1, mem2, user, -1, -1, false);
            Console.WriteLine("Hai vinto dopo {0} mosse\n\n", moves);

            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void mem()
        {
            while (true) { Console.Clear(); mem1(); }
        }
    }
}