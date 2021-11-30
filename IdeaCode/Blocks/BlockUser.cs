using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaCode.Blocks
{
    public partial class BlockUser : UserControl
    {
        int idUser;
        string userName;
        string realName;
        string e_mail;
        string password;
        string organisation;
        int solved;
        int rating;
        byte[] photo;
        Form1 MainForm;

        public BlockUser()
        {
            InitializeComponent();
        }
        public BlockUser(int idUser, string userName, string realName, string e_mail, string password, string organisation, int solved, int rating, byte[] photo, Form1 MainForm)
        {
            InitializeComponent();
            labelUserNick.Text = userName;
            labelUserRating.Text = rating.ToString();
            labelRealName.Text = realName;
            labelUserOrganisation.Text = organisation;

            this.idUser = idUser;
            this.userName = userName;
            this.realName = realName;
            this.e_mail = e_mail;
            this.password = password;
            this.organisation = organisation;
            this.solved = solved;
            this.rating = rating;

            this.MainForm = MainForm;
        }

        private void labelComplexity_Click(object sender, EventArgs e)
        {

        }

        private void BlockUser_MouseClick(object sender, MouseEventArgs e)
        {
            if(MainForm != null)
            {
                Form infoForm = new InfoForms.UserInfoForm(idUser, userName, realName, e_mail, 
                    password, organisation, solved, rating, photo, MainForm);
                MainForm.OpenChildFrom(infoForm);
            }
        }
    }
}
