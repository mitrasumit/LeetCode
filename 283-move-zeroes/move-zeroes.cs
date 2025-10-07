public class Solution {
    public void MoveZeroes(int[] nums) {

     int x=0;
     int i=0;

     while(i<nums.Length)
     {
        if(nums[i]!=0 && i<nums.Length)
        {
            nums[x]=nums[i];
            i++;
            x++;
        }
        else
        {
            i++;
        }
    }

    while(x<nums.Length)
    {
        nums[x]=0;
        x++;
    }
    }
}