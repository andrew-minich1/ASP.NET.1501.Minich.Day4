using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSort
{
    public interface ISort
    {
        bool Sort(int[] firstnumbers, int[] secondnumbers);
    }

    public class SortBySumString : ISort
    {
        public bool Sort(int[] firstnumber, int[] secondnumber)
        {
            return firstnumber.Sum() > secondnumber.Sum() ? true : false;
        }
    }

    public class SortByMaxValue : ISort
    {
        public bool Sort(int[] firstnumber, int[] secondnumber)
        {
            return firstnumber.Max() > secondnumber.Max() ? true : false;
        }
    }

    public class SortByMinValue : ISort
    {
        public bool Sort(int[] firstnumber, int[] secondnumber)
        {
            return firstnumber.Min() > secondnumber.Min() ? true : false;
        }
    }
}
