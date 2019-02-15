using System;

namespace Task_2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string say = "hello";
            Console.WriteLine(say);
            say = say.Replace("hello", "hi");
            Console.WriteLine(say);

            Console.WriteLine(say.ToUpper());
            Console.WriteLine(say.ToLower());



        }
    }
}
