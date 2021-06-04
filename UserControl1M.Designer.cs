
namespace EducationalCenter
{
    partial class UserControl1M
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
            this.buttonAccounts = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.pictureBoxManager = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManager)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAccounts
            // 
            this.buttonAccounts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAccounts.Location = new System.Drawing.Point(379, 224);
            this.buttonAccounts.Name = "buttonAccounts";
            this.buttonAccounts.Size = new System.Drawing.Size(86, 43);
            this.buttonAccounts.TabIndex = 9;
            this.buttonAccounts.Text = "Accounts";
            this.buttonAccounts.UseVisualStyleBackColor = false;
            this.buttonAccounts.Click += new System.EventHandler(this.buttonAccounts_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(42, 94);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(115, 25);
            this.labelWelcome.TabIndex = 8;
            this.labelWelcome.Text = "Welcome,";
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEmployees.Location = new System.Drawing.Point(157, 224);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(86, 43);
            this.buttonEmployees.TabIndex = 7;
            this.buttonEmployees.Text = "Employees";
            this.buttonEmployees.UseVisualStyleBackColor = false;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogOut.Location = new System.Drawing.Point(24, 15);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(70, 30);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // pictureBoxManager
            // 
            this.pictureBoxManager.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxManager.Image = global::EducationalCenter.Properties.Resources.Manager;
            this.pictureBoxManager.Location = new System.Drawing.Point(465, 56);
            this.pictureBoxManager.Name = "pictureBoxManager";
            this.pictureBoxManager.Size = new System.Drawing.Size(98, 104);
            this.pictureBoxManager.TabIndex = 10;
            this.pictureBoxManager.TabStop = false;
            // 
            // UserControl1M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources.Background;
            this.Controls.Add(this.pictureBoxManager);
            this.Controls.Add(this.buttonAccounts);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonLogOut);
            this.Name = "UserControl1M";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxManager;
        private System.Windows.Forms.Button buttonAccounts;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonLogOut;
    }
}
