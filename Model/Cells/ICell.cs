using Core.Enums;

namespace Model.Cells
{
    public interface ICell
    {
        bool IsFallingDirection(Direction direction);
        void AddFallingDirection(Direction direction);
    }
}