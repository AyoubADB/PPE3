using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class Medc
    {
        public int MedecinId { get; set; }
        public string NomMedc { get; set; }
        public string PrenomMedc { get; set;}

        public Medc (string NomMedc, string PrenomMedc, int medecinId)
        {
            this.NomMedc = NomMedc;
            this.PrenomMedc = PrenomMedc;
            MedecinId = medecinId;
        }

        public Medc()
        {
        }

        public override string ToString()
        {
            return $"{NomMedc} {PrenomMedc}";
        }
    }
}
