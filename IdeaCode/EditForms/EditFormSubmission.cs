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

namespace IdeaCode.EditForms
{
    public partial class EditFormSubmission : Form
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
        public EditFormSubmission(int idSubmission, int idTask, int idUser, DateTime timeOfSubmission,
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
            using (SqlConnection conn = new SqlConnection(AppData.connectionString))
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
            comboBox1.Text = taskName;
            comboBoxCompiler.Text = compilerName;
            comboBoxTaskUserAuthor.Text = userName;
            comboBoxVerdict.Text = verdictName;
            numericUpDownMemory.Value = usedSpace;
            numericUpDownTime.Value = usedTime;
            numericUpDownTaskId.Value = idSubmission;
            richTextBoxStatement.Text = code;
            dateTimePicker1.Value = timeOfSubmission;
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            MainForm.OpenChildFrom(new InfoForms.SubmissionInfoForm(idSubmission,
                    idTask, idUser, timeOfSubmission, idCompiler, code, idVerdict, usedTime,
                    usedSpace, MainForm));
        }

        private void iconButtonAccept_Click(object sender, EventArgs e)
        {
            idSubmission = (int)numericUpDownTaskId.Value;
            idTask = 1;
            idUser = 1;
            timeOfSubmission = dateTimePicker1.Value;
            idCompiler = 1;
            code = richTextBoxStatement.Text;
            idVerdict = 1;
            usedTime = (int)numericUpDownTime.Value;
            usedSpace = (int)numericUpDownMemory.Value;
            string taskName = comboBox1.Text;
            string verdictName = comboBoxVerdict.Text;
            string compilerName = comboBoxCompiler.Text;
            string userName = comboBoxTaskUserAuthor.Text;

            // get taskName
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_task FROM Tasks WHERE title='" + taskName + "'", conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                try
                {
                    idTask = (int)dr[0];
                }
                catch (Exception ex)
                {
                    labelDatabaseMessages.Text = "Error! Date has NOT been added to the database. " + ex.Message;
                    labelDatabaseMessages.ForeColor = AppData.FormColors.colorError;
                }
                conn.Close();
            }
            // get userName

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_user FROM Users WHERE user_name='" + userName + "'", conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                try
                {
                    idUser = (int)dr[0];
                }
                catch (Exception ex)
                {
                    labelDatabaseMessages.Text = "Error! Date has NOT been added to the database. " + ex.Message;
                    labelDatabaseMessages.ForeColor = AppData.FormColors.colorError;
                }
                conn.Close();
            }

            // get verdictName
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_verdict FROM Verdicts WHERE text_verdict='" + verdictName + "'", conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                try
                {
                    idVerdict = (int)dr[0];
                }
                catch (Exception ex)
                {
                    labelDatabaseMessages.Text = "Error! Date has NOT been added to the database. " + ex.Message;
                    labelDatabaseMessages.ForeColor = AppData.FormColors.colorError;
                }
                conn.Close();
            }
            //get compilerName
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_compiler FROM Compilers WHERE name='" + compilerName + "'", conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                try
                {
                    idCompiler = (int)dr[0];
                }
                catch (Exception ex)
                {
                    labelDatabaseMessages.Text = "Error! Date has NOT been added to the database. " + ex.Message;
                    labelDatabaseMessages.ForeColor = AppData.FormColors.colorError;
                }
                conn.Close();
            }

            string requestString = "UPDATE Submissions SET  id_task=@idTask," +
                " id_user=@idUser, id_compiler=@idCompiler, " +
                "code=@code, id_verdict=@idVerdict, used_time=@usedTime, used_space=@usedSpace," +
                " time_submission=@timeSub WHERE id_submission=@idSubmission";
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {

                SqlCommand command = new SqlCommand(requestString, conn);
                command.Parameters.AddWithValue("@idSubmission", idSubmission);
                command.Parameters.AddWithValue("@idTask", idTask);
                command.Parameters.AddWithValue("@idUser", idUser);
                command.Parameters.AddWithValue("@idCompiler", idCompiler);
                command.Parameters.AddWithValue("@code", code);
                command.Parameters.AddWithValue("@idVerdict", idVerdict);
                command.Parameters.AddWithValue("@usedTime", usedTime);
                command.Parameters.AddWithValue("@usedSpace", usedSpace);
                command.Parameters.AddWithValue("@timeSub", timeOfSubmission);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    MainForm.OpenChildFrom(new InfoForms.SubmissionInfoForm(idSubmission,
                    idTask, idUser, timeOfSubmission, idCompiler, code, idVerdict, usedTime,
                    usedSpace, MainForm));

                }
                catch (Exception ex)
                {
                    labelDatabaseMessages.Text = "Error! Date has NOT been added to the database. " + ex.Message;
                    labelDatabaseMessages.ForeColor = AppData.FormColors.colorError;
                }
                conn.Close();
            }
        }

        private void EditFormSubmission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ideaCodeDataSet1.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.ideaCodeDataSet1.Tasks);

        }
    }
}
