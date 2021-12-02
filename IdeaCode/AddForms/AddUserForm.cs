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

namespace IdeaCode.AddForms
{
    public partial class AddUserForm : Form
    {
        Form1 MainForm;
        byte[] images = new byte[1];
        int currentMaxId = 0;
        public AddUserForm(Form1 MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT max(id_user) FROM Users", conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                try
                {
                    currentMaxId = (int)dr[0];
                }
                catch
                {
                    currentMaxId = 0;
                }

                conn.Close();
            }
            numericUpDownUserId.Value = currentMaxId + 1;
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
                images = brs.ReadBytes((int)stream.Length);
                MemoryStream ms = new MemoryStream(images);
                pictureBoxUserPhoto.Image = Image.FromStream(ms);
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           if(MainForm != null) 
                MainForm.OpenChildFrom(new ChildForms.ChildFormUsers(MainForm));
        }

        private void iconButtonAccept_Click(object sender, EventArgs e)
        {
            int idUser = (int)numericUpDownUserId.Value;
            string userName = textBoxUserName.Text;
            string realName = textBoxUserRealName.Text;
            string eMail = textBoxUserEmail.Text;
            string password = textBoxPassword.Text;
            string organisation = textBoxUserOrganisation.Text;
            int solved = (int)numericUpDownUserSolved.Value;
            int rating = (int)numericUpDownUserRating.Value;

            string tableName = "Users";
            string requestString = "INSERT INTO Users VALUES (@idUser, @userName, @realName, @email, @pas, @org, @solved, @rating, @photo)";
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                
                SqlCommand command = new SqlCommand(requestString, conn);
                command.Parameters.AddWithValue("@tableName", tableName);
                command.Parameters.AddWithValue("@idUser", idUser);
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@realName", realName);
                command.Parameters.AddWithValue("@email", eMail);
                command.Parameters.AddWithValue("@pas", password);
                command.Parameters.AddWithValue("@org", organisation);
                command.Parameters.AddWithValue("@solved", solved);
                command.Parameters.AddWithValue("@rating", rating);
                command.Parameters.AddWithValue("@photo", images);
                try
                {
                    conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    labelBlogDatabaseMessages.Text = "Data has been succesfully added to database. Rows affected: " + rowsAffected.ToString();
                    labelBlogDatabaseMessages.ForeColor = AppData.FormColors.colorGreen;

                }
                catch (Exception ex)
                {
                    labelBlogDatabaseMessages.Text = "Error! Date has NOT been added to the database. " + ex.Message;
                    labelBlogDatabaseMessages.ForeColor = AppData.FormColors.colorError;
                }
                conn.Close();
            }

        }
    }
}
