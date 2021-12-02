using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using IdeaCode.ChildForms;

namespace IdeaCode
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel1.Controls.Add(leftBorderBtn);
            //Disable standart control panel
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        //Colors
        private struct FormColors
        {
            public static Color colorYellow = Color.FromArgb(251, 244, 109);
            public static Color colorGreen  = Color.FromArgb(180, 254, 152);
            public static Color colorBlue   = Color.FromArgb(119, 228, 212);
            public static Color colorPurple = Color.FromArgb(153, 140, 235);
            public static Color colorPink   = Color.FromArgb(255, 115, 136);
            public static Color colorOrange = Color.FromArgb(255, 171, 76);
            public static Color colorDarkPurple = Color.FromArgb(133, 120, 215);
            public static Color colorBlackPurple = Color.FromArgb(42, 9, 68);
            public static Color colorBlackPurpleSel = Color.FromArgb(52, 16, 75);


        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = FormColors.colorBlackPurpleSel;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon current
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = currentBtn.IconColor;

            }
        }
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = FormColors.colorBlackPurple;
                currentBtn.ForeColor = Color.OldLace;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.OldLace;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        public void OpenChildFrom(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            currentChildForm = childForm;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lableCurrentChildForm.Text = childForm.Text;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToString("T");
            labelDate.Text = DateTime.Now.ToString("d");
            if (labelTime != null && labelTime.Text[1] == ':')
                labelTime.Text = '0' + labelTime.Text;
        }

        private void iconButtonTasks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, FormColors.colorYellow);
            OpenChildFrom(new ChildFormTasks(this));
        }

        private void iconButtonUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, FormColors.colorPink);
            OpenChildFrom(new ChildFormUsers(this));
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            ResetButtons();
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }
        private void ResetButtons()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.LemonChiffon;
            lableCurrentChildForm.Text = "Home";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //From dragin
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMinControl_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("T");
            labelDate.Text = DateTime.Now.ToString("d");
            if (labelTime != null && labelTime.Text[1] == ':') 
                labelTime.Text = '0' + labelTime.Text;
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, FormColors.colorOrange);
            OpenChildFrom(new ChildFormSubmissions(this));
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, FormColors.colorPurple);
            OpenChildFrom(new OtherForms.StatisticForm());
        }
    }
}
