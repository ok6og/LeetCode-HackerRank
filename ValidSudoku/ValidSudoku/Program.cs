namespace ValidSudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValidSudoku([['5','3','.','.','7','.','.','.','.']
                                            ,['6','.','.','1','9','5','.','.','.']
                                            ,['.','9','8','.','.','.','.','6','.']
                                            ,['8','.','.','.','6','.','.','.','3']
                                            ,['4','.','.','8','.','3','.','.','1']
                                            ,['7','.','.','.','2','.','.','.','6']
                                            ,['.','6','.','.','.','.','2','8','.']
                                            ,['.','.','.','4','1','9','.','.','5']
                                            ,['.','.','.','.','8','.','.','7','9']]));
        }

        public static bool IsValidSudoku(char[][] board)
        {
            HashSet<char> rowSet = new HashSet<char>();
            HashSet<char> colSet = new HashSet<char>();

            for (int i = 0; i < board[0].Length; i++)
            {
                rowSet.Clear(); colSet.Clear();
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i][j] == '.' || !rowSet.Contains(board[i][j]))
                    {                                            
                        rowSet.Add(board[i][j]);
                    }
                    else
                    {
                        return false;
                    }

                    if (board[j][i] == '.' || !colSet.Contains(board[j][i]))
                    {
                        colSet.Add(board[j][i]);
                    }
                    else
                    {
                        return false;
                    }
                }
            }


            HashSet<char> gridSet = new HashSet<char>();
            for (int i = 0; i < 9; i += 3)
            {
                
                for (int j = 0; j < 9; j += 3)
                {
                    gridSet.Clear();
                    for (int m = i; m < i + 3; m++)
                    {
                        for (int n = j; n < j + 3; n++)
                        {
                            if (board[m][n] == '.' || !gridSet.Contains(board[m][n]))
                            {
                                gridSet.Add(board[m][n]);
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
