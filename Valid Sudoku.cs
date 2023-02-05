public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> hashset = new HashSet<string>();
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                char n = board[i][j];
                if (n != '.') {
                    if (!hashset.Add(n + "in row" + i) || !hashset.Add(n + "in column" + j) 
                    || !hashset.Add(n + "in block" +i/3 + "-" + j/3)) return false;
                }
            }
        }
        Console.Write(hashset);
        return true;
    }
}
