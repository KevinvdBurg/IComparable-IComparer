using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparable_IComparer
{
    public class StudentAddressSorter : IComparer<Student>
    {
        //A custom compare for the Student object.
        //It will be used for the .Sort() Method.
        //This specific method is used to compare the addresses of the students
        public int Compare(Student x, Student y)
        {
            return x.Address.CompareTo(y.Address);
        }
    }
}
