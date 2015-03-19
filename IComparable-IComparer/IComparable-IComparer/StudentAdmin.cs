using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IComparable_IComparer
{
    public partial class formStudents : Form
    {
        private List<Student> students;
        private bool autoNameSort;
        private bool autoNumberSort;
        private bool autoAddressSort;
        public formStudents()
        {
            InitializeComponent();

            students = new List<Student>();
            autoNameSort = true;
            autoAddressSort = false;
            autoNumberSort = false;

            //Default Students
            Student student1 = new Student("Jan", "JansenStraat 43", 32);
            Student student2 = new Student("Ivan", "BierHof 21", 39);
            Student student3 = new Student("Milton", "Ergens", 69);
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            
            //Refresh listbox
            FillListbox();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            //Check if the Number is already used by using lambas
            string name = tbName.Text;
            Student studentNumber = students.Find(Student => Student.Number == Convert.ToInt32(nudNumber.Value));
            if (studentNumber != null)
            {
                MessageBox.Show("Number is already used");
                return;
            }

            //Creates a regex that trims all the whitespaces and then checks if the string is not empty.
            if (String.IsNullOrEmpty(Regex.Replace(name, @"\s+", "")))
            {
                MessageBox.Show("Please fill in a name");
                return;
            }

            Student student = new Student(tbName.Text, tbAddress.Text, (int)nudNumber.Value);
            students.Add(student);

            FillListbox();
        }

        private void FillListbox()
        {
            //Default Sort of Student using the ICompareble
            if (autoNameSort)
            {
                students.Sort();
            }
            //Custom Number sorter for a Student object
            if (autoNumberSort)
            {
                students.Sort(new StudentNumberSorter());
            }

            //Custom Address sorter for a Student object
            if (autoAddressSort)
            {
                students.Sort(new StudentAddressSorter());
            }

            //Adds the students to the listbox
            lbStudents.Items.Clear();
            foreach (Student student in students)
            {
                lbStudents.Items.Add(student.ToString());
            }
        }

        /// <summary>
        /// Switch the sort method to use the Name of the Student. Than it will call the FillListbox() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbName_CheckedChanged(object sender, EventArgs e)
        {

            if (autoNameSort)
            {
                autoNameSort = false;
            }
            else
            {
                autoNameSort = true;
            }

            FillListbox();
        }
        /// <summary>
        /// Switch the sort method to use the Address of the Student. Than it will call the FillListbox() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (autoAddressSort)
            {
                autoAddressSort = false;
            }
            else
            {
                autoAddressSort = true;
            }

            FillListbox();
        }
        /// <summary>
        /// Switch the sort method to use the Number of the Student. Than it will call the FillListbox() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (autoNumberSort)
            {
                autoNumberSort = false;
            }
            else
            {
                autoNumberSort = true;
            }

            FillListbox();
        }
    }
}
