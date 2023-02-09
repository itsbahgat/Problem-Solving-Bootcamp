namespace encodeAndDecodeStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(){"we", "say", ":", "yes"};
            string str = encode(list);
            Console.WriteLine(str);
            list = decode(str);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
         String encode(List<String> strs)
        {
                // ceck that the list doesn't contain the same sequence you are enoding with
            return string.Join(":;", strs);
        }
         List<String> decode(String str)
        {
            return str.Split(":;").ToList();
        }
        }
    }
}