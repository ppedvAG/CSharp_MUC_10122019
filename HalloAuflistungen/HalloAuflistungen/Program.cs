using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloAuflistungen
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            Console.WriteLine("*** Hallo Auflistungen ***");

            HalloArray();
            List<string> eineListe = new List<string>();
            eineListe.Add("Hallo");
            eineListe.Add("Welt");
            eineListe.Insert(0, "*** ");
            eineListe.Add("Blöööööck!!!");
            eineListe.RemoveAt(3);
            eineListe.Add("BBB");
            eineListe.Add("AAA");

            foreach (string item in eineListe)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        private static void HalloArray()
        {
            int[][] zahlen = new int[4][];
            zahlen[0] = new int[2];
            zahlen[1] = new int[2];
            zahlen[2] = new int[2];
            zahlen[3] = new int[2];

            zahlen[0][0] = 64;
            zahlen[0][1] = 164;
            zahlen[1][0] = -6;
            zahlen[1][1] = 173;
            zahlen[2][0] = 6436436;
            zahlen[2][1] = 437;
            zahlen[3][0] = -2652;
            zahlen[3][1] = 4376;

            for (int i = 0; i < zahlen.Length; i++)
            {
                for (int j = 0; j < zahlen[i].Length; j++)
                {
                    Console.WriteLine("i:" + i + " j:" + j + " " + zahlen[i][j]);
                }
            }
        }
    }
}
