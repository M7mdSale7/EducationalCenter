using System.Windows.Forms;

namespace EducationalCenter
{
    partial class Form2E
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
        private void InitializeComponent(UserControl userControl)
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelBookLessons = new System.Windows.Forms.Label();

            this.SuspendLayout();
            //
            // UserControl
            //
            userControl.Location= new System.Drawing.Point(1, 50);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(26, 30);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(55, 13);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome,";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(494, 24);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(64, 20);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // labelBookLessons
            // 
            this.labelBookLessons.AutoSize = true;
            this.labelBookLessons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelBookLessons.Location = new System.Drawing.Point(26, 98);
            this.labelBookLessons.Name = "labelBookLessons";
            this.labelBookLessons.Size = new System.Drawing.Size(84, 15);
            this.labelBookLessons.TabIndex = 8;
            this.labelBookLessons.Text = "Book Lessons:";
            // 
            // Form2E_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(userControl);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelBookLessons);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Form2E_A";
            this.Text = "Form2E_A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelBookLessons;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
    }
}