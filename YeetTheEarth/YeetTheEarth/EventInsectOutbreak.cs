using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventInsectOutbreak : IEvent
    {
        private Earth _earth;

        private string[] _options = {
            "Increase pesticide.",
            "Distribute bug spray.",
            "Nothing."};

        private string _name = "Insect Outbreak";
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
            _earth.NextMonth();
            return _options;
        }

        public string ChooseOption(int option) //Choose one of the options and get the result
        {
            StringBuilder reaction = new StringBuilder();
            switch (option)
            {
                case 1:
                    _earth.GDP = _earth.GDP - 3000000000;
                    _earth.Energy.ModifyNuclearUse(.5);
                    _earth.Co2Rate = _earth.Co2Rate - 0.5;
                    _earth.Population = _earth.Population - 30000000;
                    reaction.Append("You have spent $3,000,000,000 on new nuclear plants");
                    reaction.Append("\nThe percent of Nuclear power has increased.");
                    reaction.Append("\nThe rate of CO2 concentrasion rise has decreased.");
                    reaction.Append("\nA nuclear reactor eploded and killed 30,000,000 people.");
                    break;
                case 2:
                    reaction.Append("\nNothing happened.");
                    break;
            }
            return reaction.ToString();
        }

        public EventInsectOutbreak(Earth earth)
        {
            _earth = earth;
        }
    }
}
