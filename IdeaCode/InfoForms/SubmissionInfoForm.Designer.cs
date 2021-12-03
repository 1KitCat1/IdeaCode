
namespace IdeaCode.InfoForms
{
    partial class SubmissionInfoForm
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
            this.labelDownloadInfo = new System.Windows.Forms.Label();
            this.labelErrorMessages = new System.Windows.Forms.Label();
            this.panelConfirmDelete = new System.Windows.Forms.Panel();
            this.labelConfirmDelete = new System.Windows.Forms.Label();
            this.labelSubmissionVerdict = new System.Windows.Forms.Label();
            this.labelSubmissionAuthor = new System.Windows.Forms.Label();
            this.labelTaskSpace = new System.Windows.Forms.Label();
            this.labelTaskTime = new System.Windows.Forms.Label();
            this.labelTaskTitle = new System.Windows.Forms.Label();
            this.richTextBoxCode = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelCompiler = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonDownload = new FontAwesome.Sharp.IconButton();
            this.iconButtonEditTask = new FontAwesome.Sharp.IconButton();
            this.iconButtonConfirmDelete = new FontAwesome.Sharp.IconButton();
            this.iconButtonCancelDelete = new FontAwesome.Sharp.IconButton();
            this.iconButtonDeleteTask = new FontAwesome.Sharp.IconButton();
            this.iconButtonBack = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconAuthor = new FontAwesome.Sharp.IconPictureBox();
            this.iconTime = new FontAwesome.Sharp.IconPictureBox();
            this.iconMemory = new FontAwesome.Sharp.IconPictureBox();
            this.panelConfirmDelete.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDownloadInfo
            // 
            this.labelDownloadInfo.AutoSize = true;
            this.labelDownloadInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDownloadInfo.Location = new System.Drawing.Point(56, 496);
            this.labelDownloadInfo.Name = "labelDownloadInfo";
            this.labelDownloadInfo.Size = new System.Drawing.Size(0, 20);
            this.labelDownloadInfo.TabIndex = 60;
            // 
            // labelErrorMessages
            // 
            this.labelErrorMessages.AutoSize = true;
            this.labelErrorMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorMessages.Location = new System.Drawing.Point(239, 497);
            this.labelErrorMessages.Name = "labelErrorMessages";
            this.labelErrorMessages.Size = new System.Drawing.Size(0, 20);
            this.labelErrorMessages.TabIndex = 57;
            // 
            // panelConfirmDelete
            // 
            this.panelConfirmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConfirmDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.panelConfirmDelete.Controls.Add(this.labelConfirmDelete);
            this.panelConfirmDelete.Controls.Add(this.iconButtonConfirmDelete);
            this.panelConfirmDelete.Controls.Add(this.iconButtonCancelDelete);
            this.panelConfirmDelete.Location = new System.Drawing.Point(650, 10);
            this.panelConfirmDelete.Name = "panelConfirmDelete";
            this.panelConfirmDelete.Size = new System.Drawing.Size(145, 200);
            this.panelConfirmDelete.TabIndex = 56;
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
            // labelSubmissionVerdict
            // 
            this.labelSubmissionVerdict.AutoSize = true;
            this.labelSubmissionVerdict.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubmissionVerdict.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelSubmissionVerdict.Location = new System.Drawing.Point(926, 219);
            this.labelSubmissionVerdict.Name = "labelSubmissionVerdict";
            this.labelSubmissionVerdict.Size = new System.Drawing.Size(44, 25);
            this.labelSubmissionVerdict.TabIndex = 51;
            this.labelSubmissionVerdict.Text = "OK";
            this.labelSubmissionVerdict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSubmissionAuthor
            // 
            this.labelSubmissionAuthor.AutoSize = true;
            this.labelSubmissionAuthor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubmissionAuthor.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelSubmissionAuthor.Location = new System.Drawing.Point(926, 289);
            this.labelSubmissionAuthor.Name = "labelSubmissionAuthor";
            this.labelSubmissionAuthor.Size = new System.Drawing.Size(107, 25);
            this.labelSubmissionAuthor.TabIndex = 49;
            this.labelSubmissionAuthor.Text = "_KitCat_";
            this.labelSubmissionAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTaskSpace
            // 
            this.labelTaskSpace.AutoSize = true;
            this.labelTaskSpace.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskSpace.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelTaskSpace.Location = new System.Drawing.Point(926, 83);
            this.labelTaskSpace.Name = "labelTaskSpace";
            this.labelTaskSpace.Size = new System.Drawing.Size(95, 25);
            this.labelTaskSpace.TabIndex = 48;
            this.labelTaskSpace.Text = "128 MB";
            // 
            // labelTaskTime
            // 
            this.labelTaskTime.AutoSize = true;
            this.labelTaskTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskTime.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelTaskTime.Location = new System.Drawing.Point(927, 147);
            this.labelTaskTime.Name = "labelTaskTime";
            this.labelTaskTime.Size = new System.Drawing.Size(108, 25);
            this.labelTaskTime.TabIndex = 47;
            this.labelTaskTime.Text = "1000 ms";
            // 
            // labelTaskTitle
            // 
            this.labelTaskTitle.AutoSize = true;
            this.labelTaskTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.labelTaskTitle.Location = new System.Drawing.Point(142, 23);
            this.labelTaskTitle.Name = "labelTaskTitle";
            this.labelTaskTitle.Size = new System.Drawing.Size(136, 29);
            this.labelTaskTitle.TabIndex = 43;
            this.labelTaskTitle.Text = "Find max";
            // 
            // richTextBoxCode
            // 
            this.richTextBoxCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.richTextBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxCode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxCode.ForeColor = System.Drawing.Color.LemonChiffon;
            this.richTextBoxCode.Location = new System.Drawing.Point(12, 27);
            this.richTextBoxCode.Name = "richTextBoxCode";
            this.richTextBoxCode.ReadOnly = true;
            this.richTextBoxCode.Size = new System.Drawing.Size(750, 369);
            this.richTextBoxCode.TabIndex = 2;
            this.richTextBoxCode.Text = "print(\"Hello World\")";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxCode);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.OldLace;
            this.groupBox1.Location = new System.Drawing.Point(48, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 417);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Code";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateTime.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelDateTime.Location = new System.Drawing.Point(831, 27);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(237, 25);
            this.labelDateTime.TabIndex = 61;
            this.labelDateTime.Text = "2021-12-03 11:31:58";
            // 
            // labelCompiler
            // 
            this.labelCompiler.AutoSize = true;
            this.labelCompiler.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompiler.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelCompiler.Location = new System.Drawing.Point(926, 350);
            this.labelCompiler.Name = "labelCompiler";
            this.labelCompiler.Size = new System.Drawing.Size(105, 25);
            this.labelCompiler.TabIndex = 63;
            this.labelCompiler.Text = "Python3";
            this.labelCompiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 41;
            this.iconPictureBox2.Location = new System.Drawing.Point(870, 343);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(53, 41);
            this.iconPictureBox2.TabIndex = 62;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconButtonDownload
            // 
            this.iconButtonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconButtonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDownload.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonDownload.ForeColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonDownload.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.iconButtonDownload.IconColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonDownload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDownload.IconSize = 30;
            this.iconButtonDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDownload.Location = new System.Drawing.Point(972, 482);
            this.iconButtonDownload.Name = "iconButtonDownload";
            this.iconButtonDownload.Size = new System.Drawing.Size(172, 45);
            this.iconButtonDownload.TabIndex = 59;
            this.iconButtonDownload.Text = "Download";
            this.iconButtonDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonDownload.UseVisualStyleBackColor = false;
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
            this.iconButtonEditTask.Location = new System.Drawing.Point(486, 14);
            this.iconButtonEditTask.Name = "iconButtonEditTask";
            this.iconButtonEditTask.Size = new System.Drawing.Size(124, 45);
            this.iconButtonEditTask.TabIndex = 58;
            this.iconButtonEditTask.Text = "Edit";
            this.iconButtonEditTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonEditTask.UseVisualStyleBackColor = false;
            this.iconButtonEditTask.Click += new System.EventHandler(this.iconButtonEditTask_Click);
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
            this.iconButtonDeleteTask.Location = new System.Drawing.Point(660, 14);
            this.iconButtonDeleteTask.Name = "iconButtonDeleteTask";
            this.iconButtonDeleteTask.Size = new System.Drawing.Size(124, 45);
            this.iconButtonDeleteTask.TabIndex = 55;
            this.iconButtonDeleteTask.Text = "Delete";
            this.iconButtonDeleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonDeleteTask.UseVisualStyleBackColor = false;
            this.iconButtonDeleteTask.Click += new System.EventHandler(this.iconButtonDeleteTask_Click);
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
            this.iconButtonBack.Location = new System.Drawing.Point(12, 26);
            this.iconButtonBack.Name = "iconButtonBack";
            this.iconButtonBack.Size = new System.Drawing.Size(50, 33);
            this.iconButtonBack.TabIndex = 54;
            this.iconButtonBack.UseVisualStyleBackColor = true;
            this.iconButtonBack.Click += new System.EventHandler(this.iconButtonBack_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Gavel;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 41;
            this.iconPictureBox1.Location = new System.Drawing.Point(870, 211);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(53, 41);
            this.iconPictureBox1.TabIndex = 50;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconAuthor
            // 
            this.iconAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.iconAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconAuthor.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconAuthor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconAuthor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAuthor.IconSize = 41;
            this.iconAuthor.Location = new System.Drawing.Point(870, 282);
            this.iconAuthor.Name = "iconAuthor";
            this.iconAuthor.Size = new System.Drawing.Size(53, 41);
            this.iconAuthor.TabIndex = 46;
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
            this.iconTime.Location = new System.Drawing.Point(870, 142);
            this.iconTime.Name = "iconTime";
            this.iconTime.Size = new System.Drawing.Size(53, 41);
            this.iconTime.TabIndex = 45;
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
            this.iconMemory.Location = new System.Drawing.Point(870, 78);
            this.iconMemory.Name = "iconMemory";
            this.iconMemory.Size = new System.Drawing.Size(53, 41);
            this.iconMemory.TabIndex = 44;
            this.iconMemory.TabStop = false;
            // 
            // SubmissionInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1156, 538);
            this.Controls.Add(this.labelCompiler);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelDownloadInfo);
            this.Controls.Add(this.iconButtonDownload);
            this.Controls.Add(this.iconButtonEditTask);
            this.Controls.Add(this.labelErrorMessages);
            this.Controls.Add(this.panelConfirmDelete);
            this.Controls.Add(this.iconButtonDeleteTask);
            this.Controls.Add(this.iconButtonBack);
            this.Controls.Add(this.labelSubmissionVerdict);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.labelSubmissionAuthor);
            this.Controls.Add(this.labelTaskSpace);
            this.Controls.Add(this.labelTaskTime);
            this.Controls.Add(this.iconAuthor);
            this.Controls.Add(this.iconTime);
            this.Controls.Add(this.iconMemory);
            this.Controls.Add(this.labelTaskTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubmissionInfoForm";
            this.Text = "Submission Info";
            this.panelConfirmDelete.ResumeLayout(false);
            this.panelConfirmDelete.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMemory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDownloadInfo;
        private FontAwesome.Sharp.IconButton iconButtonDownload;
        private FontAwesome.Sharp.IconButton iconButtonEditTask;
        private System.Windows.Forms.Label labelErrorMessages;
        private System.Windows.Forms.Panel panelConfirmDelete;
        private System.Windows.Forms.Label labelConfirmDelete;
        private FontAwesome.Sharp.IconButton iconButtonConfirmDelete;
        private FontAwesome.Sharp.IconButton iconButtonCancelDelete;
        private FontAwesome.Sharp.IconButton iconButtonDeleteTask;
        private FontAwesome.Sharp.IconButton iconButtonBack;
        private System.Windows.Forms.Label labelSubmissionVerdict;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelSubmissionAuthor;
        private System.Windows.Forms.Label labelTaskSpace;
        private System.Windows.Forms.Label labelTaskTime;
        private FontAwesome.Sharp.IconPictureBox iconAuthor;
        private FontAwesome.Sharp.IconPictureBox iconTime;
        private FontAwesome.Sharp.IconPictureBox iconMemory;
        private System.Windows.Forms.Label labelTaskTitle;
        private System.Windows.Forms.RichTextBox richTextBoxCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelCompiler;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}