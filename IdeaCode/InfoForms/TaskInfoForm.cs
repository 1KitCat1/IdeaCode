using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaCode.InfoForms
{
    public partial class TaskInfoForm : Form
    {
        public TaskInfoForm()
        {
            InitializeComponent();
        }
        public TaskInfoForm(string taskTitle, string taskStatement, string taskAuthor, int taskComplexity,
            string topic, int timeLimit, int spaceLimit)
        {
            InitializeComponent();
            labelTaskTitle.Text = taskTitle;
            labelTaskSpace.Text = spaceLimit.ToString() + " MB";
            labelTaskTime.Text = timeLimit.ToString() + " ms";
            labelTaskAuthor.Text = taskAuthor;
            richTextBox1.Text = taskStatement;
            labelTaskTopic.Text = topic;
            labelTaskComplexity.Text = taskComplexity.ToString();
        }

        private void labelTaskSpace_Click(object sender, EventArgs e)
        {

        }

        private void labelTaskTime_Click(object sender, EventArgs e)
        {

        }
    }
}
