using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventThorumPower : IEvent
    {
        private Earth _earth;

        private string[] _options = {
            "Make Thorium Power Plants.",
            "Do Nothing."};

        private string _name = "Energy Crisis";
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

        private static int _totalMonths = 1; //Total length of event
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
            _earth.AdvanceMonth();

            return _options;


        }

        public string ChooseOption(int option) //Choose one of the options and get the result
        {
            throw new NotImplementedException();
        }

        public EventThorumPower(Earth earth)
        {
            _earth = earth;
        }
    }
}
