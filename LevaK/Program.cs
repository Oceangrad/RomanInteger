using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevaK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomainToInt("MCMXCIV")); //1994
            Console.WriteLine(RomainToInt("Нажмите любую кнопку для выхода"));
            Console.Read();
        }

        static int RomainToInt(string s)
        {
            int Rez = 0;

            for(int i = 0; i < s.Length; i++)
            {
                string str = s[i].ToString();

                switch (str)
                {
                    case "I":
                        if (i != s.Length-1)
                        {
                            if (s[i + 1].ToString() == "V")
                            {
                                Rez += 4;
                                i++;
                            }
                            else if (s[i + 1].ToString() == "X")
                            {
                                Rez += 9;
                                i++;
                            }
                            else
                            {
                                Rez += 1;
                            }
                        }
                        else
                        {
                            Rez += 1;
                        }
                        break;
                    case "V":
                        Rez += 5;
                        break;
                    case "X":
                        if (i != s.Length - 1)
                        {
                            if (s[i + 1].ToString() == "L")
                            {
                                Rez += 40;
                                i++;
                            }
                            else if (s[i + 1].ToString() == "C")
                            {
                                Rez += 90;
                                i++;
                            }
                            else
                            {
                                Rez += 10;
                            }
                        }
                        else
                        {
                            Rez += 10;
                        }
                        break;
                    case "L":
                        Rez += 50;
                        break;
                    case "C":
                        if (i != s.Length - 1)
                        {
                            if (s[i + 1].ToString() == "D")
                            {
                                Rez += 400;
                                i++;
                            }
                            else if (s[i + 1].ToString() == "M")
                            {
                                Rez += 900;
                                i++;
                            }
                            else
                            {
                                Rez += 100;
                            }
                        }
                        else
                        {
                            Rez += 100;
                        }
                        break;
                    case "D":
                        Rez += 500;
                        break;
                    case "M":
                        Rez += 1000;
                        break;
                }
            }
            return Rez;
        }
    }
}
