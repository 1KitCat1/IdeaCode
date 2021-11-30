
namespace IdeaCode.ChildForms
{
    partial class ChildFormBlogs
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
            this.flowLayoutPanelBlogs = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBlogs
            // 
            this.flowLayoutPanelBlogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBlogs.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelBlogs.Name = "flowLayoutPanelBlogs";
            this.flowLayoutPanelBlogs.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanelBlogs.TabIndex = 0;
            // 
            // ChildFormBlogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelBlogs);
            this.Name = "ChildFormBlogs";
            this.Text = "Blogs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBlogs;
    }
}