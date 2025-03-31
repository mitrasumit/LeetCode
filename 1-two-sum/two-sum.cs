public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> hashMap=new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++)
        {
            var sum=target-nums[i];

            if(hashMap.ContainsKey(sum))
            {
                return new[] {i,hashMap[sum]};
            }
            if(!hashMap.ContainsKey(nums[i]))
                hashMap.Add(nums[i],i);
        }
        return null;
    }
}