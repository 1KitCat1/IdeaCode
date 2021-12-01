using IdeaCode.Properties;
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

namespace IdeaCode.InfoForms
{
    public partial class UserInfoForm : Form
    {
        Form1 MainForm;
        int idUser;
        public UserInfoForm(int idUser, string userName, string realName, string e_mail, 
            string password, string organisation, int solved, int rating, byte[] photo, Form1 MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            if(photo != null && photo.Length != 1)
            {
                MemoryStream ms = new MemoryStream(photo);
                pictureBoxUserPhoto.Image = Image.FromStream(ms);
            }
            labelUserId.Text = idUser.ToString();
            labelRealName.Text = realName;
            labelUserEmail.Text = e_mail;
            labelUserRating.Text = rating.ToString();
            labelUserSolved.Text = solved.ToString();
            labelUserUsername.Text = userName;

            panelConfirmDelete.Visible = false;
            this.idUser = idUser;
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(MainForm != null)
            {
                MainForm.OpenChildFrom(new ChildForms.ChildFormUsers(MainForm));
            }
        }

        private void iconButtonDeleteUser_Click(object sender, EventArgs e)
        {
            panelConfirmDelete.Visible = true;

        }

        private void iconButtonCancelDelete_Click(object sender, EventArgs e)
        {
            panelConfirmDelete.Visible = false;
        }

        private void iconButtonConfirmDelete_Click(object sender, EventArgs e)
        {
            string requestString = "DELETE FROM Users WHERE id_user=@delIdUser; ";

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {

                SqlCommand command = new SqlCommand(requestString, conn);
                command.Parameters.AddWithValue("@delIdUser", idUser);
                try
                {
                    conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MainForm.OpenChildFrom(new ChildForms.ChildFormUsers(MainForm));

                }
                catch (Exception ex)
                {
                    labelErrorMessages.Text = "Error! Date has NOT been added to the database. " + ex.Message;
                    labelErrorMessages.ForeColor = AppData.FormColors.colorError;
                }
                conn.Close();
            }
        }
    }
}
