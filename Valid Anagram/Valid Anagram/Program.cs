namespace Valid_Anagram
{
    internal class Program
    {
        public static bool  IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            char[] ss = s.ToCharArray();
            char[] tt = t.ToCharArray();
            Array.Sort(ss);
            Array.Sort(tt);
            return ss.SequenceEqual(tt);
        }
        static void Main(string[] args)
        {
            String s , t;
            s = Console.ReadLine();
            t = Console.ReadLine();
            Console.WriteLine(IsAnagram(s , t));
        }
    }
}