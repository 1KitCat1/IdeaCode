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

            // 3rd gift
            List<int> idUsersNotPicked = new List<int>();
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_user FROM Users WHERE user_name!='" +
                    userName1 + "' AND user_name!='" + userName2+"'", conn);
                var dt = new DataTable();
                sda.Fill(dt);
                
                try
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        idUsersNotPicked.Add((int)dr[0]);
                    }
                }
                catch
                {
                    //error
                }
                conn.Close();
            }
            Random rnd = new Random();
            int choosedInd = rnd.Next(0, idUsersNotPicked.Count-1);
            int idUser3 = idUsersNotPicked[choosedInd];

            string userName3 = "";
            byte[] photo3 = new byte[1];
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT user_name, photo FROM Users WHERE id_user=" + idUser3.ToString(), conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                try
                {
                    userName3 = dr[0].ToString();
                    photo3 = (byte[])dr[1];
                }
                catch
                {
                    //error
                }
                conn.Close();
            }
            if (photo3.Length > 2)
            {
                MemoryStream ms = new MemoryStream(photo3);
                pictureBoxGetGift3.Image = System.Drawing.Image.FromStream(ms);
            }
            labelGetGift3.Text = userName3;
        }

        private void SendGiftsForm_Load(object sender, EventArgs e)
        {

        }

        private void labelGift1_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonNotify_Click(object sender, EventArgs e)
        {
            labelMessages.Text = "Notification has been send to winners!";
            labelMessages.ForeColor = AppData.FormColors.colorGreen;
        }

        private void iconButtonEditUser_Click(object sender, EventArgs e)
        {
            labelMessages.Text = "Notification has been send to the winners!";
            labelMessages.ForeColor = AppData.FormColors.colorGreen;
        }
    }
}
