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
    public partial class PostAd : Form
    {
       public static string activeUser;
      List<Place> places = new List<Place>();
        public PostAd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Place p1 = new Place();
            p1.name = plName.Text;
            p1.city = city.Text;
            p1.price = double.Parse(price.Text);
            p1.province = province.Text;
            
            places.Add(p1);

            foreach (Place p in places)
            {
                MessageBox.Show(p1.name);
            }

            using (SqlConnection connection = new SqlConnection("Data Source=SARBPREETBOPARA;Initial Catalog=alphadb;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("Select name from place where name=@name");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@name", plName.Text);

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Location Already Exists!");
                    }
                    else
                    {
                        using (SqlConnection connection2 = new SqlConnection("Data Source=SARBPREETBOPARA;Initial Catalog=alphadb;Integrated Security=True"))
                        {
                            SqlCommand cmd2 = new SqlCommand("INSERT INTO place (name,city,province,price,street) VALUES (@nm,@cty,@prv,@prc,@str)");
                            cmd2.CommandType = CommandType.Text;
                            cmd2.Connection = connection2;
                            cmd2.Parameters.AddWithValue("@nm", plName.Text);
                            cmd2.Parameters.AddWithValue("@cty", city.Text);
                            cmd2.Parameters.AddWithValue("@prv", province.Text);
                            cmd2.Parameters.AddWithValue("@prc", price.Text);
                            cmd2.Parameters.AddWithValue("@str", street.Text);
                            connection2.Open();
                            cmd2.ExecuteNonQuery();
                        }

                        using (SqlConnection connection2 = new SqlConnection("Data Source=SARBPREETBOPARA;Initial Catalog=alphadb;Integrated Security=True"))
                        {
                            SqlCommand cmd2 = new SqlCommand("INSERT INTO placePerson (plName,postedBy) VALUES (@pn,@pb)");
                            cmd2.CommandType = CommandType.Text;
                            cmd2.Connection = connection2;
                            cmd2.Parameters.AddWithValue("@pn", plName.Text);
                            cmd2.Parameters.AddWithValue("@pb", activeUser);

                            connection2.Open();
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
                connection.Close();
            }
        }

        private void plName_Validating(object sender, CancelEventArgs e)
        {
            if (plName.Text == null || plName.Text == "")
            {
                MessageBox.Show("Missing destination!");

            }
            int n;
            bool isNumeric = int.TryParse(plName.Text, out n);
            if (isNumeric)
            {
                MessageBox.Show("Please enter a valid destination!");
            }
        }

        private void street_Validating(object sender, CancelEventArgs e)
        {
            if (street.Text == null || street.Text == "")
            {
                MessageBox.Show("Missing street name!");

            }
            int n;
            bool isNumeric = int.TryParse(street.Text, out n);
            if (isNumeric)
            {
                MessageBox.Show("Please enter a valid street name!");
            }
        }

        private void city_Validating(object sender, CancelEventArgs e)
        {
            if (city.Text == null || city.Text == "")
            {
                MessageBox.Show("Missing city name!");

            }
            int n;
            bool isNumeric = int.TryParse(city.Text, out n);
            if (isNumeric)
            {
                MessageBox.Show("Please enter a valid city name!");
            }
        }

        private void province_Validating(object sender, CancelEventArgs e)
        {
            if (province.Text == null || province.Text == "")
            {
                MessageBox.Show("Missing province name!");

            }
            int n;
            bool isNumeric = int.TryParse(province.Text, out n);
            if (isNumeric)
            {
                MessageBox.Show("Please enter a valid city name!");
            }
        }

        private void PostAd_Load(object sender, EventArgs e)
        {

        }

        private void price_Validating(object sender, CancelEventArgs e)
        {
            if (price.Text == null || price.Text == "")
            {
                MessageBox.Show("Missing city name!");

            }
            double n;
            bool isNumeric = double.TryParse(price.Text, out n);
            if (!isNumeric)
            {
                MessageBox.Show("Please enter a valid price!");
            }
        }
    }
}
