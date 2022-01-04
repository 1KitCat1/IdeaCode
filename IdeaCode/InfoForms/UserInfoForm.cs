using IdeaCode.Properties;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
        string userName;
        string realName;
        string e_mail;
        string password;
        string organisation;
        int solved;
        int rating;
        byte[] photo;

        public UserInfoForm(int idUser, string userName, string realName, string e_mail, 
            string password, string organisation, int solved, int rating, byte[] photo, Form1 MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            if(photo != null && photo.Length != 1)
            {
                MemoryStream ms = new MemoryStream(photo);
                pictureBoxUserPhoto.Image = System.Drawing.Image.FromStream(ms);
            }
            labelUserId.Text = idUser.ToString();
            labelRealName.Text = realName;
            labelUserEmail.Text = e_mail;
            labelUserRating.Text = rating.ToString();
            labelUserSolved.Text = solved.ToString();
            labelUserUsername.Text = userName;

            panelConfirmDelete.Visible = false;
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
                    labelErrorMessages.Text = "Error! Date has NOT been removed from the database. " + ex.Message;
                    labelErrorMessages.ForeColor = AppData.FormColors.colorError;
                }
                conn.Close();
            }
        }

        private void iconButtonEditUser_Click(object sender, EventArgs e)
        {
            MainForm.OpenChildFrom(new EditForms.EditFormUser(idUser, userName, realName, e_mail,
            password, organisation, solved, rating, photo, MainForm));
        }

        private void iconButtonDownload_Click(object sender, EventArgs e)
        {
            string fileName = "UserInfo"+userName+(DateTime.Now.ToString("d")+ DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm")+ DateTime.Now.ToString("ss"));
            
            var document = new iTextSharp.text.Document();
            using (var writer = PdfWriter.GetInstance(document, new FileStream(@"C:\Users\DenCHik\OneDrive\Pictures\"+fileName +".pdf", FileMode.Create)))
            {
                document.Open();

                var font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12);
                var fontBold = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, 1);

                document.NewPage();
                document.Add(new Paragraph("Id user: " + idUser, fontBold));
                document.Add(new Paragraph("Username: " + userName, font));
                document.Add(new Paragraph("Real name: " + realName, font));
                document.Add(new Paragraph("E-mail: " + e_mail, font));
                document.Add(new Paragraph("Organisation: " + organisation, font));
                document.Add(new Paragraph("Solved: " + solved.ToString(), font));
                document.Add(new Paragraph("Rating: " + rating.ToString(), font));
                document.Add(new Paragraph("Photo: ", font));
                if (photo.Length < 2)
                {
                    document.Add(new Paragraph("    NO PHOTO", fontBold));
                }
                else
                {
                    var pic = iTextSharp.text.Image.GetInstance(photo);
                    pic.SetAbsolutePosition(100, 400);
                    writer.DirectContent.AddImage(pic);
                }


                document.Close();
                writer.Close();
                labelDownloadInfo.ForeColor = AppData.FormColors.colorGreen;
                labelDownloadInfo.Text = "File succesfully created: " + @"C:\Users\DenCHik\OneDrive\Pictures\" + fileName + ".pdf";
            }
        }
    }
}
