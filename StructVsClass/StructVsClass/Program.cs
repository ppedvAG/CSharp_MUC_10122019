using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 5;
            Console.WriteLine(zahl);
            MachMehr(zahl);
            Console.WriteLine(zahl);


            long großeZahl = 436843;

            Kuchen meinKuchen = null;
            meinKuchen = new Kuchen();

            KuchenEssen(meinKuchen);

            Console.WriteLine(meinKuchen.ToString());
            Console.ReadLine();
        }

        private static void MachMehr(int zahl)
        {
            zahl = zahl + 5;
        }

        private static void KuchenEssen(Kuchen meinKuchen)
        {
            meinKuchen.KcAl--;
        }
    }

    class Kuchen
    {
        public int KcAl { get; set; }

        public Kuchen()
        {

        }

        ~Kuchen()
        {

        }
    }
}
