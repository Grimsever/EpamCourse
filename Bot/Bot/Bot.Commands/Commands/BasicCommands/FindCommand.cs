using Common;
using System.Collections.Generic;
using static Common.Vocabulary;

namespace Bot.Commands.Commands.BasicCommands
{
    public class FindCommand : ICommand
    {
        public string Name => FindSmth;

        public string[] TokenResponser { get; set; } = { "найд", "найт", "find", "search", "поищ", "посмотр", "поиск", "/find" };

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
                FindSmth
            };

            string text = "Пока я слишком глуп, что бы что-то искать!!!!";

            return new Answer(text, list);
        }
    }
}
