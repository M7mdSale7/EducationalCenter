
namespace EducationalCenter
{
    partial class UserControl1M
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
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCloseChildForm = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonAccounts = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.buttonEmployeesReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.labelname);
            this.panelDesktopPane.Controls.Add(this.pictureBoxStudent);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(580, 570);
            this.panelDesktopPane.TabIndex = 5;
            // 
            // labelname
            // 
            this.labelname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.labelname.Location = new System.Drawing.Point(40, 129);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(0, 26);
            this.labelname.TabIndex = 17;
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxStudent.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStudent.Image = global::EducationalCenter.Properties.Resources.Manager;
            this.pictureBoxStudent.Location = new System.Drawing.Point(413, 50);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(94, 105);
            this.pictureBoxStudent.TabIndex = 16;
            this.pictureBoxStudent.TabStop = false;
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
            this.panelTitleBar.TabIndex = 4;
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
            this.panelMenu.Controls.Add(this.buttonAccounts);
            this.panelMenu.Controls.Add(this.buttonEmployees);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 650);
            this.panelMenu.TabIndex = 3;
            // 
            // buttonAccounts
            // 
            this.buttonAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAccounts.FlatAppearance.BorderSize = 0;
            this.buttonAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccounts.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAccounts.Image = global::EducationalCenter.Properties.Resources._015_book;
            this.buttonAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccounts.Location = new System.Drawing.Point(0, 140);
            this.buttonAccounts.Name = "buttonAccounts";
            this.buttonAccounts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonAccounts.Size = new System.Drawing.Size(220, 60);
            this.buttonAccounts.TabIndex = 2;
            this.buttonAccounts.Text = "  Accounts";
            this.buttonAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAccounts.UseVisualStyleBackColor = true;
            this.buttonAccounts.Click += new System.EventHandler(this.buttonAccounts_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmployees.FlatAppearance.BorderSize = 0;
            this.buttonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployees.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEmployees.Image = global::EducationalCenter.Properties.Resources._090_entrepeneur;
            this.buttonEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.Location = new System.Drawing.Point(0, 80);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonEmployees.Size = new System.Drawing.Size(220, 60);
            this.buttonEmployees.TabIndex = 1;
            this.buttonEmployees.Text = "  Employees";
            this.buttonEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonEmployeesReport
            // 
            this.buttonEmployeesReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEmployeesReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEmployeesReport.Location = new System.Drawing.Point(273, 318);
            this.buttonEmployeesReport.Name = "buttonEmployeesReport";
            this.buttonEmployeesReport.Size = new System.Drawing.Size(86, 43);
            this.buttonEmployeesReport.TabIndex = 11;
            this.buttonEmployeesReport.Text = "Employees Report";
            this.buttonEmployeesReport.UseVisualStyleBackColor = false;
            //this.buttonEmployeesReport.Click += new System.EventHandler(this.buttonEmployeesReport_Click);
            // 
            // UserControl1M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "UserControl1M";
            this.Size = new System.Drawing.Size(800, 650);
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCloseChildForm;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonAccounts;
        private System.Windows.Forms.Button buttonEmployeesReport;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Panel panelLogo;
    }
}
