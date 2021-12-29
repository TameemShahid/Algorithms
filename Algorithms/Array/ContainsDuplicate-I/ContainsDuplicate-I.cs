using System.Collections.Generic;

namespace Algorithms.Array_ContainsDuplicate
{
    public class ContainsDuplicate_I
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> elements = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                bool added = elements.Add(nums[i]);
                if (!added) return true;
            }
            return false;
        }
    }
}
