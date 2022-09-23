using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumaconstructor
{
    class suma
    {
        public double V1;
        public double V2;

        public suma()
        {
        }

        public suma(double v1, double v2)
        {
            V1 = v1;
            V2 = v2;
        }
        public double sumar()
        {
            return V1 + V2;
        }
    }
}
