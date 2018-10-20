﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class EventGenerator
    {
        private List<IEvent> _allEvents;

        private List<IEvent> _remainingEvents;

        private Random _randomizer;

        public EventGenerator(Earth _earth)
        {
            //Add each possible event
            _allEvents.Add(new EventPopulationExplosion(_earth));
            _allEvents.Add(new EventSolarTechImprovement(_earth));
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