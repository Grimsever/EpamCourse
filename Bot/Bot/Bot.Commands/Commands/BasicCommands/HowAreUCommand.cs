using Common;
using System.Collections.Generic;
using static Common.Vocabulary;

namespace Bot.Commands.Commands.BasicCommands
{
    public class HowAreUCommand : ICommand
    {
        public string Name => HowAreU;

        public string[] TokenResponser { get; set; } = new string[] { "how are you", "как ты", "как дела" };

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
            List<string> list = new List<string>()
            {
                HowAreU
            };

            string text = "В норме)";

            return new Answer(text, list);
        }
    }
}
