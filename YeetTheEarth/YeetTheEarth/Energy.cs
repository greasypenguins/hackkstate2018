using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class Energy
    {
        public double _rate;
        public Energy(Energy e, double rate)
        {
            _rate = rate;
        }

    }
    class EnergySource
    {

        private Energy _solar;
        public Energy Solar
        {
            get;
            set;
        }
        private Energy _hydro;
        public Energy Hydro
        {
            get;
            set;
        }
        private Energy _geothermic;
        public Energy Geothermic
        {
            get;
            set;
        }
        private Energy _wind;
        public Energy Wind
        {
            get;
            set;
        }
        private Energy _nuclear;
        public Energy Nuclear
        {
            get;
            set;
        }
        private Energy _coal;
        public Energy Coal
        {
            get;
            set;
        }
        private Energy _naturalGas;
        public Energy NaturalGas
        {
            get;
            set;
        }
    }
}
