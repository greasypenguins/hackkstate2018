using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventThoriumPower : IEvent
    {
        private readonly string _art = @"                ,     :     ,
          '.    ;    :    ;    ,`
      '-.   '.   ;   :   ;   ,`   ,-`
   "" -.   '-.  '.  ;  :  ;  ,`  ,-`   ,-""
      ""-.   '-. '. ; : ; ,` ,-`   ,-""
 '""--.   '""-.  '-.'  '  `.-`  ,-""`   ,--""`
      '""--.  '""-.   ...   ,-""`  ,--""`
           '""--.  .:::::.  ,--""`
------------------:::::::------------------
                   ~~~~~
                    ~~~
                     ~"; //ASCII art for this event
        public string Art
        {
            get
            {
                return _art;
            }
        }

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

        private string _description = "Researchers have discovered the secret to producing electricity by harvesting the power of the Thorium atom. Now, nuclear advocates suggest scaling the technology to replace conventional power sources.";
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
                case 0: //power plants
                    if (_earth.PoliticalPoints < 2)
                    {
                        return "You did not have enough political influence to pursue your plan. Nothing happened.";
                    }
                    _earth.GDP = _earth.GDP - 3000000000;
                    _earth.Energy.ModifyNuclearUse(.5);
                    _earth.Co2Rate *= -1.05;
                    _earth.Population = _earth.Population - 30000000;
                    return "You have spent $3,000,000,000 on new nuclear plants. The percent of Nuclear power has increased. The rate of CO2 concentrasion rise has decreased. A nuclear reactor exploded and killed 30,000,000 people.";
                default:
                    return "Nothing happened.";
            }

        }

        public EventThoriumPower(Earth earth)
        {
            _earth = earth;
        }
    }
}
