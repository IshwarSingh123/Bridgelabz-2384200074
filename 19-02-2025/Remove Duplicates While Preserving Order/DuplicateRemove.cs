using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_While_Preserving_Order
{
    internal class DuplicateRemove
    {
        public List<int> RemoveDuplicates(List<int> list)
        {
            HashSet<int> set = new HashSet<int>(); // Track seen elements
            List<int> result = new List<int>();    // Store unique elements

            foreach (var item in list)
            {
                if (!set.Contains(item))
                {
                    set.Add(item);
                    result.Add(item);
                }
            }

            return result; // Return new list with duplicates removed
        }

    }
}
