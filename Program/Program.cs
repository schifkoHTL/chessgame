using ClassLib;
namespace Program;
public class Program
{
    public static int Main()
    {      
        ChessFigure Springer1 = new("H", [0,5]);
        GameField Field = new();

        Field.board[Springer1.position[0], Springer1.position[1]] = Springer1;
        Console.WriteLine(Field);

        Field.Move(Springer1, [2,4]);
        Console.WriteLine(Field);
        return 0;
    }
}