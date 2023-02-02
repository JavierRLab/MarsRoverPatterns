namespace MarsRoverPatterns;

internal class LeftCommand : ICommand
{
    private readonly Compass _compass;

    public LeftCommand(Compass compass)
    {
        _compass = compass;
        throw new NotImplementedException();
    }
}