public class Solution {
    public bool IsValidSudoku(char[][] board) {
                Dictionary<int, HashSet<char>> row = new();
                Dictionary<int, HashSet<char>> column = new();
                Dictionary<(int,int), HashSet<char>> subBox = new();

                for(int i =0;i<9;i++)
                {
                    row[i] = new HashSet<char>();
                    for (int j = 0;j < 9;j++)
                    {
                        if (board[i][j] == '.')
                            continue;
                    if(!column.ContainsKey(j))
                             column[j] = new HashSet<char>();
                    if(!subBox.ContainsKey((i/3, j/3))) 
                            subBox[(i/3, j/3)] = new HashSet<char>();
                        if (row[i].Contains(board[i][j]) || column[j].Contains(board[i][j]) || subBox[(i/3, j/3)].Contains(board[i][j]))
                            return false;
                        row[i].Add(board[i][j]);
                        column[j].Add(board[i][j]);
                        subBox[(i/3, j/3)].Add(board[i][j]);
                    }
                }
                return true;
    }
}