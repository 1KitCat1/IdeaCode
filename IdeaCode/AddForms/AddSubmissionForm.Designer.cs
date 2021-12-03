
namespace IdeaCode.AddForms
{
    partial class AddSubmissionForm
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
            this.labelDatabaseMessages = new System.Windows.Forms.Label();
            this.numericUpDownTaskId = new System.Windows.Forms.NumericUpDown();
            this.iconButtonAccept = new FontAwesome.Sharp.IconButton();
            this.comboBoxTaskUserAuthor = new System.Windows.Forms.ComboBox();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMemory = new System.Windows.Forms.NumericUpDown();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxStatement = new System.Windows.Forms.RichTextBox();
            this.iconAuthor = new FontAwesome.Sharp.IconPictureBox();
            this.iconTime = new FontAwesome.Sharp.IconPictureBox();
            this.iconMemory = new FontAwesome.Sharp.IconPictureBox();
            this.labelTaskSpace = new System.Windows.Forms.Label();
            this.labelTaskTime = new System.Windows.Forms.Label();
            this.iconButtonBack = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.comboBoxVerdict = new System.Windows.Forms.ComboBox();
            this.comboBoxCompiler = new System.Windows.Forms.ComboBox();
            this.ideaCodeDataSet = new IdeaCode.IdeaCodeDataSet();
            this.verdictsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verdictsTableAdapter = new IdeaCode.IdeaCodeDataSetTableAdapters.VerdictsTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.verdictsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.compilersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compilersTableAdapter = new IdeaCode.IdeaCodeDataSetTableAdapters.CompilersTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new IdeaCode.IdeaCodeDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaskId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ideaCodeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdictsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdictsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compilersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDatabaseMessages
            // 
            this.labelDatabaseMessages.AutoSize = true;
            this.labelDatabaseMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDatabaseMessages.Location = new System.Drawing.Point(56, 481);
            this.labelDatabaseMessages.Name = "labelDatabaseMessages";
            this.labelDatabaseMessages.Size = new System.Drawing.Size(0, 20);
            this.labelDatabaseMessages.TabIndex = 74;
            // 
            // numericUpDownTaskId
            // 
            this.numericUpDownTaskId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.numericUpDownTaskId.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownTaskId.ForeColor = System.Drawing.Color.LemonChiffon;
            this.numericUpDownTaskId.Location = new System.Drawing.Point(696, 26);
            this.numericUpDownTaskId.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDownTaskId.Name = "numericUpDownTaskId";
            this.numericUpDownTaskId.Size = new System.Drawing.Size(96, 29);
            this.numericUpDownTaskId.TabIndex = 73;
            this.numericUpDownTaskId.Value = new decimal(new int[] {
            64,
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
            this.iconButtonAccept.TabIndex = 70;
            this.iconButtonAccept.Text = "Accept";
            this.iconButtonAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAccept.UseVisualStyleBackColor = false;
            // 
            // comboBoxTaskUserAuthor
            // 
            this.comboBoxTaskUserAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.comboBoxTaskUserAuthor.DataSource = this.usersBindingSource;
            this.comboBoxTaskUserAuthor.DisplayMember = "user_name";
            this.comboBoxTaskUserAuthor.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBoxTaskUserAuthor.ForeColor = System.Drawing.Color.LemonChiffon;
            this.comboBoxTaskUserAuthor.FormattingEnabled = true;
            this.comboBoxTaskUserAuthor.Location = new System.Drawing.Point(924, 291);
            this.comboBoxTaskUserAuthor.Name = "comboBoxTaskUserAuthor";
            this.comboBoxTaskUserAuthor.Size = new System.Drawing.Size(179, 30);
            this.comboBoxTaskUserAuthor.TabIndex = 68;
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
            this.numericUpDownTime.TabIndex = 66;
            this.numericUpDownTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
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
            this.numericUpDownMemory.TabIndex = 65;
            this.numericUpDownMemory.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 41;
            this.iconPictureBox3.Location = new System.Drawing.Point(643, 21);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(53, 41);
            this.iconPictureBox3.TabIndex = 72;
            this.iconPictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxStatement);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.OldLace;
            this.groupBox1.Location = new System.Drawing.Point(48, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 417);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Code";
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
            // iconAuthor
            // 
            this.iconAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconAuthor.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconAuthor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconAuthor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAuthor.IconSize = 41;
            this.iconAuthor.Location = new System.Drawing.Point(870, 281);
            this.iconAuthor.Name = "iconAuthor";
            this.iconAuthor.Size = new System.Drawing.Size(53, 41);
            this.iconAuthor.TabIndex = 59;
            this.iconAuthor.TabStop = false;
            // 
            // iconTime
            // 
            this.iconTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconTime.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconTime.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconTime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTime.IconSize = 41;
            this.iconTime.Location = new System.Drawing.Point(870, 141);
            this.iconTime.Name = "iconTime";
            this.iconTime.Size = new System.Drawing.Size(53, 41);
            this.iconTime.TabIndex = 58;
            this.iconTime.TabStop = false;
            // 
            // iconMemory
            // 
            this.iconMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconMemory.IconChar = FontAwesome.Sharp.IconChar.Memory;
            this.iconMemory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconMemory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMemory.IconSize = 41;
            this.iconMemory.Location = new System.Drawing.Point(870, 77);
            this.iconMemory.Name = "iconMemory";
            this.iconMemory.Size = new System.Drawing.Size(53, 41);
            this.iconMemory.TabIndex = 57;
            this.iconMemory.TabStop = false;
            // 
            // labelTaskSpace
            // 
            this.labelTaskSpace.AutoSize = true;
            this.labelTaskSpace.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskSpace.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelTaskSpace.Location = new System.Drawing.Point(1025, 82);
            this.labelTaskSpace.Name = "labelTaskSpace";
            this.labelTaskSpace.Size = new System.Drawing.Size(46, 25);
            this.labelTaskSpace.TabIndex = 61;
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
            this.labelTaskTime.TabIndex = 60;
            this.labelTaskTime.Text = "ms";
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
            this.iconButtonBack.TabIndex = 64;
            this.iconButtonBack.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 41;
            this.iconPictureBox2.Location = new System.Drawing.Point(870, 345);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(53, 41);
            this.iconPictureBox2.TabIndex = 63;
            this.iconPictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(323, 33);
            this.comboBox1.TabIndex = 75;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Gavel;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 41;
            this.iconPictureBox1.Location = new System.Drawing.Point(870, 210);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(53, 41);
            this.iconPictureBox1.TabIndex = 62;
            this.iconPictureBox1.TabStop = false;
            // 
            // comboBoxVerdict
            // 
            this.comboBoxVerdict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.comboBoxVerdict.DataSource = this.verdictsBindingSource;
            this.comboBoxVerdict.DisplayMember = "is_ok";
            this.comboBoxVerdict.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBoxVerdict.ForeColor = System.Drawing.Color.LemonChiffon;
            this.comboBoxVerdict.FormattingEnabled = true;
            this.comboBoxVerdict.Location = new System.Drawing.Point(924, 221);
            this.comboBoxVerdict.Name = "comboBoxVerdict";
            this.comboBoxVerdict.Size = new System.Drawing.Size(179, 30);
            this.comboBoxVerdict.TabIndex = 76;
            // 
            // comboBoxCompiler
            // 
            this.comboBoxCompiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.comboBoxCompiler.DataSource = this.compilersBindingSource;
            this.comboBoxCompiler.DisplayMember = "name";
            this.comboBoxCompiler.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBoxCompiler.ForeColor = System.Drawing.Color.LemonChiffon;
            this.comboBoxCompiler.FormattingEnabled = true;
            this.comboBoxCompiler.Location = new System.Drawing.Point(924, 356);
            this.comboBoxCompiler.Name = "comboBoxCompiler";
            this.comboBoxCompiler.Size = new System.Drawing.Size(179, 30);
            this.comboBoxCompiler.TabIndex = 77;
            // 
            // ideaCodeDataSet
            // 
            this.ideaCodeDataSet.DataSetName = "IdeaCodeDataSet";
            this.ideaCodeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verdictsBindingSource
            // 
            this.verdictsBindingSource.DataMember = "Verdicts";
            this.verdictsBindingSource.DataSource = this.ideaCodeDataSet;
            // 
            // verdictsTableAdapter
            // 
            this.verdictsTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(880, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 78;
            // 
            // verdictsBindingSource1
            // 
            this.verdictsBindingSource1.DataMember = "Verdicts";
            this.verdictsBindingSource1.DataSource = this.ideaCodeDataSet;
            // 
            // compilersBindingSource
            // 
            this.compilersBindingSource.DataMember = "Compilers";
            this.compilersBindingSource.DataSource = this.ideaCodeDataSet;
            // 
            // compilersTableAdapter
            // 
            this.compilersTableAdapter.ClearBeforeFill = true;
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
            // AddSubmissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1156, 538);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxCompiler);
            this.Controls.Add(this.comboBoxVerdict);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelDatabaseMessages);
            this.Controls.Add(this.numericUpDownTaskId);
            this.Controls.Add(this.iconButtonAccept);
            this.Controls.Add(this.comboBoxTaskUserAuthor);
            this.Controls.Add(this.numericUpDownTime);
            this.Controls.Add(this.numericUpDownMemory);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconAuthor);
            this.Controls.Add(this.iconTime);
            this.Controls.Add(this.iconMemory);
            this.Controls.Add(this.labelTaskSpace);
            this.Controls.Add(this.labelTaskTime);
            this.Controls.Add(this.iconButtonBack);
            this.Controls.Add(this.iconPictureBox2);
            this.Name = "AddSubmissionForm";
            this.Text = "Add Submission";
            this.Load += new System.EventHandler(this.AddSubmissionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaskId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ideaCodeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdictsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdictsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compilersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDatabaseMessages;
        private System.Windows.Forms.NumericUpDown numericUpDownTaskId;
        private FontAwesome.Sharp.IconButton iconButtonAccept;
        private System.Windows.Forms.ComboBox comboBoxTaskUserAuthor;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.NumericUpDown numericUpDownMemory;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxStatement;
        private FontAwesome.Sharp.IconPictureBox iconAuthor;
        private FontAwesome.Sharp.IconPictureBox iconTime;
        private FontAwesome.Sharp.IconPictureBox iconMemory;
        private System.Windows.Forms.Label labelTaskSpace;
        private System.Windows.Forms.Label labelTaskTime;
        private FontAwesome.Sharp.IconButton iconButtonBack;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ComboBox comboBoxVerdict;
        private System.Windows.Forms.ComboBox comboBoxCompiler;
        private IdeaCodeDataSet ideaCodeDataSet;
        private System.Windows.Forms.BindingSource verdictsBindingSource;
        private IdeaCodeDataSetTableAdapters.VerdictsTableAdapter verdictsTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource verdictsBindingSource1;
        private System.Windows.Forms.BindingSource compilersBindingSource;
        private IdeaCodeDataSetTableAdapters.CompilersTableAdapter compilersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private IdeaCodeDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}