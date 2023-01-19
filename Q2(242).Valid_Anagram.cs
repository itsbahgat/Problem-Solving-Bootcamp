public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        IDictionary<char, int> str = new Dictionary<char, int>();
        int x;
        if (s.Length == t.Length)
        {
            for (int i = 0; i < s.Length; i++)
            {

                if (str.ContainsKey(s[i]))
                {
                    str[s[i]] += 1;
                }
                else
                    str.Add(s[i], 1);
            }
            for (int i = 0; i < t.Length; i++)
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