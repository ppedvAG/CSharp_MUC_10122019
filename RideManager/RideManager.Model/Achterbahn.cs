using System;

namespace RideManager.Model
{
    public class Achterbahn : Fahrgeschäft
    {
        public double Länge { get; set; }
        public int MaxSpeed { get; set; }

        public override decimal Preis
        {
            get { return 5; }
        }

        public override  decimal GetTicketPreis(DateTime alter)
        {
            return Preis + 3;
        }
    }
}
