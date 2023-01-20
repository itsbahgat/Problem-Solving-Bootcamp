public class Solution {
    public bool IsAnagram(string s, string t) {
       
      char[] str1 = s.ToCharArray();
      char[] str2 = t.ToCharArray();
      int n1=str1.Count();
        int n2=str2.Count();
        if(n1!=n2){
          return false;
        }
        Array.Sort(str1);
        Array.Sort(str2);

        for (int i = 0; i < n1; i++) {
            if (str1[i] != str2[i]) {
                return false;
            }
        }
 
        return true;
    }
    }
