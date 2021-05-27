
namespace EducationalCenter
{
    partial class Form1TA
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
            this.buttonExams = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.buttonGradesReport = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonViewSchedule = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExams
            // 
            this.buttonExams.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExams.Location = new System.Drawing.Point(426, 260);
            this.buttonExams.Name = "buttonExams";
            this.buttonExams.Size = new System.Drawing.Size(86, 43);
            this.buttonExams.TabIndex = 16;
            this.buttonExams.Text = "Exams";
            this.buttonExams.UseVisualStyleBackColor = true;
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAttendance.Location = new System.Drawing.Point(236, 181);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(86, 43);
            this.buttonAttendance.TabIndex = 15;
            this.buttonAttendance.Text = "Attendance";
            this.buttonAttendance.UseVisualStyleBackColor = true;
            // 
            // buttonGradesReport
            // 
            this.buttonGradesReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGradesReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGradesReport.Location = new System.Drawing.Point(426, 108);
            this.buttonGradesReport.Name = "buttonGradesReport";
            this.buttonGradesReport.Size = new System.Drawing.Size(86, 43);
            this.buttonGradesReport.TabIndex = 14;
            this.buttonGradesReport.Text = "Grades Report";
            this.buttonGradesReport.UseVisualStyleBackColor = true;
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStudents.Location = new System.Drawing.Point(51, 260);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(86, 43);
            this.buttonStudents.TabIndex = 13;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = true;
            // 
            // buttonViewSchedule
            // 
            this.buttonViewSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonViewSchedule.Location = new System.Drawing.Point(51, 108);
            this.buttonViewSchedule.Name = "buttonViewSchedule";
            this.buttonViewSchedule.Size = new System.Drawing.Size(86, 43);
            this.buttonViewSchedule.TabIndex = 12;
            this.buttonViewSchedule.Text = "View Schedule";
            this.buttonViewSchedule.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(502, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(12, 19);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(115, 25);
            this.labelWelcome.TabIndex = 21;
            this.labelWelcome.Text = "Welcome,";
            // 
            // Form1TA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources._52cf2839_f541_4fe6_b077_385373bd2004;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonExams);
            this.Controls.Add(this.buttonAttendance);
            this.Controls.Add(this.buttonGradesReport);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.buttonViewSchedule);
            this.Name = "Form1TA";
            this.Text = "Form1TA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExams;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonGradesReport;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonViewSchedule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelWelcome;
    }
}