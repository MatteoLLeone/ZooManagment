using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leone_Zoo1
{
    class Animale
    {
        public string Nome { get; set; }
        public string Specie { get; set; }
        public int Età { get; set; }
        public int Peso { get; set; }
        public string StatodiSalute { get; set; }
        public DateOnly DataArrivo { get; set; }
        public int AnimaliAlloZoo { get; set; }

        private double _pesoiniziale;
        private int numeroControlliveterinari;

        public double CalcolaCiboDiarioKg()
        {
             return 0; 
        
        }
        public double CalcolaCostoGestioneMensile()
        {
            return 0;
        }
        public double 

    }
}
