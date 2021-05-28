
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
            this.buttonViewSchedule = new System.Windows.Forms.Button();
            this.buttonGradesReport = new System.Windows.Forms.Button();
            this.buttonAvailableLessons = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonViewSchedule
            // 
            this.buttonViewSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonViewSchedule.Location = new System.Drawing.Point(75, 127);
            this.buttonViewSchedule.Name = "buttonViewSchedule";
            this.buttonViewSchedule.Size = new System.Drawing.Size(86, 43);
            this.buttonViewSchedule.TabIndex = 1;
            this.buttonViewSchedule.Text = "View Schedule";
            this.buttonViewSchedule.UseVisualStyleBackColor = true;
            this.buttonViewSchedule.Click += new System.EventHandler(this.buttonViewSchedule_Click);
            // 
            // buttonGradesReport
            // 
            this.buttonGradesReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGradesReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGradesReport.Location = new System.Drawing.Point(75, 226);
            this.buttonGradesReport.Name = "buttonGradesReport";
            this.buttonGradesReport.Size = new System.Drawing.Size(86, 43);
            this.buttonGradesReport.TabIndex = 2;
            this.buttonGradesReport.Text = "Grades Report";
            this.buttonGradesReport.UseVisualStyleBackColor = true;
            this.buttonGradesReport.Click += new System.EventHandler(this.buttonGradesReport_Click);
            // 
            // buttonAvailableLessons
            // 
            this.buttonAvailableLessons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAvailableLessons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAvailableLessons.Location = new System.Drawing.Point(378, 127);
            this.buttonAvailableLessons.Name = "buttonAvailableLessons";
            this.buttonAvailableLessons.Size = new System.Drawing.Size(86, 43);
            this.buttonAvailableLessons.TabIndex = 3;
            this.buttonAvailableLessons.Text = "Available Lessons";
            this.buttonAvailableLessons.UseVisualStyleBackColor = true;
            this.buttonAvailableLessons.Click += new System.EventHandler(this.buttonAvailableLessons_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(12, 27);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(115, 25);
            this.labelWelcome.TabIndex = 7;
            this.labelWelcome.Text = "Welcome,";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(502, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonAvailableLessons);
            this.Controls.Add(this.buttonGradesReport);
            this.Controls.Add(this.buttonViewSchedule);
            this.Name = "Form1S";
            this.Text = "Form1S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonViewSchedule;
        private System.Windows.Forms.Button buttonGradesReport;
        private System.Windows.Forms.Button buttonAvailableLessons;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button button1;
    }
}