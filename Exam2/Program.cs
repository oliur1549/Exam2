using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Age, City;
            Console.Write("Enter Name :");
            Name =Console.ReadLine();

            Console.Write("Enter Age :");
            Age = Console.ReadLine();

            Console.Write("Enter City :");
            City = Console.ReadLine();

            List<string> names = new List<string>() { Name, Age, City };
            

            var redult = from element in names
                          orderby Name
                          select element;

            foreach (var item in redult)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
