
namespace EducationalCenter
{
    partial class Form1T
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
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonGradesReport = new System.Windows.Forms.Button();
            this.buttonTeachingAssistants = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonViewSchedule
            // 
            this.buttonViewSchedule.Location = new System.Drawing.Point(75, 92);
            this.buttonViewSchedule.Name = "buttonViewSchedule";
            this.buttonViewSchedule.Size = new System.Drawing.Size(86, 43);
            this.buttonViewSchedule.TabIndex = 0;
            this.buttonViewSchedule.Text = "View Schedule";
            this.buttonViewSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonStudents
            // 
            this.buttonStudents.Location = new System.Drawing.Point(75, 192);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(86, 43);
            this.buttonStudents.TabIndex = 1;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = true;
            // 
            // buttonGradesReport
            // 
            this.buttonGradesReport.Location = new System.Drawing.Point(75, 289);
            this.buttonGradesReport.Name = "buttonGradesReport";
            this.buttonGradesReport.Size = new System.Drawing.Size(86, 43);
            this.buttonGradesReport.TabIndex = 2;
            this.buttonGradesReport.Text = "Grades Report";
            this.buttonGradesReport.UseVisualStyleBackColor = true;
            // 
            // buttonTeachingAssistants
            // 
            this.buttonTeachingAssistants.Location = new System.Drawing.Point(448, 92);
            this.buttonTeachingAssistants.Name = "buttonTeachingAssistants";
            this.buttonTeachingAssistants.Size = new System.Drawing.Size(86, 43);
            this.buttonTeachingAssistants.TabIndex = 3;
            this.buttonTeachingAssistants.Text = "Teaching Assistants";
            this.buttonTeachingAssistants.UseVisualStyleBackColor = true;
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.Location = new System.Drawing.Point(448, 192);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(86, 43);
            this.buttonAttendance.TabIndex = 4;
            this.buttonAttendance.Text = "Attendance";
            this.buttonAttendance.UseVisualStyleBackColor = true;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(327, 180);
            this.textBoxDate.MaxLength = 15;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(86, 20);
            this.textBoxDate.TabIndex = 5;
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(327, 223);
            this.textBoxTime.MaxLength = 15;
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(86, 20);
            this.textBoxTime.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Time";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(498, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(64, 20);
            this.buttonLogOut.TabIndex = 9;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(23, 34);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(55, 13);
            this.labelWelcome.TabIndex = 10;
            this.labelWelcome.Text = "Welcome,";
            // 
            // Form1T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.buttonAttendance);
            this.Controls.Add(this.buttonTeachingAssistants);
            this.Controls.Add(this.buttonGradesReport);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.buttonViewSchedule);
            this.Name = "Form1T";
            this.Text = "Form1T";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonViewSchedule;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonGradesReport;
        private System.Windows.Forms.Button buttonTeachingAssistants;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelWelcome;
    }
}