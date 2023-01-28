// See https://aka.ms/new-console-template for more information

using System.Numerics;

string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
IList<IList<string>> list = GroupAnagrams(strs);


foreach (var sublist in list)
{
    foreach (var obj in sublist)
    {
        Console.WriteLine(obj);
    }
}

#region case1
//IList<IList<string>> GroupAnagrams(string[] strs)
//{
//    List<int> done = new List<int>();
//    IList<IList<string>> list = new List<IList<string>>();
//    for (int i = 0; (i < strs.Length); i++)
//    {
//        if (done.Contains(i))
//            continue;
//        List<string> matching = new List<string>();
//        matching.Add(strs[i]);
//        for (int j=i+1; j<strs.Length; j++)
//        {
//            if (IsAnagram(strs[i], strs[j]))
//            {
//                matching.Add(strs[j]);
//                done.Add(j);
//                //Console.WriteLine($"{strs[i]}, {strs[j]}");
//            }
//        }
//        list.Add(matching);
//    }
//    return list;
//}

//bool IsAnagram(string s, string t)
//{
//    char[] ss = s.ToCharArray();
//    char[] tt = t.ToCharArray();
//    Array.Sort(ss);
//    Array.Sort(tt);
//    return ss.SequenceEqual(tt);
//}

#endregion

#region case2
IList<IList<string>> GroupAnagrams(string[] strs)
{
    IDictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
    for (int i=0; i< strs.Length; i++)
    {
        char[] characters = strs[i].ToArray();
        Array.Sort(characters);
        string str = new string(characters);
        if (dict.ContainsKey(str))
        {
            dict[str].Add(strs[i]);
        }
        else 
        {
            List<string> data = new List<string>
            {
                strs[i]
            };
            dict.Add(str, data);
        }
    }
    return dict.Values.ToList();
}
#endregion