
namespace IdeaCode.ChildForms
{
    partial class ChildFormTasks
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.iconButtonFilter = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddTask = new FontAwesome.Sharp.IconButton();
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
            this.panelLeftSidebar.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(936, 538);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.iconButtonFilter);
            this.panelButtons.Controls.Add(this.iconButtonAddTask);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(220, 145);
            this.panelButtons.TabIndex = 0;
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
            // iconButtonAddTask
            // 
            this.iconButtonAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconButtonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddTask.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonAddTask.ForeColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonAddTask.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAddTask.IconColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonAddTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddTask.IconSize = 30;
            this.iconButtonAddTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddTask.Location = new System.Drawing.Point(79, 24);
            this.iconButtonAddTask.Name = "iconButtonAddTask";
            this.iconButtonAddTask.Size = new System.Drawing.Size(129, 45);
            this.iconButtonAddTask.TabIndex = 2;
            this.iconButtonAddTask.Text = "Add";
            this.iconButtonAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAddTask.UseVisualStyleBackColor = false;
            this.iconButtonAddTask.Click += new System.EventHandler(this.iconButtonAddTask_Click);
            // 
            // ChildFormTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 538);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelLeftSidebar);
            this.Name = "ChildFormTasks";
            this.Text = "Tasks";
            this.panelLeftSidebar.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSidebar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelButtons;
        private FontAwesome.Sharp.IconButton iconButtonFilter;
        private FontAwesome.Sharp.IconButton iconButtonAddTask;
    }
}