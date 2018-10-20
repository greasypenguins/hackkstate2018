using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventEconomicCrisis : IEvent
    {
        private Earth _earth;

        private string[] _options = {
            "Invest in Coal.",
            "Invest in Solar.",
            "Invest in Wind",
            "Invest in Nuclear",
            "Invest in Natural Gas",
            "Invest in Geothermic",
            "Invest in Hydro",
            "Impliment a energy program to teach about energy conservation",
            "Do Nothing."};

        private string _name = "";
        public string Name //Name of event
        {
            get
            {
                return _name;
            }
        }

        private string _description = string.Join("",
            "An energy crisis has struck. People have been rapidly using energy this month and you notice you wont have enough to last.",
            "Its only half way through the month. What do you do?");
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
        public string[] NextMonth() //Advance the event one month and get options
        {
            string[] ret;

            switch (_monthsLeft)
            {
                case 3:
                    ret = _options;
                    break;
                case 2:
                    ret = "";
                    break;
                case 1:
                    ret = "";
                    break;
                default:
                    ret = "";
                    break;
            }
        }

            public string ChooseOption(int option) //Choose one of the options and get the result
        {
            throw new NotImplementedException();
        }
    }
}
