using Common;
using System.Collections.Generic;
using static Common.Vocabulary;

namespace Bot.Commands.Commands.BasicCommands
{
    public class StartCommand : ICommand
    {
        public string Name => Start;

        public string[] TokenResponser { get; set; } = { "прив", "hello", "шалом", "хай", "ку", "здрав", "здаро", "/start" };

        public bool IsThisComand(string name)
        {
            foreach (var i in TokenResponser)
            {
                if (name.ToLower().Contains(i))
                {
                    return true;
                }
            }
            return false;
        }

        public Answer OnMessage()
        {
            List<string> list = new List<string>()
            {
                Start
            };

            string text = "Добро пожаловать!";

            return new Answer(text, list);
        }
    }
}
