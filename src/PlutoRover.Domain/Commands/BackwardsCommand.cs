namespace PlutoRover.Domain.Commands
{
    public class BackwardsCommand : IRoverCommand
    {
        public bool Execute(Rover rover)
        {
            return rover.MoveBackwards();
        }
    }
}
