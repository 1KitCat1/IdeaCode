﻿
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
            // ChildFormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelUsers);
            this.Name = "ChildFormUsers";
            this.Text = "Users";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUsers;
    }
}