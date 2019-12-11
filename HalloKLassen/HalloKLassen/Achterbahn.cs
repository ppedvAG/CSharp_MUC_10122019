using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloKlassen
{
    class Achterbahn
    {
        private string name; //datenfeld

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
        public int Höchstgeschwindigkeit { get; set; }
        public double Länge { get; set; }
        public double Höhe { get; set; }
        public int Sitzplätze { get; set; }
        public DateTime Baujahr { get; set; }
    }
}
