public class Solution {
    public int Search(int[] nums, int target) {
        int l=0;
        int r=nums.Length-1;

        while(l<=r)
        {
           int m=(l+r)/2;

            if(target==nums[m])
            {
                return m;
            }
            else if(target<nums[m])
            {
                r=m-1;
            }
            else
            {
                l=m+1;
            }
        }
        return -1;
    }
}