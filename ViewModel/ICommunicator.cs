using ViewModel.Models;

namespace ViewModel
{
    public interface ICommunicator
    {
        void Run(InputRobotDto[] robots, int gridSizeX, int gridSizeY);
    }
}
