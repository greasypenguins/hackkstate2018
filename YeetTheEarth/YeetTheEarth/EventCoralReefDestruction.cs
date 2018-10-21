using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventCoralReefDestruction : IEvent
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
            "Under the sea, get it? The Great Barrier Reef in Australia will be no more with the continuous increase of heat absorbed by the ocean. In a 6 months, a quater of the reef will die off.",
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
                    _earth.GDP -= 33540000;//change this
                    return "Cleaning the Ocean, this might take a bit of time, but the marine life will thank you.";//change this
                case 2:
                    _monthsLeft++;
                    _earth.GDP -= 3770000;
                    return "Adding extra protection for the reef, what an investment. This causes the population of the coral reef to increase and improve water quality in the ocean.";

                default: //Do nothing
                    return "You ignored to conserve the coral reef. The population of coral reef died very rapidly causing a scarcity on seafood. Did you hate seafood?";//change this
            }

        }

        public EventCoralReefDestruction(Earth earth)
        {
            _earth = earth;
        }
    }
}