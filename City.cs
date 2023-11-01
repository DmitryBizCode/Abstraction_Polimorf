using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_polimo
{
    public class City : Settlement    
    {
        public City(int human, double area)
        {
            try { 
                H = human;
                S = Math.Round(area,2);
                Name = "City";
            }
            catch 
            {
                throw new ArgumentOutOfRangeException("error syntactsis");
            }
        }

        public override string Show() => Name + " : humans(" + H.ToString() + "), area(" + S.ToString() + ");";
        public override double Density()
        {
            if(H <= 0 ||  S <= 0)
                throw new ArgumentOutOfRangeException("Invalid enter data");

            return H / S;
        }
    }
}
