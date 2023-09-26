using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
     class Henger : Testek
     {
        readonly double magassag;
        readonly double sugar;

        public double Sugar => sugar;
        public double Magassag => magassag;

        public Henger(double sugar, double magassag) : base("Henger")
        {
            this.sugar = sugar;
            this.magassag = magassag;
        }

        public override double Terfogat()
        {
            return (Math.PI * sugar * sugar * magassag) ;    
        }

        public override double Felszin()
        {
            return (2* (Math.PI*sugar*magassag)+2*(Math.PI*sugar*sugar));
        }

    }
}
