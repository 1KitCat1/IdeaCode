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
    public partial class ChildFormTasks : Form
    {
        public ChildFormTasks()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(new BlockTask());
            flowLayoutPanel1.Controls.Add(new BlockTask());
            flowLayoutPanel1.Controls.Add(new BlockTask());
            flowLayoutPanel1.Controls.Add(new BlockTask());
            flowLayoutPanel1.Controls.Add(new BlockTask());
            flowLayoutPanel1.Controls.Add(new BlockTask());
        }
    }
}
