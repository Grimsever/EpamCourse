using Common;
using System;
using System.Collections.Generic;
using static Common.Vocabulary;

namespace Bot.Commands.Commands.BasicCommands
{
    public class WhatCanUDoCommand : ICommand
    {
        public string Name => WhatCanYouDo;

        public string[] TokenResponser { get; set; } = new string[] { "что ты можешь?" };

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
                WhatCanYouDo
            };
            string text = "Я могу так себе пока вещей, введи /commandList и узнай!";

            return new Answer(text, list);
        }
    }
}
