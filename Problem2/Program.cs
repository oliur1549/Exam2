using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.Write("Enter first A/P (A for 12 hours P for 24 hours format) :");
            a = Console.ReadLine();

            string time;
            
            time = Console.ReadLine();
            if (a == "A")
            {
                Console.Write("Enter your Time {00:00:00} FORMAT:");
                converttime12(time);
            }
            else if (a == "P")
            {
                Console.Write("Enter your Time {00:00:00 PM} FORMAT:");
                CONVERTTIME24(time);
            }
        }
        static void CONVERTTIME24(String str)
        {

            int h1 = (int)str[1] - '0';
            int h2 = (int)str[0] - '0';
            int hh = (h2 * 10 + h1 % 10);

          
            if (str[8] == 'A')
            {
                if (hh == 12)
                {
                    Console.Write("00");
                    for (int i = 2; i <= 7; i++)
                        Console.Write(str[i]);
                }
                else
                {
                    for (int i = 0; i <= 7; i++)
                        Console.Write(str[i]);
                }
            }

           
            else
            {
                if (hh == 12)
                {
                    Console.Write("12");
                    for (int i = 2; i <= 7; i++)
                        Console.Write(str[i]);
                }
                else
                {
                    hh = hh + 12;
                    Console.Write(hh);
                    for (int i = 2; i <= 7; i++)
                        Console.Write(str[i]);
                }
            }
        }
        static void converttime12(string str)
        {
            int h1 = (int)str[0] - '0';
            int h2 = (int)str[1] - '0';

            int hh = h1 * 10 + h2;

            string times;
            if (hh < 12)
            {
                times = "AM";
            }
            else
                times = "PM";

            hh %= 12;

            if (hh == 0)
            {
                Console.Write("12");

                for (int i = 2; i < 8; ++i)
                {
                    Console.Write(str[i]);
                }
            }
            else
            {
                Console.Write(hh);
                for (int i = 2; i < 8; ++i)
                {
                    Console.Write(str[i]);
                }
            }
            Console.WriteLine(" " + times);
        }
    }
}
