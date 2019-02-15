using System;
using System.IO;


namespace filecreate
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = @"\\Mac\Home\Desktop\PP2\Week1\Task3 ";
            //string s1 = Path.Combine(s, "New");
            //Directory.CreateDirectory(s1);
            
            
            //string s2 = "Nariii.txt";
            //s1 = Path.Combine(s1, s2);
            //FileStream fs = File.Create(s1); //чтобы копировать
            //fs.Close();



            string s4 = "Nariii.text";
            string Zhako_path = @"\\Mac\Home\Desktop\PP2\Week1\Task3\New\Nariii.txt";
            string v_path = @"\\Mac\Home\Desktop\PP2";
            v_path = Path.Combine(v_path, s4);
            //File.Copy(Zhako_path, v_path, true);
            //File.Move(Zhako_path, v_path);
            File.Delete(@"\\Mac\Home\Desktop\PP2\Nariii.text");
           


        }
    }
}
