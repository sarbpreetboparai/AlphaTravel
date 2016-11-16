using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SignUp : Form
    {
        static List<Person> persons = new List<Person>();

        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p1 = new Person();
            p1.firstName = fName.Text;
            p1.lastName = lName.Text;
            p1.emailId = email.Text;
            p1.pwd = pwd.Text;

            persons.Add(p1);

            using (SqlConnection connection = new SqlConnection("Data Source=SARBPREETBOPARA;Initial Catalog=alphadb;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("Select emailId from person where emailId=@email");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@email", email.Text);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Email already used. Please select another email address");
                    }
                    else
                    {
                        using (SqlConnection connection2 = new SqlConnection("Data Source=SARBPREETBOPARA;Initial Catalog=alphadb;Integrated Security=True"))
                        {
                            SqlCommand cmd2 = new SqlCommand("INSERT INTO person (firstName, lastName, emailId,pwd) VALUES (@fn, @ln, @em,@am)");
                            cmd2.CommandType = CommandType.Text;
                            cmd2.Connection = connection2;
                            cmd2.Parameters.AddWithValue("@fn", fName.Text);
                            cmd2.Parameters.AddWithValue("@ln", lName.Text);
                            cmd2.Parameters.AddWithValue("@em", email.Text);
                            cmd2.Parameters.AddWithValue("@am", pwd.Text);
                            connection2.Open();
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Sign Up successful!");
                        }            
                    }
                }
                connection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=SARBPREETBOPARA;Initial Catalog=alphadb;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("Select emailId from person where emailId=@email AND pwd=@pswrd");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@email", siEmail.Text);
                cmd.Parameters.AddWithValue("@pswrd", siPwd.Text);
                
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        AlphaTravel.user = siEmail.Text;
                        var form = new AlphaTravel();
                       
                        form.Show(this);
                    }
                    else
                    {
                        MessageBox.Show("Invalid details! Please sign up if visiting first time!");
                    }
                }
                connection.Close();
            }
        }

        private void fName_TextChanged(object sender, EventArgs e)
        {

        }

        private void fName_Validating(object sender, CancelEventArgs e)
        {
            if (fName.Text == null || fName.Text=="")
            {
                MessageBox.Show("Please enter a first name!");
            }
        }

        private void lName_Validating(object sender, CancelEventArgs e)
        {
            if (lName.Text == null || lName.Text == "")
            {
                MessageBox.Show("Please enter a last name!");
            }
        }

        private void email_Validating(object sender, CancelEventArgs e)
        {
            if (email.Text == null || email.Text == "")
            {
                MessageBox.Show("Please enter an email!");
            }
            int n;
            bool isNumeric = int.TryParse(email.Text, out n);
            if (isNumeric)
            {
                MessageBox.Show("Please enter a valid email address!");
            }
        }

        private void cpwd_Validating(object sender, CancelEventArgs e)
        {
            if (!cpwd.Text.Equals(pwd.Text))
            {
                MessageBox.Show("Passwords entered don't match!");
            }
        }

        private void siEmail_Validating(object sender, CancelEventArgs e)
        {
            if (siEmail.Text == null || siEmail.Text == "")
            {
                MessageBox.Show("Please enter an email to login.");
            }
        }

        private void siPwd_Validating(object sender, CancelEventArgs e)
        {
            if (siPwd.Text == null || siPwd.Text == "")
            {
                MessageBox.Show("No password entered to login!");
            }
        }
    }
}
