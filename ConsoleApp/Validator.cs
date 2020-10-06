using Core.Enums;
using System;

namespace ConsoleApp
{
    public static class Validator
    {
        public static void Validate(this int coordinate)
        {
            if (coordinate < 0 || coordinate > 50)
                throw new Exception("Invalid coordinate");
        }

        public static void Validate(this Command[] commands)
        {
            if (commands.Length > 100)
                throw new Exception("Too many commands");
        }
    }
}
