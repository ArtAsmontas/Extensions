using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    static internal class ListGeneric
    {
        public static List<T> GetListEverySecondWord<T> (this List<T> list)
        {
        List<T> result = new List<T>();

            for (int i = 0; i < list.Count; i+=2)
            {
                result.Add(list[i]);
            }
            return result;
        }
    }
}
