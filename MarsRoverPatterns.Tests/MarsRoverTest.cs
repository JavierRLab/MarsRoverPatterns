namespace MarsRoverPatterns.Tests;

public class MarsRoverTest
{
    private MarsRover _marsRover;

    public MarsRoverTest()
    {
        _marsRover = new MarsRover();
    }


    [Fact]
    public void CheckInitialPosition()
    {
        Assert.Equal("0:0:N", _marsRover.execute(""));
    }

    [Theory]
    [InlineData("R", "0:0:E")]
    [InlineData("RRR", "0:0:W")]
    [InlineData("RRRRRR", "0:0:S")]
    public void TurnRight(string command, string expectedPosition)
    {
        Assert.Equal(expectedPosition, _marsRover.execute(command));
    }


}