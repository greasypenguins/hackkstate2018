using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class Earth
    {
        public int Year = 2016;
        private double _temp;
        public double Temp
        {
            get
            {
                return _temp;
            }
            set
            {
                _temp = 42;
            }
        }

        private string[] _month;
        private int _indexMonth = 1;
        private string _currentMonth;
        public string CurrentMonth
        {
            get
            {
                return _currentMonth;
            }
            set
            {
                _currentMonth = Month[_indexMonth];
            }
        }

        public string[] Month
        {
            get
            {
                return _month;
            }
            set
            {
                _month = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };


            }
        }
        private double _tempRate;
        public double TempRate
        {
            get
            {
                return _tempRate;
            }
        }

        private double _co2Con;
        public double Co2Con
        {
            get
            {
                return _co2Con;
            }
        }

        private double _co2Rate;
        public double Co2Rate
        {
            get
            {
                return _co2Rate;
            }
        }

        private double _gdp;
        public double GDP
        {
            get
            {
                return _gdp;
            }
        }

        private int _population;
        public int Population
        {
            get
            {
                return _population;
            }
        }

        private int _seaLevel;
        public int SeaLevel
        {
            get
            {
                return _seaLevel;
            }
        }

        private double _seaRate;
        public double SeaRate
        {
            get
            {
                return _seaLevel;
            }
        }

        private int _politicPoints = 3;
        public int PoliticPoints
        {
            get
            {
                return _politicPoints;
            }
            set
            {
                _politicPoints++;
            }
        }

        private double _polarCaps;
        public double PolarCap
        {
            get
            {
                return _polarCaps;
            }
        }


        public void AdvanceMonth()
        {
            _indexMonth++;
            CurrentMonth = Month[_indexMonth];
        }
    }
}
