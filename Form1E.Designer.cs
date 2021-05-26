
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonRooms = new System.Windows.Forms.Button();
            this.buttonSubjects = new System.Windows.Forms.Button();
            this.buttonExams = new System.Windows.Forms.Button();
            this.buttonParents = new System.Windows.Forms.Button();
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
            this.buttonBookLessons.Location = new System.Drawing.Point(24, 111);
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
            this.buttonBookRooms.Location = new System.Drawing.Point(172, 111);
            this.buttonBookRooms.Name = "buttonBookRooms";
            this.buttonBookRooms.Size = new System.Drawing.Size(86, 43);
            this.buttonBookRooms.TabIndex = 2;
            this.buttonBookRooms.Text = "Book Rooms";
            this.buttonBookRooms.UseVisualStyleBackColor = true;
            this.buttonBookRooms.Click += new System.EventHandler(this.buttonBookRooms_Click);
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
            // buttonStudents
            // 
            this.buttonStudents.Location = new System.Drawing.Point(24, 230);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(86, 43);
            this.buttonStudents.TabIndex = 5;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.Location = new System.Drawing.Point(316, 230);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(86, 43);
            this.buttonTeachers.TabIndex = 6;
            this.buttonTeachers.Text = "Teachers";
            this.buttonTeachers.UseVisualStyleBackColor = true;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // buttonRooms
            // 
            this.buttonRooms.Location = new System.Drawing.Point(172, 230);
            this.buttonRooms.Name = "buttonRooms";
            this.buttonRooms.Size = new System.Drawing.Size(86, 43);
            this.buttonRooms.TabIndex = 7;
            this.buttonRooms.Text = "Rooms";
            this.buttonRooms.UseVisualStyleBackColor = true;
            this.buttonRooms.Click += new System.EventHandler(this.buttonRooms_Click);
            // 
            // buttonSubjects
            // 
            this.buttonSubjects.Location = new System.Drawing.Point(470, 111);
            this.buttonSubjects.Name = "buttonSubjects";
            this.buttonSubjects.Size = new System.Drawing.Size(86, 43);
            this.buttonSubjects.TabIndex = 8;
            this.buttonSubjects.Text = "Subjects";
            this.buttonSubjects.UseVisualStyleBackColor = true;
            this.buttonSubjects.Click += new System.EventHandler(this.buttonSubjects_Click);
            // 
            // buttonExams
            // 
            this.buttonExams.Location = new System.Drawing.Point(316, 111);
            this.buttonExams.Name = "buttonExams";
            this.buttonExams.Size = new System.Drawing.Size(86, 43);
            this.buttonExams.TabIndex = 9;
            this.buttonExams.Text = "Exams";
            this.buttonExams.UseVisualStyleBackColor = true;
            this.buttonExams.Click += new System.EventHandler(this.buttonExams_Click);
            // 
            // buttonParents
            // 
            this.buttonParents.Location = new System.Drawing.Point(470, 230);
            this.buttonParents.Name = "buttonParents";
            this.buttonParents.Size = new System.Drawing.Size(86, 43);
            this.buttonParents.TabIndex = 10;
            this.buttonParents.Text = "Parents";
            this.buttonParents.UseVisualStyleBackColor = true;
            this.buttonParents.Click += new System.EventHandler(this.buttonParents_Click);
            // 
            // Form1E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.buttonParents);
            this.Controls.Add(this.buttonExams);
            this.Controls.Add(this.buttonSubjects);
            this.Controls.Add(this.buttonRooms);
            this.Controls.Add(this.buttonTeachers);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.labelWelcome);
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
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonRooms;
        private System.Windows.Forms.Button buttonSubjects;
        private System.Windows.Forms.Button buttonExams;
        private System.Windows.Forms.Button buttonParents;
    }
}