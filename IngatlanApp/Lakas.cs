using System;
using System.Collections.Generic;
using System.Text;

namespace IngatlanApp
{
    internal class Lakas : Ingatlan
    {
        public int Emelet { get; set; }

        //Konstruktor
        public Lakas(string helyrajziszam, int alapterulet, int emelet) : base(helyrajziszam, alapterulet)
        {
            Emelet = emelet;
        }
        //Metódusok
        public override int BecsultErtek()
        {
            if (Emelet > 0)
            {
                return Convert.ToInt16(base.BecsultErtek() * 1.05);

            }
            else
            {
                return BecsultErtek();
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"| Emelet: {Emelet}";
        }
    }
}
