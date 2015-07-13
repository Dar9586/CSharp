using System;
using System.Collections.Generic;
using System.Text;

namespace ita
{
    public static class Notazione
    {
        public static void nota1()
        {
            bool used = false;
            string num;
            while (true)
            {
                try
                {
                    bool usezero = true;
                    int h1 = 0;
                    Console.Write("Inserisci numero: ");
                    num = Console.ReadLine();
                    List<string> ch = new List<string>();
                    for (int a = 0; a < num.Length; a++)
                    {
                        ch.Add(num.ToCharArray()[a].ToString());
                    }
                    for (int a = 0; a < num.Length; a++)
                    {
                        if (ch[a] != "0" && ch[a] != ".") { usezero = false; }
                    }
                    if (usezero) { Console.WriteLine("0 = 0"); Console.ReadLine(); Console.Clear(); int h = 6 / h1; }
                    List<string> usable = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "." };
                    for (int a = 0; a < ch.Count; a++)
                    {
                        if (ch[a] == ".")
                        {
                            if (!used) { used = true; } else { Console.Write("Puoi inserire un solo punto."); Console.ReadLine(); int h = 6 / h1; }
                        }
                        if (!usable.Contains(ch[a]))
                        {
                            Console.Write("Puoi inserire solo numeri."); Console.ReadLine();
                            int h = 6 / h1;
                        }
                    }
                    break;
                }
                catch (DivideByZeroException)
                {
                }
            }

            StringBuilder str = new StringBuilder();
            str.Append(num.ToString());

            num = str.ToString();
            if (used)
            {
                while (true)
                {
                    if (str.ToString().ToCharArray()[0].ToString() == "0")
                    {
                        str.Remove(0, 1);
                    }
                    else { break; }
                }
                if (str.ToString().ToCharArray()[0].ToString() == ".")
                {
                    StringBuilder o = new StringBuilder();
                    o.Append("0");
                    o.Append(str.ToString());
                    str.Clear(); str.Append(o.ToString()); num = str.ToString();
                }

                if (int.Parse(num.ToCharArray()[0].ToString()) > 1)
                {
                    Console.WriteLine("\n" + num + " = " + num + "\n");
                }
                else
                {
                    StringBuilder s = new StringBuilder();
                    s.Append(num);
                    s.Remove(0, 2);
                    StringBuilder s1 = new StringBuilder();
                    s1.Append(s.ToString());
                    while (true)
                    {
                        if (s.ToString().ToCharArray()[0].ToString() == "0")
                        {
                            s.Remove(0, 1);
                        }
                        else { break; }
                    }
                    string use = s.ToString().Substring(0, 1) + "." + s.ToString().Substring(1, s.Length - 1);
                    int l = 0;
                    for (int a = 0; a < num.Length; a++)
                    {
                        if (num.ToCharArray()[a + 2].ToString() == "0")
                        {
                            l++;
                        }
                        else
                        {
                            l++; break;
                        }
                    }

                    string s3 = " * 10 ^ -" + (l).ToString();
                    for (int a = use.Length - 1; a > 0; a--)
                    {
                        if (use.ToCharArray()[use.Length - 1].ToString() == "0")
                        {
                            use = use.Substring(0, use.Length - 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (use.Length == 2)
                    {
                        Console.WriteLine("OK");
                        use = use.ToCharArray()[0].ToString();
                    }
                    try { if (use.Length > 10) { use = use.Substring(0, 7); use = use + "..."; } }
                    catch (Exception)
                    {
                    }
                    Console.WriteLine("\n" + num + " = " + use + s3 + "\n");
                }
            }
            else
            {
                while (true)
                {
                    if (str.ToString().ToCharArray()[0].ToString() == "0")
                    {
                        str.Remove(0, 1);
                    }
                    else { break; }
                }
                int k = 0;
                for (int a = str.Length - 1; a >= 0; a--)
                {
                    if (str.ToString().ToCharArray()[a].ToString() == "0")
                    {
                        k++;
                    }
                    else
                    {
                        break;
                    }
                }

                string use = str.ToString().Substring(0, 1) + "." + str.ToString().Substring(1, str.Length - k - 1);
                if (use.Length < 4)
                {
                    try
                    {
                        if (use.ToCharArray()[2].ToString() == "0") { use = str.ToString().ToCharArray()[0].ToString(); }
                    }
                    catch (IndexOutOfRangeException) { use = str.ToString().ToCharArray()[0].ToString(); }
                }
                try { if (use.Length > 10) { use = use.Substring(0, 7); use = use + "..."; } }
                catch (Exception)
                {
                }
                string s = " * 10 ^ " + (num.Length - 1).ToString();
                Console.WriteLine("\n" + num + " = " + use + s + "\n");
            }

            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void nota()
        {
            while (true) { Console.Clear(); nota1(); }
        }
    }
}