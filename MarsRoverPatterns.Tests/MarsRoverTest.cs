namespace MarsRoverPatterns.Tests;

public class MarsRoverTest
{
    private readonly MarsRover _marsRover;

    public MarsRoverTest()
    {
        _marsRover = new MarsRover();
    }


    [Fact]
    public void CheckInitialPosition()
    {
        Assert.Equal("0:0:N", _marsRover.Execute(""));
    }

    [Theory]
    [InlineData("R", "0:0:E")]
    [InlineData("RRR", "0:0:W")]
    [InlineData("RRRRRR", "0:0:S")]
    public void TurnRight(string command, string expectedPosition)
    {
        Assert.Equal(expectedPosition, _marsRover.Execute(command));
    }
    
[Theory]
    [InlineData("L", "0:0:W")]
    [InlineData("LLL", "0:0:E")]
    [InlineData("LLLLLL", "0:0:S")]
    public void TurnLeft(string command, string expectedPosition)
    {
        Assert.Equal(expectedPosition, _marsRover.Execute(command));
    }


}