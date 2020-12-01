namespace PlutoRover.Domain.Directions
{
    public class West : IDirection
    {
        private readonly Pluto _pluto;

        public West(Pluto pluto)
        {
            _pluto = pluto;
        }

        public (int x, int y) MoveForwards(int currentX, int currentY)
        {
            return (_pluto.DecrementPosition(currentX), currentY);
        }

        public (int x, int y) MoveBackwards(int currentX, int currentY)
        {
            return (_pluto.IncrementPosition(currentX), currentY);
        }

        public IDirection SpinLeft()
        {
            return new South(_pluto);
        }

        public IDirection SpinRight()
        {
            return new North(_pluto);
        }

        public override string ToString()
        {
            return "W";
        }
    }
}
