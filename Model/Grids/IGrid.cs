using Core.Enums;
using System.Collections;

namespace Model.Grids
{
    public interface IGrid 
    {
        bool IsFallingDirection(int posY, int posX, Direction direction);
        void AddFallingDirection(int posY, int posX, Direction direction);
        bool IsOutOfBounds(int posY, int posX);     
    }
}
