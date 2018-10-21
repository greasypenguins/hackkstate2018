using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventGenerator
    {
        private List<IEvent> _remainingEvents;

        public bool MoreEvents
        {
            get
            {
                if(_remainingEvents.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private Random _randomizer;

        public EventGenerator(Earth _earth)
        {
            _remainingEvents = new List<IEvent>();

            //Add each possible event
            _remainingEvents.Add(new EventGeoengAtmosphere(_earth));
            _remainingEvents.Add(new EventInsectOutbreak(_earth));
            _remainingEvents.Add(new EventPopulationExplosion(_earth));
            _remainingEvents.Add(new EventSolarTechImprovement(_earth));
            _remainingEvents.Add(new EventWildFires(_earth));
            _remainingEvents.Add(new EventCoralReefDestruction(_earth));
            _remainingEvents.Add(new EventThoriumPower(_earth));
            //...

            _randomizer = new Random();
        }

        public IEvent GetEvent()
        {
            int index = _randomizer.Next(_remainingEvents.Count);

            IEvent nextEvent = _remainingEvents[index];
            _remainingEvents.RemoveAt(index);

            return nextEvent;
        }
    }
}
