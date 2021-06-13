
namespace EducationalCenter
{
    partial class UserControlChangePass
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelOldPass = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.labelCNewPass = new System.Windows.Forms.Label();
            this.textBoxConfirmNewPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(272, 78);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(146, 26);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldPass.Location = new System.Drawing.Point(272, 130);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.Size = new System.Drawing.Size(146, 26);
            this.textBoxOldPass.TabIndex = 1;
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPass.Location = new System.Drawing.Point(272, 183);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(146, 26);
            this.textBoxNewPass.TabIndex = 2;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(87, 81);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 20);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            // 
            // labelOldPass
            // 
            this.labelOldPass.AutoSize = true;
            this.labelOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldPass.Location = new System.Drawing.Point(87, 136);
            this.labelOldPass.Name = "labelOldPass";
            this.labelOldPass.Size = new System.Drawing.Size(105, 20);
            this.labelOldPass.TabIndex = 4;
            this.labelOldPass.Text = "Old password";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPass.Location = new System.Drawing.Point(87, 189);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(112, 20);
            this.labelNewPass.TabIndex = 5;
            this.labelNewPass.Text = "New password";
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChangePass.Location = new System.Drawing.Point(244, 307);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(98, 44);
            this.buttonChangePass.TabIndex = 22;
            this.buttonChangePass.Text = "Change Password";
            this.buttonChangePass.UseVisualStyleBackColor = false;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // labelCNewPass
            // 
            this.labelCNewPass.AutoSize = true;
            this.labelCNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNewPass.Location = new System.Drawing.Point(87, 235);
            this.labelCNewPass.Name = "labelCNewPass";
            this.labelCNewPass.Size = new System.Drawing.Size(169, 20);
            this.labelCNewPass.TabIndex = 24;
            this.labelCNewPass.Text = "Confirm new password";
            // 
            // textBoxConfirmNewPass
            // 
            this.textBoxConfirmNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmNewPass.Location = new System.Drawing.Point(272, 235);
            this.textBoxConfirmNewPass.Name = "textBoxConfirmNewPass";
            this.textBoxConfirmNewPass.Size = new System.Drawing.Size(146, 26);
            this.textBoxConfirmNewPass.TabIndex = 23;
            // 
            // UserControlChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.labelCNewPass);
            this.Controls.Add(this.textBoxConfirmNewPass);
            this.Controls.Add(this.buttonChangePass);
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.labelOldPass);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.textBoxOldPass);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "UserControlChangePass";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelOldPass;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.Label labelCNewPass;
        private System.Windows.Forms.TextBox textBoxConfirmNewPass;
    }
}
