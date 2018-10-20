using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventSolarTechImprovement : IEvent
    {
        private Earth _earth;

        private string _name = "Solar Technology Improvement";
        public string Name //Name of event
        {
            get
            {
                return _name;
            }
        }

        private string _description = string.Join("",
            "Scientists have discovered a new method of creating solar cells, potentially enabling ",
            "rapid improvement in solar panel efficiency and cost.");
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

        public EventSolarTechImprovement(Earth earth)
        {
            _earth = earth;
        }
    }
}
