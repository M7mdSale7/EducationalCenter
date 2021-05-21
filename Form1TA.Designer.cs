
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
            this.buttonViewSchedule = new System.Windows.Forms.Button();
            this.ButtonExamsDates = new System.Windows.Forms.Button();
            this.buttonStudentsInfo = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonGradesReports = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonViewSchedule
            // 
            this.buttonViewSchedule.Location = new System.Drawing.Point(46, 123);
            this.buttonViewSchedule.Name = "buttonViewSchedule";
            this.buttonViewSchedule.Size = new System.Drawing.Size(90, 48);
            this.buttonViewSchedule.TabIndex = 0;
            this.buttonViewSchedule.Text = "View Schedule";
            this.buttonViewSchedule.UseVisualStyleBackColor = true;
            // 
            // ButtonExamsDates
            // 
            this.ButtonExamsDates.Location = new System.Drawing.Point(388, 123);
            this.ButtonExamsDates.Name = "ButtonExamsDates";
            this.ButtonExamsDates.Size = new System.Drawing.Size(90, 48);
            this.ButtonExamsDates.TabIndex = 1;
            this.ButtonExamsDates.Text = "Exams Dates";
            this.ButtonExamsDates.UseVisualStyleBackColor = true;
            // 
            // buttonStudentsInfo
            // 
            this.buttonStudentsInfo.Location = new System.Drawing.Point(46, 223);
            this.buttonStudentsInfo.Name = "buttonStudentsInfo";
            this.buttonStudentsInfo.Size = new System.Drawing.Size(90, 48);
            this.buttonStudentsInfo.TabIndex = 2;
            this.buttonStudentsInfo.Text = "Students Information";
            this.buttonStudentsInfo.UseVisualStyleBackColor = true;
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.Location = new System.Drawing.Point(388, 223);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(90, 48);
            this.buttonAttendance.TabIndex = 3;
            this.buttonAttendance.Text = "Attendance";
            this.buttonAttendance.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(494, 23);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(63, 27);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // buttonGradesReports
            // 
            this.buttonGradesReports.Location = new System.Drawing.Point(46, 330);
            this.buttonGradesReports.Name = "buttonGradesReports";
            this.buttonGradesReports.Size = new System.Drawing.Size(90, 48);
            this.buttonGradesReports.TabIndex = 5;
            this.buttonGradesReports.Text = "Grades Reports";
            this.buttonGradesReports.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelWelcome.Location = new System.Drawing.Point(46, 67);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(78, 20);
            this.labelWelcome.TabIndex = 6;
            this.labelWelcome.Text = "Welcome, ";
            // 
            // Form1TA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonGradesReports);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonAttendance);
            this.Controls.Add(this.buttonStudentsInfo);
            this.Controls.Add(this.ButtonExamsDates);
            this.Controls.Add(this.buttonViewSchedule);
            this.Name = "Form1TA";
            this.Text = "Form1TA";
            this.Load += new System.EventHandler(this.Form1TA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonViewSchedule;
        private System.Windows.Forms.Button ButtonExamsDates;
        private System.Windows.Forms.Button buttonStudentsInfo;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonGradesReports;
        private System.Windows.Forms.Label labelWelcome;
    }
}