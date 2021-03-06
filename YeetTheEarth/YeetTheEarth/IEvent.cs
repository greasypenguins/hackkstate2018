﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    interface IEvent
    {
        string Art { get; } //ASCII Art for this event

        string Name { get; } //Name of event

        string Description { get; } //Description of event

        int MonthsLeft { get; } //Remaining duration of event in months

        string[] NextMonth(); //Advance the event one month and get options

        string ChooseOption(int option); //Choose one of the options and get the result
        
    }
}
