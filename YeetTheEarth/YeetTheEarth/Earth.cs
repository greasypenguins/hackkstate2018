using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.

namespace YeetTheEarth
{
    class Earth
    {
        private double _temp;

        public double Temp
        {
            get
            {
                return _temp;
            }
            set
            {
                _temp = GetRandomNumber(0, 160);
            }
        }




        static Random random = new Random();
        public double GetRandomNumber(double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
