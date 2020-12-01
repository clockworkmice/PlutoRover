using System;
using System.Linq;
using PlutoRover.Domain.Commands;
using PlutoRover.Domain.Directions;

namespace PlutoRover.Domain
{
    public class RoverController
    {
        private readonly Pluto _pluto;
        private readonly Rover _rover;

        public RoverController(Pluto pluto)
        {
            _pluto = pluto;
            _rover = new Rover(0, 0, new North(_pluto), _pluto);
        }

        public void MoveRover(string commands)
        {
            foreach (var command in commands.Select(ParseCommand))
            {
                var isSuccess = command.Execute(_rover);
                if (!isSuccess)
                {
                    break;
                }
            }  
        }

        public string GetRoverPositionAndDirection()
        {
            return $"{_rover.CurrentX},{_rover.CurrentY},{_rover.CurrentDirection}";
        }

        private IRoverCommand ParseCommand(char command)
        {
            return command switch
            {
                'F' => new ForwardsCommand(),
                'B' => new BackwardsCommand(),
                'L' => new LeftCommand(),
                'R' => new RightCommand(),
                _ => throw new ArgumentException()
            };
        }
    }
}
