namespace TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i+1; j < nums.Length; j++) {
                Console.WriteLine($"[{nums[i]},{nums[j]}]");
                if (nums[i] + nums[j] == target)
                    return [i,j];
            }
        }
        return [0];
    }
}