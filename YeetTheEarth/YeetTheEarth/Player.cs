using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class Player
    {
        private int _consoleWidth = 100;

        public bool GetHardMode()
        {
            string response;
            bool hardMode;

            Console.WriteLine("Hard mode? [y/n]");
            response = Console.ReadLine();

            if(response.ToLower().Contains('y'))
            {
                hardMode = true;
            }
            else
            {
                hardMode = false;
            }

            Console.Clear();
            return hardMode;
        }

        public void ShowGameIntroMessage(int year)
        {
            WriteLineWrap("The year is " + year.ToString() + " and the IPCC (Intergovernmental Panel on Climate Change) has just finished their 44th conference. The proof and science that the members and guest speakers have gathered is irrefutable, and action must be taken to avoid any further devastation due to global warming. Because of this, nations have ceded power to the UN in regards to global warming to allow for teamwork and guidance with the fight against global warming.");
            Console.WriteLine();
            WriteLineWrap("This is where you come in. As a member of the IPCC, with your expertise in global warming, the UN has come to you for guidance. You are now in charge of how the world reacts to random events that are making global warming worse.");
            Console.WriteLine();
            WriteLineWrap("Your goal is to get Earth to a “stable/no threat” condition. Currently it stands at the “moderate/some threat” condition. If you do not act properly, the Earth’s condition will become “severe/high threat”. If this occurs, Earth will become unable to support any life and humanity will end.");
            Console.WriteLine();
            WriteLineWrap("Each month new problems may occur, and you will be given the reason as to why this occurs and why it’s bad for Earth. Then you will be given multiple options to react to the event. Depending on your decisions, things like the temperature and population will be affected, as well as the overall condition of Earth.");
            Console.WriteLine();
            WriteLineWrap("It’s up to you to understand and stop global warming so we can continue to inhabit Earth. Good luck.");
            Console.WriteLine();
            Console.Write("                               _______\n                          , o88~~88888888,\n                        , ~~? 8P  88888    8,\n                       d  d88 d88 d8_88     b\n                      d  d888888888          b\n                      8,? 88888888  d8. b o. 8\n                      8~88888888~~^ 8888| db 8\n                      ? 888888          , 888P\n                       ?  `8888b, _     d888P\n                        `   8888888b, 8888'\n                          ~-? 8888888 _.P - \n                               ~~~~~~\n");
            WriteLineWrap("Press enter to continue with your new role.");
            Console.ReadLine();
            Console.Clear();
        }

        public void Show(string s)
        {
            WriteLineWrap(s);
        }

        public void ShowWin()
        {
            Console.WriteLine("\nYOU WIN");
            WriteLineWrap("Congratulations! Although the Earth is badly beaten, you managed to save humanity from destruction! Use the principles you learned to promote smart environmental and economic policies so we can achieve the same result in real life.");
            Console.WriteLine();
        }

        public void ShowLosePopulation(long initialPopulation, long finalPopulation)
        {
            Console.WriteLine("\nYOU LOSE");
            WriteLineWrap("Unfortunately, after a long battle for humanity, the world's population has been decimated beyond all hope for recovery. The remaining survivors struggle as they perish one by one, watching the world they once knew crumble around them. It is now unlikely that the human species can continue in its current form. Use the principles you learned to promote smart environmental and economic policies so we can avoid this outcome in real life.");
            Console.WriteLine("Initial population: " + initialPopulation.ToString() + " people");
            Console.WriteLine("Final population: " + finalPopulation.ToString() + " people");
            Console.WriteLine();
        }

        public void ShowLoseGDP(decimal initialGDP, decimal finalGDP)
        {
            Console.WriteLine("\nYOU LOSE");
            WriteLineWrap("Unfortunately, after a long battle for humanity, the world's economy has been decimated beyond all hope for recovery. As institutions collapse globally, humans revert to a primitive lifestyle, as the Earth is unable to support the life they once knew. Use the principles you learned to promote smart environmental and economic policies so we can avoid this outcome in real life.");
            Console.WriteLine("Initial GDP: " + initialGDP.ToString("C", new CultureInfo("en-US")));
            Console.WriteLine("Final GDP: " + finalGDP.ToString("C", new CultureInfo("en-US")));
            Console.WriteLine();
        }

        public void ShowYear(int year)
        {
            Console.WriteLine("Year: " + year.ToString());
        }

        public void ShowMonth(string month)
        {
            Console.WriteLine("Month: " + month);
        }
        
        public void ShowPopulation(long population)
        {
            Console.WriteLine("Population: " + population.ToString() + " people");
        }

        public void ShowPoliticalPoints(int points)
        {
            Console.WriteLine("Political points: " + points.ToString() + " points");
        }

        public void ShowTemperature(double temperature)
        {
            Console.WriteLine("Global Mean Temperature: " + Math.Round(Convert.ToDecimal(temperature), 3).ToString() + " °C");
        }

        public void ShowCo2Con(double co2Con)
        {
            Console.WriteLine("CO2 Concentration: " + Math.Round(Convert.ToDecimal(co2Con), 2).ToString() + " PPM");
        }

        public void ShowSeaLevel(double seaLevel)
        {
            Console.WriteLine("Sea Level: " + Math.Round(Convert.ToDecimal(seaLevel), 4).ToString() + " m");
        }

        public void ShowGDP(decimal gdp)
        {
            Console.WriteLine("Global GDP: " + gdp.ToString("C", new CultureInfo("en-US")));
        }
        
        public int GetChoice()
        {
            Boolean valid = false;
            int ret = 0;

            while(!valid)
            {
                try
                {
                    Console.Write("Your choice: ");
                    ret = Convert.ToInt16(Console.ReadLine()) - 1;
                    valid = true;
                }
                catch(Exception e)
                {

                }
            }

            return ret;
        }

        public void ShowEventInfo(string eventName, string eventDescription)
        {
            Console.WriteLine();
            WriteLineWrap("Event: " + eventName);
            WriteLineWrap("Description: " + eventDescription);
        }

        public void ShowEventOptions(string[] eventOptions)
        {
            Console.WriteLine("What will you do?");
            for(int i = 0; i < eventOptions.Length; i++)
            {
                WriteLineWrap(string.Format("[{0}] {1}", (i + 1).ToString(), eventOptions[i]));
            }
        }

        public void ShowEventResult(string eventResult)
        {
            WriteLineWrap("Result: " + eventResult);
        }

        public void NextMonth(string month)
        {
            Console.WriteLine();
            WriteLineWrap("End of " + month + ". Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public void EndGame()
        {
            Console.WriteLine();
            WriteLineWrap("Press enter to end game.");
            Console.ReadLine();
        }

        private void WriteLineWrap(string input)
        {
            StringBuilder sb;
            int index;
            string[] words = input.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i] + " ";
            }

            if(words.Length == 0)
            {
                return;
            }
            else if(words.Length == 1)
            {
                Console.WriteLine(input);
            }
            else if(words[0].Length >= _consoleWidth)
            {
                Console.WriteLine(words[0]);
                WriteLineWrapFromArray(words, 1);
            }
            else
            {
                sb = new StringBuilder();
                sb.Append(words[0]);
                //Keep adding on if there is another word to add and it wouldn't be too long to add
                index = 1;
                while((index < words.Length) && ((sb.Length + words[index].Length) < _consoleWidth))
                {
                    sb.Append(words[index]);
                    index++;
                }
                Console.WriteLine(sb.ToString());
                //If there are more words, but the next word would make sb too long
                if(index < words.Length)
                {
                    WriteLineWrapFromArray(words, index);
                }
            }
        }

        private void WriteLineWrapFromArray(string[] input, int startIndex)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = startIndex; i < input.Length; i++)
            {
                sb.Append(input[i]);
            }
            WriteLineWrap(sb.ToString());
        }
    }
}
