using System;

namespace RideManager.Model
{
    public class Autoscooter : Fahrgeschäft
    {
        private long wattDerSoundanlage;


        /// <summary>
        /// Power des Sounds
        /// </summary>
        /// <exception  cref="AutoScooterToLessPowerException"/>
        public long WattDerSoundanlage
        {
            get { return wattDerSoundanlage; }
            set
            {
                if (value < 1000)
                    throw new AutoScooterToLessPowerException("Zu wenig Power!!!11");
                wattDerSoundanlage = value;

            }
        }

        public override decimal Preis => 7;

        public override decimal GetTicketPreis(DateTime alter)
        {
            return Preis - 2;
        }
    }

    public class AutoScooterToLessPowerException : Exception
    {
        public int MinPower { get; set; }

        public AutoScooterToLessPowerException(string message) : base(message)
        {
        }
    }
}
