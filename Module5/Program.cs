using System;
using System.Collections.Generic;

namespace Module5
{
    class Program
    {
        private static string[,] field;
        static void Main(string[] args)
        {
            const int size = 10;
            field = new string[size, size];
            List<(int cordX, int cordY, int damage, string sim)> boombs = new List<(int cordX, int cordY, int damage, string sim)>(0);
            var rnd = new Random();
            (int cordX, int cordY, string sim) girl = (cordX: 10, cordY: 10, "G");
            do
            {
                (int cordX, int cordY, int health, string sim) hero = (cordX: 0, cordY: 0, health: 10, "H");
                for (int i = 0; i < 10; i++)
                {
                    boombs.Add((rnd.Next(-1, size - 1), rnd.Next(-1, size - 1), rnd.Next(0, 10), " "));
                }
                do
                {
                    ShowField(boombs, ref hero, girl);
                    if (hero.cordX == girl.cordX - 1 && hero.cordY == girl.cordY - 1)
                    {
                        break;
                    }
                }
                while (hero.health > 0);
                if (hero.health <= 0)
                {
                    Console.WriteLine("Sorry, you loose :(");
                }
                else
                {
                    Console.WriteLine("WOW YOU WON!!! Congratulations!!!");
                }
                Console.WriteLine("Would you like to play more? y/n");
            }
            while (Console.ReadLine().ToLower() == "y");
            Console.WriteLine("Bye-Bye!");

        }
        static void ShowField(List<(int cordX, int cordY, int damage, string sim)> bombs, ref (int cordX, int cordY, int health, string sim) hero, (int cordX, int cordY, string sim) girl)
        {
            Console.Clear();
            Console.WriteLine("Game");
            FillInField(hero, girl);
            Console.WriteLine($"The hero has {hero.health} health points. Good luck.");
            Console.WriteLine();
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write($"\t{field[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t   {girl.sim}");
            Move(ref hero);
            foreach (var i in bombs)
            {
                if (i.cordX == hero.cordX && i.cordY == hero.cordY)
                {
                    hero.health -= i.damage;
                    bombs.Remove(i);
                    break;
                }
            }

        }
        static void Move(ref (int cordX, int cordY, int health, string sim) hero)
        {
            do
            {
                int dY;
                int dX;
                ConsoleKeyInfo consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow)
                {
                    dY = hero.cordY - 1;
                    if (IsMove(dY))
                    {
                        hero.cordY = dY;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You can`t move in that direction");
                    }
                }
                else if (consoleKey.Key == ConsoleKey.DownArrow)
                {
                    dY = hero.cordY + 1;
                    if (IsMove(dY))
                    {
                        hero.cordY = dY;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You can`t move in that direction");
                    }

                }
                else if (consoleKey.Key == ConsoleKey.RightArrow)
                {
                    dX = hero.cordX + 1;
                    if (IsMove(dX))
                    {
                        hero.cordX = dX;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You can`t move in that direction");
                    }
                }
                else if (consoleKey.Key == ConsoleKey.LeftArrow)
                {
                    dX = hero.cordX - 1;
                    if (IsMove(dX))
                    {
                        hero.cordX = dX;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You can`t move in that direction");
                    }

                }
                else
                {
                    Console.WriteLine("You choose the wrong button to move");
                }
            }
            while (true);
        }
        static bool IsMove(int cord)
        {
            if (cord <= field.GetLength(1) && cord >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void FillInField((int cordX, int cordY, int health, string sim) hero, (int cordX, int cordY, string sim) girl)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = ".";
                }
                field[hero.cordY, hero.cordX] = hero.sim;
            }
        }
    }

}
