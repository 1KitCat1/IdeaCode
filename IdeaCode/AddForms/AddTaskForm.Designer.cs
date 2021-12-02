﻿
namespace IdeaCode.AddForms
{
    partial class AddTaskForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxStatement = new System.Windows.Forms.RichTextBox();
            this.labelTaskSpace = new System.Windows.Forms.Label();
            this.labelTaskTime = new System.Windows.Forms.Label();
            this.numericUpDownMemory = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iconButtonBack = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconAuthor = new FontAwesome.Sharp.IconPictureBox();
            this.iconTime = new FontAwesome.Sharp.IconPictureBox();
            this.iconMemory = new FontAwesome.Sharp.IconPictureBox();
            this.ideaCodeDataSet = new IdeaCode.IdeaCodeDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new IdeaCode.IdeaCodeDataSetTableAdapters.UsersTableAdapter();
            this.numericUpDownComplexity = new System.Windows.Forms.NumericUpDown();
            this.iconButtonAccept = new FontAwesome.Sharp.IconButton();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ideaCodeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownComplexity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxStatement);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.OldLace;
            this.groupBox1.Location = new System.Drawing.Point(48, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 417);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statement";
            // 
            // richTextBoxStatement
            // 
            this.richTextBoxStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.richTextBoxStatement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxStatement.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxStatement.ForeColor = System.Drawing.Color.LemonChiffon;
            this.richTextBoxStatement.Location = new System.Drawing.Point(12, 27);
            this.richTextBoxStatement.Name = "richTextBoxStatement";
            this.richTextBoxStatement.Size = new System.Drawing.Size(750, 369);
            this.richTextBoxStatement.TabIndex = 2;
            this.richTextBoxStatement.Text = "Given n and array of length n. Find the maximal value";
            // 
            // labelTaskSpace
            // 
            this.labelTaskSpace.AutoSize = true;
            this.labelTaskSpace.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskSpace.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelTaskSpace.Location = new System.Drawing.Point(1025, 82);
            this.labelTaskSpace.Name = "labelTaskSpace";
            this.labelTaskSpace.Size = new System.Drawing.Size(46, 25);
            this.labelTaskSpace.TabIndex = 23;
            this.labelTaskSpace.Text = "MB";
            // 
            // labelTaskTime
            // 
            this.labelTaskTime.AutoSize = true;
            this.labelTaskTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskTime.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelTaskTime.Location = new System.Drawing.Point(1024, 146);
            this.labelTaskTime.Name = "labelTaskTime";
            this.labelTaskTime.Size = new System.Drawing.Size(45, 25);
            this.labelTaskTime.TabIndex = 22;
            this.labelTaskTime.Text = "ms";
            // 
            // numericUpDownMemory
            // 
            this.numericUpDownMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.numericUpDownMemory.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownMemory.ForeColor = System.Drawing.Color.LemonChiffon;
            this.numericUpDownMemory.Location = new System.Drawing.Point(923, 82);
            this.numericUpDownMemory.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDownMemory.Name = "numericUpDownMemory";
            this.numericUpDownMemory.Size = new System.Drawing.Size(96, 29);
            this.numericUpDownMemory.TabIndex = 30;
            this.numericUpDownMemory.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.numericUpDownTime.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownTime.ForeColor = System.Drawing.Color.LemonChiffon;
            this.numericUpDownTime.Location = new System.Drawing.Point(923, 146);
            this.numericUpDownTime.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(96, 29);
            this.numericUpDownTime.TabIndex = 31;
            this.numericUpDownTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.textBoxTopic.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTopic.ForeColor = System.Drawing.Color.LemonChiffon;
            this.textBoxTopic.Location = new System.Drawing.Point(924, 217);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(179, 29);
            this.textBoxTopic.TabIndex = 32;
            this.textBoxTopic.Text = "math";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.comboBox1.DataSource = this.usersBindingSource;
            this.comboBox1.DisplayMember = "user_name";
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBox1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(924, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 30);
            this.comboBox1.TabIndex = 33;
            // 
            // iconButtonBack
            // 
            this.iconButtonBack.FlatAppearance.BorderSize = 0;
            this.iconButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(244)))), ((int)(((byte)(109)))));
            this.iconButtonBack.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.iconButtonBack.IconColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBack.Location = new System.Drawing.Point(12, 25);
            this.iconButtonBack.Name = "iconButtonBack";
            this.iconButtonBack.Size = new System.Drawing.Size(50, 33);
            this.iconButtonBack.TabIndex = 29;
            this.iconButtonBack.UseVisualStyleBackColor = true;
            this.iconButtonBack.Click += new System.EventHandler(this.iconButtonBack_Click);
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
            this.iconPictureBox2.TabIndex = 27;
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
            this.iconPictureBox1.TabIndex = 25;
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
            this.iconAuthor.TabIndex = 21;
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
            this.iconTime.TabIndex = 20;
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
            this.iconMemory.TabIndex = 19;
            this.iconMemory.TabStop = false;
            // 
            // ideaCodeDataSet
            // 
            this.ideaCodeDataSet.DataSetName = "IdeaCodeDataSet";
            this.ideaCodeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.ideaCodeDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDownComplexity
            // 
            this.numericUpDownComplexity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.numericUpDownComplexity.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownComplexity.ForeColor = System.Drawing.Color.LemonChiffon;
            this.numericUpDownComplexity.Location = new System.Drawing.Point(926, 349);
            this.numericUpDownComplexity.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDownComplexity.Name = "numericUpDownComplexity";
            this.numericUpDownComplexity.Size = new System.Drawing.Size(96, 29);
            this.numericUpDownComplexity.TabIndex = 34;
            this.numericUpDownComplexity.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // iconButtonAccept
            // 
            this.iconButtonAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconButtonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAccept.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(254)))), ((int)(((byte)(152)))));
            this.iconButtonAccept.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButtonAccept.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(254)))), ((int)(((byte)(152)))));
            this.iconButtonAccept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAccept.IconSize = 30;
            this.iconButtonAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAccept.Location = new System.Drawing.Point(870, 412);
            this.iconButtonAccept.Name = "iconButtonAccept";
            this.iconButtonAccept.Size = new System.Drawing.Size(141, 45);
            this.iconButtonAccept.TabIndex = 51;
            this.iconButtonAccept.Text = "Accept";
            this.iconButtonAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAccept.UseVisualStyleBackColor = false;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.textBoxTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.ForeColor = System.Drawing.Color.LemonChiffon;
            this.textBoxTitle.Location = new System.Drawing.Point(130, 25);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(330, 32);
            this.textBoxTitle.TabIndex = 52;
            this.textBoxTitle.Text = "Find max";
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1156, 538);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.iconButtonAccept);
            this.Controls.Add(this.numericUpDownComplexity);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxTopic);
            this.Controls.Add(this.numericUpDownTime);
            this.Controls.Add(this.numericUpDownMemory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconButtonBack);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.labelTaskSpace);
            this.Controls.Add(this.labelTaskTime);
            this.Controls.Add(this.iconAuthor);
            this.Controls.Add(this.iconTime);
            this.Controls.Add(this.iconMemory);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ideaCodeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownComplexity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxStatement;
        private FontAwesome.Sharp.IconButton iconButtonBack;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelTaskSpace;
        private System.Windows.Forms.Label labelTaskTime;
        private FontAwesome.Sharp.IconPictureBox iconAuthor;
        private FontAwesome.Sharp.IconPictureBox iconTime;
        private FontAwesome.Sharp.IconPictureBox iconMemory;
        private System.Windows.Forms.NumericUpDown numericUpDownMemory;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.ComboBox comboBox1;
        private IdeaCodeDataSet ideaCodeDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private IdeaCodeDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDownComplexity;
        private FontAwesome.Sharp.IconButton iconButtonAccept;
        private System.Windows.Forms.TextBox textBoxTitle;
    }
}