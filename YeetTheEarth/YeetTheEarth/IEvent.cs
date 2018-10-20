using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    interface IEvent
    {
        string StartMessage { get; } //Message displayed when event is triggered
        
        int MonthsLeft { get; } //Remaining duration of event in months

        string NextMonth(); //Advance the event one month and get a message

        string ChooseOption(int option); //Choose one of the options and get the result
        
    }
}
