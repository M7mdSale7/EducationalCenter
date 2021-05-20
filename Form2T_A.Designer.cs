
namespace EducationalCenter
{
    partial class Form2T_A
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelSchedule = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDate,
            this.ColumnTime,
            this.ColumnRoom});
            this.dataGridView1.Location = new System.Drawing.Point(39, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(343, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // columnDate
            // 
            this.columnDate.HeaderText = "Date";
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // ColumnRoom
            // 
            this.ColumnRoom.HeaderText = "Room";
            this.ColumnRoom.Name = "ColumnRoom";
            this.ColumnRoom.ReadOnly = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(442, 33);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 50);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Location = new System.Drawing.Point(39, 84);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(58, 15);
            this.labelSchedule.TabIndex = 2;
            this.labelSchedule.Text = "Schedule:";
            // 
            // Form2T_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2T_A";
            this.Text = "Form2T-A";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoom;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelSchedule;
    }
}