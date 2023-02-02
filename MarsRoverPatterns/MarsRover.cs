namespace MarsRoverPatterns.Tests;

public class MarsRover
{
    private string[] compassDirections = {"N","E","S","W"};
    private int directionIndex;

    public string execute(string command)
    {
        foreach (var singleCommand in command)
        {
            if (singleCommand.Equals('L'))
            {
                rotateLeft();
            }
            
            if (singleCommand.Equals('R'))
            {
                rotateRight();
            }
        }

        return $"0:0:{compassDirections[directionIndex]}";
    }

    private void rotateLeft()
    {
        directionIndex = (compassDirections.Length + directionIndex - 1) % compassDirections.Length;
    }

    private void rotateRight()
    {
        directionIndex = (directionIndex + 1) % compassDirections.Length;
    }
}