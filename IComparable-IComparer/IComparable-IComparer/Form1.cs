using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            autoNameSort = false;
            autoAddressSort = false;
            autoNumberSort = false;

            FillListbox();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student(tbName.Text, tbAddress.Text, (int)nudNumber.Value);
            students.Add(student);
            
            FillListbox();
        }

        private void FillListbox()
        {
            if (autoNameSort)
            {
                students.Sort();
            }

            if (autoNumberSort)
            {
                students.Sort(new StudentNumberSorter());
            }

            if (autoAddressSort)
            {
                students.Sort(new StudentAddressSorter());
            }

            lbStudents.Items.Clear();
            foreach (Student student in students)
            {
                lbStudents.Items.Add(student.ToString());
            }
        }

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
