
namespace IdeaCode.ChildForms
{
    partial class ChildFormUsers
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
            this.flowLayoutPanelUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonAddUser = new FontAwesome.Sharp.IconButton();
            this.iconButtonFilter = new FontAwesome.Sharp.IconButton();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.iconButtonApply = new FontAwesome.Sharp.IconButton();
            this.iconButtonClear = new FontAwesome.Sharp.IconButton();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.iconPictureBoxSortOrder = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelOrganisation = new System.Windows.Forms.Label();
            this.textBoxOrganisation = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelSolved = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSortOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelUsers
            // 
            this.flowLayoutPanelUsers.AutoScroll = true;
            this.flowLayoutPanelUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelUsers.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelUsers.Name = "flowLayoutPanelUsers";
            this.flowLayoutPanelUsers.Size = new System.Drawing.Size(1156, 538);
            this.flowLayoutPanelUsers.TabIndex = 0;
            this.flowLayoutPanelUsers.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelUsers_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelFilter);
            this.panel1.Controls.Add(this.iconButtonFilter);
            this.panel1.Controls.Add(this.iconButtonAddUser);
            this.panel1.Controls.Add(this.panelButtons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(936, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 538);
            this.panel1.TabIndex = 1;
            // 
            // iconButtonAddUser
            // 
            this.iconButtonAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconButtonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddUser.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonAddUser.ForeColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonAddUser.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAddUser.IconColor = System.Drawing.Color.LemonChiffon;
            this.iconButtonAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddUser.IconSize = 30;
            this.iconButtonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddUser.Location = new System.Drawing.Point(79, 24);
            this.iconButtonAddUser.Name = "iconButtonAddUser";
            this.iconButtonAddUser.Size = new System.Drawing.Size(129, 45);
            this.iconButtonAddUser.TabIndex = 0;
            this.iconButtonAddUser.Text = "Add";
            this.iconButtonAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAddUser.UseVisualStyleBackColor = false;
            this.iconButtonAddUser.Click += new System.EventHandler(this.iconButtonAddUser_Click);
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
            this.iconButtonFilter.TabIndex = 1;
            this.iconButtonFilter.Text = "Filter";
            this.iconButtonFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonFilter.UseVisualStyleBackColor = false;
            this.iconButtonFilter.Click += new System.EventHandler(this.iconButtonFilter_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(220, 145);
            this.panelButtons.TabIndex = 2;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.panelFilter.Controls.Add(this.labelSolved);
            this.panelFilter.Controls.Add(this.numericUpDown1);
            this.panelFilter.Controls.Add(this.labelOrganisation);
            this.panelFilter.Controls.Add(this.textBoxOrganisation);
            this.panelFilter.Controls.Add(this.labelUserName);
            this.panelFilter.Controls.Add(this.textBoxUserName);
            this.panelFilter.Controls.Add(this.iconPictureBoxSortOrder);
            this.panelFilter.Controls.Add(this.labelSort);
            this.panelFilter.Controls.Add(this.comboBoxSortBy);
            this.panelFilter.Controls.Add(this.iconButtonClear);
            this.panelFilter.Controls.Add(this.iconButtonApply);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilter.Location = new System.Drawing.Point(0, 145);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(220, 393);
            this.panelFilter.TabIndex = 3;
            // 
            // iconButtonApply
            // 
            this.iconButtonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconButtonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonApply.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(254)))), ((int)(((byte)(152)))));
            this.iconButtonApply.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.iconButtonApply.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(254)))), ((int)(((byte)(152)))));
            this.iconButtonApply.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonApply.IconSize = 30;
            this.iconButtonApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonApply.Location = new System.Drawing.Point(107, 336);
            this.iconButtonApply.Name = "iconButtonApply";
            this.iconButtonApply.Size = new System.Drawing.Size(101, 45);
            this.iconButtonApply.TabIndex = 4;
            this.iconButtonApply.Text = "Apply";
            this.iconButtonApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonApply.UseVisualStyleBackColor = false;
            this.iconButtonApply.Click += new System.EventHandler(this.iconButtonApply_Click);
            // 
            // iconButtonClear
            // 
            this.iconButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClear.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(76)))));
            this.iconButtonClear.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButtonClear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(76)))));
            this.iconButtonClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClear.IconSize = 30;
            this.iconButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClear.Location = new System.Drawing.Point(3, 336);
            this.iconButtonClear.Name = "iconButtonClear";
            this.iconButtonClear.Size = new System.Drawing.Size(101, 45);
            this.iconButtonClear.TabIndex = 5;
            this.iconButtonClear.Text = "Clear";
            this.iconButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonClear.UseVisualStyleBackColor = false;
            this.iconButtonClear.Click += new System.EventHandler(this.iconButtonClear_Click);
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.comboBoxSortBy.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSortBy.ForeColor = System.Drawing.Color.LemonChiffon;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "id_user",
            "user_name",
            "solved",
            "rating"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(3, 45);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(205, 30);
            this.comboBoxSortBy.TabIndex = 6;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSort.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelSort.Location = new System.Drawing.Point(3, 24);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(68, 18);
            this.labelSort.TabIndex = 7;
            this.labelSort.Text = "Sort by";
            this.labelSort.Click += new System.EventHandler(this.labelSort_Click);
            // 
            // iconPictureBoxSortOrder
            // 
            this.iconPictureBoxSortOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.iconPictureBoxSortOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(76)))));
            this.iconPictureBoxSortOrder.IconChar = FontAwesome.Sharp.IconChar.SortAmountUp;
            this.iconPictureBoxSortOrder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(76)))));
            this.iconPictureBoxSortOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSortOrder.IconSize = 33;
            this.iconPictureBoxSortOrder.Location = new System.Drawing.Point(169, 6);
            this.iconPictureBoxSortOrder.Name = "iconPictureBoxSortOrder";
            this.iconPictureBoxSortOrder.Size = new System.Drawing.Size(39, 33);
            this.iconPictureBoxSortOrder.TabIndex = 8;
            this.iconPictureBoxSortOrder.TabStop = false;
            this.iconPictureBoxSortOrder.Click += new System.EventHandler(this.iconPictureBoxSortOrder_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.textBoxUserName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserName.ForeColor = System.Drawing.Color.LemonChiffon;
            this.textBoxUserName.Location = new System.Drawing.Point(3, 103);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(205, 29);
            this.textBoxUserName.TabIndex = 9;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserName.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelUserName.Location = new System.Drawing.Point(3, 82);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(92, 18);
            this.labelUserName.TabIndex = 10;
            this.labelUserName.Text = "Username";
            // 
            // labelOrganisation
            // 
            this.labelOrganisation.AutoSize = true;
            this.labelOrganisation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrganisation.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelOrganisation.Location = new System.Drawing.Point(3, 139);
            this.labelOrganisation.Name = "labelOrganisation";
            this.labelOrganisation.Size = new System.Drawing.Size(112, 18);
            this.labelOrganisation.TabIndex = 12;
            this.labelOrganisation.Text = "Organisation";
            // 
            // textBoxOrganisation
            // 
            this.textBoxOrganisation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.textBoxOrganisation.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOrganisation.ForeColor = System.Drawing.Color.LemonChiffon;
            this.textBoxOrganisation.Location = new System.Drawing.Point(3, 160);
            this.textBoxOrganisation.Name = "textBoxOrganisation";
            this.textBoxOrganisation.Size = new System.Drawing.Size(205, 29);
            this.textBoxOrganisation.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.numericUpDown1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.numericUpDown1.Location = new System.Drawing.Point(6, 235);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 29);
            this.numericUpDown1.TabIndex = 13;
            // 
            // labelSolved
            // 
            this.labelSolved.AutoSize = true;
            this.labelSolved.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSolved.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelSolved.Location = new System.Drawing.Point(3, 192);
            this.labelSolved.Name = "labelSolved";
            this.labelSolved.Size = new System.Drawing.Size(112, 18);
            this.labelSolved.TabIndex = 14;
            this.labelSolved.Text = "Organisation";
            // 
            // ChildFormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1156, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelUsers);
            this.Name = "ChildFormUsers";
            this.Text = "Users";
            this.panel1.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSortOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUsers;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonAddUser;
        private System.Windows.Forms.Panel panelFilter;
        private FontAwesome.Sharp.IconButton iconButtonApply;
        private FontAwesome.Sharp.IconButton iconButtonFilter;
        private System.Windows.Forms.Panel panelButtons;
        private FontAwesome.Sharp.IconButton iconButtonClear;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSortOrder;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelOrganisation;
        private System.Windows.Forms.TextBox textBoxOrganisation;
        private System.Windows.Forms.Label labelSolved;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}