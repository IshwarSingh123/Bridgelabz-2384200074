using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Frequency_of_Elements
{
    internal class FindFrequency
    {
        
        public Dictionary<string, int> FrequencyFind(List<string> list)
        { 
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (dict.ContainsKey(list[i]))
                {
                    dict[list[i]]++;
                }
                else
                {
                    dict.Add(list[i], 1);
                }


            }
            return dict;

        }
    }
}
