public class Solution {
    public int FindClosestNumber(int[] nums) {
        int a=nums[0];
        
        for(int i=0;i<nums.Length;i++)
        {
            if(Math.Abs(a)>Math.Abs(nums[i]))
            {
                a=nums[i];
            }
        }

        // for(int i=0;i<nums.Length;i++)
        // {
        //     if(Math.Abs(a)==nums[i])
        //     {
        //         return nums[i];
        //     }
        // }
        if(a<0 && nums.Contains(Math.Abs(a)))
            return Math.Abs(a);
        else
            return a;
    }
}