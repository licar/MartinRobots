using Model.Robots;

namespace Model.Coordinators
{
    public class Coordinator : ICoordinator
    {
        public void Run(IRobot[] Robots)
        {
            foreach(var robot in Robots)
            {
                robot.Move();
            }
        }
    }
}
