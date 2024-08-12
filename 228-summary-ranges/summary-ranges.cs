public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        
        List<string> str=new List<string>();
        int i=0;

       while(i<nums.Length)
       {
        int start=nums[i];

        while(i<nums.Length-1 && (nums[i]+1==nums[i+1]))
        {
            i++;
        }

            if(start==nums[i])
            {
                str.Add($"{start}");
            }
            else
                str.Add($"{start}->{nums[i]}");
        
        i++;
       }

        return str.ToArray();
    }
}