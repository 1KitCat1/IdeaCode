using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaCode.InfoForms
{
    public partial class TaskInfoForm : Form
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
        public TaskInfoForm()
        {
            InitializeComponent();
        }
        public TaskInfoForm(int idTask, string taskTitle, string taskStatement, string taskAuthor, int taskComplexity,
            string topic, int timeLimit, int spaceLimit, Form1 MainForm)
        {
            InitializeComponent();
            labelTaskTitle.Text = taskTitle;
            labelTaskSpace.Text = spaceLimit.ToString() + " MB";
            labelTaskTime.Text = timeLimit.ToString() + " ms";
            labelTaskAuthor.Text = taskAuthor;
            richTextBox1.Text = taskStatement;
            labelTaskTopic.Text = topic;
            labelTaskComplexity.Text = taskComplexity.ToString();
            this.MainForm = MainForm;
            this.idTask = idTask;
            this.taskTitle = taskTitle;
            this.timeLimit = timeLimit;
            this.taskStatement = taskStatement;
            this.taskAuthor = taskAuthor;
            this.taskComplexity = taskComplexity;
            this.topic = topic;
            this.spaceLimit = spaceLimit;
        }

        private void labelTaskSpace_Click(object sender, EventArgs e)
        {

        }

        private void labelTaskTime_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MainForm.OpenChildFrom(new ChildForms.ChildFormTasks(MainForm));
        }

        private void iconButtonDeleteTask_Click(object sender, EventArgs e)
        {
            panelConfirmDelete.Visible = true;
        }

        private void iconButtonCancelDelete_Click(object sender, EventArgs e)
        {
            panelConfirmDelete.Visible = false;
        }

        private void iconButtonConfirmDelete_Click(object sender, EventArgs e)
        {
            string requestString = "DELETE FROM Tasks WHERE id_task=@delIdTask; ";

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {

                SqlCommand command = new SqlCommand(requestString, conn);
                command.Parameters.AddWithValue("@delIdTask", idTask);
                try
                {
                    conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MainForm.OpenChildFrom(new ChildForms.ChildFormTasks(MainForm));

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
            MainForm.OpenChildFrom(new EditForms.EditFormTask(idTask, taskTitle, taskStatement, taskAuthor, taskComplexity,
            topic, timeLimit, spaceLimit, MainForm));
        }

        private void iconButtonDownload_Click(object sender, EventArgs e)
        {
            string fileName = "TaskInfo" + taskTitle + (DateTime.Now.ToString("d") + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss"));

            var document = new iTextSharp.text.Document();
            using (var writer = PdfWriter.GetInstance(document, new FileStream(@"C:\Users\DenCHik\OneDrive\Pictures\" + fileName + ".pdf", FileMode.Create)))
            {
                document.Open();

                var font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12);
                var fontBold = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, 1);


                document.NewPage();
                document.Add(new Paragraph("Id task: " + idTask, fontBold));
                document.Add(new Paragraph("Title: " + taskTitle, font));
                document.Add(new Paragraph("Statement: " + taskStatement, font));
                document.Add(new Paragraph("Author: " + taskAuthor, font));
                document.Add(new Paragraph("Complexity: " + taskComplexity.ToString(), font));
                document.Add(new Paragraph("Topic: " + topic, font));
                document.Add(new Paragraph("Time limit: " + timeLimit.ToString() + " ms", font));
                document.Add(new Paragraph("Space limit: " + spaceLimit.ToString() + " MB", font));


                document.Close();
                writer.Close();
                labelDownloadInfo.ForeColor = AppData.FormColors.colorGreen;
                labelDownloadInfo.Text = "File succesfully created: " + @"C:\Users\DenCHik\OneDrive\Pictures\" + fileName + ".pdf";
            }
        }
    }
}
