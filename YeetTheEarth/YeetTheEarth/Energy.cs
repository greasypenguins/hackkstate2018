using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class Energy
    {
        private double _co2RateConstant = 0.26; //PPM/month (parts per million per month)
        public double Co2Rate
        {
            get
            {
                return _co2RateConstant * _relativeEnergyProduction;
            }
            set
            {
                _co2RateConstant = value / _relativeEnergyProduction;
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

        //Private because it's used when percents don't add up to 100%
        private double SumPercents()
        {
            return (_percentOil + _percentCoal + _percentNaturalGas + _percentWaste + _percentNuclear + _percentHydro + _percentRenewable);
        }

        //Private because it multiplies all percents so it will be over/under 100%
        private void ModifyPercents(double modifier)
        {
            _percentOil *= modifier;
            _percentCoal *= modifier;
            _percentNaturalGas *= modifier;
            _percentWaste *= modifier;
            _percentNuclear *= modifier;
            _percentHydro *= modifier;
            _percentRenewable *= modifier;
        }

        public void ModifyOilUse(double modifier)
        {
            double otherModifier;

            _percentOil *= modifier;

            //otherModifier = goal_all_other_percents / all_other_percents
            otherModifier = (1 - _percentOil) / (SumPercents() - _percentOil);

            ModifyPercents(otherModifier);
            _percentOil /= otherModifier; //Correction
        }

        public void ModifyCoalUse(double modifier)
        {
            double otherModifier;

            _percentCoal *= modifier;

            //otherModifier = goal_all_other_percents / all_other_percents
            otherModifier = (1 - _percentCoal) / (SumPercents() - _percentCoal);

            ModifyPercents(otherModifier);
            _percentOil /= otherModifier; //Correction
        }
        public void ModifyNaturalGasUse(double modifier)
        {
            double otherModifier;

            _percentNaturalGas *= modifier;

            //otherModifier = goal_all_other_percents / all_other_percents
            otherModifier = (1 - _percentNaturalGas) / (SumPercents() - _percentNaturalGas);

            ModifyPercents(otherModifier);
            _percentNaturalGas /= otherModifier; //Correction
        }
        public void ModifyWasteUse(double modifier)
        {
            double otherModifier;

            _percentWaste *= modifier;

            //otherModifier = goal_all_other_percents / all_other_percents
            otherModifier = (1 - _percentWaste) / (SumPercents() - _percentWaste);

            ModifyPercents(otherModifier);
            _percentWaste /= otherModifier; //Correction
        }
        public void ModifyNuclearUse(double modifier)
        {
            double otherModifier;

            _percentNuclear *= modifier;

            //otherModifier = goal_all_other_percents / all_other_percents
            otherModifier = (1 - _percentNuclear) / (SumPercents() - _percentNuclear);

            ModifyPercents(otherModifier);
            _percentNuclear /= otherModifier; //Correction
        }
        public void ModifyHydroUse(double modifier)
        {
            double otherModifier;

            _percentHydro *= modifier;

            //otherModifier = goal_all_other_percents / all_other_percents
            otherModifier = (1 - _percentHydro) / (SumPercents() - _percentHydro);

            ModifyPercents(otherModifier);
            _percentHydro /= otherModifier; //Correction
        }
        public void ModifyRenewableUse(double modifier)
        {
            double otherModifier;

            _percentRenewable *= modifier;

            //otherModifier = goal_all_other_percents / all_other_percents
            otherModifier = (1 - _percentRenewable) / (SumPercents() - _percentRenewable);

            ModifyPercents(otherModifier);
            _percentRenewable /= otherModifier; //Correction
        }
    }
}
