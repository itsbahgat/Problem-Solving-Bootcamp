public class Solution {
    string encode(List<string> strs)
    {
        StringBuilder sb = new StringBuilder();
        for (int i=0;i<strs.Count-1;i++)
        {
            sb.Append(strs[i]).Append(":;");
        }
        sb.Append(strs[strs.Count-1]);
        return sb.ToString();
        //return String.Join(":;", strs);
    }

    List<string> decode(string str)
    {
        List<string> list = new();
        int j = 0;
        for (int i = 1; i<str.Length;i++)
        {
            if (str[i-1] == ':' && str[i] == ';')
            {
                list.Add(str[j..(i-1)]);
                j = i+1;
            }
        }
        list.Add(str[j..]);
        return list;
        //return str.Split(":;").ToList<string>();
    }
}