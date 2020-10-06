using Core.Enums;

namespace ViewModel.Models
{
    public class InputRobotDto
    {
        public Command[] Commands { get; set; }
        public InputRobotStateDto State { get; set; }
    }
}
