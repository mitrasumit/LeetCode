public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        List<char> r=new List<char>(ransomNote);

        foreach(char m in magazine)
        {
            if(r.Contains(m))
            {   
                r.Remove(m);
                Console.WriteLine(r.Count);
            }
            if(r.Count==0)
            {
                return true;
            }
        }
        return false;
    }
}