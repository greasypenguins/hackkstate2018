using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class Earth
    {

        public Earth()
        {

        }
        public int Year = 2016;
        private double _temp = 1.87;
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

        private string[] _month = new string[12];
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
        private double _tempRate = .025;
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

        private double _co2Con = 402.52;
        public double Co2Con
        {
            get
            {
                return _co2Con;
            }
        }

        private double _co2Rate = .0036;
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

        private double _gdp = 79865481;
        public double GDP
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

        private long _population = 7466964280;
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

        private double _seaLevel = 82.8;
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

        private double _seaRate = .04;
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

        private int _politicPoints = 3;
        public int PoliticPoints
        {
            get
            {
                return _politicPoints;
            }
            set
            {
                _politicPoints  = value;
            }
        }

        private double _polarCaps;
        public double PolarCap
        {
            get
            {
                return _polarCaps;
            }
            set
            {
                _polarCaps = value;
            }
        }


        public void AdvanceMonth()
        {
            _indexMonth++;
            CurrentMonth = Month[_indexMonth];
        }
    }
}
