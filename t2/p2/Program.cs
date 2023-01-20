// See https://aka.ms/new-console-template for more information

Console.WriteLine(IsAnagram("anagram", "anagram"));

bool IsAnagram(string s, string t)
{
    char[] ss = s.ToCharArray();
    char[] tt = t.ToCharArray();
    Array.Sort(ss);
    Array.Sort(tt);
    return ss.SequenceEqual(tt);
    //s = string.Join("", ss);
    //t= string.Join("", tt);
    //return (s == t);
}
