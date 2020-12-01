namespace PlutoRover.Domain.Commands
{
    public class RightCommand : IRoverCommand
    {
        public bool Execute(Rover rover)
        {
            return rover.SpinRight();
        }
    }
}
