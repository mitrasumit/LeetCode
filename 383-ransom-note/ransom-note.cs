public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
       Dictionary<char,int> rn=new Dictionary<char,int>();

       foreach(char c in ransomNote)
       {
        if(rn.ContainsKey(c))
            rn[c]=rn[c]+1;
         else
            rn.Add(c,1);
       }
       foreach(char c in magazine)
       {
        if(rn.ContainsKey(c))
        {
            rn[c]=rn[c]-1;
           
            if(rn[c]==0)
            {              
                rn.Remove(c);
            }
            if(rn.Count==0)
            {
                return true;
            }
        }
    }
        return false;
    }
}