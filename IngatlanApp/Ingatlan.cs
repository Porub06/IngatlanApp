using System;
using System.Collections.Generic;
using System.Text;

namespace IngatlanApp
{
    internal class Ingatlan
    {
        public string HelyrajziSzam { get; set; }
        protected int alapterulet;
        public int Alapterulet { get { return alapterulet; } set {if (value<=0){
                    alapterulet = 10;
                }
                else { alapterulet = value; }
            }
        }
        private static int osszesIngatlanSzama;
        public static int OsszesIngatlanSzama { get { return osszesIngatlanSzama; } }
        //Konstruktor

        public Ingatlan(string helyrajziszam,int alapterulet) 
        { HelyrajziSzam = helyrajziszam; Alapterulet = alapterulet; osszesIngatlanSzama++; }
        //Metódusok
        public virtual int BecsultErtek()
        {
            return Alapterulet * 400000;
        }
        public override string ToString()
        {
            return $"Ingatlanb{HelyrajziSzam} | Terület: {Alapterulet} m2 | Becsültérték: {BecsultErtek()} Ft";
        }




    }




}
