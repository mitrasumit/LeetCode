public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        Dictionary<char,int> magazineLetter=new Dictionary<char,int>();

        foreach(char character in magazine)
        {
            if(magazineLetter.ContainsKey(character))
            {
                magazineLetter[character]=magazineLetter[character]+1;
            }
            else
            {
                magazineLetter.Add(character,1);
            }
        }

        // foreach (KeyValuePair<char, int> kvp in magazineLetter)
        // {
    
        //     Console.WriteLine(string.Format("Key = {0}, Value = {1}", kvp.Key, kvp.Value));
        // }


        foreach(char character in ransomNote)
        {
            if(magazineLetter.ContainsKey(character))
            {
                if(magazineLetter[character]<=0)
                {
                    return false;
                }
                else
                    magazineLetter[character]=magazineLetter[character]-1;
            }
            else
                return false;
        }
        return true;
    }
}