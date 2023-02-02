namespace MarsRoverPatterns;

internal class LeftCommand : ICommand
{
    private readonly Compass _compass;

    public LeftCommand(Compass compass)
    {
        _compass = compass;
    }

    public void Execute()
    {
        _compass.RotateLeft();
    }
}