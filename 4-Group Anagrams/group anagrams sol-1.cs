public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {

        Dictionary<string,IList<string>> stringsDict = new();
        string str;
        char[] arr;
        for(int i=0;i<strs.Length;i++) {
            arr = strs[i].ToCharArray();
            Array.Sort(arr);
            str = new string(arr);
            if(!stringsDict.ContainsKey(str)) {
                stringsDict.Add(str,new List<string>());
            }
            stringsDict[str].Add(strs[i]);
        }
        
        return stringsDict.Values.ToList();
    }
}