using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace FinalProject
{
    public partial class AlphaTravel : Form
    {
        public static string user;
        
        public AlphaTravel()
        {
           
            InitializeComponent();
            MessageBox.Show(user);
            greet.Text = "Hello " + user;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listPlaces.Items.Clear();
            List<Place> getPlaces = new List<Place>();
            //event when post Add is clicked
            using (SqlConnection connection = new SqlConnection("Data Source=SARBPREETBOPARA;Initial Catalog=alphadb;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("Select pl.name, pl.city, pl.province, pl.price, pl.street from place pl, placePerson plp where upper(city)=upper(@city) AND upper(province)=upper(@province) AND plp.plName = pl.name AND plp.bookedBy IS NULL");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@city", destination.Text);
                cmd.Parameters.AddWithValue("@province", prov.Text);
                //int result = cmd.ExecuteNonQuery();
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
              
                    while(reader.Read()){
                        Place temp = new Place();
                        temp.name = (string)reader[0];
                        temp.city = (string)reader[1];
                        temp.province = (string)reader[2];
                        temp.price = double.Parse((string)reader[3], CultureInfo.InvariantCulture);
                        MessageBox.Show(temp.price + "");
                        int dur = (int)duration.Value;
                        temp.price = temp.price * (int)roomNo.Value * ((int)childNo.Value + (int)adultNo.Value)*dur;
                        temp.street = (string)reader[4];
                        getPlaces.Add(temp);
                    }
                }
                connection.Close();

                foreach (var pl in getPlaces)
                {
                    ListViewItem tempListItem = new ListViewItem(pl.name);
                    tempListItem.SubItems.Add(pl.street);
                    tempListItem.SubItems.Add(pl.city);
                    tempListItem.SubItems.Add(pl.province);
                    tempListItem.SubItems.Add((pl.price.ToString()));
                    listPlaces.Items.Add(tempListItem);
                }


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new PostAd();
           PostAd.activeUser= user;
            form.Show(this);
        }

        private void myAds_Click(object sender, EventArgs e)
        {
            MyAds.user = user;
            var form = new MyAds();
            form.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyBookings.user = user;
            var form = new MyBookings();
            form.Show(this);
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedPlace = this.listPlaces.SelectedItems;
            if (selectedPlace.Count != 0)
            {
                string namePlaceId = selectedPlace[0].Text;

                using (SqlConnection connection = new SqlConnection("Data Source=SARBPREETBOPARA;Initial Catalog=alphadb;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE placePerson SET bookedBy =@booked WHERE plName=@pl");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@booked", user);
                    cmd.Parameters.AddWithValue("@pl", namePlaceId);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Booked!");

            }
        }

        private void destination_Validating(object sender, CancelEventArgs e)
        {
            if (destination.Text == null || destination.Text == "")
            {
                MessageBox.Show("Missing destination!");

            }
            int n;
            bool isNumeric = int.TryParse(destination.Text, out n);
            if (isNumeric)
            {
                MessageBox.Show("Please enter a valid destination!");
            }
        }

        private void prov_Validating(object sender, CancelEventArgs e)
        {
            if (prov.Text == null || prov.Text == "")
            {
                MessageBox.Show("Missing province!");

            }
            int n;
            bool isNumeric = int.TryParse(prov.Text, out n);
            if (isNumeric)
            {
                MessageBox.Show("Please enter a valid province!");
            }
        }

        private void roomNo_Validating(object sender, CancelEventArgs e)
        {
            if (roomNo.Text == null || roomNo.Text == "")
            {
                MessageBox.Show("Missing number of rooms!");

            }

        }

        private void childNo_Validating(object sender, CancelEventArgs e)
        {
            if (childNo.Text == null || childNo.Text == "")
            {
                MessageBox.Show("Missing number of children!");

            }
        }

        private void adultNo_Validating(object sender, CancelEventArgs e)
        {
            if (adultNo.Text == null || adultNo.Text == "")
            {
                MessageBox.Show("Missing number of adults!");

            }
        }

        private void destination_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
