using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisCon1
{
    class DisplayArtikel
    {
        String artNr;
        String bezeichnung;
        String artGruppe;

        public int ArtikelOid { get; set; }

        public string ArtNr
        {
            get
            {
                return artNr;
            }

            set
            {
                artNr = value;
            }
        }

        public string Bezeichnung
        {
            get
            {
                return bezeichnung;
            }

            set
            {
                bezeichnung = value;
            }
        }

        public string ArtGruppe
        {
            get
            {
                return artGruppe;
            }

            set
            {
                artGruppe = value;
            }
        }

        public byte Bestand { get; set; }

        public int Meldebestand { get; set; }

    }
}
