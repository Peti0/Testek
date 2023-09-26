using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Teglatest : Testek
    {
        readonly double oldalA;
        readonly double oldalB;
        readonly double oldalC;

        public double OldalA => oldalA;
        public double OldalB => oldalB;
        public double OldalC => oldalC;

        public Teglatest(double oldalA, double oldalB, double oldalC) : base("Téglatest")
        {
            this.oldalA = oldalA;
            this.oldalB = oldalB;
            this.oldalC = oldalC;
        }

        public override double Terfogat()
        {
            return oldalA * oldalB * oldalC;
        }

        public override double Felszin()
        {
            return 2 * (oldalA * oldalB + oldalA * oldalC + oldalB * oldalC);
        }
    }
}
