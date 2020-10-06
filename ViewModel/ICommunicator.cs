using ViewModel.Models;

namespace ViewModel
{
    public interface ICommunicator
    {
        OutputRobotDto[] Run(InputRobotDto[] robots, int gridSizeX, int gridSizeY);
    }
}
