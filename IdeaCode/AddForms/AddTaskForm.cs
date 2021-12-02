using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaCode.AddForms
{
    public partial class AddTaskForm : Form
    {
        Form1 MainForm;
        public AddTaskForm(Form1 MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ideaCodeDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.ideaCodeDataSet.Users);

        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            MainForm.OpenChildFrom(new ChildForms.ChildFormTasks(MainForm));
        }
    }
}
