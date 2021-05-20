
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
            this.SuspendLayout();
            // 
            // buttonViewSchedule
            // 
            this.buttonViewSchedule.Location = new System.Drawing.Point(88, 106);
            this.buttonViewSchedule.Name = "buttonViewSchedule";
            this.buttonViewSchedule.Size = new System.Drawing.Size(100, 50);
            this.buttonViewSchedule.TabIndex = 0;
            this.buttonViewSchedule.Text = "View Schedule";
            this.buttonViewSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonStudents
            // 
            this.buttonStudents.Location = new System.Drawing.Point(88, 194);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(100, 50);
            this.buttonStudents.TabIndex = 1;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = true;
            // 
            // buttonGradesReport
            // 
            this.buttonGradesReport.Location = new System.Drawing.Point(88, 298);
            this.buttonGradesReport.Name = "buttonGradesReport";
            this.buttonGradesReport.Size = new System.Drawing.Size(100, 50);
            this.buttonGradesReport.TabIndex = 2;
            this.buttonGradesReport.Text = "Grades Report";
            this.buttonGradesReport.UseVisualStyleBackColor = true;
            // 
            // buttonTeachingAssistants
            // 
            this.buttonTeachingAssistants.Location = new System.Drawing.Point(313, 106);
            this.buttonTeachingAssistants.Name = "buttonTeachingAssistants";
            this.buttonTeachingAssistants.Size = new System.Drawing.Size(100, 50);
            this.buttonTeachingAssistants.TabIndex = 3;
            this.buttonTeachingAssistants.Text = "Teaching Assistants";
            this.buttonTeachingAssistants.UseVisualStyleBackColor = true;
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.Location = new System.Drawing.Point(313, 298);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(100, 50);
            this.buttonAttendance.TabIndex = 4;
            this.buttonAttendance.Text = "Attendance";
            this.buttonAttendance.UseVisualStyleBackColor = true;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(313, 192);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxDate.TabIndex = 5;
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(313, 236);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 23);
            this.textBoxTime.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Time";
            // 
            // Form1T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
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
    }
}