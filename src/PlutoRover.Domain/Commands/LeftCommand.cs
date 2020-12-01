namespace PlutoRover.Domain.Commands
{
    public class LeftCommand : IRoverCommand
    {
        public bool Execute(Rover rover)
        {
            return rover.SpinLeft();
        }
    }
}
