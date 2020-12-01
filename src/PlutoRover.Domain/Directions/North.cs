namespace PlutoRover.Domain.Directions
{
    public class North : IDirection
    {
        private readonly Pluto _pluto;

        public North(Pluto pluto)
        {
            _pluto = pluto;
        }

        public (int x, int y) MoveForwards(int currentX, int currentY)
        {
            return (currentX, _pluto.IncrementPosition(currentY));
        }

        public (int x, int y) MoveBackwards(int currentX, int currentY)
        {
            return (currentX, _pluto.DecrementPosition(currentY));
        }

        public IDirection SpinLeft()
        {
            return new West(_pluto);
        }

        public IDirection SpinRight()
        {
            return new East(_pluto);
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
