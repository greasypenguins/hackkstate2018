using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventHurricanes : IEvent
    {
        private Earth _earth;

        private string[] _options = {
            "There is alot trash in the ocean, so its going to take 5 months to do this",
            "Investment for protection for the reef, so it can grow and thrive once again",
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
            "Neptune is angry and sending hurricanes everywhere from Africa. Scientist have concluded it will take 2 months before the hurricanes flood and destroy most of Japan",
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
        }1
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
                    _earth.GDP -= 33540000;//change this
                    return "Cleaning the Ocean, this might take a bit of time";//change this
                case 2:
                    _monthsLeft++;
                    _earth.GDP -= 3770000;
                    return "Adding extra protection for the reef, what an investment. ";

                default: //Do nothing
                    return "The investment have been ignored. Was that a smart choice? Let the world burn to ashes";//change this
            }

        }

        public EventHurricanes(Earth earth)
        {
            _earth = earth;
        }
    }
}