public class Solution {
    public bool IsPalindrome(string s) {
        

        if(s.Length==1)
            return true;
        
        string pattern = @"[^A-Za-z0-9]";
         s =  (System.Text.RegularExpressions.Regex.Replace(s, pattern, string.Empty)).ToLower();


        int right=s.Length-1;
        int left=0;

        while(left<=right)
        {
            if(s[left]==s[right])
            {
                left++;
                right--;
            }
            else
                return false;
        }
        return true;
    }
}