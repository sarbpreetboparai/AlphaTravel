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
    public partial class MyAds : Form
    {
        public static string user;
        public MyAds()
        {
            InitializeComponent();
        }



        private void MyAds_Load(object sender, EventArgs e)
        {
         
            //   listViewMyAds.Items.Clear();
            loadAds();
            // TODO: This line of code loads data into the 'vasTest.person' table. You can move, or remove it, as needed.
            //this.personTableAdapter.Fill(this.vasTest.person);
            // TODO: This line of code loads data into the 'vasTest.placePerson' table. You can move, or remove it, as needed.
            //this.placePersonTableAdapter.Fill(this.vasTest.placePerson);
            // TODO: This line of code loads data into the 'vasTest.place' table. You can move, or remove it, as needed.
            //this.placeTableAdapter.Fill(this.vasTest.place);
            // TODO: This line of code loads data into the 'alphadbDataSet.person' table. You can move, or remove it, as needed.
            //this.personTableAdapter.Fill(this.alphadbDataSet.person);
           
        }

        private void IntializeDataGridAddInfo()
        {

        }
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemoveAd_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedPlace = this.listViewMyAds.SelectedItems;
            if (selectedPlace.Count != 0)
            {
                string namePlaceId = selectedPlace[0].Text;

                using (SqlConnection connection = new SqlConnection("Data Source=SARBPREETBOPARA;Initial Catalog=alphadb;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM placePerson WHERE plName=@place");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@place", namePlaceId);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                using (SqlConnection connection = new SqlConnection("Data Source=SARBPREETBOPARA;Initial Catalog=alphadb;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM place WHERE name=@place");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@place", namePlaceId);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                loadAds();
                MessageBox.Show("Deleted!");

            }
        }

        private void loadAds()
        {
            listViewMyAds.Items.Clear();
            List<Ad> myAds = new List<Ad>();
            using (SqlConnection connection = new SqlConnection("Data Source=SARBPREETBOPARA;Initial Catalog=alphadb;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT plp.plName, pl.city, pl.province, pl.street, plp.bookedBy from placePerson plp, place pl WHERE plp.plName = pl.name AND plp.postedBy =@postedBy");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
             
                cmd.Parameters.AddWithValue("@postedBy", user);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
             
                    while (reader.Read())
                    {
                        Ad temp = new Ad();

                        temp.nameOfAd = (string)reader[0];
                        temp.city = (string)reader[1];
                        temp.province = (string)reader[2];
                        temp.street = (string)reader[3];
                        if (reader.IsDBNull(4))
                        {
                            temp.bookedBy = "Not Booked";
                        }
                        else
                        {
                            temp.bookedBy = (string)reader[4];
                        }

                        myAds.Add(temp);
                    }
                }
                connection.Close();

                foreach (var ad in myAds)
                {
                    ListViewItem tempListItem = new ListViewItem(ad.nameOfAd);
                    tempListItem.SubItems.Add(ad.city);
                    tempListItem.SubItems.Add(ad.province);
                    tempListItem.SubItems.Add(ad.street);
                    tempListItem.SubItems.Add(ad.bookedBy);
                    listViewMyAds.Items.Add(tempListItem);
                }
            }
        }
    }
}
