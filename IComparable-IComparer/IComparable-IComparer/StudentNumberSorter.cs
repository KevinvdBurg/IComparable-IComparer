using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparable_IComparer
{
    public class StudentNumberSorter : IComparer<Student>
    {
        //A custom compare for the Student object.
        //It will be used for the .Sort() Method.
        //This specific method is used to compare the number of the students
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
