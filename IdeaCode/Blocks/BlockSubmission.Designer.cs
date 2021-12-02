
namespace IdeaCode.Blocks
{
    partial class BlockSubmission
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUser = new System.Windows.Forms.Label();
            this.labelOrganisation = new System.Windows.Forms.Label();
            this.labelSubmissionVerdict = new System.Windows.Forms.Label();
            this.labelSubmissionUser = new System.Windows.Forms.Label();
            this.labelSubmissionTaskName = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelUser.Location = new System.Drawing.Point(55, 54);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(56, 25);
            this.labelUser.TabIndex = 29;
            this.labelUser.Text = "user";
            // 
            // labelOrganisation
            // 
            this.labelOrganisation.AutoSize = true;
            this.labelOrganisation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrganisation.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelOrganisation.Location = new System.Drawing.Point(332, 55);
            this.labelOrganisation.Name = "labelOrganisation";
            this.labelOrganisation.Size = new System.Drawing.Size(80, 25);
            this.labelOrganisation.TabIndex = 27;
            this.labelOrganisation.Text = "verdict";
            // 
            // labelSubmissionVerdict
            // 
            this.labelSubmissionVerdict.AutoSize = true;
            this.labelSubmissionVerdict.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubmissionVerdict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.labelSubmissionVerdict.Location = new System.Drawing.Point(332, 88);
            this.labelSubmissionVerdict.Name = "labelSubmissionVerdict";
            this.labelSubmissionVerdict.Size = new System.Drawing.Size(44, 25);
            this.labelSubmissionVerdict.TabIndex = 26;
            this.labelSubmissionVerdict.Text = "OK";
            // 
            // labelSubmissionUser
            // 
            this.labelSubmissionUser.AutoSize = true;
            this.labelSubmissionUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubmissionUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.labelSubmissionUser.Location = new System.Drawing.Point(54, 89);
            this.labelSubmissionUser.Name = "labelSubmissionUser";
            this.labelSubmissionUser.Size = new System.Drawing.Size(107, 25);
            this.labelSubmissionUser.TabIndex = 24;
            this.labelSubmissionUser.Text = "_KitCat_";
            this.labelSubmissionUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSubmissionTaskName
            // 
            this.labelSubmissionTaskName.AutoSize = true;
            this.labelSubmissionTaskName.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubmissionTaskName.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelSubmissionTaskName.Location = new System.Drawing.Point(61, 15);
            this.labelSubmissionTaskName.Name = "labelSubmissionTaskName";
            this.labelSubmissionTaskName.Size = new System.Drawing.Size(136, 29);
            this.labelSubmissionTaskName.TabIndex = 23;
            this.labelSubmissionTaskName.Text = "Find max";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(22, 15);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 28;
            this.iconPictureBox1.TabStop = false;
            // 
            // BlockSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.labelOrganisation);
            this.Controls.Add(this.labelSubmissionVerdict);
            this.Controls.Add(this.labelSubmissionUser);
            this.Controls.Add(this.labelSubmissionTaskName);
            this.Name = "BlockSubmission";
            this.Size = new System.Drawing.Size(606, 128);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUser;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelOrganisation;
        private System.Windows.Forms.Label labelSubmissionVerdict;
        private System.Windows.Forms.Label labelSubmissionUser;
        private System.Windows.Forms.Label labelSubmissionTaskName;
    }
}
