using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaCode.AddForms
{
    public partial class AddSubmissionForm : Form
    {
        Form1 MainForm;
        int currentMaxId = 0;

        public AddSubmissionForm(Form1 MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT max(id_submission) FROM Submissions", conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                try
                {
                    currentMaxId = (int)dr[0];
                }
                catch
                {
                    currentMaxId = 0;
                }

                conn.Close();
            }
            numericUpDownTaskId.Value = currentMaxId + 1;
        }

        private void AddSubmissionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ideaCodeDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.ideaCodeDataSet.Users);
            // TODO: This line of code loads data into the 'ideaCodeDataSet.Compilers' table. You can move, or remove it, as needed.
            this.compilersTableAdapter.Fill(this.ideaCodeDataSet.Compilers);
            // TODO: This line of code loads data into the 'ideaCodeDataSet.Verdicts' table. You can move, or remove it, as needed.
            this.verdictsTableAdapter.Fill(this.ideaCodeDataSet.Verdicts);

        }
    }
}
