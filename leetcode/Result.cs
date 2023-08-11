using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public class Result
    {
        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            int min = 0, max = 0;
            for (int i = 0; i < 4; i++)
            {
                min = arr[i] + min;
            }
            for (int i = 1; i < 5; i++)
            {
                max = arr[i] + max;
            }
            Console.WriteLine($"{min} {max}");
            Console.ReadLine();
        }
        public static string timeConversion(string s)
        {
            DateTime time = DateTime.Parse(s);
            s = time.ToString("HH:mm:ss");
            return s;
        }
        public static int lonelyinteger(List<int> a)
        {
            a.Sort();
            int uni = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (i < a.Count - 1)
                {
                    if (a[i + 1] > a[i])
                    {
                        uni++;
                    }
                }
                else
                {
                    uni++;
                }

            }
            return uni;
        }
        public static int test(string str)
        {
            string sign = "+";
            int result = 0;
            str = str.Trim();
            if (str.Substring(0, 1) == sign)
            {
                str = str.Substring(1);
            }
            else if (str.Substring(0, 1) == "-")
            {
                str = str.Substring(1);
                sign = "-";
            }
            str = str.Substring(1);
            int temp;
            int j = 0;
            while (j < str.Length && int.TryParse(str.Substring(j, 1), out temp))
            {
                j++;
            };
            str = str.Substring(0, j);
            if (int.TryParse((sign + str), out result))
            {
                return result;
            }
            else
            {
                return result;
            }

        }
        public static int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            int result = 1;
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length)
                {
                    if (s[i] == s[i + 1])
                    {
                        if (result > max)
                        {
                            max = result;
                        }
                        result = 1;
                        start = i + 1;
                        continue;
                    }
                    if (s.Substring(start, result).IndexOf(s[i + 1]) != -1)
                    {
                        if (result > max)
                        {
                            max = result;
                        }
                        result = 1;
                        start = i + 1;
                        continue;
                    }
                    result++;

                }
                else
                {
                    if (s.Substring(start, result).IndexOf(s[i]) != -1)
                    {
                        if (result > max)
                        {
                            max = result;
                        }
                        result = 1;
                        continue;
                    }
                    else
                    {
                        result++;
                        max = result;
                    }
                }
            }
            return max;
        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {

            nums.OrderBy(x => x);
            List<IList<int>> results = new List<IList<int>>();
            List<int> showed = new List<int>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 2; j < nums.Length; j++)
                {
                    if (nums[i] + nums[i + 1] + nums[j] == 0)
                    {
                        List<int> result = new List<int>();
                        if (!(showed.Exists(x => x == nums[i]) && showed.Exists(x => x == nums[i + 1]) && showed.Exists(x => x == nums[j])))
                        {
                            result.Add(nums[i]);
                            result.Add(nums[i + 1]);
                            result.Add(nums[j]);
                            showed.Add(nums[i]);
                            showed.Add(nums[i + 1]);
                            showed.Add(nums[j]);
                            results.Add(result);
                        }
                    }
                }
            }
            if (results.Count == 0)
            {
                List<int> empty = new List<int>();
                results.Add(empty);
            }
            return results;
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            if (m > 0 && n > 0)
            {
                int maxmn = m > n ? m : n;
                int[] newarray = new int[m + n];
                int count = 0;
                int nums1count = 0;
                int nums2count = 0;
                int pointer1 = nums1[0];
                int pointer2 = nums2[0];
                while (count < m + n)
                {
                    if (pointer1 > pointer2)
                    {
                        newarray[count] = pointer2;
                        count++;
                        nums2count++;
                        if (nums2count >= n)
                        {
                            pointer2 = pointer1;
                            nums1count++;
                            pointer1 = nums1[nums1count];
                            continue;
                        }
                        pointer2 = nums2[nums2count];
                    }
                    else
                    {
                        newarray[count] = pointer1;
                        count++;
                        nums1count++;
                        if (nums1count >= m)
                        {
                            pointer1 = pointer2;
                            nums2count++;
                            pointer2 = nums2[nums2count];
                            continue;
                        }
                        pointer1 = nums1[nums1count];
                    }
                }
                foreach (int nums in newarray)
                {
                    Console.WriteLine(nums);
                }
                if ((m + n) % 2 != 0)
                {
                    return (double)newarray[(m + n) / 2];
                }
                else
                {
                    double ans = (double)(newarray[(m + n) / 2] + newarray[(m + n) / 2 + 1]) * 0.5;
                    return ans;
                }
            }
            else if (m > 0 && n == 0)
            {
                if (m % 2 != 0)
                {
                    return (double)nums1[m / 2];
                }
                else
                {
                    double ans = (double)(nums1[m / 2] + nums1[m / 2 + 1]) * 0.5;
                    return ans;
                }
            }
            else if (n > 0 && m == 0)
            {
                if (n % 2 != 0)
                {
                    return (double)nums2[n / 2];
                }
                else
                {
                    double ans = (double)(nums2[n / 2] + nums2[n / 2 + 1]) * 0.5;
                    return ans;
                }
            }
            else
            {
                return 0;
            }
        }
       
    }
}
