using Model.Robots;

namespace Model.Coordinators
{
    public interface ICoordinator
    {
        void LaunchRobots(IRobot[] Robots);
    }
}
