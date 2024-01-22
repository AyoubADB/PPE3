using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class All
    {
        public int IdAll {  get; set; }
        public string NomAll { get; set; }

        public All(int IdAll, string NomAll) 
        {
            this.IdAll = IdAll;
            this.NomAll = NomAll;
        }

        public All()
        {
        }

        public override string ToString()
        {
            return $"{NomAll}";
        }

        public All(string NomAll)
        {
            this.NomAll = NomAll;
        }
    }
}
