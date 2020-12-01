namespace PlutoRover.Domain.Directions
{
    public class South : IDirection
    {
        private readonly Pluto _pluto;

        public South(Pluto pluto)
        {
            _pluto = pluto;
        }

        public (int x, int y) MoveForwards(int currentX, int currentY)
        {
            return (currentX, _pluto.DecrementPosition(currentY));
        }

        public (int x, int y) MoveBackwards(int currentX, int currentY)
        {
            return (currentX, _pluto.IncrementPosition(currentY));
        }

        public IDirection SpinLeft()
        {
            return new East(_pluto);
        }

        public IDirection SpinRight()
        {
            return new West(_pluto);
        }

        public override string ToString()
        {
            return "S";
        }
    }
}
