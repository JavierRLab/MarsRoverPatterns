namespace MarsRoverPatterns;

internal class Compass
{
    
    private readonly string[] _compassDirections = {"N","E","S","W"};
    private int _directionIndex;
    
    
    public void RotateLeft()
    {
        _directionIndex = (_compassDirections.Length + _directionIndex - 1) % _compassDirections.Length;
    }

    public void RotateRight()
    {
        _directionIndex = (_directionIndex + 1) % _compassDirections.Length;
    }

    public string Direction()
    {
        return _compassDirections[_directionIndex];
    }
}