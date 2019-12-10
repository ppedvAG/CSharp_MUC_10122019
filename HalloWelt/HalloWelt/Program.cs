using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hallo Welt");

            int zahl; //deklaration
            zahl = 5; //zuweisung
            zahl = 12; //zuweisung
            zahl = 12 + 7;

            long großeZahl = -467834278457657387;
            byte einByte = 247;

            double kommaZahl = 4.674;
            Console.WriteLine(kommaZahl.ToString("c") + " ist der Wert");

            decimal geld = 437.834m;
            Console.WriteLine(geld.ToString("c"));

            zahl = (int)geld; //explizites casting
            Console.WriteLine(zahl);
            geld = zahl; //implizites casting

            char buchstabe = 'B';
            string text = "Das ist text";
            Console.WriteLine(text);

            Console.WriteLine("Gibt eine Zahl ein:");
            string eingabe = Console.ReadLine();
            Console.WriteLine("Deine Eingabe war: " + eingabe);


            int eingabeAlsInt = int.Parse(eingabe);
            int eingabeAlsInt222 = Convert.ToInt32(eingabe);
            int dasDoppelte = eingabeAlsInt * 2;
            Console.WriteLine("Das doppelte ist:" + dasDoppelte);


            int mehr = zahl + 1;
            mehr = mehr + 1;
            mehr *= 51;
            mehr--;


            bool einBool = true;
            bool einBool2 = zahl > 500;
            bool einBool3 = zahl <= 500;
            bool einBool4 = zahl == 23;

            if (true && !!!true || !!!!!!!!!!!!!!!!!!!!false)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("ELSE");
            }


            Console.WriteLine("Ende");
            Console.ReadLine();
        }
    }
}
