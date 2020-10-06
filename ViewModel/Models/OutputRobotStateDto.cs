using Core.Enums;

namespace ViewModel.Models
{
    public class OutputRobotStateDto
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Direction Direction { get; set; }
        public bool IsFall { get; set; } = false;
    }
}
