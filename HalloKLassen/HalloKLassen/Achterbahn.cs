using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloKlassen
{
    public class Achterbahn
    {
        private string name; //datenfeld
        private int höchstgeschwindigkeit;

        #region getter setter methode (macht so keiner!)
        //getter funktion
        public string GetName()
        {
            return name;
        }

        //setter methode
        public void SetName(string name)
        {
            this.name = name;
        }
        #endregion

        //full property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //auto property
        public string Hersteller { get; set; }
        public string Modell { get; set; }
        public int Höchstgeschwindigkeit
        {
            get { return höchstgeschwindigkeit; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Die Höchstgeschwindigkeit darf nicht negativ sein");
                else
                    höchstgeschwindigkeit = value;
            }
        }
        public double Länge { get; set; }

        public double LängeInFuß
        {
            get { return Länge * 1000 * 3.28; }
        }

        public double Höhe { get; set; }
        public int Sitzplätze { get; set; }
        public DateTime Baujahr { get; set; }


        private bool istEingepackt;
        public void Einpacken()
        {
            if (istEingepackt)
                Console.WriteLine("Diese Achterbahn ist bereit eingebpackt!");
            else
                istEingepackt = true;
        }
        public void Auspacken()
        {
            if (!istEingepackt)
                Console.WriteLine("Diese Achterbahn ist nicht eingepackt!");
            else
                istEingepackt = false;
        }


        //default konstruktor
        public Achterbahn()
        {
            Baujahr = DateTime.Now.AddDays(-7);
        }

        public Achterbahn(string name) : this()
        {
            Name = name;
        }

    }
}
