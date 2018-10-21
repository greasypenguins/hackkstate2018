using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventPopulationExplosion : IEvent
    {
        private readonly string _art = ""; //ASCII art for this event
        public string Art
        {
            get
            {
                return _art;
            }
        }

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
            switch (option)
            {
                case 1://family planning
                    _monthsLeft = 0;
                    return "This stopped the increase in population. However, you didn't lose any in the process. Good job.";
                case 2://impliment two child policy
                    _monthsLeft = 0;
                    _earth.GDP -= 1000000000;
                    return "This decreased amount of p//  opulation but now there isn't enough children and in turn overly decreased population. Oh no.";
                case 3://remove part of population
                    _monthsLeft = 0;
                    _earth.Population -= 100000000;
                    _earth.GDP -= 500000000;
                    return "You have decided mass genocide. You have lost 1,000,000,000 in the process and in turn lost a lot of money doing so. Probably not the best idea to just kill people.";
                default://nothing
                    _earth.Population -= 5000;
                    return "You did nothing this month. Population will increase.";
            }
        }

        public string[] NextMonth() //Advance the event one month and get options
        {
            string[] ret;

            switch (_monthsLeft)
            {
                case 3:
                    _earth.Population += 5000000;
                    ret = _options;
                    break;
                case 2:
                    _earth.Population += 5000000;
                    ret = _options;
                    break;
                case 1:
                    _earth.Population += 5000000;
                    ret = _options;
                    break;
                default:
                    ret = _options;
                    break;
            }

            _monthsLeft--;
            return ret;
        }

        public EventPopulationExplosion(Earth earth)
        {
            _earth = earth;
        }
    }
}
