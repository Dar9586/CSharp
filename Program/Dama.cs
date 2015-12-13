using System;
using System.Collections.Generic;
using System.Text;

namespace ita
{
    public static class Dama
    {
        private static int whereUpRight(int a)
        {
            switch (a)
            {
                case 4: return 1;
                case 5: return 2;
                case 6: return 3;
                case 8: return 4;
                case 9: return 5;
                case 10: return 6;
                case 11: return 7;
                case 12: return 9;
                case 13: return 10;
                case 14: return 11;
                case 16: return 12;
                case 17: return 13;
                case 18: return 14;
                case 19: return 15;
                case 20: return 17;
                case 21: return 18;
                case 22: return 19;
                case 24: return 20;
                case 25: return 21;
                case 26: return 22;
                case 27: return 23;
                case 28: return 25;
                case 29: return 26;
                case 30: return 27;
                default: return 99;
            }
        }

        private static int whereUpLeft(int a)
        {
            switch (a)
            {
                case 4: return 0;
                case 5: return 1;
                case 6: return 2;
                case 7: return 3;
                case 9: return 4;
                case 10: return 5;
                case 11: return 6;
                case 12: return 8;
                case 13: return 9;
                case 14: return 10;
                case 15: return 11;
                case 17: return 12;
                case 18: return 13;
                case 19: return 14;
                case 20: return 16;
                case 21: return 17;
                case 22: return 18;
                case 23: return 19;
                case 25: return 20;
                case 26: return 21;
                case 27: return 22;
                case 28: return 24;
                case 29: return 25;
                case 30: return 26;
                case 31: return 27;
                default: return 99;
            }
        }

        private static int whereDownRight(int a)
        {
            switch (a)
            {
                case 0: return 4;
                case 1: return 5;
                case 2: return 6;
                case 3: return 7;
                case 4: return 9;
                case 5: return 10;
                case 6: return 11;
                case 8: return 12;
                case 9: return 13;
                case 10: return 14;
                case 11: return 15;
                case 12: return 17;
                case 13: return 18;
                case 14: return 19;
                case 16: return 20;
                case 17: return 21;
                case 18: return 22;
                case 19: return 23;
                case 20: return 25;
                case 21: return 26;
                case 22: return 27;
                case 24: return 28;
                case 25: return 29;
                case 26: return 30;
                case 27: return 31;
                default: return 99;
            }
        }

        private static int whereDownLeft(int a)
        {
            switch (a)
            {
                case 1: return 4;
                case 2: return 5;
                case 3: return 6;
                case 4: return 8;
                case 5: return 9;
                case 6: return 10;
                case 7: return 11;
                case 9: return 12;
                case 10: return 13;
                case 11: return 14;
                case 12: return 16;
                case 13: return 17;
                case 14: return 18;
                case 15: return 19;
                case 17: return 20;
                case 18: return 21;
                case 19: return 22;
                case 20: return 24;
                case 21: return 25;
                case 22: return 26;
                case 23: return 27;
                case 25: return 28;
                case 26: return 29;
                case 27: return 30;
                default: return 99;
            }
        }

        

        private static void prin(List<string> list, int num, int can, List<int> usab)
        {
            if (can != 3) { Console.Clear(); }
            List<string> str = new List<string>();
            for (int a = 0; a < 32; a++)
            {
                if (can == 1)
                {
                    if (list[a] != "  " && list[a] != "O " && list[a] != "OO")
                    {
                        if ((a + 1) < 10) { str.Add("0" + (a + 1).ToString()); }
                        else { str.Add((a + 1).ToString()); }
                    }
                    else { str.Add("  "); }
                }
                else if (can == 2)
                {
                    if (list[a] != "  " && list[a] != "X " && list[a] != "XX")
                    {
                        if ((a + 1) < 10) { str.Add("0" + (a + 1).ToString()); }
                        else { str.Add((a + 1).ToString()); }
                    }
                    else { str.Add("  "); }
                }
                else if (can == 3) { if (usab.Contains(a)) { str.Add((a + 1).ToString()); } else { str.Add("  "); } }
            }
            int h = 0;
            for (int b = 0; b < 8; b++)
            {
                if (b == 0)
                {
                    Console.Write("┌--┬--┬--┬--┬--┬--┬--┬--┐        ");
                    if (can != 4)
                    {
                        Console.WriteLine("┌--┬--┬--┬--┬--┬--┬--┬--┐");
                    }
                    else { Console.WriteLine(); }
                }
                for (int a = 0; a < 4; a++)
                {
                    if (b % 2 == 0)
                    {
                        Console.Write("|");
                        if (num == a + h) { Console.ForegroundColor = ConsoleColor.Green; }
                        Console.Write(list[a + h]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("|  ");
                    }

                    if (b % 2 == 1)
                    {
                        Console.Write("|  ");
                        Console.Write("|");
                        if (num == a + h) { Console.ForegroundColor = ConsoleColor.Green; }
                        Console.Write(list[a + h]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                Console.Write("|        ");
                if (can != 4)
                {
                    for (int a = 0; a < 4; a++)
                    {
                        if (b % 2 == 0)
                        {
                            Console.Write("|{0}|  ", str[a + h]);
                        }
                        if (b % 2 == 1)
                        {
                            Console.Write("|  |{0}", str[a + h]);
                        }
                    }
                    Console.WriteLine("|");
                }
                else { Console.WriteLine(); }

                if (b == 7)
                {
                    Console.Write("└--┴--┴--┴--┴--┴--┴--┴--┘        ");
                    if (can != 4)
                    {
                        Console.WriteLine("└--┴--┴--┴--┴--┴--┴--┴--┘");
                    }
                    else { Console.WriteLine(); }
                }
                else
                {
                    Console.Write("├--┼--┼--┼--┼--┼--┼--┼--┤        ");
                    if (can != 4)
                    {
                        Console.WriteLine("├--┼--┼--┼--┼--┼--┼--┼--┤");
                    }
                    else { Console.WriteLine(); }
                }

                h += 4;
            }
        }

        public static void dam1()
        {
            List<string> list = new List<string>();
            for (int a = 0; a < 32; a++)
            {
				
                if (a < 12) { list.Add("O "); }
                else if (a < 20) { list.Add("  "); }
                else { list.Add("X "); }
            }
            int turn = 0;
            int who = 0;
            int num;
            while (true)
            {
                List<int> usable = new List<int>();
                List<int> where = new List<int>();
                List<bool> eat = new List<bool>();
                int ul, ur, dl, dr;
                for (int l = 0; l < 4; l++) { eat.Add(false); }
                while (true)
                {
                    prin(list, -1, 1, usable);
                    Console.Write("Inserire quale pedina muovere X: ");
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                        num--;
                        ul = whereUpLeft(num);
                        ur = whereUpRight(num);
                        dl = whereDownLeft(num);
                        dr = whereDownRight(num);
                        if (ul != 99)
                        {
                            if (list[ul] == "  ") { where.Add(ul); }
                            else if (list[ul] == "X " || list[ul] == "XX") { where.Add(-1); }
                            else if (list[ul] == "O " || list[ul] == "OO")
                            {
                                if (whereUpLeft(ul) != 99 && list[whereUpLeft(ul)] == "  ")
                                {
                                    eat[0] = true; where.Add(whereUpLeft(ul));
                                }
                                else { where.Add(-1); }
                            }
                        }
                        else { where.Add(-1); }
                        if (ur != 99)
                        {
                            if (list[ur] == "  ") { where.Add(ur); }
                            else if (list[ur] == "X " || list[ur] == "XX") { where.Add(-1); }
                            else if (list[ur] == "O " || list[ur] == "OO")
                            {
                                if (whereUpRight(ur) != 99 && list[whereUpRight(ur)] == "  ")
                                {
                                    eat[1] = true; where.Add(whereUpRight(ur));
                                }
                                else { where.Add(-1); }
                            }
                        }
                        else { where.Add(-1); }
                        if (dl != 99 && list[num] == "XX")
                        {
                            if (list[dl] == "  ") { where.Add(dl); }
                            else if (list[dl] == "X " || list[dl] == "XX") { where.Add(-1); }
                            else if (list[dl] == "O " || list[dl] == "OO")
                            {
                                if (whereDownLeft(dl) != 99 && list[whereDownLeft(dl)] == "  ")
                                {
                                    eat[2] = true; where.Add(whereDownLeft(dl));
                                }
                                else { where.Add(-1); }
                            }
                        }
                        else { where.Add(-1); }
                        if (dr != 99 && list[num] == "XX")
                        {
                            if (list[dr] == "  ") { where.Add(dr); }
                            else if (list[dr] == "X " || list[dr] == "XX") { where.Add(-1); }
                            else if (list[dr] == "O " || list[dr] == "OO")
                            {
                                if (whereDownRight(dr) != 99 && list[whereDownRight(dr)] == "  ")
                                {
                                    eat[3] = true; where.Add(whereDownRight(dr));
                                }
                                else { where.Add(-1); }
                            }
                        }
                        else { where.Add(-1); }
                        bool ok = false;
                        for (int a = 0; a < 4; a++)
                        {
                            if (where[a] != -1) { ok = true; break; }
                        }
                        if (ok)
                        {
                            if (list[num] == "X " || list[num] == "XX")
                            {
                                break;
                            }
                            else { Console.WriteLine("Numero non valido."); }
                        }
                        else { Console.WriteLine("La pedina non può muoversi."); }
                        Console.ReadLine();
                    }
                    catch (Exception)
                    {
                    }
                }
                int num1;
                while (true)
                {
                    Console.Clear();
                    Console.Write("Numeri utilizzabili: ");
                    if (eat.Contains(true))
                    {
                        for (int a = 0; a < 4; a++)
                        {
                            if (eat[a])
                            {
                                Console.Write("{0} ", where[a] + 1);
                                usable.Add(where[a]);
                            }
                        }
                    }
                    else
                    {
                        for (int a = 0; a < 4; a++)
                        {
                            if (where[a] != -1)
                            {
                                Console.Write("{0} ", where[a] + 1);
                                usable.Add(where[a]);
                            }
                        }
                    }
                    Console.WriteLine();
                    prin(list, num, 3, usable);

                    Console.Write("Scegli dove andare:");
					try{num1 = int.Parse(Console.ReadLine());}catch(Exception){num1=0;}
                    num1--;
                    if (usable.Contains(num1)) { break; }
                }

                if (eat.Contains(true))
                {
                    if (num1 == whereUpLeft(ul)) { list[ul] = "  "; list[num1] = list[num]; list[num] = "  "; }
                    else if (num1 == whereUpRight(ur)) { list[ur] = "  "; list[num1] = list[num]; list[num] = "  "; }
                    else if (num1 == whereDownLeft(dl)) { list[dl] = "  "; list[num1] = list[num]; list[num] = "  "; }
                    else if (num1 == whereDownRight(dr)) { list[dr] = "  "; list[num1] = list[num]; list[num] = "  "; }
                }
                else
                {
                    if (num1 == ul) { list[num1] = list[num]; list[num] = "  "; }
                    else if (num1 == ur) { list[num1] = list[num]; list[num] = "  "; }
                    else if (num1 == dl) { list[num1] = list[num]; list[num] = "  "; }
                    else if (num1 == dr) { list[num1] = list[num]; list[num] = "  "; }
                }
                for (int a = 0; a < 4; a++) { if (list[a] == "X ") { list[a] = "XX"; } }
                prin(list, -1, 4, usable);
                Console.ReadLine();

                usable.Clear();
                where.Clear();
                eat.Clear();
                for (int l = 0; l < 4; l++) { eat.Add(false); }

                while (true)
                {
                    prin(list, -1, 2, usable);
                    Console.Write("Inserire quale pedina muovere O: ");
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                        num--;
                        ul = whereUpLeft(num);
                        ur = whereUpRight(num);
                        dl = whereDownLeft(num);
                        dr = whereDownRight(num);
                        if (ul != 99 && list[num] == "OO")
                        {
                            if (list[ul] == "  ") { where.Add(ul); }
                            else if (list[ul] == "O " || list[ul] == "OO") { where.Add(-1); }
                            else if (list[ul] == "X " || list[ul] == "XX")
                            {
                                if (whereUpLeft(ul) != 99 && list[whereUpLeft(ul)] == "  ")
                                {
                                    eat[0] = true; where.Add(whereUpLeft(ul));
                                }
                                else { where.Add(-1); }
                            }
                        }
                        else { where.Add(-1); }
                        if (ur != 99 && list[num] == "OO")
                        {
                            if (list[ur] == "  ") { where.Add(ur); }
                            else if (list[ur] == "O " || list[ur] == "OO") { where.Add(-1); }
                            else if (list[ur] == "x " || list[ur] == "XX")
                            {
                                if (whereUpRight(ur) != 99 && list[whereUpRight(ur)] == "  ")
                                {
                                    eat[1] = true; where.Add(whereUpRight(ur));
                                }
                                else { where.Add(-1); }
                            }
                        }
                        else { where.Add(-1); }
                        if (dl != 99)
                        {
                            if (list[dl] == "  ") { where.Add(dl); }
                            else if (list[dl] == "O " || list[dl] == "OO") { where.Add(-1); }
                            else if (list[dl] == "X " || list[dl] == "XX")
                            {
                                if (whereDownLeft(dl) != 99 && list[whereDownLeft(dl)] == "  ")
                                {
                                    eat[2] = true; where.Add(whereDownLeft(dl));
                                }
                                else { where.Add(-1); }
                            }
                        }
                        else { where.Add(-1); }
                        if (dr != 99)
                        {
                            if (list[dr] == "  ") { where.Add(dr); }
                            else if (list[dr] == "O " || list[dr] == "OO") { where.Add(-1); }
                            else if (list[dr] == "X " || list[dr] == "XX")
                            {
                                if (whereDownRight(dr) != 99 && list[whereDownRight(dr)] == "  ")
                                {
                                    eat[3] = true; where.Add(whereDownRight(dr));
                                }
                                else { where.Add(-1); }
                            }
                        }
                        else { where.Add(-1); }
                        bool ok = false;
                        for (int a = 0; a < 4; a++)
                        {
                            if (where[a] != -1) { ok = true; break; }
                        }
                        if (ok)
                        {
                            if (list[num] == "O " || list[num] == "OO")
                            {
                                break;
                            }
                            else { Console.WriteLine("Numero non valido."); }
                        }
                        else { Console.WriteLine("La pedina non può muoversi."); }
                        Console.ReadLine();
                    }
                    catch (Exception)
                    {
                    }
                }
                while (true)
                {
                    Console.Clear();
                    Console.Write("Numeri utilizzabili: ");
                    if (eat.Contains(true))
                    {
                        for (int a = 0; a < 4; a++)
                        {
                            if (eat[a])
                            {
                                Console.Write("{0} ", where[a] + 1);
                                usable.Add(where[a]);
                            }
                        }
                    }
                    else
                    {
                        for (int a = 0; a < 4; a++)
                        {
                            if (where[a] != -1)
                            {
                                Console.Write("{0} ", where[a] + 1);
                                usable.Add(where[a]);
                            }
                        }
                    }
                    Console.WriteLine();
                    prin(list, num, 3, usable);

                    Console.Write("Scegli dove andare:");
                    num1 = int.Parse(Console.ReadLine());
                    num1--;
                    if (usable.Contains(num1)) { break; }
                }

                if (eat.Contains(true))
                {
                    if (num1 == whereUpLeft(ul)) { list[ul] = "  "; list[num1] = list[num]; list[num] = "  "; }
                    else if (num1 == whereUpRight(ur)) { list[ur] = "  "; list[num1] = list[num]; list[num] = "  "; }
                    else if (num1 == whereDownLeft(dl)) { list[dl] = "  "; list[num1] = list[num]; list[num] = "  "; }
                    else if (num1 == whereDownRight(dr)) { list[dr] = "  "; list[num1] = list[num]; list[num] = "  "; }
                }
                else
                {
                    if (num1 == ul) { list[num1] = list[num]; list[num] = "  "; }
                    else if (num1 == ur) { list[num1] = list[num]; list[num] = "  "; }
                    else if (num1 == dl) { list[num1] = list[num]; list[num] = "  "; }
                    else if (num1 == dr) { list[num1] = list[num]; list[num] = "  "; }
                }
                for (int a = 28; a < 32; a++) { if (list[a] == "O ") { list[a] = "OO"; } }
                prin(list, -1, 4, usable);

                Console.ReadLine();
                if (!list.Contains("X ") && !list.Contains("XX")) { who = 1; break; }
                if (!list.Contains("O ") && !list.Contains("OO")) { who = 2; break; }
                if (turn == 30) { who = 3; break; }
            }
            if (who == 1) { Console.WriteLine("Il computer ha vinto."); }
            if (who == 2) { Console.WriteLine("Il giocatore ha vinto."); }
            if (who == 3) { Console.WriteLine("I giocatori hanno pareggiato."); }

            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void dam()
        {
            while (true) { Console.Clear(); dam1(); }
        }
    }
}