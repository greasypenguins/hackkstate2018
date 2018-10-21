using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventDeforestation : IEvent
    {
        private Earth _earth;

        private string[] _options = {
            "Plant trees.",
            "Impliment laws against deforestation.",
            "Increase amount of trees being cut.",
            "Do Nothing."};

        private string _name = "Rainforest Deforestation";
        public string Name //Name of event
        {
            get
            {
                return _name;
            }
        }

        private string _description = string.Join("",
            "Breaking News! The cooperate airheadsthought it was a good idea to start cutting down rainforests in Brazil for 'paper'.",
            " If we don't stop them all the trees will be gone!!!! What will you do to save the trees?");
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
                case 0://plant trees

                    _earth.Co2Rate -= .05;
                    _earth.GDP -= 33540000;//change this
                    return "You plant a lot of trees! It doesnt stop them from cutting but you are fighting back! This decreases CO2 rate but cost quite a penny.";//change this
                case 1://laws
                    return "You stop the cooperate idiots! You saved the trees.";
                case 2://cut more trees
                    _earth.Co2Rate += .05;
                    _earth.TempRate += .05;
                    _earth.Population -= 1000000000;
                    return "You monster! You made the situation worse... Now all the trees are gone, the animals are attacking humans and the CO2 and temperature levels are going up!";

                default: //Do nothing
                    _earth.GDP -= 30000000;
                    _earth.TempRate += 0.02;
                    _earth.Co2Rate += .02;

                    return "You ignored to save the trees. :( This raised the CO2 level and temperature. All the wildlife is dying. Nature is in chaos.";//change this
            }

        }

        public EventDeforestation(Earth earth)
        {
            _earth = earth;
        }
    }
}
