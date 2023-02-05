using System.Text.Encodings.Web;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static String encode(List<String> strs)
            {
                return string.Join(":;", strs);
            }
            static List<String> decode(String str)
            {
                return str.Split(':' , ';').ToList<string>();
            }

            List<string> list1 = new List<string>() {  "we", "say", ":", "yes"};
            string encodedString = encode(list1);
            Console.WriteLine("Encoded String: " + encodedString);
            List<string> decodedList = decode(encodedString);
            Console.Write("Decoded List: [ ");
            foreach (string item in decodedList)
            {
                Console.Write($"{item}");
            }
            Console.Write("]");

        }
    }
}
