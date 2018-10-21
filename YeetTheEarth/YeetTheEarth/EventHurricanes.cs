using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventHurricanes : IEvent
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
            "Evacuate Japan.",
            "Send resources.",
            "Do Nothing."};

        private string _name = "Hurricanes";
        public string Name //Name of event
        {
            get
            {
                return _name;
            }
        }

        private string _description = string.Join("",
            "Neptune is angry and sending hurricanes from Africa. Scientists have concluded it will take 2 months before the hurricanes flood and destroy most of Japan.",
            " Day one, what do you plan to do to save Japan?");
        public string Description //Description of event
        {
            get
            {
                return _description;
            }
        }

        private static int _totalMonths = 2; //Total length of event
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
                case 0://evacuate
                    _monthsLeft = 0;
                    _earth.GDP -= 60000000000;//change this
                    return "It cost a bit but you didn't lose lives. Japan is in debt to you.";//change this
                case 1://send resources
                    _monthsLeft = 0;
                    _earth.SeaRate += .5;
                    _earth.GDP -= 4000000000;
                    _earth.Population -= 50000;
                    return "Japan was very thankful for the resources. It costed quite a penny but people were saved. The sea levels and were greatly affected and some people did end up dying.";

                default: //Do nothing
                    _earth.SeaRate += .5;
                    _earth.Population -= 1000000;
                    return "You have done nothing. Japan is in turmoil and the population decreased severely and the sea level raised dramatically.";//change this
            }

        }

        public EventHurricanes(Earth earth)
        {
            _earth = earth;
        }
    }
}