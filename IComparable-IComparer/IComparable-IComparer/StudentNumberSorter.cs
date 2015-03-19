using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparable_IComparer
{
    public class StudentNumberSorter : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            int returnValue = 0;

            if (x.Number < y.Number)
            {
                returnValue = -1;
            }
            else if (x.Number > y.Number)
            {
                returnValue = 1;
            }
            else
            {
                returnValue = 0;
            }
            return returnValue;
        }
    }
}
