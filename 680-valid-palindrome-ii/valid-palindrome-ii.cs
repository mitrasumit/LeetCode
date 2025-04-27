public class Solution {
    public bool ValidPalindrome(string s) {

        int start=0;
        int end=s.Length-1;

        while(start<end)
        {
            if(s[start]!=s[end])
            {
                return verifyPalindrome(s,start+1,end)||verifyPalindrome(s,start,end-1);
            }
            start++;
            end--;
        }
        return true;
        
        bool verifyPalindrome(string s,int start,int end)
        {
            while(start<end)
            {
                if(s[start]!=s[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}