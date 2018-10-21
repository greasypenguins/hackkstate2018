using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventWildFires : IEvent
    {
        private readonly string _art = @"           \/ |    |/
        \/ / \||/  /_/___/_
         \/   |/ \/
    _\__\_\   |  /_____/_
           \  | /          /
  __ _-----`  |{,-----------~
            \ }{
             }{{
             }}{
             {{}
       , -=-~{ .-^- _
             `}
              {"; //ASCII art for this event
        public string Art
        {
            get
            {
                return _art;
            }
        }

        private Earth _earth;

        private string[] _options = {
            "Invest in FireSafe, a liquid firefighting solution that is biodegradable in 4 months",
            "Do Nothing."};

        private string _name = "Wild Fires";
        public string Name //Name of event
        {
            get
            {
                return _name;
            }
        }

        private string _description = string.Join("",
            "A Fire crisis has struck the United States. Only you can stop wildfires. People are fleeing from their homes as the fires are destroying everything in its path. In a month, more than half of the country will burn into ashes.",
            " Only you can save the forest.");
        public string Description //Description of event
        {
            get
            {
                return _description;
            }
        }

        private static int _totalMonths = 4; //Total length of event
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
                case 0: //Fire stuff
                    if (_earth.PoliticalPoints < 1)
                    {
                        _earth.Co2Rate *= 1.05;
                        _earth.GDP -= 34643000;
                        _earth.Population -= 432000;
                        return "You did not have enough political influence to pursue your plan. The forest is crying.";
                    }
                    _monthsLeft = 0;
                    _earth.GDP -= 2870000;//change this
                    return "Smokey the bear is happy that you have invested in preventing future wildfires";//change this

                default: //Do nothing
                    _earth.Co2Rate *= 1.05;
                    _earth.GDP -= 34643000;
                    _earth.Population -= 432000;
                    return "The investment have been ignored. Was that a smart choice? Ashes. Ashes. We all fall down.";//change this
            }

        }

        public EventWildFires(Earth earth)
        {
            _earth = earth;
        }
    }
}
