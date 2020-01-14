using Common;
using System.Collections.Generic;

namespace Bot.Commands.Commands.BasicCommands
{
    public class DefaultCommand : ICommand
    {
        public string Name =>"403 command" ;

        public string[] TokenResponser { get; set; }

        public bool IsThisComand(string text)
        {
            return true;
        }

        public Answer OnMessage()
        {
           return new Answer("Я слишком глуп что бы тебя понять", new List<string>());
        }
    }
}
