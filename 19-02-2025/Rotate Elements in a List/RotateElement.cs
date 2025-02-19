using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Elements_in_a_List
{
    internal class RotateElement
    {
        public List<int> ElementsRotate(List<int> list, int index)
        {
            List<int> list2 = new List<int>();
            for (int i = index; i < list.Count; i++)
            {
                list2.Add(list[i]);
            }
            for (int i = 0; i < index; i++)
            {
                list2.Add(list[i]);
            }
            return list2;
        }
    }
}
