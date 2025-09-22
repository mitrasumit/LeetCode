public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        if (nums.Length == 1)
            return 1;

        int x = 0;
        int y = 1;

        while (y < nums.Length)
        {
            if (nums[x] == nums[y])
            {
                y++;
            }
            else
            {
                if (nums[x] < nums[y])
                {
                    nums[x + 1] = nums[y];
                    x = x + 1;
                    y = x + 1;
                }
                else
                {
                    y++;
                }
            }
        }

        return x+1;
    }
}