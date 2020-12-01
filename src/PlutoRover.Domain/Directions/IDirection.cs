namespace PlutoRover.Domain
{
    public interface IDirection
    {
        (int x, int y) MoveForwards(int currentX, int currentY);
        (int x, int y) MoveBackwards(int currentX, int currentY);
        IDirection SpinLeft();
        IDirection SpinRight();
    }
}
