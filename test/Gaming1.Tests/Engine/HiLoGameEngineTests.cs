using Gaming1.Engine;

namespace Gaming1.Tests.Engine;

public class HiLoGameEngineTests
{
    private readonly HiLoGameEngine _gameEngine;
    private const int Min = 1;
    private const int Max = 10;

    public HiLoGameEngineTests()
    {
        _gameEngine = new HiLoGameEngine(Min, Max);
    }

    [Fact]
    public void MysteryNumber_Should_BeWithinBounds()
    {
        var mysteryNumber = _gameEngine.GetMysteryNumber();

        Assert.InRange(mysteryNumber, Min, Max);
    }
}