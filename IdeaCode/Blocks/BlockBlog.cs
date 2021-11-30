using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaCode.Blocks
{
    public partial class BlockBlog : UserControl
    {
        string title;
        string fullBlog;
        string author;
        DateTime dateOfCreation;
        string topic;
        Form1 MainForm;

        public BlockBlog()
        {
            InitializeComponent();
        }
        public BlockBlog(string title, string fullBlog, string author, DateTime dateOfCreation, string topic, Form1 MainForm)
        {
            InitializeComponent();
            labelBlogAuthor.Text = author;
            labelBlogDate.Text = dateOfCreation.ToString("d");
            labelBlogTitle.Text = title;
            labelBlogTopic.Text = topic;
            this.MainForm = MainForm;
            this.title = title;
            this.fullBlog = fullBlog;
            this.author = author;
            this.dateOfCreation = dateOfCreation;
            this.topic = topic;

        }

        private void BlockBlog_Load(object sender, EventArgs e)
        {
            
        }

        private void BlockBlog_MouseClick(object sender, MouseEventArgs e)
        {
            if (MainForm != null)
            {
                MainForm.OpenChildFrom(new InfoForms.TaskInfoBlog(1, title, fullBlog, author, dateOfCreation, topic, MainForm));

            }
        }
    }
}
