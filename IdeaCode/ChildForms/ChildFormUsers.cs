using IdeaCode.Blocks;
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

namespace IdeaCode.ChildForms
{
    public partial class ChildFormUsers : Form
    {
        Form1 MainForm;
        public ChildFormUsers(Form1 MainForm)
        {
            InitializeComponent();
            DataTable usersFromDB;
            this.MainForm = MainForm;
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Users", conn);
                usersFromDB = new DataTable();
                sda.Fill(usersFromDB);
                conn.Close();
            }
            if(usersFromDB != null)
            {
                foreach(DataRow dr in usersFromDB.Rows)
                {
                    byte[] photo = new byte[1];
                    if(dr[8] != DBNull.Value)
                    {
                        photo = (byte[])dr[8];
                    }
                    flowLayoutPanelUsers.Controls.Add(new BlockUser((int)dr[0], dr[1].ToString(), dr[2].ToString(),
                        dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), (int)dr[6], (int)dr[7], photo, MainForm));
                }
            }
            /*flowLayoutPanelUsers.Controls.Add(new BlockUser());
            flowLayoutPanelUsers.Controls.Add(new BlockUser("Ensiforum", 1215, "Kiril Timchenko", "KhNURE"));*/
        }

        private void flowLayoutPanelUsers_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void iconButtonAddUser_Click(object sender, EventArgs e)
        {
            Form AddUserForm = new AddForms.AddUserForm(MainForm);
            MainForm.OpenChildFrom(AddUserForm);
        }
    }
}
