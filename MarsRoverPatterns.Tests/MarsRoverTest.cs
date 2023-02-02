namespace MarsRoverPatterns.Tests;

public class MarsRoverTest
{
    [Fact]
    public void CheckInitialPosition()
    {
        var marsRover = new MarsRover();
        Assert.Equal("0:0:N", marsRover.execute(""));
    }

    [Fact]
    public void TurnRightOnce()
    {
        var marsRover = new MarsRover();

        Assert.Equal("0:0:E", marsRover.execute("R"));
    }

    [Fact]
    public void TurnRightThree()
    {
        var marsRover = new MarsRover();

        Assert.Equal("0:0:W", marsRover.execute("RRR"));
    }
}