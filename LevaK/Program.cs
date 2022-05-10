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
            ChoiceFunc();
        }

        public static void ChoiceFunc()
        {
            int Choice;
            string RomanInt;

            Console.WriteLine("Выберите преобразование: ");
            Console.WriteLine("1 - арабские -> римские; 2 - римские -> арабские; 0 - выход");
            try
            {
                Choice = Int32.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("Введите число арабскими цифрами(-1 для выхода)");
                            RomanInt = Console.ReadLine();
                            try
                            {
                                Console.WriteLine(IntegerToRoman(Int32.Parse(RomanInt)));
                                break;
                            }
                            catch{}
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите число римскими цифрами(Только заглавные)");
                        RomanInt = Console.ReadLine();
                        while (RomanInt != "-1")
                        {
                            if(RomanToInt(RomanInt) != 0)
                            {
                                Console.WriteLine(RomanToInt(RomanInt));
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введите число римскими цифрами(-1 для выхода)"); //Хуета полная
                                RomanInt = Console.ReadLine();
                            }
                        }
                        break;
                    case -1:
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Введено неверное значение");
                        break;
                }
                if(Choice != 0)
                {
                    ChoiceFunc();
                }
                
            }
            catch
            {
                Console.WriteLine("Введите число.");
                ChoiceFunc();
            }
        }

        static int RomanToInt(string s)
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

        static string IntegerToRoman(int num)
        {
            string Rez = "";

                for(int j = 0; j < (num / 1000); j++)
                {
                    Rez += "M";
                }

                int Percent = (num % 1000)/100;

                if(Percent == 9)
                {
                    Rez += "CM";
                }
                else if (Percent == 4)
                {
                    Rez += "CD";
                }
                else if(Percent >= 5 && Percent <= 8)
                {
                    Rez += "D";
                    for (int j = 0; j < ((num % 1000) / 100)-5; j++)
                    {
                        Rez += "C";
                    }
                }
                else
                {
                    for(int j = 0; j < (num % 1000) / 100; j++)
                    {
                        Rez += "C";
                    }
                }

                Percent = (num % 100) / 10;

                if (Percent == 9)
                {
                    Rez += "XC";
                }
                else if (Percent == 4)
                {
                    Rez += "XL";
                }
                else if(Percent >= 5 && Percent <= 8)
                {
                    Rez += "L";
                    for (int j = 0; j < ((num % 100) / 10) - 5; j++)
                    {
                        Rez += "X";
                    }
                }
                else
                {
                    for (int j = 0; j < (num % 100) / 10; j++)
                    {
                        Rez += "X";
                    }
                }

                Percent = (num % 10);

                if (Percent == 9)
                {
                    Rez += "IX";
                }
                else if (Percent == 4)
                {
                    Rez += "IV";
                }
                else if (Percent >= 5 && Percent <= 8)
                {
                    Rez += "V";
                    for (int j = 0; j < (num % 10) - 5; j++)
                    {
                        Rez += "I";
                    }
                }
                else
                {
                    for (int j = 0; j < num % 10; j++)
                    {
                        Rez += "I";
                    }
                }
            return Rez;
        }
    }
}
