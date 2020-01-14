using Bot.Commands;
using Bot.Commands.Commands;
using System.Collections.Generic;

namespace Bot.ConsoleBot
{
    public class CustomBot
    {
        ICommandList commands;

        public CustomBot()
        {
            commands = new CommandList();
        }

        public List<ICommand> GetListOfCommands()
        {
            return commands.GetListOfCommands();
        }

        public string OnMessage(string text)
        {
            var command = commands.GetCommand(text);
            return command.OnMessage().Text;
        }
    }
}
