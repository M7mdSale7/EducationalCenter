
namespace EducationalCenter
{
    partial class Form1E
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
            this.buttonBookLessons = new System.Windows.Forms.Button();
            this.buttonBookRooms = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(360, 21);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // buttonBookLessons
            // 
            this.buttonBookLessons.Location = new System.Drawing.Point(24, 166);
            this.buttonBookLessons.Name = "buttonBookLessons";
            this.buttonBookLessons.Size = new System.Drawing.Size(100, 50);
            this.buttonBookLessons.TabIndex = 1;
            this.buttonBookLessons.Text = "Book Lessons";
            this.buttonBookLessons.UseVisualStyleBackColor = true;
            // 
            // buttonBookRooms
            // 
            this.buttonBookRooms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBookRooms.Location = new System.Drawing.Point(185, 168);
            this.buttonBookRooms.Name = "buttonBookRooms";
            this.buttonBookRooms.Size = new System.Drawing.Size(100, 50);
            this.buttonBookRooms.TabIndex = 2;
            this.buttonBookRooms.Text = "Book Rooms";
            this.buttonBookRooms.UseVisualStyleBackColor = true;
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Location = new System.Drawing.Point(333, 168);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(100, 50);
            this.buttonSchedule.TabIndex = 3;
            this.buttonSchedule.Text = "Schedule";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(24, 66);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(60, 15);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.Text = "Welcome,";
            // 
            // Form1E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.buttonBookRooms);
            this.Controls.Add(this.buttonBookLessons);
            this.Controls.Add(this.buttonLogOut);
            this.Name = "Form1E";
            this.Text = "Form1E";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonBookLessons;
        private System.Windows.Forms.Button buttonBookRooms;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Label labelWelcome;
    }
}