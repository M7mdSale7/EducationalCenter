
namespace EducationalCenter
{
    partial class UserControlLogin
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
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.linkLabelForgot = new System.Windows.Forms.LinkLabel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.linkLabelChange = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogIn.Location = new System.Drawing.Point(179, 261);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(70, 30);
            this.buttonLogIn.TabIndex = 21;
            this.buttonLogIn.Text = "Log in";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // linkLabelForgot
            // 
            this.linkLabelForgot.AutoSize = true;
            this.linkLabelForgot.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelForgot.Location = new System.Drawing.Point(166, 320);
            this.linkLabelForgot.Name = "linkLabelForgot";
            this.linkLabelForgot.Size = new System.Drawing.Size(92, 13);
            this.linkLabelForgot.TabIndex = 20;
            this.linkLabelForgot.TabStop = true;
            this.linkLabelForgot.Text = "Forgot Password?";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(80, 187);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 20);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(75, 124);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 20);
            this.labelUsername.TabIndex = 18;
            this.labelUsername.Text = "Username";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPass.Location = new System.Drawing.Point(179, 187);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(136, 23);
            this.textBoxPass.TabIndex = 17;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUser.Location = new System.Drawing.Point(179, 124);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(136, 23);
            this.textBoxUser.TabIndex = 16;
            // 
            // linkLabelChange
            // 
            this.linkLabelChange.AutoSize = true;
            this.linkLabelChange.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelChange.Location = new System.Drawing.Point(166, 357);
            this.linkLabelChange.Name = "linkLabelChange";
            this.linkLabelChange.Size = new System.Drawing.Size(92, 13);
            this.linkLabelChange.TabIndex = 24;
            this.linkLabelChange.TabStop = true;
            this.linkLabelChange.Text = "Change password";
            this.linkLabelChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChange_LinkClicked);
            // 
            // UserControlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelChange);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.linkLabelForgot);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "UserControlLogin";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.LinkLabel linkLabelForgot;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.LinkLabel linkLabelChange;
    }
}
