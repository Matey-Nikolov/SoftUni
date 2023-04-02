using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace BorderControl
{
    public class Program
    {
        static void Main()
        {
            //Едва ли се решава така тази задача,
            // но така се сетих и така към я написал.


            List<BigInteger> ids = new List<BigInteger>();
            //  List<Robot> robots = new List<Robot>();
            //  List<Citizen> robots = new List<Citizen>();

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "End") 
            {
                string nameOrModel = "";
                int age = 0;
                BigInteger id = 0;

                if (input.Length == 3)
                {
                    nameOrModel = input[0];
                    age = int.Parse(input[1]);
                    id = BigInteger.Parse(input[2]);

                    Citizen citizen = new Citizen(nameOrModel, age, id);
                    ids.Add(citizen.Id);
                }
                else
                {
                    nameOrModel = input[0];
                    id = int.Parse(input[1]);

                    Robot robot = new Robot(nameOrModel, id);
                    ids.Add(robot.Id);
                }

                input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string findByLastDigits = Console.ReadLine();

            ids = ids.FindAll(x => x.ToString().EndsWith(findByLastDigits));

            foreach (var item in ids)
            {
                Console.WriteLine(item);
            }
            /*
            foreach (var idCitizen in citizens)
            {
                if (idCitizen.Id.ToString().EndsWith(findByLastDigits))
                {
                    Console.WriteLine(idCitizen.Id);
                }
            }

            foreach (var idRobot in robots)
            {
                if (idRobot.Id.ToString().EndsWith(findByLastDigits))
                {
                    Console.WriteLine(idRobot.Id);
                }
            }
            */
        }
    }
}