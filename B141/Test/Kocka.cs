using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Kocka : Testek
    {
        readonly double oldal;
        public double Oldal => oldal;
        public Kocka(double oldal) : base("Kocka")
        {
            this.oldal = oldal;
        }
       
        public override double Terfogat()
        {
            return(Oldal * Oldal * Oldal);
        }
        public override double Felszin()
        { 
          return (6* Oldal * Oldal);
        }
    }
}
