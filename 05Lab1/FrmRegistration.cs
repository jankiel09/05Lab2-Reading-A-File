using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _05Lab1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String RelativePath = @"..\..\Paguiligan_Kiel.LabStream";
            string docPath = Path.GetFullPath(RelativePath);


            string studentNumber = txtStudentNumber.Text.Trim();
            string studentLastName = txtLastName.Text.Trim();
            string studentFirstName = txtFirstName.Text.Trim();
            string studentMI = txtMI.Text.Trim();
            string program = cbProgram.Text.Trim();
            string gender = cbGender.Text.Trim();
            string age = txtAge.Text.Trim();
            string birthday = dtpBirthday.Text.Trim();
            string contact = txtContact.Text.Trim();


            string[] studentInfo = {
                $"Student Number: {studentNumber}",
                $"Name: {studentLastName}, {studentFirstName} {studentMI}",
                $"Program: {program}",
                $"Gender: {gender}",
                $"Age: {age}",
                $"Birthday: {birthday}",
                $"Contact Number: {contact}"
            };

            string fileName = studentNumber + ".txt";
            string filePath = Path.Combine(docPath, fileName);


            File.WriteAllLines(filePath, studentInfo, Encoding.UTF8);

            MessageBox.Show($"Student information saved to:\n{filePath}", "Success");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudentRecord registrationForm = new FrmStudentRecord();
            registrationForm.Show();
        }
    }
}
