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

        /// <summary>
        /// Clicking the Add button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstbGrades.Items.Add(tbGrade.Text);
            lblGPA.Text = "GPA: ";
        }

        /// <summary>
        /// Clicking the Clear button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e) => tbGrade.ResetText();

        /// <summary>
        /// Clicking the Remove button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstbGrades.Items.Remove(lstbGrades.SelectedItem);
            lblGPA.Text = "GPA: ";
        }

        /// <summary>
        /// Clicking the Clear All button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstbGrades.Items.Clear();
            tbGrade.ResetText();
            lblGPA.Text = "GPA: ";
        }

        /// <summary>
        /// Clicking the Calculate button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int grades = lstbGrades.Items.Count; //Get Count of Listbox Items
            for (int i = 0; i < grades; i++)
            {
                sum += Convert.ToDouble(lstbGrades.Items[i]);
            }
            double avg = sum / grades;
            Double gpa = Math.Round((Double)avg, 2);
            lblGPA.Text = "GPA: " + gpa;
        }
    }
}