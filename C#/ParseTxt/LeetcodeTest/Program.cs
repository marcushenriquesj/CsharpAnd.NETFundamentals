using System.Text;

namespace LeetcodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string res = LongestPalindrome("babad");

            Console.WriteLine($"Result: {res}");
        }

        public static string LongestPalindrome(string s)
        {
            int maxPalSize = 1;
            int start = 0, end;
            string result = s[start].ToString();


            for (start = 0; start < s.Length - 1; start++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(s[start]);
                for (end = start + 1; end < s.Length - 1; end++)
                {
                    sb.Append(s[end]);
                    string temp = sb.ToString();
                    if (temp[0] == temp[temp.Length-1])
                    {
                        if ((end - start) > maxPalSize)
                        {
                            int frontIter = start + 1;
                            for (int backIter = end - 1; backIter >= frontIter; backIter--)
                            {
                                if (temp[backIter] == temp[frontIter])
                                {                                    
                                    if (backIter == frontIter)
                                    {
                                        maxPalSize = start - end;
                                        result = temp;
                                    }
                                    frontIter++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }


    }
}     
        
    
