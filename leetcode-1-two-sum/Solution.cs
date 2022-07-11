
namespace leetcode_1_two_sum
{
    public static class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (nums.Contains(diff))
                {
                    var numsList = nums.ToList();
                    var list = nums.Where(x => x == diff).ToList();
                    if (numsList.IndexOf(diff).Equals(i))
                        continue;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    result.Add(i);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                   
                    foreach(var l in list)
                    {
                        if(numsList.IndexOf(l)==i)
                        {
                            result.Add(numsList.LastIndexOf(diff));
                            break;
                        }
                        else
                        {
                            result.Add(numsList.IndexOf(diff));
                            break;
                        }
                    }
                    if(result!=null)
                    {
                        break;
                    }
                }
            }
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return result.ToArray();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}
