public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        int count=0;
        int max=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==1)
            {
                count++;
            }

            else
            {
                max=Math.Max(max,count);
                count=0;
            }
        }

        Console.WriteLine(count);

        return max<count ? count:max;
    }
}