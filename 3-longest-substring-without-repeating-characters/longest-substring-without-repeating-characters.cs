public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max=0;
        int maxCount=0;
        
        if(s.Length<=1)
            return s.Length;

        Dictionary<char,int> isPresent=new Dictionary<char,int>();

        for(int i=0;i<s.Length;i++)
        {
            for(int j=i;j<s.Length;j++)
            {
                if(isPresent.ContainsKey(s[j]))
                {
                    isPresent.Clear();
                    break;
                }
                else
                {
                   
                    isPresent.Add(s[j],1);
                    max=max+1;
                }
            }

            if(maxCount<max)
            {
                maxCount=max;
            }
            max=0;
        }

        return maxCount;
    }
}