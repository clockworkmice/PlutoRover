namespace PlutoRover.Domain.Directions
{
    public class East : IDirection
    {
        private readonly Pluto _pluto;

        public East(Pluto pluto)
        {
            _pluto = pluto;
        }

        public (int x, int y) MoveForwards(int currentX, int currentY)
        {
            return (_pluto.IncrementPosition(currentX), currentY);
        }

        public (int x, int y) MoveBackwards(int currentX, int currentY)
        {
            return (_pluto.DecrementPosition(currentX), currentY);
        }

        public IDirection SpinLeft()
        {
            return new North(_pluto);
        }

        public IDirection SpinRight()
        {
            return new South(_pluto);
        }

        public override string ToString()
        {
            return "E";
        }
    }
}
