using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventEconomicCrisis : IEvent
    {
        private readonly string _art = @"         _._._                       _._._
        _|   |_                     _|   |_
        | ... |_._._._._._._._._._._| ... |
        | ||| |  o NATIONAL BANK o  | ||| |
        | """""" | """"""    """"""    """"""  | """""" |
   ())  |[-|-]| [-|-] [-|-] [-|-] |[-|-]|  ())
  (())) |     |---------------------|     | (()))
 (()) ())| """""" |  """"""    """"""    """"""  | """""" |(())())
 (()))()|[-|-]|  :::   .-""-.   :::  |[-|-]|(()))()
 ()))(()|     | |~|~|  |_|_|  |~|~| |     |()))(()
    ||  |_____|_|_|_|__|_|_|__|_|_|_|_____|  ||
 ~ ~^^ @@@@@@@@@@@@@@/=======\@@@@@@@@@@@@@@ ^^~ ~
      ^~^~                                ~^~^"; //ASCII art for this event
        public string Art
        {
            get
            {
                return _art;
            }
        }

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
            "An energy crisis has struck. People have been rapidly using energy this month and you notice you wont have enough to last for the next four months.",
            "What do you do?");
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
                case 0://coal
                    _monthsLeft = 0;
                    _earth.Energy.ModifyCoalUse(.5);
                   return "Coal use rate increased.";
                case 1://renewable
                    _monthsLeft = 0;
                    _earth.Energy.ModifyRenewableUse(.5);
                    return "Renewable energy use rate increased.";
                case 2://nuclear
                    _monthsLeft = 0;
                    return "Nuclear energy use rate increased.";
                case 3://natural
                    _monthsLeft = 0;
                    return "Natural gas use rate increased.";
                case 4://hydro
                    _monthsLeft = 0;
                    return "Hydro energy use rate increased.";
                case 5://oil
                    _monthsLeft = 0;
                    return "Oil use rate increased.";
                case 6://biodegradable
                    _monthsLeft = 0;
                    _earth.Energy.ModifyHydroUse(-.5);
                    return "Biodegradable energy has increased.";
                case 7://teach
                    _monthsLeft = 0;
                    return "You taught students to conserve energy. Ending the energy crisis. You didnt increase anything though.";
                default:
                    return "You have done nothing this month. The energy crisis is still there.";
            }
            
        }

        public EventEconomicCrisis(Earth earth)
        {
            _earth = earth;
        }
    }
}
