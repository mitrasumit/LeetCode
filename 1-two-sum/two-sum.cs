public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int,int> n=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(n.TryGetValue(target-nums[i],out int index))
                return new int[]{i,index};
        
        n[nums[i]]=i;
        }
        return new int[]{};
    }
}