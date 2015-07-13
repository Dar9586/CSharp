using System;
using System.Collections.Generic;
using System.Text;

namespace ita
{
    public static class BlackJack
    {
        private static int check(List<int> list, List<int> val, bool ok)
        {
            val.Sort();
            int num = 0;
            for (int a = 0; a < val.Count; a++)
            {
                num += val[a];
            }
            if (num > 21)
            {
                if (val[val.Count - 1] == 11)
                {
                    val[val.Count - 1] = 1;
                    return check(list, val, true);
                }
            }
            if (ok)
            {
                if (num == 21 && val.Count == 2)
                {
                    return -5;
                }
                else if (num > 21)
                {
                    return -1;
                }
                else if (num == 21)
                {
                    return -2;
                }
                else
                {
                    return num;
                }
            }
            else
            {
                return num;
            }
        }

        private static void prinAll(List<int> lis, List<int> lis1, bool show, List<int> val, List<int> val1)
        {
            Console.Clear();
            prin(lis);
            Console.WriteLine("\nTotale: {0}", check(lis, val, false));
            Console.WriteLine("\n-------------------------------\n");
            if (show)
            {
                prin(lis1);
                Console.WriteLine("\nTotale: {0}", check(lis1, val1, false));
            }
            else
            {
                Console.WriteLine("1. ???????????????\n2. ???????????????\nTotale: ??");
            }
            Console.WriteLine("\n\n");
        }

        private static void prin(List<int> lis)
        {
            for (int a = 0; a < lis.Count; a++)
            {
                StringBuilder str = new StringBuilder();
                str.Append((a + 1).ToString() + ". ");
                if (lis[a] % 13 == 0)
                {
                    str.Append("Asso");
                }
                else if (lis[a] % 13 == 10)
                {
                    str.Append("Jack");
                }
                else if (lis[a] % 13 == 11)
                {
                    str.Append("Regina");
                }
                else if (lis[a] % 13 == 12)
                {
                    str.Append("Re");
                }
                else
                {
                    str.Append((lis[a] % 13) + 1);
                }

                str.Append(" di ");
                if ((int)lis[a] / 13 == 0)
                {
                    str.Append("Cuori ");
                }
                if ((int)lis[a] / 13 == 1)
                {
                    str.Append("Picche ");
                }
                if ((int)lis[a] / 13 == 2)
                {
                    str.Append("Quadri ");
                }
                if ((int)lis[a] / 13 == 3)
                {
                    str.Append("Fiori ");
                }
                List<int> ten = new List<int> { 10, 11, 112, 23, 24, 25, 36, 37, 38, 49, 50, 51 };
                if (lis[a] == 0 || lis[a] == 13 || lis[a] == 26 || lis[a] == 39)
                {
                    str.Append("(11 o 1).");
                }
                else if (ten.Contains(lis[a]))
                {
                    str.Append("(10).");
                }
                else
                {
                    str.Append("(" + ((lis[a] % 13) + 1) + ").");
                }
                Console.WriteLine(str);
            }
        }

        public static void jack1()
        {
            List<int> list = new List<int>();
            for (int a = 0; a < 52; a++)
            {
                list.Add(a);
            }
            List<int> val = new List<int>();
            for (int a = 0; a < 4; a++)
            {
                val.Add(11);
                val.Add(2);
                val.Add(3);
                val.Add(4);
                val.Add(5);
                val.Add(6);
                val.Add(7);
                val.Add(8);
                val.Add(9);
                val.Add(10);
                val.Add(10);
                val.Add(10);
                val.Add(10);
            }
            Random rnd = new Random();
            List<int> user = new List<int>();
            List<int> comp = new List<int>();
            List<int> valuser = new List<int>();
            List<int> valcomp = new List<int>();
            for (int a = 0; a < 2; a++)
            {
                int l = rnd.Next(list.Count);
                int k = list[l];
                user.Add(k);
                valuser.Add(val[k]);
                list.RemoveAt(l);
            }
            for (int a = 0; a < 2; a++)
            {
                int l = rnd.Next(list.Count);
                int k = list[l];
                comp.Add(k);
                valcomp.Add(val[k]);
                list.RemoveAt(l);
            }
            bool whoWin = true;
            bool five = true, go = true;
            if (check(user, valuser, true) != -5)
            {
                while (user.Count < 5)
                {
                    prinAll(user, comp, false, valuser, valcomp);
                    int num = 0;
                    while (true)
                    {
                        try
                        {
                            Console.Write("1 = Pesca\n2 = Passa\nScegli: ");
                            num = int.Parse(Console.ReadLine());
                            if (num > 0 && num < 3)
                            {
                                break;
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                    if (num == 1)
                    {
                        int l = rnd.Next(list.Count);
                        int k = list[l];
                        user.Add(k);
                        valuser.Add(val[k]);
                        list.RemoveAt(l);
                    }
                    else if (num == 2)
                    {
                        five = false;
                        break;
                    }
                    if (check(user, valuser, true) == -1)
                    {
                        prinAll(user, comp, false, valuser, valcomp);
                        go = false; Console.WriteLine("Hai sballato!"); five = false; Console.ReadLine();
                        break;
                    }
                    if (check(user, valuser, true) == -2)
                    {
                        prinAll(user, comp, false, valuser, valcomp);
                        five = false; Console.ReadLine();
                        break;
                    }
                }
            }
            else
            {
                five = false;
                Console.WriteLine("BlackJack per il giocatore");
                go = false; whoWin = false;
            }

            if (five)
            {
                Console.WriteLine("5 carte.");
                Console.ReadLine();
            }
            if (go)
            {
                while (true)
                {
                    prinAll(user, comp, true, valuser, valcomp);
                    if (check(user, valuser, true) < check(comp, valcomp, true) && check(user, valuser, true) != -2)
                    {
                        break;
                    }
                    else if (check(comp, valcomp, true) == -1)
                    {
                        whoWin = false;
                        break;
                    }
                    else if (check(comp, valcomp, true) == -5)
                    {
                        Console.WriteLine("BlackJack per il computer");
                        break;
                    }
                    else if (check(user, valuser, true) != -2 && check(comp, valcomp, true) == -2)
                    {
                        break;
                    }
                    else if (check(user, valuser, true) == -2 && check(comp, valcomp, true) == -2)
                    {
                        if (user.Count < comp.Count)
                        {
                            whoWin = false;
                        }
                        break;
                    }
                    else if (check(user, valuser, true) == check(comp, valcomp, true) && user.Count >= comp.Count)
                    {
                        break;
                    }
                    else if (check(user, valuser, true) == check(comp, valcomp, true) && user.Count < comp.Count)
                    {
                        int l = rnd.Next(list.Count);
                        int k = list[l];
                        comp.Add(k);
                        valcomp.Add(val[k]);
                        list.RemoveAt(l);
                        break;
                    }
                    else if (comp.Count > 5)
                    {
                        whoWin = false; break;
                    }
                    else
                    {
                        int l = rnd.Next(list.Count);
                        int k = list[l];
                        comp.Add(k);
                        valcomp.Add(val[k]);
                        list.RemoveAt(l);
                    }
                    Console.ReadLine();
                }
            }
            if (whoWin)
            {
                Console.WriteLine("Ha vinto il computer.");
            }
            else
            {
                Console.WriteLine("Ha vinto il giocatore.");
            }
            Console.ReadLine();
            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void jack()
        {
            while (true) { Console.Clear(); jack1(); }
        }
    }
}