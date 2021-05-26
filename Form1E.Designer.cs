
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
            this.buttonLogOut.Location = new System.Drawing.Point(492, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(64, 20);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // buttonBookLessons
            // 
            this.buttonBookLessons.Location = new System.Drawing.Point(21, 144);
            this.buttonBookLessons.Name = "buttonBookLessons";
            this.buttonBookLessons.Size = new System.Drawing.Size(86, 43);
            this.buttonBookLessons.TabIndex = 1;
            this.buttonBookLessons.Text = "Book Lessons";
            this.buttonBookLessons.UseVisualStyleBackColor = true;
            this.buttonBookLessons.Click += new System.EventHandler(this.buttonBookLessons_Click);
            // 
            // buttonBookRooms
            // 
            this.buttonBookRooms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBookRooms.Location = new System.Drawing.Point(241, 146);
            this.buttonBookRooms.Name = "buttonBookRooms";
            this.buttonBookRooms.Size = new System.Drawing.Size(86, 43);
            this.buttonBookRooms.TabIndex = 2;
            this.buttonBookRooms.Text = "Book Rooms";
            this.buttonBookRooms.UseVisualStyleBackColor = true;
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Location = new System.Drawing.Point(470, 146);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(86, 43);
            this.buttonSchedule.TabIndex = 3;
            this.buttonSchedule.Text = "Schedule";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(21, 57);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(55, 13);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.Text = "Welcome,";
            // 
            // Form1E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
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