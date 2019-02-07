using System;

namespace Task3
{
    class Program
    {
        public static int[] arrmaker(string[] array)
        {
            int cnt = -1;
            int[] numbers = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i ++)
            {
                cnt++;
                numbers[cnt] = int.Parse(array[i]);
                cnt++;
                numbers[cnt] = int.Parse(array[i]);
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            string[] arr = Console.ReadLine().Split(' ');
            int[] array = arrmaker(arr);
            for (int i = 0; i < array.Length; i ++)
            {
                Console.Write(array[i]);
                Console.Write(' ');
            }
        }
    }
}
