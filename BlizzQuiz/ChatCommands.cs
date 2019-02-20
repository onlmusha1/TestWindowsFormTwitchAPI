using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib.Client.Models;

namespace BlizzQuiz
{
    class ChatCommands
    {
        private string defaultReturn = "CheckMe";


        public ChatCommands()
        {
            
        }

        public string controller(string command, string commandArgs)
        {
            string com = command.ToLower();
            if(com == "test")
            {
                return "Test works!";
            }
            else if(com == "guess")
            {
                return this.makeGuess(commandArgs);
            }
            else
            {
                return this.defaultReturn;
            }
        }

        private string makeGuess(string commandArguments)
        {
            string guess = commandArguments.ToLower();

            if (guess == "a guess")
            {
                return "Winner!";
            }
            else
            {
                return this.defaultReturn;
            }
        }
        

        

    }
}
