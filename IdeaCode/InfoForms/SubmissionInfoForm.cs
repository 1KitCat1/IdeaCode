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

namespace IdeaCode.InfoForms
{
    public partial class SubmissionInfoForm : Form
    {
        int idSubmission;
        int idTask;
        int idUser;
        DateTime timeOfSubmission;
        int idCompiler;
        string code;
        int idVerdict;
        int usedTime;
        int usedSpace;
        Form1 MainForm;
        public SubmissionInfoForm(int idSubmission, int idTask, int idUser, DateTime timeOfSubmission,
            int idCompiler, string code, int idVerdict, int usedTime, int usedSpace, Form1 MainForm)
        {
            InitializeComponent();
            this.idSubmission = idSubmission;
            this.idTask = idTask;
            this.idUser = idUser;
            this.timeOfSubmission = timeOfSubmission;
            this.idCompiler = idCompiler;
            this.idVerdict = idVerdict;
            this.code = code;
            this.usedTime = usedTime;
            this.usedSpace = usedSpace;
            this.MainForm = MainForm;

            string taskName, userName, verdictName, compilerName;
            // get taskName
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT title FROM Tasks WHERE id_task=" + idTask.ToString(), conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
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

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT user_name FROM Users WHERE id_user=" + idUser.ToString(), conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
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
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT text_verdict FROM Verdicts WHERE id_verdict=" + idVerdict.ToString(), conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
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
            //get compilerName
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT name FROM Compilers WHERE id_compiler=" + idCompiler.ToString(), conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                try
                {
                    compilerName = dr[0].ToString();
                }
                catch
                {
                    compilerName = "JavaCore";
                }
                conn.Close();
            }

            labelSubmissionAuthor.Text = userName;
            labelSubmissionVerdict.Text = verdictName;
            labelTaskSpace.Text = usedSpace.ToString() + " MB";
            labelTaskTime.Text = usedTime.ToString() + " ms";
            labelTaskTitle.Text = taskName;
            richTextBoxCode.Text = code;
            labelCompiler.Text = compilerName;
            labelDateTime.Text = timeOfSubmission.ToString("G");
        }

        private void iconButtonDeleteTask_Click(object sender, EventArgs e)
        {
            panelConfirmDelete.Visible = true;
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            MainForm.OpenChildFrom(new ChildForms.ChildFormSubmissions(MainForm));
        }

        private void iconButtonCancelDelete_Click(object sender, EventArgs e)
        {
            panelConfirmDelete.Visible = false;
        }

        private void iconButtonConfirmDelete_Click(object sender, EventArgs e)
        {
            string requestString = "DELETE FROM Submissions WHERE id_submission=@delIdSubmission; ";

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {

                SqlCommand command = new SqlCommand(requestString, conn);
                command.Parameters.AddWithValue("@delIdSubmission", idSubmission);
                try
                {
                    conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MainForm.OpenChildFrom(new ChildForms.ChildFormSubmissions(MainForm));

                }
                catch (Exception ex)
                {
                    labelErrorMessages.Text = "Error! Date has NOT been removed from the database. " + ex.Message;
                    labelErrorMessages.ForeColor = AppData.FormColors.colorError;
                }
                conn.Close();
            }
        }

        private void iconButtonEditTask_Click(object sender, EventArgs e)
        {
            MainForm.OpenChildFrom(new EditForms.EditFormSubmission(idSubmission,
                    idTask, idUser, timeOfSubmission, idCompiler, code, idVerdict, usedTime,
                    usedSpace, MainForm));
        }
    }
}
