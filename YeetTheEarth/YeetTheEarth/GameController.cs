using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    public class GameController
    {
        private Player _player;
        private Earth _earth;
        private EventGenerator _eventGenerator;
        private List<IEvent> _activeEvents;
        private Random _randomizer;

        public GameController()
        {
            _player = new Player();
            _earth = new Earth();
            _eventGenerator = new EventGenerator(_earth);
            _activeEvents = new List<IEvent>();
            _randomizer = new Random();

            _player.ShowGameIntroMessage();

            while(_earth.Population > 0)
            {
                //Show stuff about Earth's current state
                _player.Show(string.Format("Year: {0}", _earth.Year));
                _player.Show(string.Format("Month: {0}", _earth.Month));
                _player.Show(string.Format("Population: {0} people", _earth.Population));
                _player.Show(string.Format("Political Capital: {0} points", _earth.PoliticPoints));
                _player.Show(string.Format("Average Temperature: {0} °C", _earth.Temp));
                _player.Show(string.Format("Sea Level: {0} m", _earth.SeaLevel));
                _player.Show(string.Format("Global GDP: ${0}", _earth.GDP));
                
                //Generate random events sometimes
                
                //Handle all active events
                if(_activeEvents.Count > 0)
                {
                    //Advance each event one month
                    for( int i = 0; i < _activeEvents.Count; i++)
                    {
                        IEvent thisEvent = _activeEvents[i];
                        //Show event info
                        _player.ShowEventInfo(thisEvent.Name, thisEvent.Description);

                        //Show player event message for this month
                        _player.ShowEventOptions(thisEvent.NextMonth());

                        //Get choice from player
                        _player.ShowEventResult(thisEvent.ChooseOption(_player.GetChoice()));
                    }

                    //Remove events that are done
                    for (int i = _activeEvents.Count - 1; i >= 0; i--)
                    {
                        if(_activeEvents[i].MonthsLeft <= 0)
                        {
                            _activeEvents.RemoveAt(i);
                        }
                    }
                }

                //Show player normal monthly options
                //Get decisions from player

                _earth.AdvanceMonth();
            }
        }
    }
}
