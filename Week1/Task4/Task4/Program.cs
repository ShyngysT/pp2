using System;

namespace Task4
{
    class Program
    { 

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);

            for(int i = 1; i <= n; i++)
            {
                for(int j = 0; j < i; j++)
                {

                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
            
           
        }
    }
}
