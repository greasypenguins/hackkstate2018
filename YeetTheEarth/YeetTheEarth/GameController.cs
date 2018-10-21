using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    public class GameController
    {
        private readonly string _title = "Yeet the Earth";
        private readonly string[] _authors = {
            "Nayeline Delosangeles Coronilla-Guerrero",
            "Weston Harder",
            "Caleb Logan",
            "Stephanie Milberger"};
        private readonly int _monthsToSurvive = 18;
        private Player _player = new Player();
        private Earth _earth = new Earth();
        private EventGenerator _eventGenerator;
        private List<IEvent> _activeEvents;
        private Random _randomizer;
        private double _eventGenerationChance;
        private long _initialPopulation;
        private long _halfPopulation;
        private decimal _initialGDP;
        private decimal _halfGDP;
        private int _initialYear;
        private string _initialMonth;
        private double _initialTemperature;
        private double _initialCo2Con;
        private double _initialSeaLevel;

        public GameController()
        {
            _player = new Player();
            _earth = new Earth();
            _eventGenerator = new EventGenerator(_earth);
            _activeEvents = new List<IEvent>();
            _randomizer = new Random();
            _eventGenerationChance = 0.35; //Each month, 2x(35% chance of generating a new event)
            _initialPopulation = _earth.Population;
            _halfPopulation = (long)((double)_initialPopulation / (double)2);
            _initialGDP = _earth.GDP;
            _halfGDP = (_initialGDP / (decimal)4);
            _initialYear = _earth.Year;
            _initialMonth = _earth.CurrentMonth;
            _initialTemperature = _earth.Temp;
            _initialCo2Con = _earth.Co2Con;
            _initialSeaLevel = _earth.SeaLevel;
    }

        public void RunGame()
        {
            if(_player.GetHardMode(_title, _authors)) //If hard mode
            {
                _earth.PopulationMultiplier = 0.95; //5% of population dies every month
                _earth.GDPMultiplier = (decimal)0.95; //5% of GDP lost every month
            }

            _player.ShowGameIntroMessage(_earth.Year);

            while ((_earth.Population >= _halfPopulation)
                && (_earth.GDP >= _halfGDP)
                && (_earth.MonthsElapsed < _monthsToSurvive))
            {
                //Show stuff about Earth's current state
                _player.ShowYear(_earth.Year);
                _player.ShowMonth(_earth.CurrentMonth);
                _player.ShowPopulation(_earth.Population);
                _player.ShowPoliticalPoints(_earth.PoliticalPoints);
                _player.ShowTemperature(_earth.Temp);
                _player.ShowCo2Con(_earth.Co2Con);
                _player.ShowSeaLevel(_earth.SeaLevel);
                _player.ShowGDP(_earth.GDP);

                //Attemp to generate random events (twice)
                if(_eventGenerator.MoreEvents)
                {
                    if (_randomizer.NextDouble() < _eventGenerationChance)
                    {
                        _activeEvents.Add(_eventGenerator.GetEvent());
                    }
                    if (_randomizer.NextDouble() < _eventGenerationChance)
                    {
                        _activeEvents.Add(_eventGenerator.GetEvent());
                    }
                }

                //Handle all active events
                if (_activeEvents.Count > 0)
                {
                    //Advance each event one month
                    for (int i = 0; i < _activeEvents.Count; i++)
                    {
                        IEvent thisEvent = _activeEvents[i];

                        //Show ASCII art
                        _player.ShowArt(thisEvent.Art);

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
                        if (_activeEvents[i].MonthsLeft <= 0)
                        {
                            _activeEvents.RemoveAt(i);
                        }
                    }
                }

                //Show player normal monthly options
                //Get decisions from player

                _player.NextMonth(_earth.CurrentMonth);
                _earth.NextMonth();
            }

            if (_earth.Population < _halfPopulation)
            {
                _player.ShowLosePopulation();
                _player.ShowInitials(_initialYear, _initialMonth, _initialPopulation, _initialTemperature, _initialCo2Con, _initialSeaLevel, _initialGDP);
                _player.ShowYear(_earth.Year);
                _player.ShowMonth(_earth.CurrentMonth);
                _player.ShowPopulation(_earth.Population);
                _player.ShowTemperature(_earth.Temp);
                _player.ShowCo2Con(_earth.Co2Con);
                _player.ShowSeaLevel(_earth.SeaLevel);
                _player.ShowGDP(_earth.GDP);
            }
            else if (_earth.GDP < _halfGDP)
            {
                _player.ShowLoseGDP();
                _player.ShowInitials(_initialYear, _initialMonth, _initialPopulation, _initialTemperature, _initialCo2Con, _initialSeaLevel, _initialGDP);
                _player.ShowYear(_earth.Year);
                _player.ShowMonth(_earth.CurrentMonth);
                _player.ShowPopulation(_earth.Population);
                _player.ShowTemperature(_earth.Temp);
                _player.ShowCo2Con(_earth.Co2Con);
                _player.ShowSeaLevel(_earth.SeaLevel);
                _player.ShowGDP(_earth.GDP);
            }
            else if (_earth.MonthsElapsed >= _monthsToSurvive)
            {
                _player.ShowWin();
                _player.ShowInitials(_initialYear, _initialMonth, _initialPopulation, _initialTemperature, _initialCo2Con, _initialSeaLevel, _initialGDP);
                _player.ShowYear(_earth.Year);
                _player.ShowMonth(_earth.CurrentMonth);
                _player.ShowPopulation(_earth.Population);
                _player.ShowTemperature(_earth.Temp);
                _player.ShowCo2Con(_earth.Co2Con);
                _player.ShowSeaLevel(_earth.SeaLevel);
                _player.ShowGDP(_earth.GDP);
            }
            else
            {
                _player.Show("Well you exited the main loop but broke the game. Good job.");
                _player.ShowYear(_earth.Year);
                _player.ShowMonth(_earth.CurrentMonth);
                _player.ShowPopulation(_earth.Population);
                _player.ShowTemperature(_earth.Temp);
                _player.ShowSeaLevel(_earth.SeaLevel);
                _player.ShowGDP(_earth.GDP);
            }

            _player.EndGame();
        }
    }
}
