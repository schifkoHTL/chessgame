using ClassLib;
namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test_Empty_Field()
    {
        GameField board = new GameField();
        for(int row = 0; row < 8; row++)
        {
            for(int col = 0; col < 8; col++)
            {
                
            }
        }
    }
}