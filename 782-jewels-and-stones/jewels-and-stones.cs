public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        
        HashSet<char> jewel= new HashSet<char>(jewels);
        int count=0;

        foreach(char c in stones)
        {
            if(jewel.Contains(c))
                count++;
        }

        return count;
    }
}