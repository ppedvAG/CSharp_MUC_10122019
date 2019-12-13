﻿using System;

namespace RideManager.Model
{
    public class Achterbahn : Fahrgeschäft, IAlter
    {
        public double Länge { get; set; }
        public int MaxSpeed { get; set; }

        public override decimal Preis
        {
            get { return 5; }
        }

        //public int MindestAlter => 18;
        public int MindestAlter { get { return 18; } }

        public bool AlterPrüfen(DateTime alter)
        {
            throw new NotImplementedException();
        }

        public override decimal GetTicketPreis(DateTime alter)
        {
            return Preis + 3;
        }
    }
}
