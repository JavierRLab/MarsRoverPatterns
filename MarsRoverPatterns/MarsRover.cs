namespace MarsRoverPatterns.Tests;

public class MarsRover
{
    private readonly Compass _compass = new();
    // private ICommand leftCommand = new LeftCommand(_compass);
    
    public string Execute(string command)
    {
        foreach (var singleCommand in command)
        {
            if (singleCommand.Equals('L'))
            {
                _compass.RotateLeft();
                
            }
            
            if (singleCommand.Equals('R'))
            {
                _compass.RotateRight();
            }
        }

        return $"0:0:{_compass.Direction()}";
    }
}