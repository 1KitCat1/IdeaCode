using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaCode.Blocks
{
    public partial class BlockUser : UserControl
    {
        public BlockUser()
        {
            InitializeComponent();
        }
        public BlockUser(string nickName, int rating, string realName, string organisation)
        {
            InitializeComponent();
            labelUserNick.Text = nickName;
            labelUserRating.Text = rating.ToString();
            labelRealName.Text = realName;
            labelUserOrganisation.Text = organisation;

            
        }

        private void labelComplexity_Click(object sender, EventArgs e)
        {

        }
    }
}
