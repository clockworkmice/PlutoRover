using System;
using FluentAssertions;
using Xunit;

namespace PlutoRover.Domain.Tests
{
    public class MoveRoverTests
    {
        [Theory]
        [InlineData("F", "0,1,N")]
        [InlineData("FFRFF", "2,2,E")]
        [InlineData("FFRFFLFL", "2,3,W")]
        [InlineData("FFRFFRFRFRF", "1,2,N")]
        [InlineData("FFRFFLBBRBB", "0,0,E")]
        [InlineData("BLF", "99,99,W")]
        public void GivenRoverOnPluto_WhenMoveCommands_ThenAtPositionAndDirection(string commands, string positionAndDirection)
        {
            var pluto = new Pluto();
            var roverController = new RoverController(pluto);

            roverController.MoveRover(commands);

            roverController.GetRoverPositionAndDirection().Should().Be(positionAndDirection);
        }

        [Theory]
        [InlineData("F", "0,1,N")]
        [InlineData("FRF", "0,1,E")]
        [InlineData("FRFFFLFRB", "0,1,E")]
        [InlineData("FFRFFRFRF", "2,1,W")]
        public void GivenRoverOnPlutoWithObstacles_WhenMoveCommands_ThenAtPositionAndDirectionBeforeCollision(string commands, string positionAndDirection)
        {
            var pluto = new Pluto();
            pluto.SetObstacle(1, 1);
            var roverController = new RoverController(pluto);

            roverController.MoveRover(commands);

            roverController.GetRoverPositionAndDirection().Should().Be(positionAndDirection);
        }

        [Theory]
        [InlineData("X799c")]
        [InlineData("FFFFFFFx")]
        [InlineData("frf")]
        public void GivenRoverOnPluto_WhenInvalidCommands_ThenException(string commands)
        {
            var pluto = new Pluto();
            var roverController = new RoverController(pluto);

            Action moveRoverAction = () => roverController.MoveRover(commands);

            moveRoverAction.Should().ThrowExactly<ArgumentException>();
        }
    }
}
