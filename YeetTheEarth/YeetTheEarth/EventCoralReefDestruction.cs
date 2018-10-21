using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventCoralReefDestruction : IEvent
    {
        private readonly string _art = @"      /`·.¸
     /¸...¸`:·
 ¸.·´  ¸   `·.¸.·´)
: © ):´;      ¸  {
 `·.¸ `·  ¸.·´\`·¸)
     `\\´´\¸.·´"; //ASCII art for this event
        public string Art
        {
            get
            {
                return _art;
            }
        }

        private Earth _earth;

        private string[] _options = {
            "Encourage people to dirty the water.",
            "Investment for protection for the reef, so it can grow and thrive once again.",
            "Do Nothing."};

        private string _name = "Coral Reef Destruction";
        public string Name //Name of event
        {
            get
            {
                return _name;
            }
        }

        private string _description = string.Join("",
            "Under the sea, get it? The Great Barrier Reef in Australia will be no more with the continuous increase of heat absorbed by the ocean. In 3 months, a quater of the reef will die off.",
            " Will you save the reef?");
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
            _monthsLeft--;
            return _options;

        }

        public string ChooseOption(int option) //Choose one of the options and get the result
        {
            switch (option)
            {
                case 0://CoralReef

                    _earth.Co2Rate *= 1.05;
                    _earth.SeaRate += .05;
                    _earth.GDP -= 33540000;//change this
                    return "How horrible! The ocean is getting worse rising the sea levels and CO2 concentration.";//change this
                case 1:
                    _monthsLeft = 0;
                    _earth.GDP -= 3770000;
                    return "Adding extra protection for the reef, what an investment. This causes the population of the coral reef to increase and improve water quality in the ocean.";

                default: //Do nothing
                    _earth.GDP -= 3042303;
                    _earth.TempRate += 0.2;
                    _earth.SeaRate += .02;

                    return "You ignored to conserve the coral reef. This raised the sea level and temperature. The population of coral reef died very rapidly causing a scarcity on seafood. Did you hate seafood?";//change this
            }

        }

        public EventCoralReefDestruction(Earth earth)
        {
            _earth = earth;
        }
    }
}