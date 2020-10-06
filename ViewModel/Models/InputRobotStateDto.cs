using Core.Enums;

namespace ViewModel.Models
{
    public class InputRobotStateDto
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public Direction Direction { get; set; }
    }
}
