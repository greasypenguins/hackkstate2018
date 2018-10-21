using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventCoralReefDestruction:IEvent
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
            "Under the sea, get it? The coral reef will be no more with the continuous increase of heat absorbed by the ocean. In a 6 months, a quater of the reef will die off.",
            "Its been a month later, will you save the reef?");
        public string Description //Description of event
        {
            get
            {
                return _description;
            }
        }

        private static int _totalMonths = 6; //Total length of event
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
                case 1://CoralReef
                    _monthsLeft++;//change this
                    _earth.GDP -= 287000000;//change this
                    return "Smokey the bear is happy that you have invested in preventing future wildfires";//change this

                default: //Do nothing
                    return "The investment have been ignored. Was that a smart choice? Let the world burn to ashes";//change this
            }

        }

        public EventWildFires(Earth earth)
        {
            _earth = earth;
        }
    }
}
