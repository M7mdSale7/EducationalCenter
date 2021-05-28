
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
            this.buttonBookLessons = new System.Windows.Forms.Button();
            this.buttonBookRooms = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonRooms = new System.Windows.Forms.Button();
            this.buttonSubjects = new System.Windows.Forms.Button();
            this.buttonExams = new System.Windows.Forms.Button();
            this.buttonParents = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBookLessons
            // 
            this.buttonBookLessons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBookLessons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBookLessons.Location = new System.Drawing.Point(24, 142);
            this.buttonBookLessons.Name = "buttonBookLessons";
            this.buttonBookLessons.Size = new System.Drawing.Size(86, 43);
            this.buttonBookLessons.TabIndex = 1;
            this.buttonBookLessons.Text = "Book Lessons";
            this.buttonBookLessons.UseVisualStyleBackColor = false;
            this.buttonBookLessons.Click += new System.EventHandler(this.buttonBookLessons_Click);
            // 
            // buttonBookRooms
            // 
            this.buttonBookRooms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBookRooms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBookRooms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBookRooms.Location = new System.Drawing.Point(172, 142);
            this.buttonBookRooms.Name = "buttonBookRooms";
            this.buttonBookRooms.Size = new System.Drawing.Size(86, 43);
            this.buttonBookRooms.TabIndex = 2;
            this.buttonBookRooms.Text = "Book Rooms";
            this.buttonBookRooms.UseVisualStyleBackColor = true;
            this.buttonBookRooms.Click += new System.EventHandler(this.buttonBookRooms_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStudents.Location = new System.Drawing.Point(24, 261);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(86, 43);
            this.buttonStudents.TabIndex = 5;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTeachers.Location = new System.Drawing.Point(316, 261);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(86, 43);
            this.buttonTeachers.TabIndex = 6;
            this.buttonTeachers.Text = "Teachers";
            this.buttonTeachers.UseVisualStyleBackColor = true;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // buttonRooms
            // 
            this.buttonRooms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRooms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRooms.Location = new System.Drawing.Point(172, 261);
            this.buttonRooms.Name = "buttonRooms";
            this.buttonRooms.Size = new System.Drawing.Size(86, 43);
            this.buttonRooms.TabIndex = 7;
            this.buttonRooms.Text = "Rooms";
            this.buttonRooms.UseVisualStyleBackColor = true;
            this.buttonRooms.Click += new System.EventHandler(this.buttonRooms_Click);
            // 
            // buttonSubjects
            // 
            this.buttonSubjects.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSubjects.Location = new System.Drawing.Point(470, 142);
            this.buttonSubjects.Name = "buttonSubjects";
            this.buttonSubjects.Size = new System.Drawing.Size(86, 43);
            this.buttonSubjects.TabIndex = 8;
            this.buttonSubjects.Text = "Subjects";
            this.buttonSubjects.UseVisualStyleBackColor = true;
            this.buttonSubjects.Click += new System.EventHandler(this.buttonSubjects_Click);
            // 
            // buttonExams
            // 
            this.buttonExams.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExams.Location = new System.Drawing.Point(316, 142);
            this.buttonExams.Name = "buttonExams";
            this.buttonExams.Size = new System.Drawing.Size(86, 43);
            this.buttonExams.TabIndex = 9;
            this.buttonExams.Text = "Exams";
            this.buttonExams.UseVisualStyleBackColor = true;
            this.buttonExams.Click += new System.EventHandler(this.buttonExams_Click);
            // 
            // buttonParents
            // 
            this.buttonParents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonParents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonParents.Location = new System.Drawing.Point(470, 261);
            this.buttonParents.Name = "buttonParents";
            this.buttonParents.Size = new System.Drawing.Size(86, 43);
            this.buttonParents.TabIndex = 10;
            this.buttonParents.Text = "Parents";
            this.buttonParents.UseVisualStyleBackColor = true;
            this.buttonParents.Click += new System.EventHandler(this.buttonParents_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(19, 50);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(115, 25);
            this.labelWelcome.TabIndex = 11;
            this.labelWelcome.Text = "Welcome,";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogOut.Location = new System.Drawing.Point(496, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(70, 30);
            this.buttonLogOut.TabIndex = 12;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEmployee.Image = global::EducationalCenter.Properties.Resources.Employee;
            this.pictureBoxEmployee.Location = new System.Drawing.Point(392, 21);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(98, 104);
            this.pictureBoxEmployee.TabIndex = 13;
            this.pictureBoxEmployee.TabStop = false;
            // 
            // Form1E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pictureBoxEmployee);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonParents);
            this.Controls.Add(this.buttonExams);
            this.Controls.Add(this.buttonSubjects);
            this.Controls.Add(this.buttonRooms);
            this.Controls.Add(this.buttonTeachers);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.buttonBookRooms);
            this.Controls.Add(this.buttonBookLessons);
            this.Name = "Form1E";
            this.Text = "Form1E";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBookLessons;
        private System.Windows.Forms.Button buttonBookRooms;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonRooms;
        private System.Windows.Forms.Button buttonSubjects;
        private System.Windows.Forms.Button buttonExams;
        private System.Windows.Forms.Button buttonParents;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.PictureBox pictureBoxEmployee;
    }
}