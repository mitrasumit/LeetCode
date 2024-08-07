public class Solution {
    public string MergeAlternately(string word1, string word2) {
        
        int word1Length=word1.Length;
        int word2Length=word2.Length;

        int w1c=0;
        int w2c=0;

        StringBuilder s=new StringBuilder();

        while(w1c<word1Length && w2c<word2Length)
        {
            s.Append(word1[w1c]);
            s.Append(word2[w2c]);

            w1c++;
            w2c++;
        }

        if(w1c==word1Length && w2c==word2Length)
            return s.ToString();
        
         else if(word1Length>word2Length)
         {
            return s.Append(word1.Substring(w1c)).ToString();
         }
        else
           return s.Append(word2.Substring(w2c)).ToString();;
    }
}