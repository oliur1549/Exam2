﻿using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, r;

            Console.Write("Input number of rows :");
            r = Convert.ToInt32(Console.ReadLine());
            if (r<3)
            {
                Console.Write("Input minimum 3");
                
            }
            else
            {
                for (i = 0; i <= r; i++)
                {
                    for (j = 1; j <= r - i; j++)
                        Console.Write(" ");
                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }

                for (i = r - 1; i >= 1; i--)
                {
                    for (j = 1; j <= r - i; j++)
                        Console.Write(" ");
                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }
            }
            
        }
    }
}
