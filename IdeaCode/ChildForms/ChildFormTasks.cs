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

namespace IdeaCode.ChildForms
{
    public partial class ChildFormTasks : Form
    {
        Form1 MainForm;
        public ChildFormTasks(Form1 MainForm)
        {
            InitializeComponent();
            DataTable tasksFromDB;
            this.MainForm = MainForm;
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tasks", conn);
                tasksFromDB = new DataTable();
                sda.Fill(tasksFromDB);
                conn.Close();
            }
            if (tasksFromDB != null)
            {
                foreach (DataRow dr in tasksFromDB.Rows)
                {
                    int idTask = (int)dr[0];
                    string taskTitle = dr[1].ToString();
                    string taskStatement = dr[2].ToString();
                    string taskAuthor = dr[3].ToString();
                    int taskComplexity = (int)dr[4];
                    string topic = dr[5].ToString(); 
                    int timeLimit = (int)dr[6];
                    int spaceLimit = (int)dr[7];
                    string userName = "_KitCat_";
                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
                    {
                        conn.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT user_name FROM Users WHERE id_user=" + taskAuthor, conn);
                        var dt = new DataTable();
                        try
                        {
                            sda.Fill(dt);
                            DataRow drL = dt.Rows[0];
                            userName = drL[0].ToString();
                        }
                        catch
                        {
                            conn.Close();
                            continue;
                        }
                        conn.Close();
                    }
                    flowLayoutPanelTasks.Controls.Add(new BlockTask(idTask, taskTitle, taskStatement,
                        userName, taskComplexity, topic,timeLimit, spaceLimit, MainForm));
                }
            }
        }

        private void iconButtonAddTask_Click(object sender, EventArgs e)
        {
            MainForm.OpenChildFrom(new AddForms.AddTaskForm(MainForm));
        }
    }
}
