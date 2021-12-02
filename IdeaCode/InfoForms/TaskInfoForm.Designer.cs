
namespace IdeaCode.InfoForms
{
    partial class TaskInfoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelTaskTitle = new System.Windows.Forms.Label();
            this.labelTaskSpace = new System.Windows.Forms.Label();
            this.labelTaskTime = new System.Windows.Forms.Label();
            this.labelTaskAuthor = new System.Windows.Forms.Label();
            this.labelTaskTopic = new System.Windows.Forms.Label();
            this.labelTaskComplexity = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconAuthor = new FontAwesome.Sharp.IconPictureBox();
            this.iconTime = new FontAwesome.Sharp.IconPictureBox();
            this.iconMemory = new FontAwesome.Sharp.IconPictureBox();
            this.panelConfirmDelete = new System.Windows.Forms.Panel();
            this.labelConfirmDelete = new System.Windows.Forms.Label();
            this.iconButtonConfirmDelete = new FontAwesome.Sharp.IconButton();
            this.iconButtonCancelDelete = new FontAwesome.Sharp.IconButton();
            this.iconButtonDeleteTask = new FontAwesome.Sharp.IconButton();
            this.labelErrorMessages = new System.Windows.Forms.Label();
            this.iconButtonEditTask = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMemory)).BeginInit();
            this.panelConfirmDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.OldLace;
            this.groupBox1.Location = new System.Drawing.Point(48, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statement";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(750, 369);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Given n and array of length n. Find the maximal value";
            // 
            // labelTaskTitle
            // 
            this.labelTaskTitle.AutoSize = true;
            this.labelTaskTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(109)))));
            this.labelTaskTitle.Location = new System.Drawing.Point(142, 22);
            this.labelTaskTitle.Name = "labelTaskTitle";
            this.labelTaskTitle.Size = new System.Drawing.Size(136, 29);
            this.labelTaskTitle.TabIndex = 1;
            this.labelTaskTitle.Text = "Find max";
            // 
            // labelTaskSpace
            // 
            this.labelTaskSpace.AutoSize = true;
            this.labelTaskSpace.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskSpace.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelTaskSpace.Location = new System.Drawing.Point(926, 82);
            this.labelTaskSpace.Name = "labelTaskSpace";
            this.labelTaskSpace.Size = new System.Drawing.Size(95, 25);
            this.labelTaskSpace.TabIndex = 10;
            this.labelTaskSpace.Text = "128 MB";
            this.labelTaskSpace.Click += new System.EventHandler(this.labelTaskSpace_Click);
            // 
            // labelTaskTime
            // 
            this.labelTaskTime.AutoSize = true;
            this.labelTaskTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskTime.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelTaskTime.Location = new System.Drawing.Point(927, 146);
            this.labelTaskTime.Name = "labelTaskTime";
            this.labelTaskTime.Size = new System.Drawing.Size(108, 25);
            this.labelTaskTime.TabIndex = 9;
            this.labelTaskTime.Text = "1000 ms";
            this.labelTaskTime.Click += new System.EventHandler(this.labelTaskTime_Click);
            // 
            // labelTaskAuthor
            // 
            this.labelTaskAuthor.AutoSize = true;
            this.labelTaskAuthor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskAuthor.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelTaskAuthor.Location = new System.Drawing.Point(926, 288);
            this.labelTaskAuthor.Name = "labelTaskAuthor";
            this.labelTaskAuthor.Size = new System.Drawing.Size(107, 25);
            this.labelTaskAuthor.TabIndex = 11;
            this.labelTaskAuthor.Text = "_KitCat_";
            this.labelTaskAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTaskTopic
            // 
            this.labelTaskTopic.AutoSize = true;
            this.labelTaskTopic.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskTopic.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelTaskTopic.Location = new System.Drawing.Point(926, 218);
            this.labelTaskTopic.Name = "labelTaskTopic";
            this.labelTaskTopic.Size = new System.Drawing.Size(40, 25);
            this.labelTaskTopic.TabIndex = 13;
            this.labelTaskTopic.Text = "dp";
            this.labelTaskTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTaskComplexity
            // 
            this.labelTaskComplexity.AutoSize = true;
            this.labelTaskComplexity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskComplexity.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelTaskComplexity.Location = new System.Drawing.Point(926, 352);
            this.labelTaskComplexity.Name = "labelTaskComplexity";
            this.labelTaskComplexity.Size = new System.Drawing.Size(54, 25);
            this.labelTaskComplexity.TabIndex = 15;
            this.labelTaskComplexity.Text = "800";
            this.labelTaskComplexity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(109)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.iconButton1.IconColor = System.Drawing.Color.LemonChiffon;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(12, 25);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(50, 33);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(109)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(109)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 41;
            this.iconPictureBox2.Location = new System.Drawing.Point(870, 345);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(53, 41);
            this.iconPictureBox2.TabIndex = 14;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(109)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(109)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 41;
            this.iconPictureBox1.Location = new System.Drawing.Point(870, 210);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(53, 41);
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconAuthor
            // 
            this.iconAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(109)))));
            this.iconAuthor.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconAuthor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(109)))));
            this.iconAuthor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAuthor.IconSize = 41;
            this.iconAuthor.Location = new System.Drawing.Point(870, 281);
            this.iconAuthor.Name = "iconAuthor";
            this.iconAuthor.Size = new System.Drawing.Size(53, 41);
            this.iconAuthor.TabIndex = 4;
            this.iconAuthor.TabStop = false;
            // 
            // iconTime
            // 
            this.iconTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(109)))));
            this.iconTime.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconTime.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(109)))));
            this.iconTime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTime.IconSize = 41;
            this.iconTime.Location = new System.Drawing.Point(870, 141);
            this.iconTime.Name = "iconTime";
            this.iconTime.Size = new System.Drawing.Size(53, 41);
            this.iconTime.TabIndex = 3;
            this.iconTime.TabStop = false;
            // 
            // iconMemory
            // 
            this.iconMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(109)))));
            this.iconMemory.IconChar = FontAwesome.Sharp.IconChar.Memory;
            this.iconMemory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(109)))));
            this.iconMemory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMemory.IconSize = 41;
            this.iconMemory.Location = new System.Drawing.Point(870, 77);
            this.iconMemory.Name = "iconMemory";
            this.iconMemory.Size = new System.Drawing.Size(53, 41);
            this.iconMemory.TabIndex = 2;
            this.iconMemory.TabStop = false;
            // 
            // panelConfirmDelete
            // 
            this.panelConfirmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConfirmDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.panelConfirmDelete.Controls.Add(this.labelConfirmDelete);
            this.panelConfirmDelete.Controls.Add(this.iconButtonConfirmDelete);
            this.panelConfirmDelete.Controls.Add(this.iconButtonCancelDelete);
            this.panelConfirmDelete.Location = new System.Drawing.Point(650, 11);
            this.panelConfirmDelete.Name = "panelConfirmDelete";
            this.panelConfirmDelete.Size = new System.Drawing.Size(145, 200);
            this.panelConfirmDelete.TabIndex = 37;
            this.panelConfirmDelete.Visible = false;
            // 
            // labelConfirmDelete
            // 
            this.labelConfirmDelete.AutoSize = true;
            this.labelConfirmDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConfirmDelete.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelConfirmDelete.Location = new System.Drawing.Point(16, 19);
            this.labelConfirmDelete.Name = "labelConfirmDelete";
            this.labelConfirmDelete.Size = new System.Drawing.Size(108, 25);
            this.labelConfirmDelete.TabIndex = 38;
            this.labelConfirmDelete.Text = "Confirm:";
            this.labelConfirmDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButtonConfirmDelete
            // 
            this.iconButtonConfirmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonConfirmDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconButtonConfirmDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonConfirmDelete.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonConfirmDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(136)))));
            this.iconButtonConfirmDelete.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.iconButtonConfirmDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(136)))));
            this.iconButtonConfirmDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonConfirmDelete.IconSize = 30;
            this.iconButtonConfirmDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonConfirmDelete.Location = new System.Drawing.Point(12, 128);
            this.iconButtonConfirmDelete.Name = "iconButtonConfirmDelete";
            this.iconButtonConfirmDelete.Size = new System.Drawing.Size(124, 45);
            this.iconButtonConfirmDelete.TabIndex = 37;
            this.iconButtonConfirmDelete.Text = "Delete";
            this.iconButtonConfirmDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonConfirmDelete.UseVisualStyleBackColor = false;
            this.iconButtonConfirmDelete.Click += new System.EventHandler(this.iconButtonConfirmDelete_Click);
            // 
            // iconButtonCancelDelete
            // 
            this.iconButtonCancelDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonCancelDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconButtonCancelDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCancelDelete.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonCancelDelete.ForeColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonCancelDelete.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.iconButtonCancelDelete.IconColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonCancelDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCancelDelete.IconSize = 30;
            this.iconButtonCancelDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCancelDelete.Location = new System.Drawing.Point(12, 75);
            this.iconButtonCancelDelete.Name = "iconButtonCancelDelete";
            this.iconButtonCancelDelete.Size = new System.Drawing.Size(124, 45);
            this.iconButtonCancelDelete.TabIndex = 36;
            this.iconButtonCancelDelete.Text = "Cancel";
            this.iconButtonCancelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCancelDelete.UseVisualStyleBackColor = false;
            this.iconButtonCancelDelete.Click += new System.EventHandler(this.iconButtonCancelDelete_Click);
            // 
            // iconButtonDeleteTask
            // 
            this.iconButtonDeleteTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDeleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconButtonDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDeleteTask.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonDeleteTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(136)))));
            this.iconButtonDeleteTask.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.iconButtonDeleteTask.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(136)))));
            this.iconButtonDeleteTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDeleteTask.IconSize = 30;
            this.iconButtonDeleteTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDeleteTask.Location = new System.Drawing.Point(660, 13);
            this.iconButtonDeleteTask.Name = "iconButtonDeleteTask";
            this.iconButtonDeleteTask.Size = new System.Drawing.Size(124, 45);
            this.iconButtonDeleteTask.TabIndex = 36;
            this.iconButtonDeleteTask.Text = "Delete";
            this.iconButtonDeleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonDeleteTask.UseVisualStyleBackColor = false;
            this.iconButtonDeleteTask.Click += new System.EventHandler(this.iconButtonDeleteTask_Click);
            // 
            // labelErrorMessages
            // 
            this.labelErrorMessages.AutoSize = true;
            this.labelErrorMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorMessages.Location = new System.Drawing.Point(239, 496);
            this.labelErrorMessages.Name = "labelErrorMessages";
            this.labelErrorMessages.Size = new System.Drawing.Size(0, 20);
            this.labelErrorMessages.TabIndex = 38;
            // 
            // iconButtonEditTask
            // 
            this.iconButtonEditTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonEditTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconButtonEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEditTask.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonEditTask.ForeColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonEditTask.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButtonEditTask.IconColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonEditTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEditTask.IconSize = 30;
            this.iconButtonEditTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEditTask.Location = new System.Drawing.Point(486, 13);
            this.iconButtonEditTask.Name = "iconButtonEditTask";
            this.iconButtonEditTask.Size = new System.Drawing.Size(124, 45);
            this.iconButtonEditTask.TabIndex = 39;
            this.iconButtonEditTask.Text = "Edit";
            this.iconButtonEditTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonEditTask.UseVisualStyleBackColor = false;
            // 
            // TaskInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1156, 538);
            this.Controls.Add(this.iconButtonEditTask);
            this.Controls.Add(this.labelErrorMessages);
            this.Controls.Add(this.panelConfirmDelete);
            this.Controls.Add(this.iconButtonDeleteTask);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.labelTaskComplexity);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.labelTaskTopic);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.labelTaskAuthor);
            this.Controls.Add(this.labelTaskSpace);
            this.Controls.Add(this.labelTaskTime);
            this.Controls.Add(this.iconAuthor);
            this.Controls.Add(this.iconTime);
            this.Controls.Add(this.iconMemory);
            this.Controls.Add(this.labelTaskTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "TaskInfoForm";
            this.Text = "TaskInfoForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMemory)).EndInit();
            this.panelConfirmDelete.ResumeLayout(false);
            this.panelConfirmDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTaskTitle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private FontAwesome.Sharp.IconPictureBox iconMemory;
        private FontAwesome.Sharp.IconPictureBox iconTime;
        private FontAwesome.Sharp.IconPictureBox iconAuthor;
        private System.Windows.Forms.Label labelTaskSpace;
        private System.Windows.Forms.Label labelTaskTime;
        private System.Windows.Forms.Label labelTaskAuthor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelTaskTopic;
        private System.Windows.Forms.Label labelTaskComplexity;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelConfirmDelete;
        private System.Windows.Forms.Label labelConfirmDelete;
        private FontAwesome.Sharp.IconButton iconButtonConfirmDelete;
        private FontAwesome.Sharp.IconButton iconButtonCancelDelete;
        private FontAwesome.Sharp.IconButton iconButtonDeleteTask;
        private System.Windows.Forms.Label labelErrorMessages;
        private FontAwesome.Sharp.IconButton iconButtonEditTask;
    }
}