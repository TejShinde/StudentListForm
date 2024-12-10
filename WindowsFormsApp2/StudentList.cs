using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String stName= txtStudentName.Text.Trim();

            //if(string.IsNullOrEmpty(stName))
            //{
            //    MessageBox.Show("Please enter student name");
            //    return;
            //}

            //if(lstStudents.Items.Contains(stName))
            //{
            //    MessageBox.Show("This Student is already in the list");
            //    return;
            //}

            if(stName== "")
            {
                MessageBox.Show("Please enter student name");
                return;
            }

            bool isDuplicate = false;
            for(int i=0;i<lstStudents.Items.Count;i++)
            {
                if (lstStudents.Items[i].ToString() == stName)
                {
                    isDuplicate = true;
                    break;
                }
            }
            if(isDuplicate)
            {
                MessageBox.Show("This Student is already in the list");
                return;
            }

            lstStudents.Items.Add(stName);
            txtStudentName.Clear(); 
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {

                MessageBox.Show("Please select a student to remove");
                return;
            }
            string SelectedItem = lstStudents.SelectedItem.ToString();
            for (int i = 0; i < lstStudents.Items.Count; i++)
            {
                if (lstStudents.Items[i].ToString() == SelectedItem)
                {
                    lstStudents.Items.RemoveAt(i);
                    break;
                }
                   
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
