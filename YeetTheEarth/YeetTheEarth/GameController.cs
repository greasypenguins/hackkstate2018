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
                _player.Show(String.Format("Year: {}", _earth.Year));
                _player.Show(String.Format("Month: {}", _earth.Month));
                _player.Show(String.Format("Population: {} people", _earth.Population));
                _player.Show(String.Format("Political Capital: {} points", _earth.PoliticPoints));
                _player.Show(String.Format("Average Temperature: {} °C", _earth.Temp));
                _player.Show(String.Format("Sea Level: {} m", _earth.SeaLevel));
                _player.Show(String.Format("Global GDP: ${}", _earth.GDP));
                
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
                        _player.ShowEventUpdate(thisEvent.NextMonth());

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
