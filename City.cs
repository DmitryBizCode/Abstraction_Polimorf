using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_polimo
{
    internal class City : Settlement    
    {
        public City(int human, double area)
        {
            H = human;
            S = area;
            Name = "City";
        }

        public override string Show() => Name + " : humans(" + H.ToString() + "), area(" + S.ToString() + ");";
        public override double Density() => H / S;
    }
}
