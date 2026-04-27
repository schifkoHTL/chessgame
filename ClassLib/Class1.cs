namespace ClassLib;

public class GameField
{
    public ChessFigure?[,] board = new ChessFigure?[8,8];

    public ChessFigure? GetFigure(int row, int col)
    {
        return board[row, col];
        //hvhjgjg
    }
}

public class ChessFigure
{
}