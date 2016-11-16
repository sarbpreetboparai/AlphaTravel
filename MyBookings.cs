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

namespace FinalProject
{
    public partial class MyBookings : Form
    {
        public static string user;
        public MyBookings()
        {
            InitializeComponent();
        }

        private void MyBookings_Load(object sender, EventArgs e)
        {
            loadBookings();
        }

        private void loadBookings()
        {
           listViewBookings.Items.Clear();
           
            List<Booking> myBookings = new List<Booking>();
            using (SqlConnection connection = new SqlConnection("Data Source=SARBPREETBOPARA;Initial Catalog=alphadb;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT plp.plName, pl.city, pl.province, pl.street, plp.postedBy from placePerson plp, place pl WHERE plp.plName = pl.name AND plp.bookedBy =@bookedBy");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
             
                cmd.Parameters.AddWithValue("@bookedBy", user);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
             
                    while (reader.Read())
                    {
                        Booking temp = new Booking();

                        temp.nameOfAd = (string)reader[0];
                        temp.city = (string)reader[1];
                        temp.province = (string)reader[2];
                        temp.street = (string)reader[3];
                        if (reader.IsDBNull(4))
                        {
                            temp.postedBy = "Not Booked";
                        }
                        else
                        {
                            temp.postedBy = (string)reader[4];
                        }

                        myBookings.Add(temp);
                    }
                }
                connection.Close();

                foreach (var bk in myBookings)
                {
                    ListViewItem tempListItem = new ListViewItem(bk.nameOfAd);
                    tempListItem.SubItems.Add(bk.city);
                    tempListItem.SubItems.Add(bk.province);
                    tempListItem.SubItems.Add(bk.street);
                    tempListItem.SubItems.Add(bk.postedBy);
                    listViewBookings.Items.Add(tempListItem);
                }
            }
        
        }
    }
}
