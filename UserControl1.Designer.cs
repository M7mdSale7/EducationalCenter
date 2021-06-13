
namespace EducationalCenter
{
    partial class UserControl1
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
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.labelname = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogIn2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogIn = new System.Windows.Forms.PictureBox();
            this.buttonCloseChildForm = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelZC = new System.Windows.Forms.Label();
            this.panelDesktopPane.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogIn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.pictureBoxLogIn2);
            this.panelDesktopPane.Controls.Add(this.pictureBoxLogIn);
            this.panelDesktopPane.Controls.Add(this.labelname);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(580, 570);
            this.panelDesktopPane.TabIndex = 8;
            // 
            // labelname
            // 
            this.labelname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.labelname.Location = new System.Drawing.Point(207, 89);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(0, 31);
            this.labelname.TabIndex = 17;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.buttonMinimize);
            this.panelTitleBar.Controls.Add(this.buttonMaximize);
            this.panelTitleBar.Controls.Add(this.buttonClose);
            this.panelTitleBar.Controls.Add(this.buttonCloseChildForm);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(580, 80);
            this.panelTitleBar.TabIndex = 7;
            this.panelTitleBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDoubleClick);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(502, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(26, 80);
            this.buttonMinimize.TabIndex = 4;
            this.buttonMinimize.Text = "O";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaximize.ForeColor = System.Drawing.Color.White;
            this.buttonMaximize.Location = new System.Drawing.Point(528, 0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(26, 80);
            this.buttonMaximize.TabIndex = 3;
            this.buttonMaximize.Text = "O";
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(554, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(26, 80);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "O";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(250, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(78, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonChangePassword);
            this.panelMenu.Controls.Add(this.buttonLogin);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 650);
            this.panelMenu.TabIndex = 6;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.labelZC);
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogIn2
            // 
            this.pictureBoxLogIn2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogIn2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxLogIn2.Image = global::EducationalCenter.Properties.Resources.Education2;
            this.pictureBoxLogIn2.InitialImage = global::EducationalCenter.Properties.Resources.Education;
            this.pictureBoxLogIn2.Location = new System.Drawing.Point(473, 0);
            this.pictureBoxLogIn2.Name = "pictureBoxLogIn2";
            this.pictureBoxLogIn2.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.pictureBoxLogIn2.Size = new System.Drawing.Size(107, 570);
            this.pictureBoxLogIn2.TabIndex = 24;
            this.pictureBoxLogIn2.TabStop = false;
            // 
            // pictureBoxLogIn
            // 
            this.pictureBoxLogIn.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogIn.Image = global::EducationalCenter.Properties.Resources.Education;
            this.pictureBoxLogIn.InitialImage = global::EducationalCenter.Properties.Resources.Education;
            this.pictureBoxLogIn.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogIn.Name = "pictureBoxLogIn";
            this.pictureBoxLogIn.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.pictureBoxLogIn.Size = new System.Drawing.Size(107, 570);
            this.pictureBoxLogIn.TabIndex = 23;
            this.pictureBoxLogIn.TabStop = false;
            // 
            // buttonCloseChildForm
            // 
            this.buttonCloseChildForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseChildForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseChildForm.Image = global::EducationalCenter.Properties.Resources.x;
            this.buttonCloseChildForm.Location = new System.Drawing.Point(6, 14);
            this.buttonCloseChildForm.Name = "buttonCloseChildForm";
            this.buttonCloseChildForm.Size = new System.Drawing.Size(54, 45);
            this.buttonCloseChildForm.TabIndex = 1;
            this.buttonCloseChildForm.UseVisualStyleBackColor = false;
            this.buttonCloseChildForm.Click += new System.EventHandler(this.buttonCloseChildForm_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChangePassword.FlatAppearance.BorderSize = 0;
            this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonChangePassword.Image = global::EducationalCenter.Properties.Resources._044_plumbing;
            this.buttonChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangePassword.Location = new System.Drawing.Point(0, 140);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonChangePassword.Size = new System.Drawing.Size(220, 60);
            this.buttonChangePassword.TabIndex = 2;
            this.buttonChangePassword.Text = "  Change password";
            this.buttonChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogin.Image = global::EducationalCenter.Properties.Resources._090_entrepeneur;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(0, 80);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonLogin.Size = new System.Drawing.Size(220, 60);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "  Log in";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::EducationalCenter.Properties.Resources.ZC;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelZC
            // 
            this.labelZC.AutoSize = true;
            this.labelZC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZC.ForeColor = System.Drawing.Color.White;
            this.labelZC.Location = new System.Drawing.Point(86, 30);
            this.labelZC.Name = "labelZC";
            this.labelZC.Size = new System.Drawing.Size(111, 24);
            this.labelZC.TabIndex = 1;
            this.labelZC.Text = "Zewail City";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 650);
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogIn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCloseChildForm;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogIn;
        private System.Windows.Forms.PictureBox pictureBoxLogIn2;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelZC;
    }
}
