using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Implementations
{
    public class SortAlgorithms
    {
        public ICollection<T> BubbleSort<T>(ICollection<T> data) where T: IComparable
        {
            T[] array = data.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j - 1].CompareTo(array[j]) > 0)
                    {
                        var temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}
