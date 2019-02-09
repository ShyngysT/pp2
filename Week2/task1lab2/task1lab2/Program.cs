using System;

namespace Task1_lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for (int i = 1; i <= s.Length / 2; i++)
            {
                if (s[i] == s[s.Length - i + 1])
                {

                    Console.Write("Yes");
                    break;
                }

                else
                {

                    Console.Write("No");
                    break;
                }
            }
            
            
            


        }
    }
}
