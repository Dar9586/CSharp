using System;
using System.Collections.Generic;

namespace ita
{
    public static class Tiles
    {
        private static void prin(List<string> list, List<int> usable, List<int> allusable, int num)
        {
            Console.Clear();
            List<string> list1 = new List<string>();
            for (int a = 0; a < 49; a++)
            {
                if (list[a] == "  " && usable.Contains(a))
                {
                    list1.Add("XX");
                }
                else { list1.Add(list[a]); }
            }
            int k = 0;
            Console.Write("\n\n        ");
            for (int a = 0; a < 49; a++)
            {
                if (list1[a] == "XX")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (num == a)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (allusable.Contains(a) && list[a] != "XX")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(list1[a]);
                Console.ForegroundColor = ConsoleColor.Gray;
                if ((a + 1) % 7 != 0)
                {
                    Console.Write("||");
                }
                else
                {
                    Console.Write("        ");
                    for (int b = 0; b < 7; b++)
                    {
                        string s = "";
                        if (b + 1 + k < 10)
                        {
                            s = "0" + (b + 1 + k).ToString();
                        }
                        else
                        {
                            s = (b + 1 + k).ToString();
                        }
                        Console.Write(s);
                        if ((b + 1) % 7 != 0)
                        {
                            Console.Write("||");
                        }
                        else
                        {
                            k = k + 7;
                            if (k != 49)
                            {
                                Console.WriteLine("\n        --------------------------        --------------------------");
                                Console.Write("        ");
                            }
                            else
                            {
                                Console.WriteLine("\n\n");
                            }
                        }
                    }
                }
            }
        }

        private static String where(int num)
        {
            if (num == 0)
            {
                return "09,15";
            }
            else if (num == 1)
            {
                return "10,14,16";
            }
            else if (num == 2)
            {
                return "07,11,15,17";
            }
            else if (num == 3)
            {
                return "08,12,16,18";
            }
            else if (num == 4)
            {
                return "13,09,17,19";
            }
            else if (num == 5)
            {
                return "10,18,20";
            }
            else if (num == 6)
            {
                return "11,19";
            }
            else if (num == 7)
            {
                return "02,16,22";
            }
            else if (num == 8)
            {
                return "03,17,21,23";
            }
            else if (num == 9)
            {
                return "00,04,14,18,22,24";
            }
            else if (num == 10)
            {
                return "01,05,15,19,23,25";
            }
            else if (num == 11)
            {
                return "02,06,16,20,24,26";
            }
            else if (num == 12)
            {
                return "03,17,25,27";
            }
            else if (num == 13)
            {
                return "04,18,26";
            }
            else if (num == 14)
            {
                return "01,09,23,29";
            }
            else if (num == 15)
            {
                return "00,02,10,24,28,30";
            }
            else if (num == 16)
            {
                return "01,03,07,11,21,25,29,31";
            }
            else if (num == 17)
            {
                return "02,04,08,12,22,26,30,32";
            }
            else if (num == 18)
            {
                return "03,05,09,13,23,27,31,33";
            }
            else if (num == 19)
            {
                return "04,06,10,24,32,34";
            }
            else if (num == 20)
            {
                return "05,11,25,33";
            }
            else if (num == 21)
            {
                return "08,16,30,36";
            }
            else if (num == 22)
            {
                return "07,09,17,31,35,37";
            }
            else if (num == 23)
            {
                return "08,10,14,18,28,32,36,38";
            }
            else if (num == 24)
            {
                return "09,11,15,19,29,33,37,39";
            }
            else if (num == 25)
            {
                return "10,12,16,20,30,34,38,40";
            }
            else if (num == 26)
            {
                return "11,13,17,31,39,41";
            }
            else if (num == 27)
            {
                return "12,18,32,40";
            }
            else if (num == 28)
            {
                return "15,23,37,43";
            }
            else if (num == 29)
            {
                return "14,16,24,38,42,44";
            }
            else if (num == 30)
            {
                return "15,17,21,25,35,39,43,45";
            }
            else if (num == 31)
            {
                return "16,18,22,26,36,40,44,46";
            }
            else if (num == 32)
            {
                return "17,19,23,27,37,41,45,47";
            }
            else if (num == 33)
            {
                return "18,20,24,38,46,48";
            }
            else if (num == 34)
            {
                return "19,25,39,47";
            }
            else if (num == 35)
            {
                return "22,30,44";
            }
            else if (num == 36)
            {
                return "21,23,31,45";
            }
            else if (num == 37)
            {
                return "22,24,28,32,42,46";
            }
            else if (num == 38)
            {
                return "23,25,29,33,43,47";
            }
            else if (num == 39)
            {
                return "24,26,30,34,44,48";
            }
            else if (num == 40)
            {
                return "25,27,31,45";
            }
            else if (num == 41)
            {
                return "26,32,46";
            }
            else if (num == 42)
            {
                return "29,37";
            }
            else if (num == 43)
            {
                return "28,30,38";
            }
            else if (num == 44)
            {
                return "29,31,35,39";
            }
            else if (num == 45)
            {
                return "30,32,36,40";
            }
            else if (num == 46)
            {
                return "31,33,37,41";
            }
            else if (num == 47)
            {
                return "32,34,38";
            }
            else if (num == 48)
            {
                return "33,39";
            }
            else
                return "";
        }

        public static void tile1()
        {
            List<string> str = new List<string>();
            for (int a = 0; a < 49; a++)
            {
                str.Add("  ");
            }
            int nn = 1;
            Random rnd = new Random();
            int k = rnd.Next(49);
            str[k] = "01";
            string w = where(k);
            List<int> usable = new List<int>();
            List<int> allusable = new List<int>();
            for (int a = 0; a < w.Split(",".ToCharArray()[0]).Length; a++)
            {
                int l = int.Parse(w.Split(",".ToCharArray()[0])[a]);
                if (str[l] == "  ") { usable.Add(l); }
            }
            for (int a = 0; a < w.Split(",".ToCharArray()[0]).Length; a++)
            {
                int l = int.Parse(w.Split(",".ToCharArray()[0])[a]);
                allusable.Add(l);
            }
            int num = k;
            while (usable.Count != 0)
            {
                prin(str, usable, allusable, num);
                Console.Write("Numeri utilizzabili:");
                for (int a = 0; a < usable.Count; a++)
                {
                    Console.Write(" {0}", usable[a] + 1);
                }
                Console.WriteLine(".\n");
                while (true)
                {
                    int k1 = 0;
                    try
                    {
                        Console.Write("Inserisci numero: ");
                        num = int.Parse(Console.ReadLine());
                        num--;
                        if (num > -1 && num < 49 && usable.Contains(num)) { break; }
                        else { int h = 6 / k1; }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Numero invalido.");
                        Console.ReadLine(); prin(str, usable, allusable, num);
                        Console.Write("Numeri utilizzabili:");
                        for (int a = 0; a < usable.Count; a++)
                        {
                            Console.Write(" {0}", usable[a] + 1);
                        }
                        Console.WriteLine(".\n");
                    }
                }
                nn++;
                str[num] = nn < 10 ? "0" + nn.ToString() : nn.ToString();
                usable.Clear();

                for (int a = 0; a < where(num).Split(",".ToCharArray()[0]).Length; a++)
                {
                    int l = int.Parse(where(num).Split(",".ToCharArray()[0])[a]);
                    if (str[l] == "  ") { usable.Add(l); }
                }
                allusable.Clear();
                for (int a = 0; a < where(num).Split(",".ToCharArray()[0]).Length; a++)
                {
                    int l = int.Parse(where(num).Split(",".ToCharArray()[0])[a]);
                    allusable.Add(l);
                }
            }
            prin(str, usable, allusable, num);
            if (str.Contains("  "))
            {
                Console.WriteLine("Hai perso dopo {0} mosse", nn);
            }
            else { Console.WriteLine("Hai vinto."); }

            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void tile()
        {
            while (true) { Console.Clear(); tile1(); }
        }
    }
}