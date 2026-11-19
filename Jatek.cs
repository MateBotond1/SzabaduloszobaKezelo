using System;
using System.Collections.Generic;
using System.Text;

namespace SzabaduloszobaKezelo
{
    public class Jatek
    {
        public string CsapatNev {  get; set; }
        public string PalyaTipus {  get; set; }
        public int JatekosokSzama {  get; set; }
        public int IdotartamPerc {  get; set; }
        public int HasznaltSegitseg {  get; set; }

        public Jatek(string sor)
        {
            string[] darabol = sor.Split(";");
            CsapatNev= darabol[0];
            PalyaTipus= darabol[1];
            JatekosokSzama=int.Parse(darabol[2]);
            IdotartamPerc= int.Parse(darabol[3]);
            HasznaltSegitseg= int.Parse(darabol[4]);
        }
        public int FizetendoOsszeg()
        {
            int palyaar = 0;
            if (PalyaTipus == "KLASSZIKUS") { palyaar = 14000; }
            else { palyaar = 18000; }
            int felar = 0;
            if (JatekosokSzama > 3) { felar = (JatekosokSzama - 3) * 3000; }
            int segitsegar = 0;
            if (HasznaltSegitseg > 1) { segitsegar = (HasznaltSegitseg - 1) * 1000; }

            return palyaar+felar+segitsegar;
        }
        public override string ToString()
        {
            return $"{CsapatNev} ({PalyaTipus}): {JatekosokSzama} fő, {IdotartamPerc} perc, {HasznaltSegitseg} segítség - Fizetendő: {FizetendoOsszeg()} Ft";
        }
    }

}
