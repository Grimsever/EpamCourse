using Bot.Commands.Commands;
using Bot.Commands.Commands.BasicCommands;
using System.Collections.Generic;

namespace Bot.Commands
{
    public class CommandList : ICommandList
    {
        private List<ICommand> commands;

        public CommandList()
        {
            commands = new List<ICommand>()
            {
                new StartCommand(),
                new EndCommand(),
                new OpenCommand(),
                new FindCommand(),
                new HowAreUCommand(),
                new WhatCanUDoCommand(),
                new GetCommandListCommand()
            };
        }

        public ICommand GetCommand(string text)
        {
            foreach (var command in commands)
            {
                if (command.IsThisComand(text))
                {
                    return command;
                }
            }
            return new DefaultCommand();
        }

        public List<ICommand> GetListOfCommands()
        {
            return commands;
        }
    }
}
