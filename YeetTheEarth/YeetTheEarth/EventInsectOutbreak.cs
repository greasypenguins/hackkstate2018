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
            "A horde of beetles have infested most cities Mexico. ",
            "It's quite disgusting and many are panicing while crops are dying. What do you do?");
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
                case 0://pesticide
                    _earth.Co2Rate += .5;
                    _earth.TempRate += .5;
                    return "The pesticide made the enviorment cry into the ocean which led to many disasters including the temperature and CO2 concentration rising. Oops.";

                case 1://bug spray
                    _earth.GDP -= 50000;
                    return "Distributing the bug spray may have cause a little penny but everyone was sure happy about it.";

                default://nothing
                    _earth.Population -= 50000;
                    return "In your effort to be incompitent, you have left society to fend for itself with the bugs. There were minor outbreaks of bug related accidents killing 50,000 people.";
            }
        }

        public EventInsectOutbreak(Earth earth)
        {
            _earth = earth;
        }
    }
}