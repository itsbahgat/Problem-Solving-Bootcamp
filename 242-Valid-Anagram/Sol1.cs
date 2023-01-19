public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
            return false; 
            
        Dictionary<char,int> dic = new Dictionary<char,int>();
        Dictionary<char,int> dic2 = new Dictionary<char,int>();

        for (int i=0; i<s.Length; i++)
        {
            if (dic.ContainsKey(s[i]))
                dic[s[i]]++;
            else
                dic[s[i]] = 1;

            if (dic2.ContainsKey(t[i]))
                dic2[t[i]]++;
            else
                dic2[t[i]] = 1;
        }

        if(dic.Except(dic2).Any())
            return false;
        return true;
    }
}