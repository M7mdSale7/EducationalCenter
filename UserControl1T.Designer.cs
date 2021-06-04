
namespace EducationalCenter
{
    partial class UserControl1T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1T));
            this.pictureBoxTeacher = new System.Windows.Forms.PictureBox();
            this.buttonExams = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.buttonTeachingAssistants = new System.Windows.Forms.Button();
            this.buttonGradesReport = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonViewSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTeacher
            // 
            this.pictureBoxTeacher.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTeacher.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTeacher.Image")));
            this.pictureBoxTeacher.Location = new System.Drawing.Point(384, 67);
            this.pictureBoxTeacher.Name = "pictureBoxTeacher";
            this.pictureBoxTeacher.Size = new System.Drawing.Size(98, 104);
            this.pictureBoxTeacher.TabIndex = 21;
            this.pictureBoxTeacher.TabStop = false;
            // 
            // buttonExams
            // 
            this.buttonExams.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExams.Location = new System.Drawing.Point(449, 193);
            this.buttonExams.Name = "buttonExams";
            this.buttonExams.Size = new System.Drawing.Size(86, 43);
            this.buttonExams.TabIndex = 20;
            this.buttonExams.Text = "Exams";
            this.buttonExams.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogOut.Location = new System.Drawing.Point(510, 62);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(70, 30);
            this.buttonLogOut.TabIndex = 19;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(20, 67);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(115, 25);
            this.labelWelcome.TabIndex = 18;
            this.labelWelcome.Text = "Welcome,";
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAttendance.Location = new System.Drawing.Point(449, 345);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(86, 43);
            this.buttonAttendance.TabIndex = 17;
            this.buttonAttendance.Text = "Attendance";
            this.buttonAttendance.UseVisualStyleBackColor = true;
            // 
            // buttonTeachingAssistants
            // 
            this.buttonTeachingAssistants.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTeachingAssistants.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTeachingAssistants.Location = new System.Drawing.Point(235, 345);
            this.buttonTeachingAssistants.Name = "buttonTeachingAssistants";
            this.buttonTeachingAssistants.Size = new System.Drawing.Size(86, 43);
            this.buttonTeachingAssistants.TabIndex = 16;
            this.buttonTeachingAssistants.Text = "Teaching Assistants";
            this.buttonTeachingAssistants.UseVisualStyleBackColor = true;
            // 
            // buttonGradesReport
            // 
            this.buttonGradesReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGradesReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGradesReport.Location = new System.Drawing.Point(235, 193);
            this.buttonGradesReport.Name = "buttonGradesReport";
            this.buttonGradesReport.Size = new System.Drawing.Size(86, 43);
            this.buttonGradesReport.TabIndex = 15;
            this.buttonGradesReport.Text = "Grades Report";
            this.buttonGradesReport.UseVisualStyleBackColor = true;
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStudents.Location = new System.Drawing.Point(53, 345);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(86, 43);
            this.buttonStudents.TabIndex = 14;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = true;
            // 
            // buttonViewSchedule
            // 
            this.buttonViewSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonViewSchedule.Location = new System.Drawing.Point(53, 193);
            this.buttonViewSchedule.Name = "buttonViewSchedule";
            this.buttonViewSchedule.Size = new System.Drawing.Size(86, 43);
            this.buttonViewSchedule.TabIndex = 13;
            this.buttonViewSchedule.Text = "View Schedule";
            this.buttonViewSchedule.UseVisualStyleBackColor = true;
            // 
            // UserControl1T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources.Background;
            this.Controls.Add(this.pictureBoxTeacher);
            this.Controls.Add(this.buttonExams);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonAttendance);
            this.Controls.Add(this.buttonTeachingAssistants);
            this.Controls.Add(this.buttonGradesReport);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.buttonViewSchedule);
            this.Name = "UserControl1T";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTeacher;
        private System.Windows.Forms.Button buttonExams;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonTeachingAssistants;
        private System.Windows.Forms.Button buttonGradesReport;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonViewSchedule;
    }
}
