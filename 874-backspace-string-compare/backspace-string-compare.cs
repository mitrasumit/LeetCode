public class Solution {
    public bool BackspaceCompare(string s, string t) {
        
        int largerString=Math.Max(s.Length,t.Length);
        string sr="";
        string tr="";

        if(largerString==0)
            return true;

        for(int i=0;i<largerString;i++)
        {
            if(i<s.Length)
            {
            if(s[i]=='#')
            {
                if(!string.IsNullOrEmpty(sr))
                {
                    sr=sr.Remove(sr.Length-1);
                }
            }
            else
                {
                    sr=sr+s[i];
                }
            }

            if(i<t.Length)
            {
                if(t[i]=='#')
            {
                if(!string.IsNullOrEmpty(tr))
                {
                    tr=tr.Remove(tr.Length-1);
                }
            }
            else
            {
                tr=tr+t[i];
            }
            }
        }
        if(sr==tr)
            return true;

        else
            return false;   
    }
}