using System;
using System.Collections.Generic;
using System.Text;

namespace NunitTesting
{
    public class BubbleSort
    {
        BubbleSort(List<int> list)
        {
            list = list;
        }
        public void Bubble(List<int> list)
        {
            var items = new List<int>();
            for (var i = 0; i < items.Count; i++)
            {
                for (var j = 0; j < items.Count - 1; j++)
                {
                    if (items[j] > items[j + 1])
                    {
                        var temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }

        }
    }
}
