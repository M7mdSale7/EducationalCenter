
namespace EducationalCenter
{
    partial class UserControl1E
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
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCloseChildForm = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonStudentReservation = new System.Windows.Forms.Button();
            this.buttonStudy = new System.Windows.Forms.Button();
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonParents = new System.Windows.Forms.Button();
            this.buttonSubjects = new System.Windows.Forms.Button();
            this.buttonExams = new System.Windows.Forms.Button();
            this.buttonRooms = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonLessons = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelZC = new System.Windows.Forms.Label();
            this.buttonRoomsReport = new System.Windows.Forms.Button();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.labelname);
            this.panelDesktopPane.Controls.Add(this.pictureBoxEmployee);
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
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEmployee.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEmployee.Image = global::EducationalCenter.Properties.Resources.Employee;
            this.pictureBoxEmployee.Location = new System.Drawing.Point(413, 50);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(94, 106);
            this.pictureBoxEmployee.TabIndex = 16;
            this.pictureBoxEmployee.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.labelLogOut);
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
            this.buttonCloseChildForm.Location = new System.Drawing.Point(3, 35);
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
            this.panelMenu.Controls.Add(this.buttonStudentReservation);
            this.panelMenu.Controls.Add(this.buttonStudy);
            this.panelMenu.Controls.Add(this.buttonTeachers);
            this.panelMenu.Controls.Add(this.buttonParents);
            this.panelMenu.Controls.Add(this.buttonSubjects);
            this.panelMenu.Controls.Add(this.buttonExams);
            this.panelMenu.Controls.Add(this.buttonRooms);
            this.panelMenu.Controls.Add(this.buttonStudents);
            this.panelMenu.Controls.Add(this.buttonLessons);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 650);
            this.panelMenu.TabIndex = 3;
            // 
            // buttonStudentReservation
            // 
            this.buttonStudentReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudentReservation.FlatAppearance.BorderSize = 0;
            this.buttonStudentReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentReservation.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStudentReservation.Image = global::EducationalCenter.Properties.Resources._041_document;
            this.buttonStudentReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentReservation.Location = new System.Drawing.Point(0, 560);
            this.buttonStudentReservation.Name = "buttonStudentReservation";
            this.buttonStudentReservation.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonStudentReservation.Size = new System.Drawing.Size(220, 60);
            this.buttonStudentReservation.TabIndex = 9;
            this.buttonStudentReservation.Text = "  Student Reservation";
            this.buttonStudentReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudentReservation.UseVisualStyleBackColor = true;
            this.buttonStudentReservation.Click += new System.EventHandler(this.buttonStudentReservation_Click);
            // 
            // buttonStudy
            // 
            this.buttonStudy.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudy.FlatAppearance.BorderSize = 0;
            this.buttonStudy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudy.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStudy.Image = global::EducationalCenter.Properties.Resources._055_whiteboard;
            this.buttonStudy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudy.Location = new System.Drawing.Point(0, 500);
            this.buttonStudy.Name = "buttonStudy";
            this.buttonStudy.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonStudy.Size = new System.Drawing.Size(220, 60);
            this.buttonStudy.TabIndex = 8;
            this.buttonStudy.Text = "  Study";
            this.buttonStudy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudy.UseVisualStyleBackColor = true;
            this.buttonStudy.Click += new System.EventHandler(this.buttonStudy_Click);
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTeachers.FlatAppearance.BorderSize = 0;
            this.buttonTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeachers.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTeachers.Image = global::EducationalCenter.Properties.Resources._040_document;
            this.buttonTeachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTeachers.Location = new System.Drawing.Point(0, 440);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonTeachers.Size = new System.Drawing.Size(220, 60);
            this.buttonTeachers.TabIndex = 7;
            this.buttonTeachers.Text = "  Teachers";
            this.buttonTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTeachers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTeachers.UseVisualStyleBackColor = true;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // buttonParents
            // 
            this.buttonParents.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonParents.FlatAppearance.BorderSize = 0;
            this.buttonParents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParents.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonParents.Image = global::EducationalCenter.Properties.Resources._005_dna;
            this.buttonParents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonParents.Location = new System.Drawing.Point(0, 380);
            this.buttonParents.Name = "buttonParents";
            this.buttonParents.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonParents.Size = new System.Drawing.Size(220, 60);
            this.buttonParents.TabIndex = 6;
            this.buttonParents.Text = "  Parents";
            this.buttonParents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonParents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonParents.UseVisualStyleBackColor = true;
            this.buttonParents.Click += new System.EventHandler(this.buttonParents_Click);
            // 
            // buttonSubjects
            // 
            this.buttonSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSubjects.FlatAppearance.BorderSize = 0;
            this.buttonSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubjects.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSubjects.Image = global::EducationalCenter.Properties.Resources._004_flasks;
            this.buttonSubjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubjects.Location = new System.Drawing.Point(0, 320);
            this.buttonSubjects.Name = "buttonSubjects";
            this.buttonSubjects.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonSubjects.Size = new System.Drawing.Size(220, 60);
            this.buttonSubjects.TabIndex = 5;
            this.buttonSubjects.Text = "  Subjects";
            this.buttonSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSubjects.UseVisualStyleBackColor = true;
            this.buttonSubjects.Click += new System.EventHandler(this.buttonSubjects_Click);
            // 
            // buttonExams
            // 
            this.buttonExams.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExams.FlatAppearance.BorderSize = 0;
            this.buttonExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExams.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonExams.Image = global::EducationalCenter.Properties.Resources._015_book;
            this.buttonExams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExams.Location = new System.Drawing.Point(0, 260);
            this.buttonExams.Name = "buttonExams";
            this.buttonExams.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonExams.Size = new System.Drawing.Size(220, 60);
            this.buttonExams.TabIndex = 4;
            this.buttonExams.Text = "  Exams";
            this.buttonExams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExams.UseVisualStyleBackColor = true;
            this.buttonExams.Click += new System.EventHandler(this.buttonExams_Click);
            // 
            // buttonRooms
            // 
            this.buttonRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRooms.FlatAppearance.BorderSize = 0;
            this.buttonRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRooms.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRooms.Image = global::EducationalCenter.Properties.Resources._065_warehouse;
            this.buttonRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRooms.Location = new System.Drawing.Point(0, 200);
            this.buttonRooms.Name = "buttonRooms";
            this.buttonRooms.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonRooms.Size = new System.Drawing.Size(220, 60);
            this.buttonRooms.TabIndex = 3;
            this.buttonRooms.Text = "  Rooms";
            this.buttonRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRooms.UseVisualStyleBackColor = true;
            this.buttonRooms.Click += new System.EventHandler(this.buttonRooms_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudents.FlatAppearance.BorderSize = 0;
            this.buttonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudents.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStudents.Image = global::EducationalCenter.Properties.Resources._090_entrepeneur;
            this.buttonStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudents.Location = new System.Drawing.Point(0, 140);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonStudents.Size = new System.Drawing.Size(220, 60);
            this.buttonStudents.TabIndex = 2;
            this.buttonStudents.Text = "  Students";
            this.buttonStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonLessons
            // 
            this.buttonLessons.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLessons.FlatAppearance.BorderSize = 0;
            this.buttonLessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLessons.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLessons.Image = global::EducationalCenter.Properties.Resources._001_book;
            this.buttonLessons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLessons.Location = new System.Drawing.Point(0, 80);
            this.buttonLessons.Name = "buttonLessons";
            this.buttonLessons.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonLessons.Size = new System.Drawing.Size(220, 60);
            this.buttonLessons.TabIndex = 1;
            this.buttonLessons.Text = "Lessons";
            this.buttonLessons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLessons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLessons.UseVisualStyleBackColor = true;
            this.buttonLessons.Click += new System.EventHandler(this.buttonLessons_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Controls.Add(this.labelZC);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::EducationalCenter.Properties.Resources.ZC;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelZC
            // 
            this.labelZC.AutoSize = true;
            this.labelZC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZC.ForeColor = System.Drawing.Color.White;
            this.labelZC.Location = new System.Drawing.Point(86, 27);
            this.labelZC.Name = "labelZC";
            this.labelZC.Size = new System.Drawing.Size(111, 24);
            this.labelZC.TabIndex = 2;
            this.labelZC.Text = "Zewail City";
            // 
            // buttonRoomsReport
            // 
            this.buttonRoomsReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRoomsReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRoomsReport.Location = new System.Drawing.Point(171, 353);
            this.buttonRoomsReport.Name = "buttonRoomsReport";
            this.buttonRoomsReport.Size = new System.Drawing.Size(86, 43);
            this.buttonRoomsReport.TabIndex = 27;
            this.buttonRoomsReport.Text = "Rooms Report";
            this.buttonRoomsReport.UseVisualStyleBackColor = true;
            this.buttonRoomsReport.Click += new System.EventHandler(this.buttonRoomsReport_Click);
            // 
            // labelLogOut
            // 
            this.labelLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.Color.White;
            this.labelLogOut.Location = new System.Drawing.Point(6, 6);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(63, 20);
            this.labelLogOut.TabIndex = 18;
            this.labelLogOut.Text = "Log out";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // UserControl1E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "UserControl1E";
            this.Size = new System.Drawing.Size(800, 650);
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonRoomsReport;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCloseChildForm;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonRooms;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonLessons;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonStudentReservation;
        private System.Windows.Forms.Button buttonStudy;
        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonParents;
        private System.Windows.Forms.Button buttonSubjects;
        private System.Windows.Forms.Button buttonExams;
        private System.Windows.Forms.Label labelZC;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelLogOut;
    }
}
