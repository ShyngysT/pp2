using System;
using System.Collections.Generic;

namespace Gosha_massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(43);
            numbers.Add(54);

            for (int i = 0; i < numbers.Count; i++)
                Console.Write(numbers[i] + ',');


            Console.ReadKey();


            
        }
    }
}
