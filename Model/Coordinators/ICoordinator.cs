using Model.Robots;

namespace Model.Coordinators
{
    public interface ICoordinator
    {
        void Run(IRobot[] Robots);
    }
}
