using Model.Coordinators;
using Model.Extension;
using Model.Grids.Factory;
using Model.Robots;
using System.Linq;
using ViewModel.Models;

namespace ViewModel
{
    public class Communicator : ICommunicator
    {
        public ICoordinator coordinator = new Coordinator();
        public IGridCreator gridCreator = new GridCreator();

        public OutputRobotDto[] Run(InputRobotDto[] robotsDto, int gridSizeX, int gridSizeY)
        {
            var grid = gridCreator.Create(gridSizeX, gridSizeY);
            var robots = robotsDto.Select(r => new Robot(r.State.PositionX, r.State.PositionY, r.State.Direction.GetDirectionDescription(), r.Commands, grid) as IRobot).ToArray();
            coordinator.LaunchRobots(robots);
            return robots.Select(r => new OutputRobotDto
            {
                PositionX = r.PositionX,
                PositionY = r.PositionY,
                Direction = r.Direction.Value,
                Fell = r.Fell
            }).ToArray();
        }
    }
}
