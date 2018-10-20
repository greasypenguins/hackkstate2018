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

        public GameController()
        {
            _player = new Player();
            _earth = new Earth();
            _eventGenerator = new EventGenerator();

            _player.ShowGameIntroMessage();

            while(_earth.Population > 0)
            {
                //Show stuff about Earth's current state
                _player.Show(String.Format("Year: {}", _earth.Year));
                _player.Show(String.Format("Month: {}", _earth.Month));
                _player.Show(String.Format("Population: {} people", _earth.Population));
                _player.Show(String.Format("Political Capital: {} points", _earth.PoliticalCapital));
                _player.Show(String.Format("Average Temperature: {} °C", _earth.Temperature));
                _player.Show(String.Format("Sea Level: {} m", _earth.SeaLevel));
                _player.Show(String.Format("Global GDP: ${}", _earth.GDP));
                
                //Generate random events sometimes
                //If there is an event in effect:
                    //For each event:
                        //Show player event message for this month
                        //Get choice from player
                        //Advance event one month

                //Show player normal monthly options
                //Get decisions from player

                _earth.NextMonth();
            }
        }
    }
}
