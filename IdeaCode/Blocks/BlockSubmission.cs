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

namespace IdeaCode.Blocks
{
    public partial class BlockSubmission : UserControl
    {
        int idSubmission;
        int idTask;
        int idUser;
        DateTime timeOfSubmission;
        int idCompiler;
        string code;
        int idVerdict;
        int usedTime;
        int usedSpace;
        Form1 MainForm;

        public BlockSubmission(int idSubmission, int idTask, int idUser, DateTime timeOfSubmission,
            int idCompiler, string code, int idVerdict, int usedTime, int usedSpace, Form1 MainForm)
        {
            InitializeComponent();
            this.idSubmission = idSubmission;
            this.idTask = idTask;
            this.idUser = idUser;
            this.timeOfSubmission = timeOfSubmission;
            this.idCompiler = idCompiler;
            this.idVerdict = idVerdict;
            this.code = code;
            this.usedTime = usedTime;
            this.usedSpace = usedSpace;
            this.MainForm = MainForm;

            string taskName, userName, verdictName;
            // get taskName
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT title FROM Tasks WHERE id_task=" + idTask.ToString(), conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                try
                {
                    taskName = dr[0].ToString();
                }
                catch
                {
                    taskName = "Find min";
                }
                conn.Close();
            }
            // get userName

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT user_name FROM Users WHERE id_user=" + idUser.ToString(), conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                try
                {
                    userName = dr[0].ToString();
                }
                catch
                {
                    userName = "_KitCat_";
                }
                conn.Close();
            }

            // get verdictName
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT text_verdict FROM Verdicts WHERE id_verdict=" + idVerdict.ToString(), conn);
                var dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                try
                {
                    verdictName = dr[0].ToString();
                }
                catch
                {
                    verdictName = "Find min";
                }
                conn.Close();
            }
            labelSubmissionTaskName.Text = taskName;
            labelSubmissionUser.Text = userName;
            labelSubmissionVerdict.Text = verdictName;

        }
    }
}
