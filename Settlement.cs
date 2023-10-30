using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_polimo
{
    public abstract class Settlement
    {
        public double S {  get; set; }
        public int H { get; set; }
        public string Name { get; set; }

        public abstract string Show();
        public abstract double Density();
    }
}
