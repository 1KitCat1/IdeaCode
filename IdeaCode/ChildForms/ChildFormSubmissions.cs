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
    public partial class ChildFormSubmissions : Form
    {
        Form1 MainForm;
        public ChildFormSubmissions(Form1 MainForm)
        {
            InitializeComponent();
            DataTable submissionsFromDB;
            this.MainForm = MainForm;
            using (SqlConnection conn = new SqlConnection(AppData.connectionString))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Submissions", conn);
                submissionsFromDB = new DataTable();
                sda.Fill(submissionsFromDB);
                conn.Close();
            }
            try
            {
                foreach (DataRow dr in submissionsFromDB.Rows)
                {
                    int idSubmission = (int)dr[0];
                    int idTask = (int) dr[1];
                    int idUser = (int)dr[2];
                    
                    int idCompiler = (int)dr[3];
                    string code = dr[4].ToString();
                    int idVerdict = (int)dr[5];
                    int usedTime = (int)dr[6];
                    int usedSpace = (int)dr[7];
                    DateTime timeOfSubmission = Convert.ToDateTime(dr[8]);
                    string taskName, userName, verdictName;
                    // get taskName
                    using (SqlConnection conn = new SqlConnection(AppData.connectionString))
                    {
                        conn.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT title FROM Tasks WHERE id_task=" + idTask.ToString(), conn);
                        var dt = new DataTable();
                        sda.Fill(dt);
                        DataRow drL = dt.Rows[0];
                        try
                        {
                            taskName = dr[0].ToString();
                        }
                        catch
                        {
                            taskName = "Find min";
                        }
                        conn.Close();
                    }
                    // get userName

                    using (SqlConnection conn = new SqlConnection(AppData.connectionString))
                    {
                        conn.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT user_name FROM Users WHERE id_user=" + idUser.ToString(), conn);
                        var dt = new DataTable();
                        sda.Fill(dt);
                        DataRow drL = dt.Rows[0];
                        try
                        {
                            userName = dr[0].ToString();
                        }
                        catch
                        {
                            userName = "_KitCat_";
                        }
                        conn.Close();
                    }

                    // get verdictName
                    using (SqlConnection conn = new SqlConnection(AppData.connectionString))
                    {
                        conn.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT text_verdict FROM Verdicts WHERE id_verdict=" + idVerdict.ToString(), conn);
                        var dt = new DataTable();
                        sda.Fill(dt);
                        DataRow drL = dt.Rows[0];
                        try
                        {
                            verdictName = dr[0].ToString();
                        }
                        catch
                        {
                            verdictName = "Find min";
                        }
                        conn.Close();
                    }

                
                flowLayoutPanelSubmissions.Controls.Add(new Blocks.BlockSubmission(idSubmission, 
                    idTask, idUser, timeOfSubmission, idCompiler, code, idVerdict, usedTime, 
                    usedSpace, MainForm));
                }
            }
            catch
            {

            }
        }

        private void iconButtonAddSubmission_Click(object sender, EventArgs e)
        {
            MainForm.OpenChildFrom(new AddForms.AddSubmissionForm(MainForm));
        }
    }
}
