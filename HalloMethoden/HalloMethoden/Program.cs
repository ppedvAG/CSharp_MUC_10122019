using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** HalloMethoden ***");

            Console.ForegroundColor = ConsoleColor.Red;

            SagHallo();
            SagHallo("Kevin");
            SagHallo("Kevin", 12);

            //int zahl = GibtMirFünf();
            int bessereZahl = Verdoppeln(Verdoppeln(Verdoppeln(Verdoppeln(GibtMirFünf()))));
            Console.WriteLine(bessereZahl);

            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        /// <summary>
        /// Verdoppelt zahlen
        /// </summary>
        /// <param name="zahl">Der Eingabewert der verdoppelt werden soll</param>
        /// <returns>Das doppelte der Eingabe</returns>
        static int Verdoppeln(int zahl)
        {
            return zahl * 2;
        }


        static int GibtMirFünf()
        {
            //todo mal ne bessere zahl aussuchen!
            return 5 / int.Parse("0");
        }

        //Methode ohne Parameter
        /// <summary>
        /// Schreibt Hallo in die Console
        /// </summary>
        static void SagHallo()
        {
            SagHallo("");
        }

        //Methode mit einem Parameter
        /// <summary>
        /// Sagt dem Hallo mit Namen
        /// </summary>
        /// <param name="name">Der Name dem Hallo gesagt werden soll</param>
        static void SagHallo(string name)
        {
            //hack totaler pfusch!!!
            Console.WriteLine("Hallo " + name + Verdoppeln(GibtMirFünf()));
        }

        //Methode mit zwei Parametern

        static void SagHallo(string name, int alter)
        {
            Console.WriteLine("Hallo " + name + " der " + alter + " Jahre alt ist");
        }



    }
}
