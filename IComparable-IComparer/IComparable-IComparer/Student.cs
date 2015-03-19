using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparable_IComparer
{
    public class Student : IComparable<Student>
    {
        public Student(string name, string address, int number)
        {
            Name = name;
            Address = address;
            Number = number;
        }
    
        public string Name {get; set; }

        public string Address { get; set; }

        public int Number { get; set; }

        public int CompareTo(Student other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public string ToString()
        {
            return "Name: " + Name + ", Address: " + Address + ", Number: " + Number + "";
        }
    }
}
