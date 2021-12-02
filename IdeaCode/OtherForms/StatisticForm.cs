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

        }

        private void chartCountProblemsByComplexity_Click(object sender, EventArgs e)
        {

        }
    }
}
