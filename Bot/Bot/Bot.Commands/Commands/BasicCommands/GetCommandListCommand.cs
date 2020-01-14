using Common;
using System.Collections.Generic;
using static Common.Vocabulary;

namespace Bot.Commands.Commands.BasicCommands
{
    public class GetCommandListCommand : ICommand
    {
        public string Name => ListCommands;

        public string[] TokenResponser { get; set; } = new string[] {"/commandList" };

        public bool IsThisComand(string text)
        {
            return text == TokenResponser[0];
        }

        public Answer OnMessage()
        {
            List<string> list = new List<string>()
            {
                ListCommands
            };

            string text = $"{Start} {ByeBye} {WhatCanYouDo} {HowAreU} {OpenSmth} {FindSmth} {ListCommands}";
            return new Answer(text,list);
        }
    }
}
