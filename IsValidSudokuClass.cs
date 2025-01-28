public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<int> hashset = new HashSet<int>();
        Dictionary<int, HashSet<int>> rows = new Dictionary<int, HashSet<int>>();
        Dictionary<int, HashSet<int>> columns = new Dictionary<int, HashSet<int>>();
        Dictionary<string, HashSet<int>> matrix = new Dictionary<string, HashSet<int>>();
        //traverse all the rows 9
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }
                if (!rows.ContainsKey(i))
                {
                    rows.TryAdd(i, new HashSet<int>());
                }
                if (rows[i].Contains(board[i][j]))
                {
                    return false;
                }
                if (!columns.ContainsKey(j))
                {
                    columns.TryAdd(j, new HashSet<int>());
                }
                if (columns[j].Contains(board[i][j]))
                {
                    return false;
                }
                string key = i / 3 + " " + j / 3;
                if (!matrix.ContainsKey(key))
                {
                    matrix.TryAdd(key, new HashSet<int>());
                }
                if (matrix[key].Contains(board[i][j]))
                {
                    return false;
                }

                rows[i].Add(board[i][j]);
                columns[j].Add(board[i][j]);
                matrix[key].Add(board[i][j]);
            }

        }
        return true;
    }

}