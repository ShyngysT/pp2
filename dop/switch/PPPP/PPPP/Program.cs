using System;

namespace PPPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int num;
            num = randNum.Next(1, 6);

            switch(num) {
            case 1:
                    Console.WriteLine("Num is 1" + num);
                    break;
            case 3:
                    Console.WriteLine("Num is 2" + num);
                    break;
                default:
                    Console.WriteLine("Nothing!" + num);
                    break;
            }
            Console.ReadLine();

        }
    }
}
