using System;

namespace ita
{
    public static class TrisPl
    {
        private static void prinScheme(string[] list, bool other)
        {
            Console.Write(" {0}|{1}|{2}", list[6], list[7], list[8]);
            if (other) { Console.Write("    7|8|9"); }
            Console.Write("\n -----");
            if (other) { Console.Write("    -----"); }
            Console.Write("\n {0}|{1}|{2}", list[3], list[4], list[5]);
            if (other) { Console.Write("    4|5|6"); }
            Console.Write("\n -----");
            if (other) { Console.Write("    -----"); }
            Console.Write("\n {0}|{1}|{2}", list[0], list[1], list[2]);
            if (other) { Console.Write("    1|2|3"); }
            Console.WriteLine("\n");
            Console.ReadLine();
            Console.Clear();
        }

        public static void trispl1()
        {
            Random rnd = new Random();
            bool who = true;
            int who1 = rnd.Next(2);
            if (who1 == 1) { who = false; }
            if (who) { Console.Write("Inizia il giocatore 1"); Console.ReadLine(); }
            else { Console.Write("Inizia il giocatore 2"); Console.ReadLine(); }

            string[] list = new string[] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            prinScheme(list, true);
            while (true)
            {
                if (who)
                {
                    int where;
                    while (true)
                    {
                        try
                        {
                            Console.Write("Inserici dove inserire la X: ");
                            where = int.Parse(Console.ReadLine());
                            if (where > 0 && where < 10 && list[where - 1] == " ")
                            {
                                break;
                            }
                        }
                        catch (Exception) { }
                    }
                    where--;
                    list[where] = "X";
                }
                who = true;
                prinScheme(list, true);
                if (list[6] == "X" && list[3] == "X" && list[0] == "X") { Console.WriteLine("Il giocatore 1 ha vinto!"); break; }
                else if (list[7] == "X" && list[4] == "X" && list[1] == "X") { Console.WriteLine("Il giocatore 1 ha vinto!"); break; }
                else if (list[8] == "X" && list[5] == "X" && list[2] == "X") { Console.WriteLine("Il giocatore 1 ha vinto!"); break; }
                else if (list[0] == "X" && list[1] == "X" && list[2] == "X") { Console.WriteLine("Il giocatore 1 ha vinto!"); break; }
                else if (list[3] == "X" && list[4] == "X" && list[5] == "X") { Console.WriteLine("Il giocatore 1 ha vinto!"); break; }
                else if (list[6] == "X" && list[7] == "X" && list[8] == "X") { Console.WriteLine("Il giocatore 1 ha vinto!"); break; }
                else if (list[6] == "X" && list[4] == "X" && list[2] == "X") { Console.WriteLine("Il giocatore 1 ha vinto!"); break; }
                else if (list[8] == "X" && list[4] == "X" && list[0] == "X") { Console.WriteLine("Il giocatore 1 ha vinto!"); break; }
                else if (list[0] != " " && list[1] != " " && list[2] != " "
                    && list[3] != " " && list[4] != " " && list[5] != " "
                    && list[6] != " " && list[7] != " " && list[8] != " ")
                { Console.WriteLine("Pareggio"); break; }

                int where1;
                while (true)
                {
                    try
                    {
                        Console.Write("Inserici dove inserire la O: ");
                        where1 = int.Parse(Console.ReadLine());
                        if (where1 > 0 && where1 < 10 && list[where1 - 1] == " ")
                        {
                            break;
                        }
                    }
                    catch (Exception) { }
                }
                where1--;
                list[where1] = "O";

                prinScheme(list, true);
                if (list[6] == "O" && list[3] == "O" && list[0] == "O") { Console.WriteLine("Il giocatore 2 ha vinto!"); break; }
                else if (list[7] == "O" && list[4] == "O" && list[1] == "O") { Console.WriteLine("Il giocatore 2 ha vinto!"); break; }
                else if (list[8] == "O" && list[5] == "O" && list[2] == "O") { Console.WriteLine("Il giocatore 2 ha vinto!"); break; }
                else if (list[0] == "O" && list[1] == "O" && list[2] == "O") { Console.WriteLine("Il giocatore 2 ha vinto!"); break; }
                else if (list[3] == "O" && list[4] == "O" && list[5] == "O") { Console.WriteLine("Il giocatore 2 ha vinto!"); break; }
                else if (list[6] == "O" && list[7] == "O" && list[8] == "O") { Console.WriteLine("Il giocatore 2 ha vinto!"); break; }
                else if (list[6] == "O" && list[4] == "O" && list[2] == "O") { Console.WriteLine("Il giocatore 2 ha vinto!"); break; }
                else if (list[8] == "O" && list[4] == "O" && list[0] == "O") { Console.WriteLine("Il giocatore 2 ha vinto!"); break; }
                else if (list[0] != " " && list[1] != " " && list[2] != " "
                    && list[3] != " " && list[4] != " " && list[5] != " "
                    && list[6] != " " && list[7] != " " && list[8] != " ")
                { Console.WriteLine("Pareggio"); break; }
            }
            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void trispl()
        {
            while (true) { Console.Clear(); trispl1(); }
        }
    }
}