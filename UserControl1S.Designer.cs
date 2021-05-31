
namespace EducationalCenter
{
    partial class UserControl1S
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
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonAvailableLessons = new System.Windows.Forms.Button();
            this.buttonGradesReport = new System.Windows.Forms.Button();
            this.buttonViewSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStudent.Image = global::EducationalCenter.Properties.Resources.Student;
            this.pictureBoxStudent.Location = new System.Drawing.Point(354, 115);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(154, 158);
            this.pictureBoxStudent.TabIndex = 15;
            this.pictureBoxStudent.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(501, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(30, 73);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(115, 25);
            this.labelWelcome.TabIndex = 13;
            this.labelWelcome.Text = "Welcome,";
            // 
            // buttonAvailableLessons
            // 
            this.buttonAvailableLessons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAvailableLessons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAvailableLessons.Location = new System.Drawing.Point(98, 352);
            this.buttonAvailableLessons.Name = "buttonAvailableLessons";
            this.buttonAvailableLessons.Size = new System.Drawing.Size(86, 43);
            this.buttonAvailableLessons.TabIndex = 12;
            this.buttonAvailableLessons.Text = "Available Lessons";
            this.buttonAvailableLessons.UseVisualStyleBackColor = true;
            // 
            // buttonGradesReport
            // 
            this.buttonGradesReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGradesReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGradesReport.Location = new System.Drawing.Point(98, 246);
            this.buttonGradesReport.Name = "buttonGradesReport";
            this.buttonGradesReport.Size = new System.Drawing.Size(86, 43);
            this.buttonGradesReport.TabIndex = 11;
            this.buttonGradesReport.Text = "Grades Report";
            this.buttonGradesReport.UseVisualStyleBackColor = true;
            // 
            // buttonViewSchedule
            // 
            this.buttonViewSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonViewSchedule.Location = new System.Drawing.Point(98, 147);
            this.buttonViewSchedule.Name = "buttonViewSchedule";
            this.buttonViewSchedule.Size = new System.Drawing.Size(86, 43);
            this.buttonViewSchedule.TabIndex = 10;
            this.buttonViewSchedule.Text = "View Schedule";
            this.buttonViewSchedule.UseVisualStyleBackColor = true;
            // 
            // UserControl1S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources.Background;
            this.Controls.Add(this.pictureBoxStudent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonAvailableLessons);
            this.Controls.Add(this.buttonGradesReport);
            this.Controls.Add(this.buttonViewSchedule);
            this.Name = "UserControl1S";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonAvailableLessons;
        private System.Windows.Forms.Button buttonGradesReport;
        private System.Windows.Forms.Button buttonViewSchedule;
    }
}
