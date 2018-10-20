using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventPopulationExplosion : IEvent
    {
        private Earth _earth;

        private string _name = "Population Explosion";
        public string Name //Name of event
        {
            get
            {
                return _name;
            }
        }

        private string _description = string.Join("",
            "There has been a sudden population explosion in Venezuela! Many experts warn that unchecked ",
            "population growth could lead to famine or an energy crisis.");
        public string Description //Description of event
        {
            get
            {
                return _description;
            }
        }

        int _monthsLeft = 3; //Total length of event
        public int MonthsLeft //Remaining duration of event in months
        {
            get
            {
                return _monthsLeft;
            }
        }

        public string ChooseOption(int option) //Choose one of the options and get the result
        {
            throw new NotImplementedException();
        }

        public string NextMonth() //Advance the event one month and get a message
        {
            _monthsLeft--;

            throw new NotImplementedException();
        }

        public EventPopulationExplosion(Earth earth)
        {
            _earth = earth;
        }
    }
}
