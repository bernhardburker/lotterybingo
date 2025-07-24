
using LotteryBingo;
namespace LotteryBingo.Tests;

public class Tests
{

    [Test]
    public void Board_Should_Be_5x5()
    {
        var board = new Board();
        Assert.AreEqual(5, board.Matrix.GetLength(0));
        Assert.AreEqual(5, board.Matrix.GetLength(1));
    }

}