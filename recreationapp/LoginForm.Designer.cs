namespace recreationapp
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTxtField = new System.Windows.Forms.TextBox();
            this.passwordTxtField = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.showPasswordBtn = new System.Windows.Forms.Button();
            this.loginError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usernameTxtField
            // 
            this.usernameTxtField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtField.Location = new System.Drawing.Point(209, 287);
            this.usernameTxtField.Multiline = true;
            this.usernameTxtField.Name = "usernameTxtField";
            this.usernameTxtField.Size = new System.Drawing.Size(302, 34);
            this.usernameTxtField.TabIndex = 2;
            // 
            // passwordTxtField
            // 
            this.passwordTxtField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtField.Location = new System.Drawing.Point(209, 364);
            this.passwordTxtField.Multiline = true;
            this.passwordTxtField.Name = "passwordTxtField";
            this.passwordTxtField.PasswordChar = '*';
            this.passwordTxtField.Size = new System.Drawing.Size(276, 31);
            this.passwordTxtField.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginBtn.Location = new System.Drawing.Point(225, 440);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(157, 49);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(158, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome to Login Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::recreationapp.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(212, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.Location = new System.Drawing.Point(206, 324);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(0, 16);
            this.usernameError.TabIndex = 8;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Location = new System.Drawing.Point(206, 398);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(0, 16);
            this.passwordError.TabIndex = 9;
            // 
            // showPasswordBtn
            // 
            this.showPasswordBtn.BackColor = System.Drawing.SystemColors.Window;
            this.showPasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showPasswordBtn.Image = global::recreationapp.Properties.Resources.eye_icon;
            this.showPasswordBtn.Location = new System.Drawing.Point(462, 364);
            this.showPasswordBtn.Name = "showPasswordBtn";
            this.showPasswordBtn.Size = new System.Drawing.Size(49, 33);
            this.showPasswordBtn.TabIndex = 11;
            this.showPasswordBtn.UseVisualStyleBackColor = false;
            this.showPasswordBtn.Click += new System.EventHandler(this.ShowPasswordBtn_Click);
            // 
            // loginError
            // 
            this.loginError.AutoSize = true;
            this.loginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginError.Location = new System.Drawing.Point(206, 258);
            this.loginError.Name = "loginError";
            this.loginError.Size = new System.Drawing.Size(0, 22);
            this.loginError.TabIndex = 12;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(681, 560);
            this.Controls.Add(this.loginError);
            this.Controls.Add(this.showPasswordBtn);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.usernameError);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxtField);
            this.Controls.Add(this.usernameTxtField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTxtField;
        private System.Windows.Forms.TextBox passwordTxtField;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernameError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Button showPasswordBtn;
        private System.Windows.Forms.Label loginError;
    }
}

