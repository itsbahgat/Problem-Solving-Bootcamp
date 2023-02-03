public class Solution
{
    public IListIListstring GroupAnagrams(string[] strs)
    {


        IListstring li = new Liststring();
        IListIListstring str = new ListIListstring();


        bool exist = false;

        int count = strs.Count();

        li.Add(strs[0]);
        str.Add(li);
        if (count == 1) return str;

        for (int i = 1; i  strs.Count(); i++)
        {
            if (strs[i] != -1)
            {
                exist = false;
                foreach (Liststring subList in str)
                {

                    if (IsAnagram(strs[i], subList[0]))
                    {
                        subList.Add(strs[i]);
                        strs[i] = -1;
                        exist = true;
                        break;

                    }


                }
                if (!exist)
                    str.Add(new Liststring { strs[i] });
            }
        }

        return str;

    }
    public bool IsAnagram(string s, string t)
    {
        IDictionarychar, int str = new Dictionarychar, int();
        int x;
        if (s.Length == t.Length)
        {
            for (int i = 0;is.Length; i++)
            {

                if (str.ContainsKey(s[i]))
                {
                    str[s[i]] += 1;
                }
                else
                    str.Add(s[i], 1);
            }
            for (int i = 0; it.Length; i++)
            {
                if (!str.ContainsKey(t[i]))
                {
                    return false;
                }
                else
                {
                    x = str[t[i]] - 1;
                    str[t[i]] = x;
                    if (x == 0) str.Remove(t[i]);
                }

            }
        }
        else return false;

        return true;
    }
}