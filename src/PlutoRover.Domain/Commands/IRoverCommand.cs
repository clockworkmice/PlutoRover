namespace PlutoRover.Domain.Commands
{
    public interface IRoverCommand
    {
        bool Execute(Rover rover);
    }
}
