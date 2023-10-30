using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_polimo
{
    internal class Village : Settlement
    {
        private int P { get; set; }
        public Village(int house,int people, double area) { 
            H = house;
            S = area;
            P = people;
            Name = "Village";
        }

        public override string Show() => Name + " : houses(" + H.ToString() + "), people in it(" + P.ToString() + "), area(" + S.ToString() + ");"; 
        public override double Density() => (H * P) / S;

    }
}
