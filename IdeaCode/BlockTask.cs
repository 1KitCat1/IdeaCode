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
        public BlockTask(string taskTitle, string taskStatement, string taskAuthor, int taskComplexity,
            string topic, int timeLimit, int spaceLimit)
        {
            InitializeComponent();
            labelTaskTitle.Text = taskTitle;
            labelTaskComplexity.Text = taskComplexity.ToString();
            labelTaskTime.Text = timeLimit.ToString() + " ms";
            labelTaskTopic.Text = topic;
            labelTaskSpace.Text = spaceLimit.ToString() + " MB";
            
        }
    }
}
