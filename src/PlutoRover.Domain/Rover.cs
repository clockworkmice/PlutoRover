namespace PlutoRover.Domain
{
    public class Rover
    {
        private readonly Pluto _pluto;

        public Rover(int x, int y, IDirection direction, Pluto pluto)
        {
            CurrentX = x;
            CurrentY = y;
            CurrentDirection = direction;
            _pluto = pluto;
        }

        public int CurrentX { get; private set; }
        public int CurrentY { get; private set; }
        public IDirection CurrentDirection { get; private set; }

        public bool MoveForwards()
        {
            var (x, y) = CurrentDirection.MoveForwards(CurrentX, CurrentY);
            return CheckCollisionsAndMove(x, y);
        }

        public bool MoveBackwards()
        {
            var (x, y) = CurrentDirection.MoveBackwards(CurrentX, CurrentY);
            return CheckCollisionsAndMove(x, y);
        }

        public bool SpinLeft()
        {
            CurrentDirection = CurrentDirection.SpinLeft();
            return true;
        }

        public bool SpinRight()
        {
            CurrentDirection = CurrentDirection.SpinRight();
            return true;
        }

        private bool CheckCollisionsAndMove(int x, int y)
        {
            if (_pluto.IsObstacleAtPosition(x, y))
            {
                return false;
            }

            CurrentX = x;
            CurrentY = y;
            return true;
        }
    }
}
