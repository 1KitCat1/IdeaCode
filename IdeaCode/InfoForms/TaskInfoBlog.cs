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
    public partial class TaskInfoBlog : Form
    {
        Form1 MainForm;
        public TaskInfoBlog()
        {
            InitializeComponent();
        }
        public TaskInfoBlog(int blogId, string title, string fullBlog, string author, DateTime dateOfCreation, string topic, Form1 MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            labelBlogAuthor.Text = author;
            labelBlogDate.Text = dateOfCreation.ToString("d");
            labelBlogID.Text = blogId.ToString();
            labelBlogTitle.Text = title;
            labelBlogTopic.Text = topic;
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(MainForm != null)
            {
                MainForm.OpenChildFrom(new ChildForms.ChildFormBlogs(MainForm));
            }
        }
    }
}
