using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ita
{
    public static class Password
    {
        private static void met1()
        {
            Console.Clear();
            int num, upp, low, spe, len, how, save;
            String nume = "0123456789";
            String uppe = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String lowe = "abcdefghijklmnopqrstuvwxyz";
            String spec = "!#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~";
            string use;
            while (true)
            {
                Console.Write("Inserire numeri [1 = Si | 0 = No]: ");
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num > -1 && num < 2)
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
                Console.Write("Inserire lettere maiuscole [1 = Si | 0 = No]: ");
                try
                {
                    upp = int.Parse(Console.ReadLine());
                    if (upp > -1 && upp < 2)
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
                Console.Write("Inserire lettere minuscole [1 = Si | 0 = No]: ");
                try
                {
                    low = int.Parse(Console.ReadLine());
                    if (low > -1 && low < 2)
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
                Console.Write("Inserire caratteri speciali [1 = Si | 0 = No]: ");
                try
                {
                    spe = int.Parse(Console.ReadLine());
                    if (spe > -1 && spe < 2)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                }
            }
            Console.Write("Inserisci altri caratteri da aggiungere: ");
            use = Console.ReadLine();
            while (true)
            {
                Console.Write("Salvare le password generate [1 = Si | 0 = No]: ");
                try
                {
                    save = int.Parse(Console.ReadLine());
                    if (save > -1 && save < 2)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                }
            }
            string name = "";
            if (save == 1)
            {
                while (name.Length == 0 && !File.Exists(name))
                {
                    Console.Write("Inserisci nome file: ");
                    name = Console.ReadLine();
                }
                name = name + ".txt";
                var f = File.Create(name);
                f.Close();
            }
            while (true)
            {
                int sav = 74;
                if (save == 1) { sav = 999; }
                Console.Write("Inserisci lunghezza password [3 : {0}]: ", sav);
                try
                {
                    len = int.Parse(Console.ReadLine());
                    if (len > 2 && len < sav + 1)
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
                int sav = 295;
                if (save == 1) { sav = 9999; }
                Console.Write("Inserisci quante password generare [0 : {0}]: ", sav);
                try
                {
                    how = int.Parse(Console.ReadLine());
                    if (how > -1 && how < sav + 1)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                }
            }

            Console.Clear();
            StringBuilder str = new StringBuilder();
            Random rnd = new Random();
            for (int b = 0; b < how; b++)
            {
                str.Clear();
                while (str.Length < len)
                {
                    int k = rnd.Next(5);
                    if (k == 1 && num == 1)
                    {
                        int k1 = rnd.Next(nume.Length);
                        str.Append(nume.ToCharArray()[k1]);
                    }
                    else if (k == 2 && upp == 1)
                    {
                        int k1 = rnd.Next(uppe.Length);
                        str.Append(uppe.ToCharArray()[k1]);
                    }
                    else if (k == 3 && low == 1)
                    {
                        int k1 = rnd.Next(lowe.Length);
                        str.Append(lowe.ToCharArray()[k1]);
                    }
                    else if (k == 4 && spe == 1)
                    {
                        int k1 = rnd.Next(spec.Length);
                        str.Append(spec.ToCharArray()[k1]);
                    }
                    else if (k == 5 && use.Length != 0)
                    {
                        int k1 = rnd.Next(use.Length);
                        str.Append(use.ToCharArray()[k1]);
                    }
                }
                int l = how.ToString().Length;
                string s = "";
                for (int a = (b + 1).ToString().Length; a < l; a++)
                {
                    s = s + "0";
                }
                s = s + (b + 1).ToString();
                Console.WriteLine(s + ". " + str.ToString());
                if (save == 1)
                {
                    using (StreamWriter sw = File.AppendText(name))
                    {
                        sw.WriteLine(s + ". " + str.ToString());
                        sw.Close();
                    }
                }
            }
        }

        private static void met2()
        {
            Console.Clear();
            List<string> allowed = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "n", "u", "l", "s", "c", "o" };
            List<string> numer = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            String nume = "0123456789";
            String uppe = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String lowe = "abcdefghijklmnopqrstuvwxyz";
            String spec = "!#$%&\'()*+,-./:;<=>?@[\\]^_`{|}~";
            string use = "", sep = "";
            int how;
            Console.WriteLine("Inserisci schema:");
            Console.WriteLine("n = numeri");
            Console.WriteLine("u = lettere maiuscole");
            Console.WriteLine("l = lettere minuscole");
            Console.WriteLine("s = caratteri speciali");
            Console.WriteLine("c = caratteri personalizzati");
            Console.WriteLine("o = separatore");
            Console.WriteLine("Potete inserire un numero prima dello schema");
            Console.WriteLine("\nEs.    5nl creerà uno schema con 5 numeri e una lettera minuscola");
            Console.WriteLine("\n\nInserisci schema:");
            StringBuilder str = new StringBuilder();
            StringBuilder str1 = new StringBuilder();
            str1.Append(Console.ReadLine());
            bool user = false;
            bool oo = false;
            str.Append(str1.ToString().ToLower());
            for (int a = 0; a < str.Length; a++)
            {
                if (!allowed.Contains(str.ToString().ToCharArray()[a].ToString()))
                {
                    str.Remove(a, 1); a--;
                }
                if (str.ToString().ToCharArray()[a].ToString() == "c") { user = true; }
                if (str.ToString().ToCharArray()[a].ToString() == "o") { oo = true; }
            }
            if (user)
            {
                while (use.Length == 0)
                {
                    Console.Write("Inserisci altri caratteri da aggiungere: ");
                    use = Console.ReadLine();
                }
            }
            if (oo)
            {
                while (sep.Length == 0)
                {
                    Console.Write("Inserisci carattere separatore: ");
                    sep = Console.ReadLine();
                }
            }
            int save = 0;

            while (numer.Contains(str.ToString().ToCharArray()[str.Length - 1].ToString())) { str.Remove(str.Length - 1, 1); }
            while (true)
            {
                Console.Write("Salvare le password generate [1 = Si | 0 = No]: ");
                try
                {
                    save = int.Parse(Console.ReadLine());
                    if (save > -1 && save < 2)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                }
            }
            string name = "";
            if (save == 1)
            {
                while (name.Length == 0 && !File.Exists(name))
                {
                    Console.Write("Inserisci nome file: ");
                    name = Console.ReadLine();
                }
                name = name + ".txt";
                var f = File.Create(name);
                f.Close();
            }
            while (true)
            {
                int sav = 295;
                if (save == 1) { sav = 9999; }
                Console.Write("Inserisci quante password generare [1 : {0}]: ", sav);
                try
                {
                    how = int.Parse(Console.ReadLine());
                    if (how > 0 && how < sav + 1)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                }
            }
            int cache = 0;
            List<int> finalnum = new List<int>();
            List<string> finallet = new List<string>();
            for (int a = 0; a < str.Length; a++)
            {
                if (numer.Contains(str.ToString().ToCharArray()[a].ToString()))
                {
                    cache = int.Parse(cache.ToString() + str.ToString().ToCharArray()[a].ToString());
                }
                else
                {
                    if (cache != 0)
                    {
                        finalnum.Add(cache); cache = 0;
                    }
                    else { finalnum.Add(1); cache = 0; }
                }
            }
            for (int a = 0; a < str.Length; a++)
            {
                if (numer.Contains(str.ToString().ToCharArray()[a].ToString()))
                {
                    str.Remove(a, 1); a--;
                }
            }
            for (int a = 0; a < str.Length; a++)
            {
                finallet.Add(str.ToString().ToCharArray()[a].ToString());
            }
            Random rnd = new Random();
            StringBuilder str11 = new StringBuilder();
            for (int l = 0; l < how; l++)
            {
                str11.Clear();
                for (int b = 0; b < finalnum.Count; b++)
                {
                    for (int a = 0; a < finalnum[b]; a++)
                    {
                        string k = finallet[b];
                        if (k == "n")
                        {
                            str11.Append(nume.ToCharArray()[rnd.Next(nume.Length)]);
                        }
                        else if (k == "u")
                        {
                            str11.Append(uppe.ToCharArray()[rnd.Next(uppe.Length)]);
                        }
                        else if (k == "o")
                        {
                            str11.Append(sep);
                        }
                        else if (k == "l")
                        {
                            str11.Append(lowe.ToCharArray()[rnd.Next(lowe.Length)]);
                        }
                        else if (k == "s")
                        {
                            str11.Append(spec.ToCharArray()[rnd.Next(spec.Length)]);
                        }
                        else if (k == "c")
                        {
                            str11.Append(use.ToCharArray()[rnd.Next(use.Length)]);
                        }
                    }
                }
                if (l + 1 < 10)
                {
                    Console.WriteLine("00{0}. {1}", l + 1, str11);
                    if (save == 1)
                    {
                        using (StreamWriter sw = File.AppendText(name))
                        {
                            sw.WriteLine("00" + (l + 1).ToString() + ". " + str11.ToString());
                            sw.Close();
                        }
                    }
                }
                else if (l + 1 < 100)
                {
                    Console.WriteLine("0{0}. {1}", l + 1, str11);
                    if (save == 1)
                    {
                        using (StreamWriter sw = File.AppendText(name))
                        {
                            sw.WriteLine("0" + (l + 1).ToString() + ". " + str11.ToString());
                            sw.Close();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("{0}. {1}", l + 1, str11);
                    if (save == 1)
                    {
                        using (StreamWriter sw = File.AppendText(name))
                        {
                            sw.WriteLine((l + 1).ToString() + ". " + str11.ToString());
                            sw.Close();
                        }
                    }
                }
            }
        }

        private static void met3()
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            string[] str = Directory.GetFiles(path);
            List<string> list = new List<string>();
            for (int a = 0; a < str.Length; a++)
            {
                if (str[a].Substring(str[a].Length - 4) == ".txt")
                {
                    list.Add(str[a].Substring(path.Length + 1));
                }
            }
            bool used = false;
            int num = 0;
            for (int a = 0; a < list.Count; a++)
            {
                while (true)
                {
                    Console.Clear();
                    Console.Write("Utilizzare {0} come dizionario [1 = Si: 0 = No]: ", list[a]);
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                        if (num > -1 && num < 2)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                if (num == 1) { used = true; num = a; break; }
            }
            if (used)
            {
                string sep = "";
                while (true)
                {
                    Console.Write("Inserire separatore tra le parole [n = a capo]: ");
                    try
                    {
                        sep = Console.ReadLine();
                        if (sep.Length == 1)
                        {
                            break;
                        }
                        else { Console.WriteLine("1 carattere."); }
                    }
                    catch (Exception)
                    {
                    }
                }
                if (sep == "n") { sep = "\n"; }
                Console.Clear();
                string i = Path.Combine(path, list[num]);
                StreamReader sw = new StreamReader(i);
                string[] s = sw.ReadToEnd().Split(sep.ToCharArray()[0]);
                sw.Close();
                Console.WriteLine("Il dizionario contiene {0} parole.", s.Length);
                int save, len, how;
                while (true)
                {
                    Console.Write("Salvare le password generate [1 = Si | 0 = No]: ");
                    try
                    {
                        save = int.Parse(Console.ReadLine());
                        if (save > -1 && save < 2)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                string name = "";
                if (save == 1)
                {
                    while (name.Length == 0 && !File.Exists(name))
                    {
                        Console.Write("Inserisci nome file: ");
                        name = Console.ReadLine();
                    }
                    name = name + ".txt";
                    var f = File.Create(name);
                    f.Close();
                }
                while (true)
                {
                    int sav = 74;
                    if (save == 1) { sav = 999; }
                    Console.Write("Inserisci quante parole per password [3 : {0}]: ", sav);
                    try
                    {
                        len = int.Parse(Console.ReadLine());
                        if (len > 2 && len < sav + 1)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                string se;
                while (true)
                {
                    Console.Write("Inserisci separatore parole [1 carattere]: ");
                    try
                    {
                        se = Console.ReadLine();
                        if (se.Length == 1)
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
                    int sav = 295;
                    if (save == 1) { sav = 9999; }
                    Console.Write("Inserisci quante password generare [0 : {0}]: ", sav);
                    try
                    {
                        how = int.Parse(Console.ReadLine());
                        if (how > -1 && how < sav + 1)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }

                Console.Clear();
                Random rnd = new Random();
                StringBuilder str0 = new StringBuilder();
                for (int b = 0; b < how; b++)
                {
                    str0.Clear();
                    for (int a = 0; a < len; a++)
                    {
                        str0.Append(s[rnd.Next(s.Length)]);
                        if ((a + 1) < len)
                        {
                            str0.Append(se);
                        }
                    }
                    int l = how.ToString().Length;
                    string s1 = "";
                    for (int a = (b + 1).ToString().Length; a < l; a++)
                    {
                        s1 = s1 + "0";
                    }
                    s1 = s1 + (b + 1).ToString();
                    Console.WriteLine(s1 + ". " + str0.ToString());
                    if (save == 1)
                    {
                        using (StreamWriter sw1 = File.AppendText(name))
                        {
                            sw1.WriteLine(s1 + ". " + str0.ToString());
                            sw1.Close();
                        }
                    }
                }
            }
            else { Console.WriteLine("Nessun dizionario scelto."); }
        }

        public static void pass1()
        {
            string num;
            Console.WriteLine("1 = Casuale");
            Console.WriteLine("2 = Schema");
            Console.WriteLine("3 = Dizionario");
            Console.Write("Inserisci quale metodo usare: ");
            num = Console.ReadLine();
            Console.Clear();
            if (num == "1") { met1(); }
            if (num == "2") { met2(); }
            if (num == "3") { met3(); }
            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00") { Program.Main(); }
        }

        public static void pass()
        {
            while (true) { Console.Clear(); pass1(); }
        }
    }
}