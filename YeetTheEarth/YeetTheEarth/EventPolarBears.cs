using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventPolarBears : IEvent
    {
        private Earth _earth;

        private string[] _options = {
            "Do nothing.",
            "Invest in polar bear breeding programs in world-famous zoos."};

        private string _name = "Polar Bear Die-Off";
        public string Name //Name of event
        {
            get
            {
                return _name;
            }
        }

        private string _description = "Polar bear numbers are dwindling and researchers are becoming concerned for their survival.";
        public string Description //Description of event
        {
            get
            {
                return _description;
            }
        }

        private static int _totalMonths = 1; //Total length of event
        private int _monthsLeft = _totalMonths;
        public int MonthsLeft //Remaining duration of event in months
        {
            get
            {
                return _monthsLeft;
            }
        }

        public string ChooseOption(int option) //Choose one of the options and get the result
        {
            switch (option)
            {
                case 1: //breeding program
                    if(_earth.PoliticalPoints < 2)
                    {
                        return "You did not have enough political influence to pursue your plan. The polar bears have been ignored.";
                    }
                    _earth.PoliticalPoints -= 2;
                    _earth.GDP -= 1000000000;
                    return "The polar bear breeding program was expensive and widely criticized as an ineffective coverup of the real problem. Critics say the only way to save the polar bears is to save polar sea ice.";
                
                default: //Do nothing
                    return "The polar bears have been ignored, for now. You focus on solving the root problem of receding polar ice caps caused by global warming.";
            }
        }

        public string[] NextMonth() //Advance the event one month and get options
        {
            _monthsLeft--;
            return _options;
        }

        public EventPolarBears(Earth earth)
        {
            _earth = earth;
        }
    }
}
