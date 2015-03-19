using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparable_IComparer
{
    public class Student : IComparable<Student>
    {
        //Constructor
        public Student(string name, string address, int number)
        {
            Name = name;
            Address = address;
            Number = number;
        }
    
        //Properties
        public string Name {get; set; }

        public string Address { get; set; }

        public int Number { get; set; }

        //Default Compare method used by the .Sort() method for a list of the type Student.
        public int CompareTo(Student other)
        {
            return this.Name.CompareTo(other.Name);
        }

        //The ToString() method will return all the properies of the class Student in a string
        public string ToString()
        {
            return "Name: " + Name + ", Address: " + Address + ", Number: " + Number + "";
        }
    }
}
