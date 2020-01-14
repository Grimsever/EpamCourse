using Bot.ConsoleBot;
using System;

namespace UI
{
    public class ConsoleBotEx
    {
        private CustomBot customBot = new CustomBot();

        public void Start()
        {
            Console.WriteLine("Bot start work");
        }

        public void End()
        {
            Console.WriteLine("Bot stop work");
        }
        public void GoTalk()
        {
            while (true)
            {
                string text = customBot.OnMessage(Console.ReadLine());
                if (text != "Пока!")
                {
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine(text);
                    break;
                }
            }
        }
        public void GetListOfCommands()
        {
            foreach(var item in customBot.GetListOfCommands())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
