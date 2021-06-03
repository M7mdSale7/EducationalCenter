
namespace EducationalCenter
{
    partial class UserControl2T_B
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
            this.dataGridViewTeacherStudents = new System.Windows.Forms.DataGridView();
            this.labelStudents = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeacherStudents
            // 
            this.dataGridViewTeacherStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacherStudents.Location = new System.Drawing.Point(24, 91);
            this.dataGridViewTeacherStudents.Name = "dataGridViewTeacherStudents";
            this.dataGridViewTeacherStudents.RowTemplate.Height = 25;
            this.dataGridViewTeacherStudents.Size = new System.Drawing.Size(542, 130);
            this.dataGridViewTeacherStudents.TabIndex = 2;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.BackColor = System.Drawing.Color.Transparent;
            this.labelStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelStudents.Location = new System.Drawing.Point(20, 54);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(87, 20);
            this.labelStudents.TabIndex = 43;
            this.labelStudents.Text = "Students:";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(491, 54);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 44;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // UserControl2T_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources.Background;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.dataGridViewTeacherStudents);
            this.Name = "UserControl2T_B";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTeacherStudents;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Button buttonBack;
    }
}
