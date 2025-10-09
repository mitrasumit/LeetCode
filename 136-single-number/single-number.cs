public class Solution {
    public int SingleNumber(int[] nums) {
        
        Dictionary <int,int> dup=new Dictionary<int,int>();

        int value=1;

        for(int i=0;i<nums.Length;i++)
        {
            if(dup.ContainsKey(nums[i]))
            {
                dup[nums[i]]=value+1;
            }
            else
            {
                dup.TryAdd(nums[i],value);
            }
        }

        foreach(var keyValuePair in dup)
        {
            if(keyValuePair.Value==1)
            {
                return keyValuePair.Key;
            }
        }
        return 0;
    }
}