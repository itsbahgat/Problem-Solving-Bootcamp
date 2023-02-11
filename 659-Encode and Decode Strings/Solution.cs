internal class Solution
{
    List<String> strCPY;

    public string Encode(List<string> strs)
    {
        string coded = string.Empty;
        for (int i = 0; i < strs.Count; i++)
        {
            coded += strs[i].Length + "," + strs[i];
        }
        return coded;

    }
    public List<string> Decode(string str)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < str.Length;)
        {
            string Slength = string.Empty, word = string.Empty;
            while (str[i] != ',')
            {
                Slength += str[i++];
            }
            Int32.TryParse(Slength, out int length);
            i++;
            for (int j = 0; j < length; j++, i++)
            {
                word += str[i];
            }
            result.Add(word);
        }
        return result;

    }
}