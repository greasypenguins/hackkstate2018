using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class Energy
    {
        private double _co2Rate = 0.25; //PPM/month (parts per million per month)
        public double Co2Rate
        {
            get
            {
                return _co2Rate;
            }
            set
            {
                _co2Rate = value;
            }
        }

        private double _relativeEnergyProduction = 1; //Relative to start of game
        public double RelativeEnergyProduction
        {
            get
            {
                return _relativeEnergyProduction;
            }
            set
            {
                _relativeEnergyProduction = value;
            }
        }

        private double _percentOil = 0.313;
        public double PercentOil
        {
            get
            {
                return _percentOil;
            }
            set
            {
                _percentOil = value;
            }
        }

        private double _percentCoal = 0.286;
        public double PercentCoal
        {
            get
            {
                return _percentCoal;
            }
            set
            {
                _percentCoal = value;
            }
        }

        private double _percentNaturalGas = 0.212;
        public double PercentNaturalGas
        {
            get
            {
                return _percentNaturalGas;
            }
            set
            {
                _percentNaturalGas = value;
            }
        }

        private double _percentWaste = 0.103;
        public double PercentWaste
        {
            get
            {
                return _percentWaste;
            }
            set
            {
                _percentWaste = value;
            }
        }

        private double _percentNuclear = 0.048;
        public double PercentNuclear
        {
            get
            {
                return _percentNuclear;
            }
            set
            {
                _percentNuclear = value;
            }
        }

        private double _percentHydro = 0.024;
        public double PercentHydro
        {
            get
            {
                return _percentHydro;
            }
            set
            {
                _percentHydro = value;
            }
        }

        private double _percentRenewable = 0.014;
        public double PercentRenewable
        {
            get
            {
                return _percentRenewable;
            }
            set
            {
                _percentRenewable = value;
            }
        }

        public Energy()
        {
            
        }

        public void ModifyOilUse(double modifier)
        {
            _percentOil *= modifier;


        }
    }
}
