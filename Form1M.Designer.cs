﻿
namespace EducationalCenter
{
    partial class Form1M
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
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonAccounts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogOut.Location = new System.Drawing.Point(502, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(70, 30);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEmployees.Location = new System.Drawing.Point(50, 202);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(86, 43);
            this.buttonEmployees.TabIndex = 1;
            this.buttonEmployees.Text = "Employees";
            this.buttonEmployees.UseVisualStyleBackColor = false;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonHireEmployees_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(47, 77);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(115, 25);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Welcome,";
            // 
            // buttonAccounts
            // 
            this.buttonAccounts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAccounts.Location = new System.Drawing.Point(276, 202);
            this.buttonAccounts.Name = "buttonAccounts";
            this.buttonAccounts.Size = new System.Drawing.Size(86, 43);
            this.buttonAccounts.TabIndex = 4;
            this.buttonAccounts.Text = "Accounts";
            this.buttonAccounts.UseVisualStyleBackColor = false;
            this.buttonAccounts.Click += new System.EventHandler(this.buttonMakeAccounts_Click);
            // 
            // Form1M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources._52cf2839_f541_4fe6_b077_385373bd2004;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.buttonAccounts);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonLogOut);
            this.Name = "Form1M";
            this.Text = "Form1M";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonAccounts;
    }
}