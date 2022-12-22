// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var grid = new int[3][] { new int[] { 1, 3, 2 }, new int[] { 5, 2, 2 }, new int[] { 2, 1, 1 } };
Solution s = new Solution();
var answer = s.MinPathSum(grid);  
Console.WriteLine(answer);  

public class Solution
{
  public int MinPathSum(int[][] grid)
  {
    int rows = grid.Length;
    int c = grid[0].Length;
    var dp = new int[c + 1];
    for (int i = 0; i < dp.Length; i++)
    {
      if (i == dp.Length - 2) dp[i] = 0;
      else dp[i] = int.MaxValue;
    }

    while (rows-- > 0)
    {
      for (int i = dp.Length - 2; i >= 0; i--)
      {
        int val = grid[rows][i];
        dp[i] = val + Math.Min(dp[i], dp[i + 1]);
      }
    }

    return dp[0];
  }
}