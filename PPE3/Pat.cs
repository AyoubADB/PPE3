using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class Pat
    {
        public string NomPat { get; set; }
        public string PrenomPat { get; set; }
        public int AgePat { get; set; }
        public string SexePat { get; set; }

        public string Allergie { get; set; }
        public string Antecedent { get;set; }

        public Pat( string NomPat, string PrenomPat, int AgePat, string SexePat)
        {
            this.NomPat = NomPat;
            this.PrenomPat = PrenomPat;
            this.AgePat = AgePat;
            this.SexePat = SexePat;
            this.Allergie = "";
            this.Antecedent = "";
        }
       
    }
    
    internal class PatOrdo
    {
        public int PatientId { get; set; }

        public string NomPatOrdo { get; set; }
        public string PrenomPatOrdo { get; set; }

        public PatOrdo (string NomPatOrdo, string PrenomPatOrdo, int patientId)
        {
            this.NomPatOrdo = NomPatOrdo;
            this.PrenomPatOrdo = PrenomPatOrdo;
            this.PatientId = patientId;
        }

        public PatOrdo()
        {
            
        }

        public override string ToString()
        {
            return $"{NomPatOrdo} {PrenomPatOrdo}";
        }
    }
}


