using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparable_IComparer
{
    public class StudentAddressSorter : IComparer<Student>
    {
    
        public int Compare(Student x, Student y)
        {
            return x.Address.CompareTo(y.Address);
        }
    }
}
