using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class Medoc
    {
        public int MedicamentId {  get; set; }
        public string NomMedoc {  get; set; }

        public Medoc(string NomMedoc,int medicamentId)
        {
            this.NomMedoc = NomMedoc;
            this.MedicamentId = medicamentId;
        }

        public Medoc(string NomMedoc)
        {
            this.NomMedoc = NomMedoc;
        }

        public Medoc()
        {
            this.NomMedoc = NomMedoc;
        }

        public override string ToString()
        {
            return $"{NomMedoc}";
        }
    }

    internal class MedocIncompatible
    {

        public string NomMedicament { get; set; }
        
        public MedocIncompatible(string NomMedicament)
        {
            this.NomMedicament = NomMedicament;
        }

        public override string ToString()
        {
            return $"Nom du médicament incompatible : {NomMedicament}";
        }

    }
}
