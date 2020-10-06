using Core;
using Core.Enums;
using DirectionDescription = System.Collections.Generic.KeyValuePair<(int x, int y), Core.Enums.Direction>;

namespace Model.Robots
{
    public interface IRobot
    {
        int PositionX { get;  }
        int PositionY { get;  }
        DirectionDescription Direction { get;  }
        bool Fell { get;  }
        void Move();
    }
}
