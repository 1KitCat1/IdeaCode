using IdeaCode.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public UserInfoForm(int idUser, string userName, string realName, string e_mail, 
            string password, string organisation, int solved, int rating, byte[] photo, Form1 MainForm)
        {
            this.MainForm = MainForm;
            if(photo != null && photo.Length != 1)
            {
                MemoryStream ms = new MemoryStream(photo);
                pictureBoxUserPhoto.Image = Image.FromStream(ms);
            }
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(MainForm != null)
            {
                MainForm.OpenChildFrom(new ChildForms.ChildFormUsers(MainForm));
            }
        }
    }
}
