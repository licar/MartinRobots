using System;
using ViewModel.Models;

namespace ConsoleApp
{
    public static class ConsoleHelper
    {
        public static void WriteResult(OutputRobotDto[] robots)
        {
            foreach(var robot in robots)
            {
                Console.WriteLine($"{robot.PositionX} {robot.PositionY} {robot.Direction.ToString()} {(robot.Fell ? "LOST" : string.Empty)}");
            }
        }
    }
}
