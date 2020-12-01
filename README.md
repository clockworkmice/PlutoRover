# Pluto Rover

## Implementation

PlutoRover.Domain is a class library since execution is discouraged. RoverController is the entry point through which the tests pass a string command.

This was developed using TDD with 3 main tests each with different cases.

## Tests

1. Given Rover On Pluto  
When Move Commands  
Then At Position And Direction
2. Given Rover On Pluto With Obstacles  
When Move Commands  
Then At Position And Direction Before Collision
3. Given Rover On Pluto  
When Invalid Commands  
Then Exception

For more code coverage unit tests could be written but for the complexity of the problem I thought functional tests such as these should suffice.

## How to run

To test successful behaviour please run the test project from the root folder run `dotnet test`.

## Notes

I didn't fully understand the requirements of what should happen upon collision with an obstacle but I've assumed it meant to not proceed onto the point with the obstacle but instease report the current position and end the execution of commands.