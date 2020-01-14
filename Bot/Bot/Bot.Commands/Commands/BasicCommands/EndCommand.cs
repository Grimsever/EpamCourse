using Common;
using System.Collections.Generic;
using static Common.Vocabulary;

namespace Bot.Commands.Commands.BasicCommands
{
    public class EndCommand : ICommand
    {
        public string Name => ByeBye;

        public string[] TokenResponser { get; set; } = new string[] { "пок", "bye", "досв", "увид", "до встр", "/end" };

        public bool IsThisComand(string text)
        {
            foreach (var i in TokenResponser)
            {
                if (text.ToLower().Contains(i))
                {
                    return true;
                }
            }
            return false;
        }

        public Answer OnMessage()
        {
            List<string> list = new List<string>
            {
                ByeBye
            };
            string text = "Пока!";

            return new Answer(text, list);
        }
    }
}
