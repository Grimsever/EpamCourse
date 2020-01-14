using Common;

namespace Bot.Commands.Commands
{
    public interface ICommand
    {
        string Name { get; }
        string[] TokenResponser { get; set; }
        bool IsThisComand(string text);

        Answer OnMessage();
    }
}
