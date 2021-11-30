
namespace IdeaCode.Blocks
{
    partial class BlockUser
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.labelOrganisation = new System.Windows.Forms.Label();
            this.labelUserOrganisation = new System.Windows.Forms.Label();
            this.labelRealName = new System.Windows.Forms.Label();
            this.labelUserRating = new System.Windows.Forms.Label();
            this.labelUserNick = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(136)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(136)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(21, 15);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 15;
            this.iconPictureBox1.TabStop = false;
            // 
            // labelOrganisation
            // 
            this.labelOrganisation.AutoSize = true;
            this.labelOrganisation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrganisation.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelOrganisation.Location = new System.Drawing.Point(331, 55);
            this.labelOrganisation.Name = "labelOrganisation";
            this.labelOrganisation.Size = new System.Drawing.Size(135, 25);
            this.labelOrganisation.TabIndex = 14;
            this.labelOrganisation.Text = "organisation";
            this.labelOrganisation.Click += new System.EventHandler(this.labelComplexity_Click);
            // 
            // labelUserOrganisation
            // 
            this.labelUserOrganisation.AutoSize = true;
            this.labelUserOrganisation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserOrganisation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(136)))));
            this.labelUserOrganisation.Location = new System.Drawing.Point(331, 88);
            this.labelUserOrganisation.Name = "labelUserOrganisation";
            this.labelUserOrganisation.Size = new System.Drawing.Size(104, 25);
            this.labelUserOrganisation.TabIndex = 13;
            this.labelUserOrganisation.Text = "KhNURE";
            // 
            // labelRealName
            // 
            this.labelRealName.AutoSize = true;
            this.labelRealName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRealName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(136)))));
            this.labelRealName.Location = new System.Drawing.Point(333, 16);
            this.labelRealName.Name = "labelRealName";
            this.labelRealName.Size = new System.Drawing.Size(159, 25);
            this.labelRealName.TabIndex = 12;
            this.labelRealName.Text = "Denis Riabtsev";
            // 
            // labelUserRating
            // 
            this.labelUserRating.AutoSize = true;
            this.labelUserRating.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(136)))));
            this.labelUserRating.Location = new System.Drawing.Point(53, 89);
            this.labelUserRating.Name = "labelUserRating";
            this.labelUserRating.Size = new System.Drawing.Size(68, 25);
            this.labelUserRating.TabIndex = 11;
            this.labelUserRating.Text = "1745";
            this.labelUserRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserNick
            // 
            this.labelUserNick.AutoSize = true;
            this.labelUserNick.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserNick.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelUserNick.Location = new System.Drawing.Point(60, 15);
            this.labelUserNick.Name = "labelUserNick";
            this.labelUserNick.Size = new System.Drawing.Size(129, 29);
            this.labelUserNick.TabIndex = 10;
            this.labelUserNick.Text = "_KitCat_";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRating.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelRating.Location = new System.Drawing.Point(54, 54);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(71, 25);
            this.labelRating.TabIndex = 20;
            this.labelRating.Text = "rating";
            // 
            // BlockUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.labelOrganisation);
            this.Controls.Add(this.labelUserOrganisation);
            this.Controls.Add(this.labelRealName);
            this.Controls.Add(this.labelUserRating);
            this.Controls.Add(this.labelUserNick);
            this.Name = "BlockUser";
            this.Size = new System.Drawing.Size(606, 128);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BlockUser_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelOrganisation;
        private System.Windows.Forms.Label labelUserOrganisation;
        private System.Windows.Forms.Label labelRealName;
        private System.Windows.Forms.Label labelUserRating;
        private System.Windows.Forms.Label labelUserNick;
        private System.Windows.Forms.Label labelRating;
    }
}
