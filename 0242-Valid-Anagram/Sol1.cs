public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length){
            return false;
       }

       int[] char_counts = new int[26];

       for(int i =0; i<s.Length;i++){
            char_counts[s[i]-'a']++;
            char_counts[t[i]-'a']--;
       }

       foreach(int count in char_counts ){
            if(count!=0){
                return false;
            }
       }

       return true;
    }
}