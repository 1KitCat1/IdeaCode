using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaCode.ChildForms
{
    public partial class ChildFormBlogs : Form
    {
        public ChildFormBlogs(Form1 MainForm)
        {
            InitializeComponent();
            flowLayoutPanelBlogs.Controls.Add(new Blocks.BlockBlog("1", "aa", "aaa", new DateTime(1222), "asd", MainForm));
            
        }
    }
}
