using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventSolarTechImprovement : IEvent
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
            "Invest in solar research.",
            "Mass produce solar technology."};

        private string _name = "Solar Technology Improvement";
        public string Name //Name of event
        {
            get
            {
                return _name;
            }
        }

        private string _description = string.Join("",
            "Scientists have discovered a new method of creating solar cells, potentially enabling ",
            "rapid improvement in solar panel efficiency and cost.");
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
                    _earth.GDP -= 10000000000;
                    return "Scientist have studied hard and have found nothing. Lost a little money. Oh well.";

                case 2://solar research
                    _monthsLeft = 0;
                    _earth.Co2Rate -= .05;
                    _earth.TempRate -= .05;

                    return "This helped decrease CO2 and temperature rate.";
                default://nothing
                    _earth.Co2Rate += 1;
                    _earth.TempRate += 1;
                    _earth.SeaRate += 1;
                    return "You did nothing this month. This has increased temperature, CO2, and the sea level.";
            }
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
            _monthsLeft--;
            return ret;
        }

        public EventSolarTechImprovement(Earth earth)
        {
            _earth = earth;
        }
    }
}
