
namespace EducationalCenter
{
    partial class UserControl2E_J
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
            this.dataGridViewTA = new System.Windows.Forms.DataGridView();
            this.labelTA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTA
            // 
            this.dataGridViewTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTA.Location = new System.Drawing.Point(34, 105);
            this.dataGridViewTA.Name = "dataGridViewTA";
            this.dataGridViewTA.ReadOnly = true;
            this.dataGridViewTA.Size = new System.Drawing.Size(424, 172);
            this.dataGridViewTA.TabIndex = 0;
            // 
            // labelTA
            // 
            this.labelTA.AutoSize = true;
            this.labelTA.BackColor = System.Drawing.Color.Transparent;
            this.labelTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTA.Location = new System.Drawing.Point(30, 63);
            this.labelTA.Name = "labelTA";
            this.labelTA.Size = new System.Drawing.Size(176, 20);
            this.labelTA.TabIndex = 11;
            this.labelTA.Text = "Teaching Assistants:";
            // 
            // UserControl2E_J
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTA);
            this.Controls.Add(this.dataGridViewTA);
            this.Name = "UserControl2E_J";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTA;
        private System.Windows.Forms.Label labelTA;
    }
}
