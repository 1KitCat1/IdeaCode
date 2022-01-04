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

namespace IdeaCode.OtherForms
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();

            var countTaskComplexity = new List<int>();
            for(int start = 1; start+499 <=3500; start += 500)
            {
                int end = start + 499;
                int count = 0;
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
                {
                    conn.Open();
                    string request = "SELECT count(id_task) FROM Tasks WHERE complexity>=" + start.ToString()+
                        " AND complexity<=" + end.ToString();
                    SqlDataAdapter sda = new SqlDataAdapter(request, conn);
                    var dt = new DataTable();
                    try
                    {
                        sda.Fill(dt);
                        DataRow dr = dt.Rows[0];
                        count = (int)dr[0];
                    }
                    catch
                    {
                        count = 0;
                        //maybe some error;
                    }
                    countTaskComplexity.Add(count);
                    conn.Close();
                }
            }
            chartCountProblemsByComplexity.Series["Series1"].Points.AddXY("1-500", countTaskComplexity[0]);
            chartCountProblemsByComplexity.Series["Series1"].Points.AddXY("501-1000", countTaskComplexity[1]);
            chartCountProblemsByComplexity.Series["Series1"].Points.AddXY("1001-1500", countTaskComplexity[2]);
            chartCountProblemsByComplexity.Series["Series1"].Points.AddXY("1501-2000", countTaskComplexity[3]);
            chartCountProblemsByComplexity.Series["Series1"].Points.AddXY("2001-2500", countTaskComplexity[4]);
            chartCountProblemsByComplexity.Series["Series1"].Points.AddXY("2501-3000", countTaskComplexity[5]);
            chartCountProblemsByComplexity.Series["Series1"].Points.AddXY("3001-3500", countTaskComplexity[6]);

            // Users by rating

            var countUsersByRating = new List<int>();
            for (int start = 1; start + 399 <= 3600; start += 400)
            {
                int end = start + 399;
                int count = 0;
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
                {
                    conn.Open();
                    string request = "SELECT count(id_user) FROM Users WHERE rating>=" + start.ToString() +
                        " AND rating<=" + end.ToString();
                    SqlDataAdapter sda = new SqlDataAdapter(request, conn);
                    var dt = new DataTable();
                    try
                    {
                        sda.Fill(dt);
                        DataRow dr = dt.Rows[0];
                        count = (int)dr[0];
                    }
                    catch
                    {
                        count = 0;
                        //maybe some error;
                    }
                    countUsersByRating.Add(count);
                    conn.Close();
                }
            }
            for(int end = 400; end <= 3600 && countUsersByRating.Count > ((int)(end / 400) - 1); end += 400)
            {
                chartUsersByRating.Series["Series1"].Points.AddXY((end-399).ToString() + "-" + (end.ToString()), countUsersByRating[(int)(end/400)-1]);
            }

            // users by amount of solved tasks

            var countUsersBySolved = new List<int>();
            for (int start = 1; start + 499 <= 5000; start += 500)
            {
                int end = start + 499;
                int count = 0;
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
                {
                    conn.Open();
                    string request = "SELECT count(id_user) FROM Users WHERE solved>=" + start.ToString() +
                        " AND solved<=" + end.ToString();
                    SqlDataAdapter sda = new SqlDataAdapter(request, conn);
                    var dt = new DataTable();
                    try
                    {
                        sda.Fill(dt);
                        DataRow dr = dt.Rows[0];
                        count = (int)dr[0];
                    }
                    catch
                    {
                        count = 0;
                        //maybe some error;
                    }
                    countUsersBySolved.Add(count);
                    conn.Close();
                }
            }
            for (int end = 500; end <= 5000 && countUsersBySolved.Count > ((int)(end / 500) - 1); end += 500)
            {
                chartBySolved.Series["Series1"].Points.AddXY((end - 499).ToString() + "-" + (end.ToString()), countUsersBySolved[(int)(end / 500) - 1]);
            }

            // submissions by compilers
            List<int> CompilersCount = new List<int>();
            List<string> CompilersNames = new List<string>();

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-34VCO73\SQLEXPRESS;Initial Catalog=IdeaCode;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT name, count(id_submission) FROM Compilers, Submissions " +
                    "WHERE Compilers.id_compiler=Submissions.id_compiler GROUP BY name", conn);
                var dt = new DataTable();
                sda.Fill(dt);

                try
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        CompilersNames.Add(dr[0].ToString());
                        CompilersCount.Add((int)dr[1]);
                    }
                }
                catch
                {
                    //error
                }
                conn.Close();
                for(int i = 0; i < CompilersCount.Count; i++)
                {
                    chartByCompilers.Series["Series1"].Points.AddXY(CompilersNames[i], CompilersCount[i]);
                }
            }
        }

        private void chartCountProblemsByComplexity_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonApply_Click(object sender, EventArgs e)
        {
            // submissions by compilers
            List<int> CompilersCount = new List<int>();
            List<string> CompilersNames = new List<string>();
            DateTime from = dateTimePickerFrom.Value;
            DateTime to = dateTimePickerTo.Value;
            string fromDataString = from.ToString("yyyy") + '-' + from.ToString("dd") + '-' + from.ToString("MM");
            string toDataString = to.ToString("yyyy") + '-' + to.ToString("dd") + '-' + to.ToString("MM");


            using (SqlConnection conn = new SqlConnection(AppData.connectionString))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT name, count(id_submission) FROM Compilers, Submissions WHERE Compilers.id_compiler = Submissions.id_compiler AND time_submission >= '"+fromDataString+"' AND time_submission <= '"+toDataString+"' GROUP BY name", conn);
                var dt = new DataTable();
                

                try
                {
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        CompilersNames.Add(dr[0].ToString());
                        CompilersCount.Add((int)dr[1]);
                    }
                }
                catch
                {
                    //error
                }
                conn.Close();
                for (int i = 0; i < CompilersCount.Count; i++)
                {
                    chartByCompilers.Series["Series1"].Points.AddXY(CompilersNames[i], CompilersCount[i]);
                }
            }
        }
    }
}
