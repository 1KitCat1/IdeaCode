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
        public ChildFormUsers(Form MainForm)
        {
            InitializeComponent();
            DataTable usersFromDB;
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
                    flowLayoutPanelUsers.Controls.Add(new BlockUser(dr[1].ToString(), Convert.ToInt32(dr["rating"]), dr["real_name"].ToString(), dr["organisation"].ToString()));
                }
            }
            /*flowLayoutPanelUsers.Controls.Add(new BlockUser());
            flowLayoutPanelUsers.Controls.Add(new BlockUser("Ensiforum", 1215, "Kiril Timchenko", "KhNURE"));*/
        }

        private void flowLayoutPanelUsers_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
