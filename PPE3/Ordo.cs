using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class Ordo
    {
        public string PosologieOrdo {  get; set; }  
        public string DureeTraitement { get; set; }
        public string InstructionOrdo { get; set; } 

        public Ordo(string PosologieOrdo, string DureeTraitement, string InstructionOrdo) 
        {
            this.PosologieOrdo = PosologieOrdo;
            this.DureeTraitement = DureeTraitement;
            this.InstructionOrdo = InstructionOrdo;
            
        }
    }
}
