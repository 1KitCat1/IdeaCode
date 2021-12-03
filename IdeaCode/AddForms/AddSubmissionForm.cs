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

namespace IdeaCode.AddForms
{
    public partial class AddSubmissionForm : Form
    {
        Form1 MainForm;
        int currentMaxId = 0;

        public AddSubmissionForm(Form1 MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT max(id_submission) FROM Submissions", conn);
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
            numericUpDownTaskId.Value = currentMaxId + 1;
        }

        private void AddSubmissionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ideaCodeDataSet1.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.ideaCodeDataSet1.Tasks);
            // TODO: This line of code loads data into the 'ideaCodeDataSet1.Verdicts' table. You can move, or remove it, as needed.
            this.verdictsTableAdapter1.Fill(this.ideaCodeDataSet1.Verdicts);
            // TODO: This line of code loads data into the 'ideaCodeDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.ideaCodeDataSet.Users);
            // TODO: This line of code loads data into the 'ideaCodeDataSet.Compilers' table. You can move, or remove it, as needed.
            this.compilersTableAdapter.Fill(this.ideaCodeDataSet.Compilers);
            // TODO: This line of code loads data into the 'ideaCodeDataSet.Verdicts' table. You can move, or remove it, as needed.
            this.verdictsTableAdapter.Fill(this.ideaCodeDataSet.Verdicts);

        }

        private void iconButtonAccept_Click(object sender, EventArgs e)
        {
            int idSubmission = (int)numericUpDownTaskId.Value;
            int idTask = 1;
            int idUser = 1;
            DateTime timeOfSubmission = dateTimePicker1.Value;
            int idCompiler = 1;
            string code = richTextBoxStatement.Text;
            int idVerdict = 1;
            int usedTime = (int)numericUpDownTime.Value;
            int usedSpace = (int)numericUpDownMemory.Value;
            string taskName = comboBox1.Text;
            string verdictName = comboBoxVerdict.Text;
            string compilerName = comboBoxCompiler.Text;
            string userName = comboBoxTaskUserAuthor.Text;

            // get taskName
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_task FROM Tasks WHERE title='" + taskName +"'", conn);
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

            string requestString = "INSERT INTO Submissions VALUES (@idSubmission, @idTask, @idUser, @idCompiler, " +
                "@code, @idVerdict, @usedTime, @usedSpace, @timeSub)";
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
                    int rowsAffected = command.ExecuteNonQuery();
                    labelDatabaseMessages.Text = "Data has been succesfully added to database. Rows affected: " + rowsAffected.ToString();
                    labelDatabaseMessages.ForeColor = AppData.FormColors.colorGreen;

                }
                catch (Exception ex)
                {
                    labelDatabaseMessages.Text = "Error! Date has NOT been added to the database. " + ex.Message;
                    labelDatabaseMessages.ForeColor = AppData.FormColors.colorError;
                }
                conn.Close();
            }
        }
    }
}
