public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        Dictionary<char,int> d= new ();
        for(int i=0;i<s.Length;i++) {
            if(d.ContainsKey(s[i])) {
                d[s[i]]++;
            }
            else {
                d.Add(s[i],1);
            }
        }
        for(int i=0;i<t.Length;i++) {
            if(!d.ContainsKey(t[i]) || d[t[i]]==0) {
                return false;
            } else {
                d[t[i]]--;
            }
        }
        return true;
    }
}