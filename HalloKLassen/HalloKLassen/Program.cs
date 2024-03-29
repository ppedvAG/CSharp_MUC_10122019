﻿using System;

namespace HalloKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("*** Hallo Klassen ***");

#if DEBUG
            Console.WriteLine("DEBUGGGGGG");
#endif 

            HalloKlassen.Achterbahn meineAchterbahn; //deklaration
            meineAchterbahn = new Achterbahn("Silverstar"); //instanzierung
            //meineAchterbahn.Name = "Silverstar";
            meineAchterbahn.Hersteller = "MackRide";
            meineAchterbahn.Modell = "LSM Launch coster";
            meineAchterbahn.Höchstgeschwindigkeit = -121;
            meineAchterbahn.Höchstgeschwindigkeit = 121;
            meineAchterbahn.Höhe = 70;
            meineAchterbahn.Länge = 1.2;
            meineAchterbahn.Baujahr = new DateTime(2002, 3, 23);
            meineAchterbahn.Sitzplätze = 36;

            Achterbahn nochEineAchterbahn = new Achterbahn();
            nochEineAchterbahn.Name = "Olympia Looping";
            nochEineAchterbahn.Hersteller = "Schwarzkopf";
            nochEineAchterbahn.Modell = "Klassik Lift";
            nochEineAchterbahn.Höchstgeschwindigkeit = 90;
            nochEineAchterbahn.Höhe = 47;
            nochEineAchterbahn.Länge = 0.7;
            nochEineAchterbahn.Baujahr = new DateTime(1989, 1, 1);
            nochEineAchterbahn.Sitzplätze = 28;

            ZeigeAchterbahn(meineAchterbahn);
            ZeigeAchterbahn(nochEineAchterbahn);

            meineAchterbahn.Einpacken();
            meineAchterbahn.Auspacken();

            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        static void ZeigeAchterbahn(Achterbahn bahn)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Name: {bahn.Name} Hersteller: {bahn.Hersteller} Modell: {bahn.Modell}");
            Console.WriteLine($"MaxSpeed: {bahn.Höchstgeschwindigkeit} kmn/h");
            Console.WriteLine($"Höhe: {bahn.Höhe:0.00}m Länge: {bahn.Länge}km ({bahn.LängeInFuß}ft)");
            //Console.WriteLine("Höhe: {0}m Länge: {1}m", bahn.Höhe, bahn.Länge); //OLD STyle
            Console.WriteLine($"Sitzplätze: {bahn.Sitzplätze}");
            Console.WriteLine($"Baujahr: {bahn.Baujahr:d}");
        }
    }
}
