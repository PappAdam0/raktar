using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raktar
{
    class megrendeles
    {
        private string datum;

        public string DATUM
        {
            get { return datum; }
            set { datum = value; }
        }

        private string kod;

        public string KOD
        {
            get { return kod; }
            set { kod = value; }
        }

        private string email;

        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        private List<tetel> tetelek;

        private int osszeg;

        public int OSSZEG
        {
            get { return osszeg; }
            set { osszeg = value; }
        }

       

        public void TetelHozzaad(string kod, int db)
        {
            tetelek.Add(new tetel(kod, db));
        }

        private int Ara(string kod, List<termek> termekek)
        {
            int i = 0;
            while (termekek[i].KOD != kod)
            {
                i++;
            }
            return termekek[i].AR;
        }
        public void Szamolas(List<termek> termekek)
        {
            // kód alapján megkeresni a terméket

            // szum += ár * db (Ahány termék van)
            int szum = 0;
            for (int i = 0; i < tetelek.Count; i++)
            {
                int ar = Ara(tetelek[i].KOD,termekek);
                szum += ar * tetelek[i].DB;
            }
            this.osszeg = szum;

            
        }

        public megrendeles(string datum, string kod, string email)
        {
            this.datum = datum;
            this.kod = kod;
            this.email = email;
            tetelek = new List<tetel>();
        }
    }
}
