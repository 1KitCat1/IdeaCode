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

namespace IdeaCode.EditForms
{
    public partial class EditFormUser : Form
    {
        Form1 MainForm;
        int idUser;
        string userName;
        string realName;
        string e_mail;
        string password;
        string organisation;
        int solved;
        int rating;
        byte[] photo;
        public EditFormUser()
        {
            InitializeComponent();
        }
        public EditFormUser(int idUser, string userName, string realName, string e_mail,
            string password, string organisation, int solved, int rating, byte[] photo, Form1 MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            if (photo != null && photo.Length != 1)
            {
                MemoryStream ms = new MemoryStream(photo);
                pictureBoxUserPhoto.Image = Image.FromStream(ms);
            }
            labelUserId.Text = idUser.ToString();
            textBoxUserRealName.Text = realName;
            textBoxUserEmail.Text = e_mail;
            numericUpDownUserRating.Value = rating;
            numericUpDownUserSolved.Value = solved;
            textBoxUserName.Text = userName;
            textBoxPassword.Text = password;

            this.idUser = idUser;
            this.userName = userName;
            this.realName = realName;
            this.e_mail = e_mail;
            this.password = password;
            this.organisation = organisation;
            this.solved = solved;
            this.rating = rating;
            this.photo = photo;
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            MainForm.OpenChildFrom(new InfoForms.UserInfoForm(idUser, userName, realName, e_mail,
            password, organisation, solved, rating, photo, MainForm));
        }

        private void iconButtonAccept_Click(object sender, EventArgs e)
        {

            string requestString = "UPDATE Users SET user_name=@userName, real_name=@realName, e_mail=@email, password=@pas, " +
                "organisation=@org, solved=@solved, rating=@rating, photo=@photo WHERE id_user=@idUser";
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                userName = textBoxUserName.Text;
                realName = textBoxUserRealName.Text;
                e_mail = textBoxUserEmail.Text;
                password = textBoxPassword.Text;
                organisation = textBoxUserOrganisation.Text;
                solved = (int)numericUpDownUserSolved.Value;
                rating = (int)numericUpDownUserRating.Value;


                SqlCommand command = new SqlCommand(requestString, conn);
                command.Parameters.AddWithValue("@idUser", idUser);
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@realName", realName);
                command.Parameters.AddWithValue("@email", e_mail);
                command.Parameters.AddWithValue("@pas", password);
                command.Parameters.AddWithValue("@org", organisation);
                command.Parameters.AddWithValue("@solved", solved);
                command.Parameters.AddWithValue("@rating", rating);
                command.Parameters.AddWithValue("@photo", photo);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    MainForm.OpenChildFrom(new InfoForms.UserInfoForm(idUser, userName, realName, e_mail,
                    password, organisation, solved, rating, photo, MainForm));

                }
                catch (Exception ex)
                {
                    labelBlogDatabaseMessages.Text = "Error! Date has NOT been added to the database. " + ex.Message;
                    labelBlogDatabaseMessages.ForeColor = AppData.FormColors.colorError;
                }
            }
        }

        private void iconButtonUpload_Click(object sender, EventArgs e)
        {
            string photoPath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    photoPath = openFileDialog.FileName;
                }
            }

            if (photoPath.Length != 0)
            {
                FileStream stream = new FileStream(photoPath, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                photo = brs.ReadBytes((int)stream.Length);
                MemoryStream ms = new MemoryStream(photo);
                pictureBoxUserPhoto.Image = Image.FromStream(ms);
            }
        }
    }
}
