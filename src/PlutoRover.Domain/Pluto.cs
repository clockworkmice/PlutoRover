namespace PlutoRover.Domain
{
    public class Pluto
    {
        private int? _obstacleX;
        private int? _obstacleY;

        public int IncrementPosition(int position)
        {
            return position >= 99 ? 0 : position + 1;
        }

        public int DecrementPosition(int position)
        {
            return position <= 0 ? 99 : position - 1;
        }

        public bool IsObstacleAtPosition(int x, int y)
        {
            return x == _obstacleX && y == _obstacleY;
        }

        public void SetObstacle(int x, int y)
        {
            _obstacleX = x;
            _obstacleY = y;
        }
    }
}
