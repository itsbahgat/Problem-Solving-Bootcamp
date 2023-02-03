public class Solution
{
    /*
     * @param strs: a list of strings
     * @return: encodes a list of strings to a single string.
     */

    public String Encode(List<String> strs)
    {
        StringBuilder builder = new StringBuilder();
        //builder.Append("= =");
        for (int i = 0; i < strs.Count; i++)
        {
            builder.Append("= =" + strs[i] + "= =");
        }
        //builder.Append("= =");
        return builder.ToString();
        // write your code here
    }

    /*
     * @param str: A string
     * @return: dcodes a single string to a list of strings
     */
    public List<String> Decode(String str)
    {
        List<String> inputs = new List<String>();
        string[] arr = str.Split("= =");
        int counter = 0;
        for (int i = 1; i < arr.Length - 1; i += 2)
        {
            inputs.Add(arr[i]);
            //counter++;
        }

        return inputs;
    }
}