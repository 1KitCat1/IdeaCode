using IdeaCode.Blocks;
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
    public partial class ChildFormUsers : Form
    {
        public ChildFormUsers(Form MainForm)
        {
            InitializeComponent();
            flowLayoutPanelUsers.Controls.Add(new BlockUser());
            flowLayoutPanelUsers.Controls.Add(new BlockUser("Ensiforum", 1215, "Kiril Timchenko", "KhNURE"));
        }

        private void flowLayoutPanelUsers_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
