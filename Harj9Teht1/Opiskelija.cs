using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Luo Opiskelija-luokka, jolla on ominaisuudet Etunimi, Sukunimi, AsioID ja Ryhmä. AsioID on aina uniikki, yksilöllinen. 
 Lisää rekisteriin aluksi neljän testi-oppilaan tiedot: Masa Niemi, Allan Aalto, Hanna Husso ja Teppo Testaaja. */
namespace MiniASIO
{
    class Opiskelija
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string AsioID { get; set; }
        public string Ryhmä { get; set; }

        /*public Opiskelija(string etunimi, string sukunimi, string asioID, string ryhmä)
        {
            this.Etunimi = etunimi;
            this.Sukunimi = sukunimi;
            this.AsioID = asioID;
            this.Ryhmä = ryhmä;
        } */
        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + AsioID + " " + Ryhmä;
        }
    }
}
