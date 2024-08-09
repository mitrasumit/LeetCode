public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s==t)
            return true;

        else if(s=="")
            return true;
        else if(s.Length>t.Length)
            return false;

        else
        {
            int i=0;
            int j=0;

            while(j<t.Length)
            {
                if(s[i]==t[j])
                {
                    if(i==s.Length-1)
                        return true;
                    
                    Console.WriteLine(i+" "+j);
                    i++;
                    
                }
                j++;
            }  
            return false;
        }
    }
}