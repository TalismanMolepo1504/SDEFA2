using System;
using System.Windows.Forms;
using ULMSWinFormsApp.Models;

namespace ULMSWinFormsApp.Forms
{
    public partial class FrmMarksCapture : Form
    {
        public FrmMarksCapture()
        {
            InitializeComponent();
        }

        private void btnCalculateResults_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSubject1.Text, out double subject1) ||
                !double.TryParse(txtSubject2.Text, out double subject2) ||
                !double.TryParse(txtSubject3.Text, out double subject3))
            {
                MessageBox.Show("Enter the valid numeric values");
                return;
            }

            MarkRecord record = new MarkRecord()
            {
                StudentId = txtMarkStudentId.Text,
                StudentName = txtMarkStudentName.Text,
                Subject1 = subject1,
                Subject2 = subject2,
                Subject3 = subject3
            };

            record.Average = (record.Subject1 + record.Subject2 + record.Subject3) / 3.0;

            txtMarksOutput.Text =
                "Marks captured successfully!" + Environment.NewLine +
                $"Student ID: {record.StudentId}" + Environment.NewLine +
                $"Student Name: {record.StudentName}" + Environment.NewLine +
                $"Subject 1: {record.Subject1}" + Environment.NewLine +
                $"Subject 2: {record.Subject2}" + Environment.NewLine +
                $"Subject 3: {record.Subject3}" + Environment.NewLine +
                $"Average Marks: {record.Average:F2}";
        }

        private void btnClearMarks_Click(object sender, EventArgs e)
        {
            txtMarkStudentId.Clear();
            txtMarkStudentName.Clear();
            txtSubject1.Clear();
            txtSubject2.Clear();
            txtSubject3.Clear();
            txtMarksOutput.Clear();
            txtMarkStudentId.Focus();
        }

        private void btnBackMarks_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
