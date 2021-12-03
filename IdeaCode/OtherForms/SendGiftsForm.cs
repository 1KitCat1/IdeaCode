using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaCode.OtherForms
{
    public partial class SendGiftsForm : Form
    {
        public SendGiftsForm()
        {
            InitializeComponent();
            string userName1 = "";
            byte[] photo1 = new byte[1];
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT user_name, photo FROM Users WHERE rating=(SELECT MAX(rating) FROM USERS)", conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                try
                {
                    userName1 = dr[0].ToString();
                    photo1 = (byte[])dr[1];
                }
                catch
                {
                    //error
                }
                conn.Close();
            }
            if(photo1.Length > 2)
            {
                MemoryStream ms = new MemoryStream(photo1);
                pictureBoxGetGift1.Image = System.Drawing.Image.FromStream(ms);
            }
            labelUserUsername.Text = userName1;

            string userName2 = "";
            byte[] photo2 = new byte[1];
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT user_name, photo FROM Users WHERE solved=(SELECT MAX(solved) FROM USERS)", conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                try
                {
                    userName2 = dr[0].ToString();
                    photo2 = (byte[])dr[1];
                }
                catch
                {
                    //error
                }
                conn.Close();
            }
            if (photo1.Length > 2)
            {
                MemoryStream ms = new MemoryStream(photo1);
                pictureBoxGetGift2.Image = System.Drawing.Image.FromStream(ms);
            }
            labelGetGift2.Text = userName2;

        }

        private void SendGiftsForm_Load(object sender, EventArgs e)
        {

        }

        private void labelGift1_Click(object sender, EventArgs e)
        {

        }
    }
}
