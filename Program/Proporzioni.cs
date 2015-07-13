using System;
using System.Collections.Generic;

namespace ita
{
    public static class Proporzioni
    {
        public static void prop1()
        {
            int finda1 = 0, finda2 = 0, finda3 = 0;
            bool i1 = true, i2 = true, i3 = true;
            string str;
            while (true)
            {
                try
                {
                    Console.Write("Inserire proporzione: "); str = Console.ReadLine();
                    for (int a = 0; a < str.Length; a++)
                    {
                        if (str.ToCharArray()[a].ToString() == ":")
                        {
                            finda1 = a;
                            i1 = false;
                            break;
                        }
                    }
                    if (i1)
                    {
                        int h = 6 / finda1;
                    }
                    for (int a = finda1; a < str.Length; a++)
                    {
                        if (str.ToCharArray()[a].ToString() == "=")
                        {
                            finda2 = a;
                            i2 = false;
                            break;
                        }
                    }
                    if (i2)
                    {
                        int h = 6 / finda2;
                    }
                    for (int a = finda2; a < str.Length; a++)
                    {
                        if (str.ToCharArray()[a].ToString() == ":")
                        {
                            finda3 = a;
                            i3 = false;
                            break;
                        }
                    }
                    if (i3)
                    {
                        int h = 6 / finda3;
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Formato proporzione errato.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            List<string> list = new List<string>();
            list.Add(str.Substring(0, finda1));
            list.Add(str.Substring(finda1 + 1, finda2 - finda1 - 1));
            list.Add(str.Substring(finda2 + 1, finda3 - finda2 - 1));
            list.Add(str.Substring(finda3 + 1, str.Length - finda3 - 1));
            int where1 = 0, where2 = 0, where3 = 0;
            double int1 = 0, int2 = 0, int3 = 0, int4 = 0;
            double result = 0;
            Console.WriteLine();
            try
            {
                int1 = double.Parse(list[0]);
            }
            catch (Exception)
            {
                list[0] = "X";
                if (where1 == 0)
                {
                    where1 = 1;
                }
                else if (where2 == 0)
                {
                    where2 = 1;
                }
                else if (where3 == 0)
                {
                    where3 = 1;
                }
            }
            try
            {
                int2 = double.Parse(list[1]);
            }
            catch (Exception)
            {
                list[1] = "X";
                if (where1 == 0)
                {
                    where1 = 2;
                }
                else if (where2 == 0)
                {
                    where2 = 2;
                }
                else if (where3 == 0)
                {
                    where3 = 2;
                }
            }
            try
            {
                int3 = double.Parse(list[2]);
            }
            catch (Exception)
            {
                list[2] = "X";
                if (where1 == 0)
                {
                    where1 = 3;
                }
                else if (where2 == 0)
                {
                    where2 = 3;
                }
                else if (where3 == 0)
                {
                    where3 = 3;
                }
            }
            try
            {
                int4 = double.Parse(list[3]);
            }
            catch (Exception)
            {
                list[3] = "X";
                if (where1 == 0)
                {
                    where1 = 4;
                }
                else if (where2 == 0)
                {
                    where2 = 4;
                }
                else if (where3 == 0)
                {
                    where3 = 4;
                }
            }
            List<string> list1 = new List<string>();
            if (where1 == 1 || where2 == 1 || where3 == 1)
            {
                list1.Add("X");
            }
            else
            {
                list1.Add(int1.ToString());
            }
            if (where1 == 2 || where2 == 2 || where3 == 2)
            {
                list1.Add("X");
            }
            else
            {
                list1.Add(int2.ToString());
            }
            if (where1 == 3 || where2 == 3 || where3 == 3)
            {
                list1.Add("X");
            }
            else
            {
                list1.Add(int3.ToString());
            }
            if (where1 == 4 || where2 == 4 || where3 == 4)
            {
                list1.Add("X");
            }
            else
            {
                list1.Add(int4.ToString());
            }

            if (where1 != 0)
            {
                if (where1 != 0 && where2 != 0 && where3 != 0)
                {
                    Console.WriteLine("{0}:{1}={2}:{3}\n\nLa Proporzione non può essere determinata\n", list1[0], list1[1], list1[2], list1[3], result);
                }
                else if (where1 != 0 && where2 != 0)
                {
                    if (where1 == 1 && where2 == 4)
                    {
                        result = Math.Pow(int2 * int3, 0.5);
                        Console.WriteLine("{0}:{1}={2}:{3}\n\nLa Proporzione è uguale a {4}\n", list1[0], list1[1], list1[2], list1[3], result);
                    }
                    else if (where1 == 2 && where2 == 3)
                    {
                        result = Math.Pow(int1 * int4, 0.5);
                        Console.WriteLine("{0}:{1}={2}:{3}\n\nLa Proporzione è uguale a {4}\n", list1[0], list1[1], list1[2], list1[3], result);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1}={2}:{3}\n\nLa Proporzione non può essere determinata\n", list1[0], list1[1], list1[2], list1[3], result);
                    }
                }
                else if (where1 != 0)
                {
                    if (where1 == 1)
                    {
                        result = (int2 * int3) / int4;
                    }
                    if (where1 == 2)
                    {
                        result = (int1 * int4) / int3;
                    }
                    if (where1 == 3)
                    {
                        result = (int1 * int4) / int2;
                    }
                    if (where1 == 4)
                    {
                        result = (int2 * int3) / int1;
                    }
                    Console.WriteLine("{0}:{1}={2}:{3}\n\nLa Proporzione è uguale a {4}\n", list1[0], list1[1], list1[2], list1[3], result);
                }
            }
            else
            {
                if (int1 / int2 == int3 / int4)
                {
                    Console.WriteLine("{0}:{1}={2}:{3}\n\nLa Proporzione è vera\n", list1[0], list1[1], list1[2], list1[3]);
                }
                else
                {
                    Console.WriteLine("{0}:{1}={2}:{3}\n\nLa Proporzione è falsa\n", list1[0], list1[1], list1[2], list1[3]);
                }
            }
            Console.Write("00 per tornare al menù o INVIO per continuare: ");
            string b = Console.ReadLine();
            if (b == "00")
            {
                Program.Main();
            }
        }

        public static void prop()
        {
            while (true)
            {
                Console.Clear();
                prop1();
            }
        }
    }
}