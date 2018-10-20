using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class Earth
    {
        private int _monthsElapsed = 0;
        public int MonthsElapsed
        {
            get
            {
                return _monthsElapsed;
            }
        }

        public int YMYearsElapsed //(Year-Month format) Rounded down to whole number
        {
            get
            {
                return (_monthsElapsed / (int)12);
            }
        }

        public int YMMonthsElapsed //(Year-Month format) Months elapsed in addition to the years elapsed
        {
            get
            {
                return _monthsElapsed - (12 * (_monthsElapsed / (int)12));
            }
        }

        private int _year = 2018;
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        private string[] _months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        private int _monthIndex = 9; //Start in October
        public int MonthIndex
        {
            get
            {
                return _monthIndex;
            }
            set
            {
                _monthIndex = value;
            }
        }

        public string CurrentMonth
        {
            get
            {
                return _months[_monthIndex];
            }
        }

        private double _temp = 14.7; //Degrees C
        public double Temp
        {
            get
            {
                return _temp;
            }
            set
            {
                _temp = value;
            }
        }

        private double _tempRate = 0.00142; //Degrees C per month (+1.7 C / Century)
        public double TempRate
        {
            get
            {
                return _tempRate;
            }
            set
            {
                _tempRate = value;
            }
        }

        private double _co2Con = 402.52; //PPM (parts per million)
        public double Co2Con
        {
            get
            {
                return _co2Con;
            }
            set
            {
                _co2Con = value;
            }
        }

        public double Co2Rate
        {
            get
            {
                return _energy.Co2Rate;
            }
            set
            {
                _energy.Co2Rate = value;
            }
        }

        private decimal _gdp = 79865481000000; //Dollars
        public decimal GDP
        {
            get
            {
                return _gdp;
            }
            set
            {
                _gdp = value;
            }
        }

        private long _population = 7466964280; //People
        public long Population
        {
            get
            {
                return _population;
            }
            set
            {
                _population = value;
            }
        }

        private double _seaLevel = 0; //Meters
        public double SeaLevel
        {
            get
            {
                return _seaLevel;
            }
            set
            {
                _seaLevel = value;
            }
        }

        private double _seaRate = .000258; //Meters per month
        public double SeaRate
        {
            get
            {
                return _seaLevel;
            }
            set
            {
                _seaLevel = value;
            }
        }

        private readonly double _startingLandArea = 148940000; //Square km
        private readonly double _landPercentLossRateConstant = 0.0000083 / 0.000258; //Multiply by _seaRate to get % lost that month
        private double _landPercentLost = 0;
        public double LandPercentLost //Percent of land area lost since start of game
        {
            get
            {
                return _landPercentLost;
            }
        }
        public double LandAreaLost
        {
            get
            {
                return _landPercentLost * _startingLandArea;
            }
        }

        private int _politicalPoints = 3;
        private int _politicalPointsRate = 3; //Points per month
        public int PoliticalPoints
        {
            get
            {
                return _politicalPoints;
            }
            set
            {
                _politicalPoints = value;
            }
        }

        private Energy _energy;
        public Energy Energy
        {
            get
            {
                return _energy;
            }
            set
            {
                _energy = value;
            }
        }

        public void NextMonth()
        {
            _monthsElapsed++;
            _monthIndex = (_monthIndex + 1) % 12;
            if(_monthIndex == 0)
            {
                _year++;
            }

            _temp += _tempRate;
            _co2Con += _energy.Co2Rate;
            _seaLevel += _seaRate;
            _landPercentLost += _landPercentLossRateConstant * _seaRate;
            _politicalPoints += _politicalPointsRate;
            _tempRate += _energy.Co2Rate / (double)10000000;
        }

        public Earth()
        {
            _energy = new Energy();
        }
    }
}
