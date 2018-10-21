using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventPopulationExplosion : IEvent
    {
        private Earth _earth;

        private string[] _options = {
            "Do nothing.",
            "Invest in family planning.",
            "Implement two child policy.",
            "Remove part of the population."};

        private string _name = "Population Explosion";
        public string Name //Name of event
        {
            get
            {
                return _name;
            }
        }

        private string _description = string.Join("",
            "There has been a sudden population explosion in Venezuela! Many experts warn that unchecked ",
            "population growth could lead to famine or an energy crisis.");
        public string Description //Description of event
        {
            get
            {
                return _description;
            }
        }

        private static int _totalMonths = 3; //Total length of event
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
            throw new NotImplementedException();
        }

        public string[] NextMonth() //Advance the event one month and get options
        {
            string[] ret;

            switch (_monthsLeft)
            {
                case 3:
                    ret = _options;
                    break;
                case 2:
                    ret = _options;
                    break;
                case 1:
                    ret = _options;
                    break;
                default:
                    ret = _options;
                    break;
            }

            throw new NotImplementedException();
            _monthsLeft--;
            return ret;
        }

        public EventPopulationExplosion(Earth earth)
        {
            _earth = earth;
        }
    }
}
