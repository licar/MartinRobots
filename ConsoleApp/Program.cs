using System;
using System.Collections.Generic;
using ViewModel;
using ViewModel.Models;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {       
            try
            {
                Console.WriteLine("Input:");

                var line = Console.ReadLine();
                var coordinates = line.GetGridCoordinates();
                var robots = new List<InputRobotDto>();
                while ((line = Console.ReadLine()) != null && !string.IsNullOrWhiteSpace(line))
                {
                    var state = line.GetState();
                    line = Console.ReadLine();
                    var commands = line.GetCommands();
                    robots.Add(new InputRobotDto { Commands = commands, State = state });
                }

                ICommunicator communicator = new Communicator();
                var outputRobotsStates = communicator.Run(robots.ToArray(), coordinates.x, coordinates.y);

                Console.WriteLine("Output:");
                ConsoleHelper.WriteResult(outputRobotsStates);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }   
        }
    }
}
