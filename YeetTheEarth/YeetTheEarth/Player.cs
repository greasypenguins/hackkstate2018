using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeetTheEarth
{
    class Player
    {
        private int _consoleWidth = 100;

        public void ShowGameIntroMessage()
        {
            Console.WriteLine("The year is 2016 and the IPCC (Intergovernmental Panel on Climate Change) has just finished their 44th conference.\n The proof and science that the members and guest speakers have gathered is irrefutable, and action must be taken to avoid any further devastation due to global warming. \nBecause of this, nations have ceded power to the UN in regards to global warming to allow for teamwork and guidance with the fight against global warming.");
            Console.WriteLine(" ");
            Console.WriteLine("This is where you come in. As a member of the IPCC, with your expertise in global warming, the UN has come to you for guidance. \nYou are now in charge of how the world reacts to random events that are making global warming worse.");
            Console.WriteLine(" ");
            Console.WriteLine("Your goal is to get the Earth to a “stable/no threat” condition. \nCurrently it stands at the “moderate/some threat” condition. \nIf you do not act properly, the Earth’s condition will become “severe/high threat”. If this occurs, Earth will become unable to support any life and humanity will end.");
            Console.WriteLine(" ");
            Console.WriteLine("Each month new problems may occur, and you will be given the reason as to why this occurs and why it’s bad for Earth. \nThen you will be given multiple options to react to the event. \nDepending on your decisions, things like the temperature and population will be affected, as well as the overall condition of Earth.");
            Console.WriteLine(" ");
            Console.WriteLine("It’s up to you to understand and stop global warming so we can continue to inhabit Earth. Good luck.");
            Console.WriteLine(" ");
        }

        public void Show(string s)
        {
            Console.Write("\n"+ s);
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
                finally
                {

                }
            }

            return ret;
        }

        public void ShowEventInfo(string eventName, string eventDescription)
        {
            Console.WriteLine("Event: " + eventName);
            Console.WriteLine("Description: " + eventDescription);
        }

        public void ShowEventOptions(string[] eventOptions)
        {
            Console.WriteLine("What will you do?");
            for(int i = 0; i < eventOptions.Length; i++)
            {
                Console.WriteLine("[{0}] {1}", (i + 1).ToString(), eventOptions[i]);
            }
        }

        public void ShowEventResult(string eventResult)
        {
            Console.WriteLine("Result: " + eventResult);
        }

        private void WriteLineWrap(string output)
        {
            if(output.Length <= _consoleWidth)
            {
                Console.WriteLine(output);
            }
            else
            {
                string[] words = output.Split(' ');

                int currentWordsLength = 0;
                int remainingWordsLength = 0;

                Stack<string> currentWords = new Stack<string>();
                Stack<string> remainingWords = new Stack<string>();

                while(currentWordsLength < _consoleWidth)
                {

                }
            }
        }
    }
}
