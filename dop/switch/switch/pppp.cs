using System;

namespace pppp


{
    class Program
{
        public static void Main(string[] args)
        {
            Random randNum = new Random();
            int num;
            num = randNum.Next(1, 9);
            switch (num)
        {
            case 3:
                Console.WriteLine("Num is 3" + num);
                break;
            case 7:
                Console.WriteLine("Num is 7" + num);
                break;
            default:
                Console.WriteLine("Nothing!" + num);
                break;

        }
            Console.ReadKey();
    }
}
}

