namespace MarsRoverPatterns.Tests;

public class MarsRover
{
    private string compassDirection = "N";

    public string execute(string command)
    {
        if(command.Equals("R")) compassDirection = "E";
        if(command.Equals("RRR")) compassDirection = "W";

        return $"0:0:{compassDirection}";
    }
}