public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        Array.Sort(strs);

        string f=strs[0];
        string l=strs[strs.Length-1];

        int i=0;

        while(i<f.Length && f[i]==l[i])
        {
            i++;
        }

        return f.Substring(0,i);
        
    }
}