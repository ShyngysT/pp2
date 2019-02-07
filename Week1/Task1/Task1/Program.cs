using System;

namespace Task1
{
    class Program
    {
        static bool isPrime(int num)
        {
            if (num == 1) return false;
            for (int i = 2; i  < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        { 
            
            string s = Console.ReadLine();
            int n = int.Parse(s);
            string k = Console.ReadLine();
            string[] arr = k.Split(' ');
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int num = int.Parse(arr[i]);
                if(isPrime(num) == true)
                {
                    cnt++;
                }

            }
            Console.WriteLine(cnt);
            for (int i = 0; i < arr.Length; i++)
            {
                int num = int.Parse(arr[i]);
                if (isPrime(num) == true)
                {
                    Console.Write(num);
                    Console.Write(' ');
                }

            }



        }
    }
}
