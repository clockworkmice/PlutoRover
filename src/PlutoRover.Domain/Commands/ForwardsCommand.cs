namespace PlutoRover.Domain.Commands
{
    public class ForwardsCommand : IRoverCommand
    {
        public bool Execute(Rover rover)
        {
            return rover.MoveForwards();
        }
    }
}
