using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class Energy
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


        public Energy(Energy e)
        {

        }

    }
}
