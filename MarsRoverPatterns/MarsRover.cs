namespace MarsRoverPatterns;

public class MarsRover
{
    private Compass _compass = new();
    private ICommand leftCommand;

    public MarsRover()
    {
        this.leftCommand = new LeftCommand(_compass);
    }

    public string Execute(string command)
    {
        foreach (var singleCommand in command)
        {
            if (singleCommand.Equals('L'))
            {
                leftCommand.Execute();
                
            }
            
            if (singleCommand.Equals('R'))
            {
                _compass.RotateRight();
            }
        }

        return $"0:0:{_compass.Direction()}";
    }
}