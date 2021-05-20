
namespace EducationalCenter
{
    partial class Form1M
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
            this.buttonHireEmployees = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(361, 40);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // buttonHireEmployees
            // 
            this.buttonHireEmployees.Location = new System.Drawing.Point(55, 168);
            this.buttonHireEmployees.Name = "buttonHireEmployees";
            this.buttonHireEmployees.Size = new System.Drawing.Size(100, 50);
            this.buttonHireEmployees.TabIndex = 1;
            this.buttonHireEmployees.Text = "Hire Employees";
            this.buttonHireEmployees.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(55, 89);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(60, 15);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Welcome,";
            // 
            // Form1M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonHireEmployees);
            this.Controls.Add(this.buttonLogOut);
            this.Name = "Form1M";
            this.Text = "Form1M";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonHireEmployees;
        private System.Windows.Forms.Label labelWelcome;
    }
}