using Model.Robots;

namespace Model.Coordinators
{
    public class Coordinator : ICoordinator
    {
        public void LaunchRobots(IRobot[] Robots)
        {
            foreach(var robot in Robots)
            {
                robot.Move();
            }
        }
    }
}
