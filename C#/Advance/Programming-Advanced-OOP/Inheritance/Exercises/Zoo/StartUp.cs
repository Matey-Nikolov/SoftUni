using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main()
        {
            string gorillaName = Console.ReadLine();
            Gorilla gorilla = new Gorilla(gorillaName);

            string snakeNname = Console.ReadLine();
            Snake snake = new Snake(snakeNname);

            string lizardName = Console.ReadLine();
            Lizard lizard = new Lizard(lizardName);

            string bearName = Console.ReadLine();
            Bear bear = new Bear(bearName);

            Console.WriteLine(gorilla.ToString());
            Console.WriteLine(snake.ToString());
            Console.WriteLine(lizard.ToString());
            Console.WriteLine(bear.ToString());
        }
    }
}