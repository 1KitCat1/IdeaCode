
namespace IdeaCode.AddForms
{
    partial class AddUserForm
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
            this.iconButtonUpload = new FontAwesome.Sharp.IconButton();
            this.pictureBoxUserPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButtonUpload
            // 
            this.iconButtonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUpload.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonUpload.ForeColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonUpload.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.iconButtonUpload.IconColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonUpload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUpload.IconSize = 35;
            this.iconButtonUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUpload.Location = new System.Drawing.Point(51, 286);
            this.iconButtonUpload.Name = "iconButtonUpload";
            this.iconButtonUpload.Size = new System.Drawing.Size(137, 40);
            this.iconButtonUpload.TabIndex = 1;
            this.iconButtonUpload.Text = "Upload ";
            this.iconButtonUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonUpload.UseVisualStyleBackColor = true;
            // 
            // pictureBoxUserPhoto
            // 
            this.pictureBoxUserPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(25)))), ((int)(((byte)(95)))));
            this.pictureBoxUserPhoto.Image = global::IdeaCode.Properties.Resources.LogoBoldBig;
            this.pictureBoxUserPhoto.Location = new System.Drawing.Point(49, 37);
            this.pictureBoxUserPhoto.Name = "pictureBoxUserPhoto";
            this.pictureBoxUserPhoto.Size = new System.Drawing.Size(249, 242);
            this.pictureBoxUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxUserPhoto.TabIndex = 0;
            this.pictureBoxUserPhoto.TabStop = false;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButtonUpload);
            this.Controls.Add(this.pictureBoxUserPhoto);
            this.Name = "AddUserForm";
            this.Text = "Add User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUserPhoto;
        private FontAwesome.Sharp.IconButton iconButtonUpload;
    }
}