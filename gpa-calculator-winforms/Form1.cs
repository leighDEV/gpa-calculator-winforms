using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpa_calculator_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstbGrades.Items.Add(tbGrade.Text);
            lblGPA.Text = "GPA: ";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbGrade.ResetText();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstbGrades.Items.Remove(lstbGrades.SelectedItem);
            lblGPA.Text = "GPA: ";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstbGrades.Items.Clear();
            tbGrade.ResetText();
            lblGPA.Text = "GPA: ";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double avg = 0, sum = 0;
            int lstCount = lstbGrades.Items.Count; //Get Count of Listbox Items
            for (int i = 0; i < lstCount; i++)
            {
                sum += Convert.ToDouble(lstbGrades.Items[i]);
            }
            avg = sum / lstCount;
            Double gpa = Math.Round((Double)avg, 2);
            lblGPA.Text = "GPA: " + gpa;
        }

    }
}
