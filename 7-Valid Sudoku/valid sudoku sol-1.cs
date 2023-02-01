public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char> rowSet = new();
        HashSet<char> colSet = new();
        Dictionary<(int,int),HashSet<char>> squares = new();
        for (int row=0;row<board.Length;row++) {
            for (int col=0;col<board.Length;col++) {
                if(board[row][col]!='.') {
                    //check duplicate in rach row
                    if(!rowSet.Add(board[row][col]))
                        return false;
                    if(!squares.ContainsKey((row/3,col/3)))
                        squares.Add((row/3,col/3),new());
                    //check duplicate in each square
                    if(!squares[(row/3,col/3)].Add(board[row][col]))
                        return false;
                }
                if(board[col][row]!='.')
                    //check duplicate in rach column
                    if(!colSet.Add(board[col][row]))
                        return false;
            }
            rowSet.Clear();
            colSet.Clear();
        }
        return true;
    }
}