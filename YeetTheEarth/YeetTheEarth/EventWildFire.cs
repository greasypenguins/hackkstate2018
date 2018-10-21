using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventWildFires : IEvent
    {
        private Earth _earth;

        private string[] _options = {
            "Invest in FireSafe, a liquid firefighting solution that is biodegradable in 4 months",
            "Do Nothing."};

        private string _name = "Fire Crisis";
        public string Name //Name of event
        {
            get
            {
                return _name;
            }
        }

        private string _description = string.Join("",
            "A Fire crisis has struck. Only you can stop wildfires. People are fleeing from their homes as the fires are destroying everything in its path. In a month, more than half of the cities will burn into ashes.",
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
            _monthsLeft--;
            return _options;

        }

        public string ChooseOption(int option) //Choose one of the options and get the result
        {
            switch (option)
            {
                case 1: //Fire stuff
                    _monthsLeft++;//change this
                    _earth.GDP -= 1000000000000;//change this
                    return "Small scale tests in Siberia show encouraging results.";//change this

                default: //Do nothing
                    return "The scientists have been ignored. Was this a wise choice? The world may never know.";//change this
            }
            
        }

        public EventWildFires(Earth earth)
        {
            _earth = earth;
        }
    }
}
