
namespace EducationalCenter
{
    partial class Form1S
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
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonViewSchedule = new System.Windows.Forms.Button();
            this.buttonGradesReport = new System.Windows.Forms.Button();
            this.buttonAvailableLessons = new System.Windows.Forms.Button();
            this.buttonContactTA = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(363, 32);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // buttonViewSchedule
            // 
            this.buttonViewSchedule.Location = new System.Drawing.Point(88, 146);
            this.buttonViewSchedule.Name = "buttonViewSchedule";
            this.buttonViewSchedule.Size = new System.Drawing.Size(100, 50);
            this.buttonViewSchedule.TabIndex = 1;
            this.buttonViewSchedule.Text = "View Schedule";
            this.buttonViewSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonGradesReport
            // 
            this.buttonGradesReport.Location = new System.Drawing.Point(88, 241);
            this.buttonGradesReport.Name = "buttonGradesReport";
            this.buttonGradesReport.Size = new System.Drawing.Size(100, 50);
            this.buttonGradesReport.TabIndex = 2;
            this.buttonGradesReport.Text = "Grades Report";
            this.buttonGradesReport.UseVisualStyleBackColor = true;
            // 
            // buttonAvailableLessons
            // 
            this.buttonAvailableLessons.Location = new System.Drawing.Point(293, 145);
            this.buttonAvailableLessons.Name = "buttonAvailableLessons";
            this.buttonAvailableLessons.Size = new System.Drawing.Size(100, 50);
            this.buttonAvailableLessons.TabIndex = 3;
            this.buttonAvailableLessons.Text = "Available Lessons";
            this.buttonAvailableLessons.UseVisualStyleBackColor = true;
            // 
            // buttonContactTA
            // 
            this.buttonContactTA.Location = new System.Drawing.Point(293, 240);
            this.buttonContactTA.Name = "buttonContactTA";
            this.buttonContactTA.Size = new System.Drawing.Size(100, 50);
            this.buttonContactTA.TabIndex = 4;
            this.buttonContactTA.Text = "Contact a TA";
            this.buttonContactTA.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(40, 39);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(60, 15);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome,";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(40, 81);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(41, 15);
            this.labelGrade.TabIndex = 6;
            this.labelGrade.Text = "Grade ";
            // 
            // Form1S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonContactTA);
            this.Controls.Add(this.buttonAvailableLessons);
            this.Controls.Add(this.buttonGradesReport);
            this.Controls.Add(this.buttonViewSchedule);
            this.Controls.Add(this.buttonLogOut);
            this.Name = "Form1S";
            this.Text = "Form1S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonViewSchedule;
        private System.Windows.Forms.Button buttonGradesReport;
        private System.Windows.Forms.Button buttonAvailableLessons;
        private System.Windows.Forms.Button buttonContactTA;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelGrade;
    }
}