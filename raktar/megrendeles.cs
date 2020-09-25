﻿using System;
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

        public void TetelHozzaad(string kod, int db)
        {
            tetelek.Add(new tetel(kod, db));
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
