namespace MarsRoverPatterns.Tests;

public class MarsRoverTest
{
    [Fact]
    public void CheckInitialPosition()
    {
        var marsRover = new MarsRover();
        Assert.Equal("0:0:N", marsRover.execute(""));
    }
}