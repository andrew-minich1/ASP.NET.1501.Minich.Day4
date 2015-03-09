using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSort;

namespace SortMatrix
{
    public static  class Matrix
    {
        public static void Sort(int[][] array, ISort sort, bool x)
        {
            if(array==null || sort==null)
            {
                throw new NullReferenceException();
            }
            bool swaped;
            for (int i = 0; i < array.Length; i++)
            {
                swaped = false;
                for (int y = 0; y < array.Length - 1; y++)
                {
                    if(x==sort.Sort(array[y], array[y + 1]))
                    {
                        Swap(array, y, y + 1);
                        swaped = true;
                    }
                }
                if (!swaped) break;
            }
        }

        /// <summary>
        /// Swaps the elements of the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private static void Swap(int[][] array, int left, int right)
        {
            int[] temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
