using System;

namespace ita
{
    public static class TrisPc
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

        public static void trispc1()
        {
            Random rnd = new Random();
            bool who = true;
            int who1 = rnd.Next(2);
            if (who1 == 1) { who = false; }
            if (who) { Console.Write("Inizia il giocatore"); Console.ReadLine(); }
            else { Console.Write("Inizia il computer"); Console.ReadLine(); }

            string[] list = new string[] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            while (true)
            {
                if (who)
                {
                    prinScheme(list, true);
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
                prinScheme(list, false);
                if (list[6] == "X" && list[3] == "X" && list[0] == "X") { Console.WriteLine("Il giocatore ha vinto!"); break; }
                else if (list[7] == "X" && list[4] == "X" && list[1] == "X") { Console.WriteLine("Il giocatore ha vinto!"); break; }
                else if (list[8] == "X" && list[5] == "X" && list[2] == "X") { Console.WriteLine("Il giocatore ha vinto!"); break; }
                else if (list[0] == "X" && list[1] == "X" && list[2] == "X") { Console.WriteLine("Il giocatore ha vinto!"); break; }
                else if (list[3] == "X" && list[4] == "X" && list[5] == "X") { Console.WriteLine("Il giocatore ha vinto!"); break; }
                else if (list[6] == "X" && list[7] == "X" && list[8] == "X") { Console.WriteLine("Il giocatore ha vinto!"); break; }
                else if (list[6] == "X" && list[4] == "X" && list[2] == "X") { Console.WriteLine("Il giocatore ha vinto!"); break; }
                else if (list[8] == "X" && list[4] == "X" && list[0] == "X") { Console.WriteLine("Il giocatore ha vinto!"); break; }
                else if (list[0] != " " && list[1] != " " && list[2] != " "
                    && list[3] != " " && list[4] != " " && list[5] != " "
                    && list[6] != " " && list[7] != " " && list[8] != " ")
                { Console.WriteLine("Pareggio"); break; }

                if (list[0] == "O" && list[1] == "O" && list[2] == " ") { list[2] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[0] == "O" && list[2] == "O" && list[1] == " ") { list[1] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[1] == "O" && list[2] == "O" && list[0] == " ") { list[0] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[3] == "O" && list[4] == "O" && list[5] == " ") { list[5] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[4] == "O" && list[5] == "O" && list[3] == " ") { list[3] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[3] == "O" && list[5] == "O" && list[4] == " ") { list[4] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[6] == "O" && list[7] == "O" && list[8] == " ") { list[8] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[8] == "O" && list[7] == "O" && list[6] == " ") { list[6] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[8] == "O" && list[6] == "O" && list[7] == " ") { list[7] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                //-------------------------------------------------------------------
                else if (list[6] == "O" && list[3] == "O" && list[0] == " ") { list[0] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[6] == "O" && list[0] == "O" && list[3] == " ") { list[3] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[0] == "O" && list[3] == "O" && list[6] == " ") { list[6] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[7] == "O" && list[4] == "O" && list[1] == " ") { list[1] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[4] == "O" && list[1] == "O" && list[7] == " ") { list[7] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[7] == "O" && list[1] == "O" && list[4] == " ") { list[4] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[8] == "O" && list[5] == "O" && list[2] == " ") { list[2] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[2] == "O" && list[8] == "O" && list[5] == " ") { list[5] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[2] == "O" && list[5] == "O" && list[8] == " ") { list[8] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                //-------------------------------------------------------------------
                else if (list[6] == "O" && list[4] == "O" && list[2] == " ") { list[2] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[6] == "O" && list[2] == "O" && list[4] == " ") { list[4] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[2] == "O" && list[4] == "O" && list[6] == " ") { list[6] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[8] == "O" && list[4] == "O" && list[0] == " ") { list[0] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[4] == "O" && list[0] == "O" && list[8] == " ") { list[8] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                else if (list[8] == "O" && list[0] == "O" && list[4] == " ") { list[4] = "O"; Console.WriteLine("Il computer ha vinto!"); break; }
                //---------------------------Perdita------------------------------
                else if (list[0] == "X" && list[1] == "X" && list[2] == " ") { list[2] = "O"; }
                else if (list[0] == "X" && list[2] == "X" && list[1] == " ") { list[1] = "O"; }
                else if (list[1] == "X" && list[2] == "X" && list[0] == " ") { list[0] = "O"; }
                else if (list[3] == "X" && list[4] == "X" && list[5] == " ") { list[5] = "O"; }
                else if (list[4] == "X" && list[5] == "X" && list[3] == " ") { list[3] = "O"; }
                else if (list[3] == "X" && list[5] == "X" && list[4] == " ") { list[4] = "O"; }
                else if (list[6] == "X" && list[7] == "X" && list[8] == " ") { list[8] = "O"; }
                else if (list[8] == "X" && list[7] == "X" && list[6] == " ") { list[6] = "O"; }
                else if (list[8] == "X" && list[6] == "X" && list[7] == " ") { list[7] = "O"; }
                //-------------------------------------------------------------------
                else if (list[6] == "X" && list[3] == "X" && list[0] == " ") { list[0] = "O"; }
                else if (list[6] == "X" && list[0] == "X" && list[3] == " ") { list[3] = "O"; }
                else if (list[0] == "X" && list[3] == "X" && list[6] == " ") { list[6] = "O"; }
                else if (list[7] == "X" && list[4] == "X" && list[1] == " ") { list[1] = "O"; }
                else if (list[4] == "X" && list[1] == "X" && list[7] == " ") { list[7] = "O"; }
                else if (list[7] == "X" && list[1] == "X" && list[4] == " ") { list[4] = "O"; }
                else if (list[8] == "X" && list[5] == "X" && list[2] == " ") { list[2] = "O"; }
                else if (list[2] == "X" && list[8] == "X" && list[5] == " ") { list[5] = "O"; }
                else if (list[2] == "X" && list[5] == "X" && list[8] == " ") { list[8] = "O"; }
                //-------------------------------------------------------------------
                else if (list[6] == "X" && list[4] == "X" && list[2] == " ") { list[2] = "O"; }
                else if (list[6] == "X" && list[2] == "X" && list[4] == " ") { list[4] = "O"; }
                else if (list[2] == "X" && list[4] == "X" && list[6] == " ") { list[6] = "O"; }
                else if (list[8] == "X" && list[4] == "X" && list[0] == " ") { list[0] = "O"; }
                else if (list[4] == "X" && list[0] == "X" && list[8] == " ") { list[8] = "O"; }
                else if (list[8] == "X" && list[0] == "X" && list[4] == " ") { list[4] = "O"; }
                else
                {
                    while (true)
                    {
                        int k = rnd.Next(9);
                        if (list[k] == " ") { list[k] = "O"; break; }
                    }
                }
                if (list[0] != " " && list[1] != " " && list[2] != " "
                    && list[3] != " " && list[4] != " " && list[5] != " "
                    && list[6] != " " && list[7] != " " && list[8] != " ")
                { Console.WriteLine("Pareggio"); break; }
            }
            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void trispc()
        {
            while (true) { Console.Clear(); trispc1(); }
        }
    }
}