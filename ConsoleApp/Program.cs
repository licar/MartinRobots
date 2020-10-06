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

                coordinates.x.Validate();
                coordinates.y.Validate();

                var robots = new List<InputRobotDto>();
                while ((line = Console.ReadLine()) != null && !string.IsNullOrWhiteSpace(line))
                {
                    var state = line.GetState();

                    state.PositionX.Validate();
                    state.PositionY.Validate();


                    line = Console.ReadLine();
                    var commands = line.GetCommands();
                    commands.Validate();

                    robots.Add(new InputRobotDto { Commands = commands, State = state });
                }

                ICommunicator communicator = new Communicator();
                var outputRobotsStates = communicator.Run(robots.ToArray(), coordinates.x, coordinates.y);
                Console.WriteLine("Output:");
                ConsoleHelper.WriteResult(outputRobotsStates);
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          
        }
    }
}
