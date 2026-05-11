using System.Net.Http.Headers;

namespace ClassLib;

public class GameField
{
    public ChessFigure?[,] board = new ChessFigure?[8,8];

    public ChessFigure? GetFigure(int row, int col)
    {
        return board[row, col];
    }

    public override string ToString()
    {
        string output = "";
        for(int j = 0; j < 8; j++)
        {
            for(int i = 0; i < 8; i++)
            {
                if(board[j,i] == null)
                {
                    output += "   |";
                }
                else
                {
                    output += $" {board[j,i]!.name} |";
                }

                if(i == 7 && j != 7)
                {
                    output += $"{Environment.NewLine}---+---+---+---+---+---+---+---{Environment.NewLine}";
                }


            }
        }
        output += $"{Environment.NewLine}";
        return output;
    }

    public bool Move(ChessFigure F, int[] toField)
    {
        bool isPossible = false;

        int[] fromField = F.position;

        int rowToField = toField[0];
        int colToField = toField[1];

        int rowFromField = F.position[0];
        int colFromField = F.position[1];

        int rowFieldDif;
        int colFieldDif;
        if (rowToField < 0 || colToField < 0 || rowToField > 7 || colToField > 7) //falls das feld wohin es soll minus ist oder über 7, scheitert der Zug
        {
            return false;
        }


        if (F.name == "H")
        {
            
            rowFieldDif = Math.Abs(rowFromField - rowToField);
            colFieldDif = Math.Abs(colFromField - colToField);

            if ((rowFieldDif == 1 && colFieldDif == 2) || (rowFieldDif == 2 && colFieldDif == 1))
            {
                F.position = [rowToField, colToField];
                board[rowFromField, colFromField] = null;
                board[rowToField, colToField] = F;

                isPossible = true;
                return isPossible;
            }
        }


        return isPossible;
    }
}

public class ChessFigure
{
    public string name;
    public int[] position;

    public ChessFigure(string namen, int[] pos)
    {
        name = namen;
        position = pos;
    }

    
}

/*
King = K
Queen = Q
Pawn = P
Rook = R
Springer = S
Bishop = B
*/