using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                _month = new string[12] {"January", "February", "March", "April", "May","June", "July", "August", "September","October" , "November", "December"};
                

            }
        }
        


        public void AdvanceMonth(string month)
        {
            _indexMonth++;
            CurrentMonth = Month[_indexMonth]; 
        }
    }
}
