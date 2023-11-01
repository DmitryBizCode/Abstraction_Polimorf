using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_polimo
{
    public class Village : Settlement
    {
        private int P { get; set; }
        public Village(int house,int people, double area) {
            try
            {
                H = house;
                S = Math.Round(area, 2);
                P = people;
                Name = "Village";
            }
            catch 
            {
                throw new ArgumentOutOfRangeException("error syntactsis");
            }
        }

        public override string Show() => Name + " : houses(" + H.ToString() + "), people in it(" + P.ToString() + "), area(" + S.ToString() + ");";
        public override double Density()
        {
            if (H <= 0 || S <= 0 || P <= 0)
                throw new ArgumentOutOfRangeException("Invalid enter data");
            return (H * P) / S;
        }
    }
}
