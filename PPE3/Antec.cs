using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class Antec
    {
        public int IdAntec {  get; set; }
        public string NomAntec { get; set; }

        public Antec(int IdAntec, string NomAntec)  
        {
            this.IdAntec = IdAntec;
            this.NomAntec = NomAntec;
        }

        public Antec()
        {
        }

        public Antec(string antec)
        {
            this.NomAntec= antec;
        }

        public override string ToString()
        {
            return $"{NomAntec}";
        }
    }
}
