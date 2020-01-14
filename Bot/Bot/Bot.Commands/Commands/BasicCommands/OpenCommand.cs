using Common;
using System.Collections.Generic;
using static Common.Vocabulary;

namespace Bot.Commands.Commands.BasicCommands
{
    public class OpenCommand : ICommand
    {
        public string Name => OpenSmth;

        public string[] TokenResponser { get; set; } =new string[] { "open", "откр","/open"};

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
                OpenSmth
            };

            string text = "Пока я слишком глуп, что бы что-то открывать!!!!";

            return new Answer(text, list);
        }
    }
}
