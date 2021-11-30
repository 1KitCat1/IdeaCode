
namespace IdeaCode.ChildForms
{
    partial class ChildFormUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonAddUser = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelUsers
            // 
            this.flowLayoutPanelUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelUsers.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelUsers.Name = "flowLayoutPanelUsers";
            this.flowLayoutPanelUsers.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanelUsers.TabIndex = 0;
            this.flowLayoutPanelUsers.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelUsers_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButtonAddUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(580, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 450);
            this.panel1.TabIndex = 1;
            // 
            // iconButtonAddUser
            // 
            this.iconButtonAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconButtonAddUser.FlatAppearance.BorderSize = 0;
            this.iconButtonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddUser.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonAddUser.ForeColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonAddUser.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAddUser.IconColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddUser.IconSize = 30;
            this.iconButtonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddUser.Location = new System.Drawing.Point(100, 24);
            this.iconButtonAddUser.Name = "iconButtonAddUser";
            this.iconButtonAddUser.Size = new System.Drawing.Size(108, 45);
            this.iconButtonAddUser.TabIndex = 0;
            this.iconButtonAddUser.Text = "Add";
            this.iconButtonAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAddUser.UseVisualStyleBackColor = false;
            // 
            // ChildFormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelUsers);
            this.Name = "ChildFormUsers";
            this.Text = "Users";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUsers;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonAddUser;
    }
}