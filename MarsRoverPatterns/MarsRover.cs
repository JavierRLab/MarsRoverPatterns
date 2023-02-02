namespace MarsRoverPatterns.Tests;

public class MarsRover
{
    private string[] compassDirections = {"N","E","S","W"};
    private int directionIndex;

    public string execute(string command)
    {
        foreach (var singleCommand in command)
        {
            if (singleCommand.Equals('R'))
            {
                rotateRight();
            }
        }

        return $"0:0:{compassDirections[directionIndex]}";
    }

    private void rotateRight()
    {
        directionIndex = (directionIndex + 1) % compassDirections.Length;
    }
}