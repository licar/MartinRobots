namespace Model.Grids.Factory
{
    public interface IGridCreator
    {
        IGrid Create(int x, int y);
    }
}
