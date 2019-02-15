using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Week_3_lab3ke_ex
{
    class Program
    {
        public static void Primee();
        {
            StreamReader sr = new StreamReader("Input.txt");
            string s = sr.ReadToEnd();
            sr.Close();
            StreamWriter sw = new StreamWriter("output.txt");
            string[] ss = string.Split();
        for(int i=0; i<ss.Length; i++) // пробегаемся по массиву
   {
    int cnt = 0; // нужно что бы посчитать сколько будет делителей у каждого числа
        int x = int.Parse(ss[i]); // переводим строку в int x
    for(int j=1; j<=x; j++) // с этим циклом посчитаем сколько у этого числа делителей
    {
     if (x % j == 0) // если есть делитель то cnt++
     {
      cnt++;
     }
}
    if(cnt == 2) // когда у нас 2 делителя то это число prime
    {
     sw.Write(x+" "); //записываем его в output.txt
    }
   }
   sw.Close();//закрываем
  }
 
