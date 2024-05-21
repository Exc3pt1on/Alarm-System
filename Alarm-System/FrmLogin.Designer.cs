namespace Alarm_System
{
    partial class FrmLogin
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
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chbShowPassword = new System.Windows.Forms.CheckBox();
            this.lblNewAccount = new System.Windows.Forms.Label();
            this.liLblNewAccount = new System.Windows.Forms.LinkLabel();
            this.panLogin = new System.Windows.Forms.Panel();
            this.panSignup = new System.Windows.Forms.Panel();
            this.liLblBackToLogin = new System.Windows.Forms.LinkLabel();
            this.txtPhoneNr = new System.Windows.Forms.TextBox();
            this.lblPhoneNr = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmployeeNr = new System.Windows.Forms.TextBox();
            this.lblEmployeeNr = new System.Windows.Forms.Label();
            this.txtPasswordNewRepeat = new System.Windows.Forms.TextBox();
            this.lblPasswordNewRepeat = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblPasswordNew = new System.Windows.Forms.Label();
            this.txtUsernameNew = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.chbShowPasswordNew = new System.Windows.Forms.CheckBox();
            this.lblUsernameNew = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.panLogin.SuspendLayout();
            this.panSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(40, 242);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(123, 27);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(39, 130);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(124, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(39, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(124, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(36, 111);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(36, 158);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // chbShowPassword
            // 
            this.chbShowPassword.AutoSize = true;
            this.chbShowPassword.Location = new System.Drawing.Point(39, 205);
            this.chbShowPassword.Name = "chbShowPassword";
            this.chbShowPassword.Size = new System.Drawing.Size(124, 20);
            this.chbShowPassword.TabIndex = 5;
            this.chbShowPassword.Text = "Show password";
            this.chbShowPassword.UseVisualStyleBackColor = true;
            this.chbShowPassword.CheckedChanged += new System.EventHandler(this.chbShowPassword_CheckedChanged);
            // 
            // lblNewAccount
            // 
            this.lblNewAccount.AutoSize = true;
            this.lblNewAccount.Location = new System.Drawing.Point(17, 297);
            this.lblNewAccount.Name = "lblNewAccount";
            this.lblNewAccount.Size = new System.Drawing.Size(146, 16);
            this.lblNewAccount.TabIndex = 7;
            this.lblNewAccount.Text = "Don\'t have an account?";
            // 
            // liLblNewAccount
            // 
            this.liLblNewAccount.AutoSize = true;
            this.liLblNewAccount.Location = new System.Drawing.Point(42, 325);
            this.liLblNewAccount.Name = "liLblNewAccount";
            this.liLblNewAccount.Size = new System.Drawing.Size(97, 16);
            this.liLblNewAccount.TabIndex = 8;
            this.liLblNewAccount.TabStop = true;
            this.liLblNewAccount.Text = "Create account";
            this.liLblNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liLblNewAccount_LinkClicked);
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.txtUsername);
            this.panLogin.Controls.Add(this.liLblNewAccount);
            this.panLogin.Controls.Add(this.btnSignIn);
            this.panLogin.Controls.Add(this.lblNewAccount);
            this.panLogin.Controls.Add(this.txtPassword);
            this.panLogin.Controls.Add(this.chbShowPassword);
            this.panLogin.Controls.Add(this.lblUsername);
            this.panLogin.Controls.Add(this.lblPassword);
            this.panLogin.Location = new System.Drawing.Point(95, 22);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(209, 489);
            this.panLogin.TabIndex = 9;
            // 
            // panSignup
            // 
            this.panSignup.Controls.Add(this.liLblBackToLogin);
            this.panSignup.Controls.Add(this.txtPhoneNr);
            this.panSignup.Controls.Add(this.lblPhoneNr);
            this.panSignup.Controls.Add(this.txtEmail);
            this.panSignup.Controls.Add(this.lblEmail);
            this.panSignup.Controls.Add(this.txtEmployeeNr);
            this.panSignup.Controls.Add(this.lblEmployeeNr);
            this.panSignup.Controls.Add(this.txtPasswordNewRepeat);
            this.panSignup.Controls.Add(this.lblPasswordNewRepeat);
            this.panSignup.Controls.Add(this.txtLastname);
            this.panSignup.Controls.Add(this.txtPasswordNew);
            this.panSignup.Controls.Add(this.lblLastname);
            this.panSignup.Controls.Add(this.lblPasswordNew);
            this.panSignup.Controls.Add(this.txtUsernameNew);
            this.panSignup.Controls.Add(this.btnSignUp);
            this.panSignup.Controls.Add(this.txtFirstname);
            this.panSignup.Controls.Add(this.chbShowPasswordNew);
            this.panSignup.Controls.Add(this.lblUsernameNew);
            this.panSignup.Controls.Add(this.lblFirstname);
            this.panSignup.Location = new System.Drawing.Point(95, 22);
            this.panSignup.Name = "panSignup";
            this.panSignup.Size = new System.Drawing.Size(226, 574);
            this.panSignup.TabIndex = 10;
            this.panSignup.Visible = false;
            // 
            // liLblBackToLogin
            // 
            this.liLblBackToLogin.AutoSize = true;
            this.liLblBackToLogin.Location = new System.Drawing.Point(59, 542);
            this.liLblBackToLogin.Name = "liLblBackToLogin";
            this.liLblBackToLogin.Size = new System.Drawing.Size(87, 16);
            this.liLblBackToLogin.TabIndex = 9;
            this.liLblBackToLogin.TabStop = true;
            this.liLblBackToLogin.Text = "Login instead";
            this.liLblBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liLblBackToLogin_LinkClicked);
            // 
            // txtPhoneNr
            // 
            this.txtPhoneNr.Location = new System.Drawing.Point(42, 300);
            this.txtPhoneNr.Name = "txtPhoneNr";
            this.txtPhoneNr.Size = new System.Drawing.Size(123, 22);
            this.txtPhoneNr.TabIndex = 6;
            // 
            // lblPhoneNr
            // 
            this.lblPhoneNr.AutoSize = true;
            this.lblPhoneNr.Location = new System.Drawing.Point(42, 281);
            this.lblPhoneNr.Name = "lblPhoneNr";
            this.lblPhoneNr.Size = new System.Drawing.Size(60, 16);
            this.lblPhoneNr.TabIndex = 17;
            this.lblPhoneNr.Text = "Phone nr";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(42, 249);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(42, 230);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            // 
            // txtEmployeeNr
            // 
            this.txtEmployeeNr.Location = new System.Drawing.Point(42, 196);
            this.txtEmployeeNr.Name = "txtEmployeeNr";
            this.txtEmployeeNr.Size = new System.Drawing.Size(123, 22);
            this.txtEmployeeNr.TabIndex = 4;
            // 
            // lblEmployeeNr
            // 
            this.lblEmployeeNr.AutoSize = true;
            this.lblEmployeeNr.Location = new System.Drawing.Point(42, 177);
            this.lblEmployeeNr.Name = "lblEmployeeNr";
            this.lblEmployeeNr.Size = new System.Drawing.Size(83, 16);
            this.lblEmployeeNr.TabIndex = 13;
            this.lblEmployeeNr.Text = "Employee nr";
            // 
            // txtPasswordNewRepeat
            // 
            this.txtPasswordNewRepeat.Location = new System.Drawing.Point(42, 441);
            this.txtPasswordNewRepeat.Name = "txtPasswordNewRepeat";
            this.txtPasswordNewRepeat.Size = new System.Drawing.Size(123, 22);
            this.txtPasswordNewRepeat.TabIndex = 8;
            // 
            // lblPasswordNewRepeat
            // 
            this.lblPasswordNewRepeat.AutoSize = true;
            this.lblPasswordNewRepeat.Location = new System.Drawing.Point(42, 422);
            this.lblPasswordNewRepeat.Name = "lblPasswordNewRepeat";
            this.lblPasswordNewRepeat.Size = new System.Drawing.Size(114, 16);
            this.lblPasswordNewRepeat.TabIndex = 11;
            this.lblPasswordNewRepeat.Text = "Repeat password";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(42, 136);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(123, 22);
            this.txtLastname.TabIndex = 3;
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Location = new System.Drawing.Point(42, 394);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.Size = new System.Drawing.Size(123, 22);
            this.txtPasswordNew.TabIndex = 7;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(42, 117);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(69, 16);
            this.lblLastname.TabIndex = 8;
            this.lblLastname.Text = "Last name";
            // 
            // lblPasswordNew
            // 
            this.lblPasswordNew.AutoSize = true;
            this.lblPasswordNew.Location = new System.Drawing.Point(42, 375);
            this.lblPasswordNew.Name = "lblPasswordNew";
            this.lblPasswordNew.Size = new System.Drawing.Size(67, 16);
            this.lblPasswordNew.TabIndex = 9;
            this.lblPasswordNew.Text = "Password";
            // 
            // txtUsernameNew
            // 
            this.txtUsernameNew.Location = new System.Drawing.Point(42, 35);
            this.txtUsernameNew.Name = "txtUsernameNew";
            this.txtUsernameNew.Size = new System.Drawing.Size(123, 22);
            this.txtUsernameNew.TabIndex = 1;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(42, 495);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(122, 44);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(42, 82);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(123, 22);
            this.txtFirstname.TabIndex = 2;
            // 
            // chbShowPasswordNew
            // 
            this.chbShowPasswordNew.AutoSize = true;
            this.chbShowPasswordNew.Location = new System.Drawing.Point(42, 469);
            this.chbShowPasswordNew.Name = "chbShowPasswordNew";
            this.chbShowPasswordNew.Size = new System.Drawing.Size(131, 20);
            this.chbShowPasswordNew.TabIndex = 10;
            this.chbShowPasswordNew.Text = "Show passwords";
            this.chbShowPasswordNew.UseVisualStyleBackColor = true;
            this.chbShowPasswordNew.CheckedChanged += new System.EventHandler(this.chbShowPasswordNew_CheckedChanged);
            // 
            // lblUsernameNew
            // 
            this.lblUsernameNew.AutoSize = true;
            this.lblUsernameNew.Location = new System.Drawing.Point(42, 16);
            this.lblUsernameNew.Name = "lblUsernameNew";
            this.lblUsernameNew.Size = new System.Drawing.Size(70, 16);
            this.lblUsernameNew.TabIndex = 3;
            this.lblUsernameNew.Text = "Username";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(42, 63);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(69, 16);
            this.lblFirstname.TabIndex = 4;
            this.lblFirstname.Text = "First name";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 608);
            this.Controls.Add(this.panSignup);
            this.Controls.Add(this.panLogin);
            this.Name = "FrmLogin";
            this.Text = "Sign in";
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.panSignup.ResumeLayout(false);
            this.panSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chbShowPassword;
        private System.Windows.Forms.Label lblNewAccount;
        private System.Windows.Forms.LinkLabel liLblNewAccount;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Panel panSignup;
        private System.Windows.Forms.TextBox txtUsernameNew;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.CheckBox chbShowPasswordNew;
        private System.Windows.Forms.Label lblUsernameNew;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblPasswordNew;
        private System.Windows.Forms.TextBox txtPasswordNewRepeat;
        private System.Windows.Forms.Label lblPasswordNewRepeat;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmployeeNr;
        private System.Windows.Forms.Label lblEmployeeNr;
        private System.Windows.Forms.TextBox txtPhoneNr;
        private System.Windows.Forms.Label lblPhoneNr;
        private System.Windows.Forms.LinkLabel liLblBackToLogin;
    }
}