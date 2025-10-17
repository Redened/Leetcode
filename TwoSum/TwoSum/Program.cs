namespace TwoSum;

public class Program
{
    public static void Main()
    {
        var solutionResult = Solution.TwoSum([2, 5, 5, 11], 10);

        Console.WriteLine(string.Join(" ", solutionResult));
    }
}

public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return [];
    }
}