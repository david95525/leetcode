using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems
{
    public class EasyLevel
    {
        //28
        public static int Find_the_Index_of_the_First_Occurrence_in_a_String(string haystack, string needle)
        {
            int length = haystack.Length - needle.Length;
            int result = -1;
            for (int i = 0; i <= length; i++)
            {
                string temp = haystack.Substring(i, needle.Length);
                if (temp == needle && result < 0)
                {
                    result = i;
                }
            }
            return result;
        }
        //35
        public static int Search_Insert_Position(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int i = 0, j = nums.Length - 1;
            int index = -1;
            while (i <= j)
            {
                index = (i + j) / 2;
                if (nums[index] == target)
                    return index;
                if (nums[index] >= target)
                    j = index - 1;
                else
                    i = index + 1;
            }
            return i;
        }
        //58
        public static int Length_of_Last_Word(string s)
        {
            int count = 0;
            int last = s.Length - 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[last].ToString() == " ")
                {
                    last--;
                }
                else
                {
                    if (s[i].ToString() != " ") count++;
                    else break;
                }
            }
            return count;
        }
    }
}
