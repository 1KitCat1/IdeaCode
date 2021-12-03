
namespace IdeaCode.ChildForms
{
    partial class ChildFormSubmissions
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
            this.panelLeftSidebar = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.flowLayoutPanelSubmissions = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButtonFilter = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddSubmission = new FontAwesome.Sharp.IconButton();
            this.panelLeftSidebar.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftSidebar
            // 
            this.panelLeftSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.panelLeftSidebar.Controls.Add(this.panelButtons);
            this.panelLeftSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeftSidebar.Location = new System.Drawing.Point(936, 0);
            this.panelLeftSidebar.Name = "panelLeftSidebar";
            this.panelLeftSidebar.Size = new System.Drawing.Size(220, 538);
            this.panelLeftSidebar.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.iconButtonFilter);
            this.panelButtons.Controls.Add(this.iconButtonAddSubmission);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(220, 145);
            this.panelButtons.TabIndex = 0;
            // 
            // flowLayoutPanelSubmissions
            // 
            this.flowLayoutPanelSubmissions.AutoScroll = true;
            this.flowLayoutPanelSubmissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.flowLayoutPanelSubmissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSubmissions.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelSubmissions.Name = "flowLayoutPanelSubmissions";
            this.flowLayoutPanelSubmissions.Size = new System.Drawing.Size(936, 538);
            this.flowLayoutPanelSubmissions.TabIndex = 2;
            // 
            // iconButtonFilter
            // 
            this.iconButtonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconButtonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFilter.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonFilter.ForeColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonFilter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconButtonFilter.IconColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFilter.IconSize = 30;
            this.iconButtonFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFilter.Location = new System.Drawing.Point(79, 88);
            this.iconButtonFilter.Name = "iconButtonFilter";
            this.iconButtonFilter.Size = new System.Drawing.Size(129, 45);
            this.iconButtonFilter.TabIndex = 3;
            this.iconButtonFilter.Text = "Filter";
            this.iconButtonFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonFilter.UseVisualStyleBackColor = false;
            // 
            // iconButtonAddSubmission
            // 
            this.iconButtonAddSubmission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAddSubmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconButtonAddSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddSubmission.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonAddSubmission.ForeColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonAddSubmission.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAddSubmission.IconColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonAddSubmission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddSubmission.IconSize = 30;
            this.iconButtonAddSubmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddSubmission.Location = new System.Drawing.Point(79, 24);
            this.iconButtonAddSubmission.Name = "iconButtonAddSubmission";
            this.iconButtonAddSubmission.Size = new System.Drawing.Size(129, 45);
            this.iconButtonAddSubmission.TabIndex = 2;
            this.iconButtonAddSubmission.Text = "Add";
            this.iconButtonAddSubmission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAddSubmission.UseVisualStyleBackColor = false;
            this.iconButtonAddSubmission.Click += new System.EventHandler(this.iconButtonAddSubmission_Click);
            // 
            // ChildFormSubmissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1156, 538);
            this.Controls.Add(this.flowLayoutPanelSubmissions);
            this.Controls.Add(this.panelLeftSidebar);
            this.Name = "ChildFormSubmissions";
            this.Text = "Submissions";
            this.panelLeftSidebar.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSidebar;
        private System.Windows.Forms.Panel panelButtons;
        private FontAwesome.Sharp.IconButton iconButtonFilter;
        private FontAwesome.Sharp.IconButton iconButtonAddSubmission;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSubmissions;
    }
}