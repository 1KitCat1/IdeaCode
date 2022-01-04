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
    public partial class EditFormTask : Form
    {
        Form1 MainForm;
        int idTask;
        string taskTitle;
        string taskStatement;
        string taskAuthor;
        int taskComplexity;
        string topic;
        int timeLimit;
        int spaceLimit;
        public EditFormTask(int idTask, string taskTitle, string taskStatement, string taskAuthor, int taskComplexity,
            string topic, int timeLimit, int spaceLimit, Form1 MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            this.idTask = idTask;
            this.taskTitle = taskTitle;
            this.timeLimit = timeLimit;
            this.taskStatement = taskStatement;
            this.taskAuthor = taskAuthor;
            this.taskComplexity = taskComplexity;
            this.topic = topic;
            this.spaceLimit = spaceLimit;

            numericUpDownTaskId.Value = idTask;
            numericUpDownTime.Value = timeLimit;
            numericUpDownMemory.Value = spaceLimit;
            numericUpDownComplexity.Value = taskComplexity;
            textBoxTitle.Text = taskTitle;
            textBoxTopic.Text = topic;
            richTextBoxStatement.Text = taskStatement;
            comboBoxTaskUserAuthor.Text = taskAuthor;
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            MainForm.OpenChildFrom(new InfoForms.TaskInfoForm(idTask, taskTitle, taskStatement,
                taskAuthor, taskComplexity, topic, timeLimit, spaceLimit, MainForm));
        }

        private void iconButtonAccept_Click(object sender, EventArgs e)
        {
            taskTitle = textBoxTitle.Text;
            taskStatement = richTextBoxStatement.Text;
            taskAuthor = comboBoxTaskUserAuthor.Text;
            taskComplexity = (int)numericUpDownComplexity.Value;
            topic = textBoxTopic.Text;
            timeLimit = (int)numericUpDownTime.Value;
            spaceLimit = (int)numericUpDownMemory.Value;
            int idUser = 1;

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_user FROM Users WHERE user_name='" + taskAuthor + "'", conn);
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

            string requestString = "UPDATE Tasks SET title=@title, statement=@statement, id_user=@idUser, complexity=@comp, " +
                "topic=@topic, time_limit=@tl, space_limit=@sl WHERE id_task=@idTask";
            using (SqlConnection conn = new SqlConnection(AppData.connectionString))
            {
                SqlCommand command = new SqlCommand(requestString, conn);
                command.Parameters.AddWithValue("@idTask", idTask);
                command.Parameters.AddWithValue("@title", taskTitle);
                command.Parameters.AddWithValue("@statement", taskStatement);
                command.Parameters.AddWithValue("@idUser", idUser);
                command.Parameters.AddWithValue("@comp", taskComplexity);
                command.Parameters.AddWithValue("@topic", topic);
                command.Parameters.AddWithValue("@tl", timeLimit);
                command.Parameters.AddWithValue("@sl", spaceLimit);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    MainForm.OpenChildFrom(new InfoForms.TaskInfoForm(idTask, taskTitle, taskStatement, taskAuthor,
                        taskComplexity, topic, timeLimit, spaceLimit, MainForm));

                }
                catch (Exception ex)
                {
                    labelBlogDatabaseMessages.Text = "Error! Date has NOT been added to the database. " + ex.Message;
                    labelBlogDatabaseMessages.ForeColor = AppData.FormColors.colorError;
                }
            }
        }

        private void EditFormTask_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ideaCodeDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.ideaCodeDataSet.Users);

        }
    }
}
