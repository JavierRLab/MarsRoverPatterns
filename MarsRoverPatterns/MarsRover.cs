namespace MarsRoverPatterns;

public class MarsRover
{
    private Compass _compass = new();
    private ICommand leftCommand;
    private ICommand rightCommand;

    public MarsRover()
    {
        this.leftCommand = new LeftCommand(_compass);
        this.rightCommand = new rightCommand(_compass);
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
                rightCommand.Execute();
            }
        }

        return $"0:0:{_compass.Direction()}";
    }
}