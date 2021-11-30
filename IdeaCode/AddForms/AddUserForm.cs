using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaCode.AddForms
{
    public partial class AddUserForm : Form
    {
        Form1 MainForm;
        byte[] images = null;
        public AddUserForm(Form1 MainForm)
        {
            InitializeComponent();
        }

        private void iconButtonUpload_Click(object sender, EventArgs e)
        {
            string photoPath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    photoPath = openFileDialog.FileName;
                }
            }
            
            if (photoPath.Length != 0)
            {
                FileStream stream = new FileStream(photoPath, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                MemoryStream ms = new MemoryStream(images);
                pictureBoxUserPhoto.Image = Image.FromStream(ms);
            }

        }
    }
}
