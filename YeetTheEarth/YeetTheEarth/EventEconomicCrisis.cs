using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventEconomicCrisis : IEvent
    {
        private Earth _earth;

        private string[] _options = {
            "Invest in Coal.",
            "Invest in Renewable Energy",
            "Invest in Nuclear",
            "Invest in Natural Gas",
            "Invest in Hydro",
            "Invest in Oil",
            "Invest in Biodegradable Energy",
            "Impliment a energy program to teach about energy conservation",
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
            _monthsLeft--;
            return _options;


        }

        public string ChooseOption(int option) //Choose one of the options and get the result
        {
            

            switch (option)
            {
                case 0://coal
                    _earth.Energy.ModifyCoalUse(.5);
                   return "Coal use rate increased.";
                case 1://renewable
                    _earth.Energy.ModifyRenewableUse(.5);
                    return "Renewable energy use rate increased.";
                    return "";
                case 2://nuclear
                    return "Nuclear energy use rate increased.";
                case 3://natural
                    return "Natural gas use rate increased.";
                case 4://hydro
                    return "Hydro energy use rate increased.";
                case 5://oil
                    return "Oil use rate increased.";
                case 6://biodegradable
                    _earth.Energy.ModifyHydroUse(-.5);
                    return "Biodegradable ";
                case 7://teach
                    return "";
                default:
                    return "";
            }
            
        }

        public EventEconomicCrisis(Earth earth)
        {
            _earth = earth;
        }
    }
}
