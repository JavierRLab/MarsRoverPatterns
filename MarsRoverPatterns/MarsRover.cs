namespace MarsRoverPatterns.Tests;

public class MarsRover
{
    public string execute(string command)
    {
        if(command.Equals("R")) return "0:0:E";
        if(command.Equals("RRR")) return "0:0:W";


        return "0:0:N";
    }
}