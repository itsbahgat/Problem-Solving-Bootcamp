// See https://aka.ms/new-console-template for more information



bool IsValidSudoku(char[][] board)
{
    if (board.GetLength(0)!= board.GetLength(1))
        return false;
    for (int i=0; i<board.GetLength(0); i++)
    {
        board[i].Count();
    }
}
