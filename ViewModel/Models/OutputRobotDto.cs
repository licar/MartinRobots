using Core.Enums;

namespace ViewModel.Models
{
    public class OutputRobotDto
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public Direction Direction { get; set; }
        public bool Fell { get; set; } = false;
    }
}
