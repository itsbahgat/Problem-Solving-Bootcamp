public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

            char[] temp = null;
            string str = null;
            for (int i=0; i<strs.Length; i++)
            {
                temp = strs[i].ToCharArray();
                Array.Sort(temp);
                str = new string(temp);

                if (dic.ContainsKey(str))
                    dic[str].Add(strs[i]);
                else
                    dic.Add(str, new List<string>() { strs[i] });
              }


        IList<IList<string>> answer = new List<IList<string>>();
        foreach (var x in dic)
            answer.Add(x.Value);

        return answer;
    }
}