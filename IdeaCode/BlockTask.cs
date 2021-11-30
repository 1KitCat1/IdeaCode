using IdeaCode.InfoForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IdeaCode
{
    public partial class BlockTask : UserControl
    {
        string taskTitle;
        string taskStatement;
        string taskAuthor;
        string topic;
        int taskComplexity;
        int timeLimit;
        int spaceLimit;
        Form1 MainForm;

        public BlockTask(string taskTitle, string taskStatement, string taskAuthor, int taskComplexity,
            string topic, int timeLimit, int spaceLimit, Form1 MainForm)
        {
            InitializeComponent();
            labelTaskTitle.Text = taskTitle;
            labelTaskComplexity.Text = taskComplexity.ToString();
            labelTaskTime.Text = timeLimit.ToString() + " ms";
            labelTaskTopic.Text = topic;
            labelTaskSpace.Text = spaceLimit.ToString() + " MB";
            this.taskTitle = taskTitle;
            this.taskStatement = taskStatement;
            this.taskAuthor = taskAuthor;
            this.topic = topic;
            this.taskComplexity = taskComplexity;
            this.timeLimit = timeLimit;
            this.spaceLimit = spaceLimit;
            this.MainForm = MainForm;
              
            
        }

        private void BlockTask_MouseClick(object sender, MouseEventArgs e)
        {
            Form taskInfo = new TaskInfoForm(taskTitle, taskStatement, taskAuthor, taskComplexity,
            topic, timeLimit, spaceLimit);
            /*taskInfo.Show();*/
            MainForm.OpenChildFrom(taskInfo);
            
        }

    }
}
