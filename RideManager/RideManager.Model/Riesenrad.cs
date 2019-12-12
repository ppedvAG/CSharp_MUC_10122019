using System;

namespace RideManager.Model
{
    public class Riesenrad : Fahrgeschäft
    {
        public int Höhe { get; set; }
        public int AnzGondeln { get; set; }

        public override decimal Preis => 12;

        public override decimal GetTicketPreis(DateTime alter)
        {
            return Preis / 2;
        }
    }
}
