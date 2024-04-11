using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DayOff
{
    class StartUp
    {
        private static Breakfast breakfast = new Breakfast();
        private static Newspaper newspaper = new Newspaper();
        private static Radio radio = new Radio();

        static async Task Main()
        {
            Console.WriteLine("Good morning! " +
                "Your plans for today are: " +
                "making breakfast and listening to music, " +
                "eating breakfast and reading the news.");

            // TODO: 
            // Instantiate the objects from the classes and run the methods.
            // You have to cook breakfast and listen to music at the same time.
            // When you finish preparing the breakfast, you should start eating the prepared breakfast.
            // The state of the breakfast should be cooked and eaten.
            // When you finish listening to the music, you should turn off the radio and start reading the newspaper.
            // The newspaper status should be Readed.
            // Print the objects states.

            Task<Breakfast> breakfastCookedTask = MakingBreakfastAsync();
            Task<Radio> radioTask = ListeningMusicAsync();
            Task<Breakfast> breakfastEatingTask = EatingBreakfastAsync();
            Task<Newspaper> readingTask = ReadingNewsAsync();

            List<Task> tasks = new List<Task> 
            { breakfastCookedTask, radioTask, breakfastEatingTask, readingTask };

            await Task.WhenAll(tasks);

            Console.WriteLine($"Breakfast was cooked: {breakfast.IsReady}");
            Console.WriteLine($"Breakfast was eaten: {breakfast.IsEaten}");

            Console.WriteLine($"The radio is on: {radio.IsOn}");
            Console.WriteLine($"The newspaper was read: {newspaper.IsReaded}");
        }

        static async Task<Breakfast> MakingBreakfastAsync()
        {
            // TODO: The method should:
            // take a Breakfast object as a parameter
            // print "Making breakfast."
            // then it should sleep the task for 1000 milliseconds
            // change the state of the breakfast object to cooked
            // print the message  from the object’s method
            // finally return the Breakfast object

            Console.WriteLine("Making breakfast.");

            await Task.Delay(1000);

            Console.WriteLine(breakfast.Cooked());

            return breakfast;
        }

        static async Task<Radio> ListeningMusicAsync()
        {
            // TODO: The method should:
            // take a Radio object as a parameter
            // turn on the radio and print the message  from the object’s method
            // then it should sleep the task for 1000 milliseconds
            // turn off the radio and print the message  from the object’s method
            // finally return the Radio object

            Console.WriteLine(radio.RadioOn());

            await Task.Delay(1000);

            Console.WriteLine(radio.RadioOf());

            return radio;
        }

        static async Task<Breakfast> EatingBreakfastAsync()
        {
            // TODO: The method should:
            // take a Breakfast object as a parameter
            // print "Eating breakfast."
            // then it should sleep the task for 1700 milliseconds
            // change the state of the breakfast object to eaten
            // print the message  from the object’s method
            // finally return the Breakfast object


            Console.WriteLine("Eating breakfast.");

            await Task.Delay(1700);

            Console.WriteLine(breakfast.Eaten());

            return breakfast;
        }

        static async Task<Newspaper> ReadingNewsAsync()
        {
            // TODO: The method should:
            // take a Newspaper object as a parameter
            // read the newspaper and print the message from the object’s method
            // then it should sleep the task for 1700 milliseconds
            // finally return the Newspaper object

            Console.WriteLine(newspaper.Reading());

            await Task.Delay(1700);

            return newspaper;
        }
    }
}