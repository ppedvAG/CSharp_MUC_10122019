using System;

namespace RideManager.Model
{
    public class Autoscooter : Fahrgeschäft
    {
        public long WattDerSoundanlage { get; set; }

        public override decimal Preis => 7;

        public override decimal GetTicketPreis(DateTime alter)
        {
            return Preis - 2;
        }
    }
}
