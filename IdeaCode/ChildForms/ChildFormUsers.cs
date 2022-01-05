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
        bool sortAscending = false;
        bool solvedFilterActive = false;
        bool ratingFilterActive = false;
        public ChildFormUsers(Form1 MainForm)
        {
            InitializeComponent();
            DataTable usersFromDB;
            this.MainForm = MainForm;
            using (SqlConnection conn = new SqlConnection(AppData.connectionString))
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
            panelFilter.Visible = false;
            /*panel1.BackColor = AppData.FormColors.backColorPurpleLight;*/
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

        private void iconButtonFilter_Click(object sender, EventArgs e)
        {
            if (panelFilter.Visible)
            {
                panelFilter.Visible = false;
            }
            else
            {
                panelFilter.Visible = true;
            }
        }

        private void iconButtonClear_Click(object sender, EventArgs e)
        {
            if(MainForm != null)
            {
                MainForm.OpenChildFrom(new ChildForms.ChildFormUsers(MainForm));
            }
        }

        private void labelSort_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBoxSortOrder_Click(object sender, EventArgs e)
        {
            if (sortAscending)
            {
                sortAscending = false;
                iconPictureBoxSortOrder.IconChar = FontAwesome.Sharp.IconChar.SortAmountUp;
                iconPictureBoxSortOrder.IconColor = AppData.FormColors.colorOrange;
            }
            else
            {
                sortAscending = true;
                iconPictureBoxSortOrder.IconChar = FontAwesome.Sharp.IconChar.SortAmountDownAlt;
                iconPictureBoxSortOrder.IconColor = AppData.FormColors.colorPurple;
            }
        }

        private void iconButtonApply_Click(object sender, EventArgs e)
        {
            DataTable usersFromDB;
            string query = "SELECT * FROM Users";
            bool whereUsed = false;
            if(textBoxUserName.Text.Length > 0)
            {
                query += " WHERE user_name LIKE '%" + textBoxUserName.Text + "%'";
                whereUsed = true;
            }
            if(textBoxOrganisation.Text.Length > 0)
            {
                if(whereUsed)
                {
                    query += " AND";
                }
                else
                {
                    query += " WHERE";
                    whereUsed = true;
                }
                query += " organisation LIKE '%" + textBoxOrganisation.Text + "%'";
            }
            if (solvedFilterActive)
            {
                if (whereUsed)
                {
                    query += " AND";
                }
                else
                {
                    query += " WHERE";
                    whereUsed = true;
                }
                query += " solved>=" + numericUpDownSolvedFrom.Value.ToString()+ " AND solved<="+numericUpDownSolvedTo.Value.ToString();
            }
            if (ratingFilterActive)
            {
                if (whereUsed)
                {
                    query += " AND";
                }
                else
                {
                    query += " WHERE";
                    whereUsed = true;
                }
                query += " rating>=" + numericUpDownRatingFrom.Value.ToString() + " AND rating<=" + numericUpDownRatingTo.Value.ToString();
            }
            if (comboBoxSortBy.Text.Length > 0)
            {
                query += " ORDER BY " + comboBoxSortBy.Text;
                if (!sortAscending)
                    query += " DESC";
            }
            
            using (SqlConnection conn = new SqlConnection(AppData.connectionString))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                usersFromDB = new DataTable();
                sda.Fill(usersFromDB);
                conn.Close();
            }
            flowLayoutPanelUsers.Controls.Clear();
            if (usersFromDB != null)
            {
                foreach (DataRow dr in usersFromDB.Rows)
                {
                    byte[] photo = new byte[1];
                    if (dr[8] != DBNull.Value)
                    {
                        photo = (byte[])dr[8];
                    }
                    flowLayoutPanelUsers.Controls.Add(new BlockUser((int)dr[0], dr[1].ToString(), dr[2].ToString(),
                        dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), (int)dr[6], (int)dr[7], photo, MainForm));
                }
            }
        }

        private void numericUpDownSolvedFrom_ValueChanged(object sender, EventArgs e)
        {
            solvedFilterActive = true;
        }

        private void numericUpDownSolvedTo_ValueChanged(object sender, EventArgs e)
        {
            solvedFilterActive = true;
        }

        private void numericUpDownRatingFrom_ValueChanged(object sender, EventArgs e)
        {
            ratingFilterActive = true;
        }

        private void numericUpDownRatingTo_ValueChanged(object sender, EventArgs e)
        {
            ratingFilterActive = true;
        }
    }
}
