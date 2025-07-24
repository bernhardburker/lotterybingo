namespace LotteryBingo
{
    public class Board
    {
        public int[,] Matrix { get; }

        public Board()
        {
            Matrix = new int[5, 5];
        }
    }
}
