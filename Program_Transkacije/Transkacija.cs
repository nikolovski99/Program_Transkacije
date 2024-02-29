using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Transkacije
{
    class Transkacija
    {
        public String ID;
        public String Naziv;
        public DateTime Datum;
        public String iznos;
        public String opis;

        public Transkacija(String iD, string naziv, DateTime datum, string iznos, string opis)
        {
            ID = iD;
            Naziv = naziv;
            Datum = datum;
            this.iznos = iznos;
            this.opis = opis;
        }

        public String getID() { return ID; }
        public String getNaziv() { return Naziv; }

        public DateTime getDatum () { return Datum; ; }

        public String getIznos() { return iznos; }

        public String getOpis() { return opis; }
    }
}
