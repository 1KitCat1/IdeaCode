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
        Form1 MainForm;
        public ChildFormTasks(Form1 MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            flowLayoutPanel1.Controls.Add(new BlockTask("Find max", "find maximal value", "_KitCat_", 800, "math", 1000, 128, MainForm, this));
            flowLayoutPanel1.Controls.Add(new BlockTask("Sort array", "Given n and array length n. Print it in sorted way"
                , "_KitCat_", 800, "construct", 1000, 256, MainForm, this));
            /*flowLayoutPanel1.Controls.Add(new BlockTask());*/
        }

        private void iconButtonAddTask_Click(object sender, EventArgs e)
        {
            MainForm.OpenChildFrom(new AddForms.AddTaskForm(MainForm));
        }
    }
}
