using System;

namespace RideManager.Model
{
    public abstract class Fahrgeschäft
    {
        public string Hersteller { get; set; }
        public string Modell { get; set; }
        public string Name { get; set; }
        public DateTime Baujahr { get; set; }

        protected int Geheim { get; set; }

        public abstract decimal Preis { get; }

        public virtual decimal GetTicketPreis(DateTime alter)
        {
            return 9999;
        }
    }
}
