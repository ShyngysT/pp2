using System;

namespace ppp


{
    class Program
{
    static void Main(string[] args)
    {
        Random randnum = new Random;
        int num = randnum.Next(1, 9);
        switch (num)
        {
            case 3: Console.WriteLine("Num is 3");
                break;
            case 7:
                Console.WriteLine("Num is 4");
                break;
            default:
                Console.WriteLine("Nothing!");
                break;

        }
    }
}
}

