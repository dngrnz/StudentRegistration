using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplicationRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {

                comboBox1.Items.Add(i);
            }
            ArrayList months_of_the_year = new ArrayList();
            months_of_the_year.Add("January");
            months_of_the_year.Add("February");
            months_of_the_year.Add("March");
            months_of_the_year.Add("April");
            months_of_the_year.Add("May");
            months_of_the_year.Add("June");
            months_of_the_year.Add("July");
            months_of_the_year.Add("August");
            months_of_the_year.Add("September");
            months_of_the_year.Add("October");
            months_of_the_year.Add("November");
            months_of_the_year.Add("December");
            
            for (int i = 0; i < 12; i++)
            {
                comboBox2.Items.Add(months_of_the_year[i]);
            }
             int currentYear = DateTime.Now.Year;
             for (int i = 1900; i <= currentYear; i++)
            {
                comboBox3.Items.Add(i);
            }
            ArrayList BS_Programs = new ArrayList();
            BS_Programs.Add("Bachelor of Science in Computer Science");
            BS_Programs.Add("Bachelor of Science in Information Technology");
            BS_Programs.Add("Bachelor of Science in Information Systems");
            BS_Programs.Add("Bachelor of Science in Computer Engineering");
            foreach (String programs in BS_Programs)
            {
                comboBox4.Items.Add(programs);
            }
            
            }
            private void button1_Click_1(object sender, EventArgs e)
                    {
                    string gender = "no gender";
                        string LastName = textBox1.Text;
                        string FirstName = textBox2.Text;
                        string MiddleName = textBox3.Text;
                        string Name = "LastName + FirstName + MiddleName";
                    string birth = " Date of Birth: " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text;
                    string program = comboBox4.Text;
                        if (radioButton1.Checked == true)
                        {
                            gender = "Male";
                        }
                        else
                        {
                            gender = "Female";
                        }
                  string message = "Student Name: " + LastName + "," + FirstName + " " + MiddleName + "\n Gender: " + gender +
                    "\n Date of Birth: " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text + "\n Program: " + comboBox4.Text;
            if (LastName != null && FirstName != null && MiddleName != null && birth != null && program != null && gender != "no gender")
            {
                information(Name, gender, birth, program);
            }
            else if (Name != null && program != null && birth == null && gender == "no gender")
            {
                information(Name, program);
            }
            else if (LastName != null && FirstName != null && MiddleName == null && program != null && birth == null && gender == "no gender" ) {
                information(FirstName, LastName, program);
            }

                    }
        public void information (string Name, string birth, string gender, string program)
        {

            string gender1;
            string LastName = textBox1.Text;
            string FirstName = textBox2.Text;
            string MiddleName = textBox3.Text;
            string program1 = comboBox4.Text;
            string Name1 = "LastName + FirstName + MiddleName";
            string message = "Student Name: " + LastName + "," + FirstName + " " + MiddleName + "\n Gender: " + gender +
                "\n Date of Birth: " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text + "\n Program: " + comboBox4.Text;
            MessageBox.Show(message);
        }
        public void information(string Name, string Program) {
            string gender;
            string LastName = textBox1.Text;
            string FirstName = textBox2.Text;
            string MiddleName = textBox3.Text;
            string program1 = comboBox4.Text;
            string Name1 = "LastName + FirstName + MiddleName";
            string message = "Student Name: " +  Name1 +  "\n Program: " + comboBox4.Text;
            MessageBox.Show(message);
        }
        public void information(string FirstName, string LastName, string program) {
            string LastName1 = textBox1.Text;
            string FirstName1 = textBox2.Text;
            string program1 = comboBox4.Text;
            string Name = FirstName1 + " " + LastName1;
            string message = Name + "\n" + program1;
            MessageBox.Show(message);
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Bitmap.FromFile(file.FileName);
            }
        }

        
    }
    }
    


        


