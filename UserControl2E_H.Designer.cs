
namespace EducationalCenter
{
    partial class UserControl2E_H
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
            this.labelDelete = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.labelCapacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.BackColor = System.Drawing.Color.Transparent;
            this.labelDelete.Location = new System.Drawing.Point(114, 67);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(154, 13);
            this.labelDelete.TabIndex = 98;
            this.labelDelete.Text = "Double click on a row to delete";
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.BackColor = System.Drawing.Color.Transparent;
            this.labelRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRooms.Location = new System.Drawing.Point(22, 11);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(70, 20);
            this.labelRooms.TabIndex = 97;
            this.labelRooms.Text = "Rooms:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnCapacity});
            this.dataGridView1.Location = new System.Drawing.Point(26, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(242, 150);
            this.dataGridView1.TabIndex = 99;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "Number";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            // 
            // ColumnCapacity
            // 
            this.ColumnCapacity.HeaderText = "Capacity";
            this.ColumnCapacity.Name = "ColumnCapacity";
            this.ColumnCapacity.ReadOnly = true;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(350, 99);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 100;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(347, 83);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 101;
            this.labelNumber.Text = "Number";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(350, 210);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 102;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(350, 154);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapacity.TabIndex = 103;
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(347, 138);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(48, 13);
            this.labelCapacity.TabIndex = 104;
            this.labelCapacity.Text = "Capacity";
            // 
            // UserControl2E_H
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources.Background;
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelRooms);
            this.Name = "UserControl2E_H";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCapacity;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.Label labelCapacity;
    }
}
