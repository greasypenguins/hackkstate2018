﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventGeoengAtmosphere : IEvent
    {
        private readonly string _art = @"      _,                _.
     (  `)            (`  ).
  .=( ` ,_ `)    .-``(      ).
 (.__.:-`-_.'   (.,,(.       '`.
                      `--`--`'`"; //ASCII art for this event
        public string Art
        {
            get
            {
                return _art;
            }
        }

        private Earth _earth;

        private string[] _options = {
            "Do nothing.",
            "Conduct small area testing.",
            "Deploy worldwide."};

        private string _name = "Atmospheric Geoengineering";
        public string Name //Name of event
        {
            get
            {
                return _name;
            }
        }

        private string _description = "Scientists have hypothesized that injecting a new chemical into the atmosphere could reflect sunlight and reduce global warming.";
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

        public string ChooseOption(int option) //Choose one of the options and get the result
        {
            switch (option)
            {
                case 1: //Small scale testing
                    if(_earth.PoliticalPoints < 2)
                    {
                        return "You did not have enough political influence to pursue your plan. The scientists have been ignored.";
                    }
                    _earth.PoliticalPoints -= 2;
                    _monthsLeft++;
                    _earth.GDP -= 1000000000000;
                    _options[1] = "Continue conducting small scale tests.";
                    _description = "After the small scale testing, proponents of geoengineering are convinced that injecting a new chemical into the atmosphere would reflect sunlight and reduce global warming.";
                    return "Small scale tests in Siberia show encouraging results.";

                case 2: //Large scale deployment
                    if (_earth.PoliticalPoints < 2)
                    {
                        return "You did not have enough political influence to pursue your plan. The scientists have been ignored.";
                    }
                    if (_earth.PoliticalPoints < 3)
                    {
                        _earth.PoliticalPoints -= 2;
                        _monthsLeft++;
                        _earth.GDP -= 1000000000000;
                        _options[1] = "Continue conducting small scale tests.";
                        _description = "After the small scale testing, proponents of geoengineering are convinced that injecting a new chemical into the atmosphere would reflect sunlight and reduce global warming.";
                        return "You did not have enough political influence to pursue your entire plan, but small scale tests were conducted in Siberia that showed encouraging results..";
                    }
                    _earth.PoliticalPoints -= 3;
                    _earth.GDP -= 10000000000000;
                    _earth.Population -= 2000000000;
                    return "World governments poured billions into geoengineering Earth's atmosphere. While the atmosphere's increased reflectivity decreased global warming, billions perished due to the environmental effects.";

                default: //Do nothing
                    return "The scientists have been ignored. Was this a wise choice? The world may never know.";
            }
        }

        public string[] NextMonth() //Advance the event one month and get options
        {
            _monthsLeft--;
            return _options;
        }

        public EventGeoengAtmosphere(Earth earth)
        {
            _earth = earth;
        }
    }
}
