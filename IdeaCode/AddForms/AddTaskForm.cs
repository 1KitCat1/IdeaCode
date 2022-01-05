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
    public partial class AddTaskForm : Form
    {
        Form1 MainForm;
        int currentMaxId = 0;
        public AddTaskForm(Form1 MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            using (SqlConnection conn = new SqlConnection(AppData.connectionString))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT max(id_task) FROM Tasks", conn);
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

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.ideaCodeDataSet.Users);
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            MainForm.OpenChildFrom(new ChildForms.ChildFormTasks(MainForm));
        }

        private void iconButtonAccept_Click(object sender, EventArgs e)
        {
            int idTask = (int)numericUpDownTaskId.Value;
            string title = textBoxTitle.Text;
            string statement = richTextBoxStatement.Text;
            string username = comboBoxTaskUserAuthor.Text;
            int complexity = (int)numericUpDownComplexity.Value;
            string topic = textBoxTopic.Text;
            int timeLimit = (int)numericUpDownTime.Value;
            int spaceLimit = (int)numericUpDownMemory.Value;

            int idUser = 0;
            using (SqlConnection conn = new SqlConnection(AppData.connectionString))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_user FROM Users WHERE user_name='"+username+"'", conn);
                var dt = new DataTable();
                
                try
                {
                    sda.Fill(dt);
                    DataRow dr = dt.Rows[0];
                    idUser = (int)dr[0];
                }
                catch (Exception ex)
                {
                    labelDatabaseMessages.Text = "Error! No such user has been found. " + ex.Message;
                    labelDatabaseMessages.ForeColor = AppData.FormColors.colorError;
                    conn.Close();
                    return;
                }
                conn.Close();
            }
            /*string tableName = "Tasks";*/
            string requestString = "INSERT INTO Tasks VALUES (@idTask, @title, @statement, @idUser, @compexity, @topic, @timeLimit, @spaceLimit)";
            using (SqlConnection conn = new SqlConnection(AppData.connectionString))
            {

                SqlCommand command = new SqlCommand(requestString, conn);
                command.Parameters.AddWithValue("@idTask", idTask);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@statement", statement);
                command.Parameters.AddWithValue("@idUser", idUser);
                command.Parameters.AddWithValue("@compexity", complexity);
                command.Parameters.AddWithValue("@topic", topic);
                command.Parameters.AddWithValue("@timeLimit", timeLimit);
                command.Parameters.AddWithValue("@spaceLimit", spaceLimit);
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
