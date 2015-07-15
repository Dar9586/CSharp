using System;
using System.Collections.Generic;
using System.Text;

namespace ita
{
    public static class Switch
    {
        

        private static void prinscheme(int b, int h, List<string> user)
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
						st1.Append(Utility.rev(Utility.rev(st).Append("00")));
                    }
                    else if (a + 1 < 100)
                    {
						st1.Append(Utility.rev(Utility.rev(st).Append("0")));
                    }
                }
                else if (sum > 9)
                {
                    if (a + 1 < 10)
                    {
						st1.Append(Utility.rev(Utility.rev(st).Append("0")));
                    }
                }
                second.Add(st.ToString());
            }
            int num = 0;
            for (int a = 0; a < h; a++)
            {
                for (int l = 0; l < b; l++)
                {
                    Console.Write(user[l + num] + " ");
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

        public static void swit1()
        {
            Random rnd = new Random();
            int bas = 0, alt = 0;
            while (bas * alt < 4)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Inserisci base [1:13]: ");
                        bas = int.Parse(Console.ReadLine());
                        if (bas > 0 && bas < 14)
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
                        Console.Write("Inserisci altezza [1:22]: ");
                        alt = int.Parse(Console.ReadLine());
                        if (alt > 0 && alt < 23)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                if (bas * alt < 4)
                {
                    Console.WriteLine("Schema troppo piccolo, INVIO per rincominciare.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            List<string> list = new List<string>();
            Console.Write("Inserisci carattere casella piena: ");
            char ch;
            try
            {
                ch = Console.ReadLine().ToCharArray()[0];
                if (String.IsNullOrWhiteSpace(ch.ToString())) { ch = "X".ToCharArray()[0]; }
            }
            catch (Exception)
            {
                ch = "X".ToCharArray()[0];
            }
            Console.WriteLine("Verrà utilizzato il carattere {0} per le caselle piene.", ch.ToString());
            Console.Write("Inserisci carattere casella vuota: ");
            char ch1;
            try
            {
                ch1 = Console.ReadLine().ToCharArray()[0];
            }
            catch (Exception)
            {
                ch1 = "-".ToCharArray()[0];
                if (String.IsNullOrWhiteSpace(ch1.ToString())) { ch1 = "-".ToCharArray()[0]; }
            }
            Console.WriteLine("Verrà utilizzato il carattere {0} per le caselle piene.", ch1.ToString());
            for (int a = 0; a < bas * alt; a++)
            {
                if (rnd.Next(2) == 1)
                {
                    list.Add(ch.ToString());
                }
                else
                {
                    list.Add(ch1.ToString());
                }
            }
            prinscheme(bas, alt, list);
            int moves = 0;
            while (list.Contains(ch1.ToString()) && list.Contains(ch.ToString()))
            {
                int where;
                while (true)
                {
                    try
                    {
                        Console.Write("Inserisci dove cambiare [1:{0}]: ", bas * alt);
                        where = int.Parse(Console.ReadLine());
                        if (where > 0 && where <= bas * alt)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                where--;
                if (list[where] == ch.ToString()) { list[where] = ch1.ToString(); } else { list[where] = ch.ToString(); }
                try { if (where % bas != 0) { if (list[where - 1] == ch.ToString()) { list[where - 1] = ch1.ToString(); } else { list[where - 1] = ch.ToString(); } } } catch (ArgumentOutOfRangeException) { }
                try { if ((where + 1) % bas != 0) { if (list[where + 1] == ch.ToString()) { list[where + 1] = ch1.ToString(); } else { list[where + 1] = ch.ToString(); } } } catch (ArgumentOutOfRangeException) { }
                try { if (list[where + bas] == ch.ToString()) { list[where + bas] = ch1.ToString(); } else { list[where + bas] = ch.ToString(); } } catch (ArgumentOutOfRangeException) { }
                try { if (list[where - bas] == ch.ToString()) { list[where - bas] = ch1.ToString(); } else { list[where - bas] = ch.ToString(); } } catch (ArgumentOutOfRangeException) { }
                prinscheme(bas, alt, list);
                moves++;
            }
            Console.WriteLine("Hai vinto dopo {0} mosse\n\n", moves);

            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string bv = Console.ReadLine();
            if (bv == "00") { Program.Main(); }
        }

        public static void swit()
        {
            while (true) { Console.Clear(); swit1(); }
        }
    }
}