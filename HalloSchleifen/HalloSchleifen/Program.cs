using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HalloSchleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zählergesteuerte Schleife
            //StreamWriter sw = new StreamWriter("zahlen.txt");
            //for (int i = 0; i < 100; i++)
            //{
            //    //Console.WriteLine(i);
            //    sw.WriteLine(i);
            //}
            //sw.Close();

            //kopfgesteuerte schleife
            StreamReader sr = new StreamReader("zahlen.txt");
            int summe = 0;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                summe += int.Parse(line);
            }
            sr.Close();

            //fußgesteuerte schleife
            do
            {
                Console.WriteLine(DateTime.Now);
            } while (DateTime.Now.Second < 30);


            Console.WriteLine("Summe: " + summe);
            Console.WriteLine("Ende");
            Console.ReadLine();
        }
    }
}
