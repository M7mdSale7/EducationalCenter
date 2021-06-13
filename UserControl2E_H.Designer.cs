
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
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.BackColor = System.Drawing.Color.Transparent;
            this.labelDelete.Location = new System.Drawing.Point(138, 110);
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
            this.labelRooms.Location = new System.Drawing.Point(46, 65);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(70, 20);
            this.labelRooms.TabIndex = 97;
            this.labelRooms.Text = "Rooms:";
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(50, 126);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.Size = new System.Drawing.Size(242, 283);
            this.dataGridViewRooms.TabIndex = 99;
            this.dataGridViewRooms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellDoubleClick);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(370, 154);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 101;
            this.labelNumber.Text = "Number";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(373, 281);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 102;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(370, 209);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(48, 13);
            this.labelCapacity.TabIndex = 104;
            this.labelCapacity.Text = "Capacity";
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(373, 170);
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumber.TabIndex = 106;
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.Location = new System.Drawing.Point(373, 225);
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCapacity.TabIndex = 107;
            // 
            // UserControl2E_H
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDownCapacity);
            this.Controls.Add(this.numericUpDownNumber);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.dataGridViewRooms);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelRooms);
            this.Name = "UserControl2E_H";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
    }
}
