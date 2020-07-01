namespace Snake
{
    partial class register
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
            this.Register_LB_background = new System.Windows.Forms.Label();
            this.Register_TB_username = new System.Windows.Forms.TextBox();
            this.Register_LB_username = new System.Windows.Forms.Label();
            this.Register_LB_password = new System.Windows.Forms.Label();
            this.Register_LB_password2 = new System.Windows.Forms.Label();
            this.Register_TB_password = new System.Windows.Forms.TextBox();
            this.Register_TB_password2 = new System.Windows.Forms.TextBox();
            this.Register_BT_login = new System.Windows.Forms.Button();
            this.Register_BT_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Register_LB_background
            // 
            this.Register_LB_background.Image = global::Snake.Properties.Resources.background;
            this.Register_LB_background.Location = new System.Drawing.Point(-11, -1);
            this.Register_LB_background.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Register_LB_background.Name = "Register_LB_background";
            this.Register_LB_background.Size = new System.Drawing.Size(533, 351);
            this.Register_LB_background.TabIndex = 1;
            // 
            // Register_TB_username
            // 
            this.Register_TB_username.Location = new System.Drawing.Point(283, 62);
            this.Register_TB_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register_TB_username.Name = "Register_TB_username";
            this.Register_TB_username.Size = new System.Drawing.Size(132, 25);
            this.Register_TB_username.TabIndex = 6;
            // 
            // Register_LB_username
            // 
            this.Register_LB_username.AutoSize = true;
            this.Register_LB_username.BackColor = System.Drawing.Color.Transparent;
            this.Register_LB_username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_LB_username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Register_LB_username.Location = new System.Drawing.Point(76, 66);
            this.Register_LB_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Register_LB_username.Name = "Register_LB_username";
            this.Register_LB_username.Size = new System.Drawing.Size(142, 15);
            this.Register_LB_username.TabIndex = 7;
            this.Register_LB_username.Text = "请输入您的用户名：";
            // 
            // Register_LB_password
            // 
            this.Register_LB_password.AutoSize = true;
            this.Register_LB_password.BackColor = System.Drawing.Color.Transparent;
            this.Register_LB_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_LB_password.Location = new System.Drawing.Point(79, 131);
            this.Register_LB_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Register_LB_password.Name = "Register_LB_password";
            this.Register_LB_password.Size = new System.Drawing.Size(127, 15);
            this.Register_LB_password.TabIndex = 8;
            this.Register_LB_password.Text = "请输入您的密码：";
            // 
            // Register_LB_password2
            // 
            this.Register_LB_password2.AutoSize = true;
            this.Register_LB_password2.BackColor = System.Drawing.Color.Transparent;
            this.Register_LB_password2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_LB_password2.Location = new System.Drawing.Point(79, 192);
            this.Register_LB_password2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Register_LB_password2.Name = "Register_LB_password2";
            this.Register_LB_password2.Size = new System.Drawing.Size(157, 15);
            this.Register_LB_password2.TabIndex = 9;
            this.Register_LB_password2.Text = "请再次输入您的密码：";
            // 
            // Register_TB_password
            // 
            this.Register_TB_password.Location = new System.Drawing.Point(283, 128);
            this.Register_TB_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register_TB_password.Name = "Register_TB_password";
            this.Register_TB_password.PasswordChar = '*';
            this.Register_TB_password.Size = new System.Drawing.Size(132, 25);
            this.Register_TB_password.TabIndex = 10;
            // 
            // Register_TB_password2
            // 
            this.Register_TB_password2.Location = new System.Drawing.Point(283, 189);
            this.Register_TB_password2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register_TB_password2.Name = "Register_TB_password2";
            this.Register_TB_password2.PasswordChar = '*';
            this.Register_TB_password2.Size = new System.Drawing.Size(132, 25);
            this.Register_TB_password2.TabIndex = 11;
            // 
            // Register_BT_login
            // 
            this.Register_BT_login.BackColor = System.Drawing.Color.Transparent;
            this.Register_BT_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Register_BT_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Register_BT_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_BT_login.Location = new System.Drawing.Point(300, 259);
            this.Register_BT_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register_BT_login.Name = "Register_BT_login";
            this.Register_BT_login.Size = new System.Drawing.Size(100, 29);
            this.Register_BT_login.TabIndex = 12;
            this.Register_BT_login.Text = "返回登陆";
            this.Register_BT_login.UseVisualStyleBackColor = false;
            this.Register_BT_login.Click += new System.EventHandler(this.Register_BT_login_Click);
            // 
            // Register_BT_register
            // 
            this.Register_BT_register.BackColor = System.Drawing.Color.Transparent;
            this.Register_BT_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Register_BT_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Register_BT_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_BT_register.Location = new System.Drawing.Point(81, 259);
            this.Register_BT_register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register_BT_register.Name = "Register_BT_register";
            this.Register_BT_register.Size = new System.Drawing.Size(100, 29);
            this.Register_BT_register.TabIndex = 13;
            this.Register_BT_register.Text = "注册";
            this.Register_BT_register.UseVisualStyleBackColor = false;
            this.Register_BT_register.Click += new System.EventHandler(this.Register_BT_register_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 349);
            this.Controls.Add(this.Register_BT_register);
            this.Controls.Add(this.Register_BT_login);
            this.Controls.Add(this.Register_TB_password2);
            this.Controls.Add(this.Register_TB_password);
            this.Controls.Add(this.Register_LB_password2);
            this.Controls.Add(this.Register_LB_password);
            this.Controls.Add(this.Register_LB_username);
            this.Controls.Add(this.Register_TB_username);
            this.Controls.Add(this.Register_LB_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Register_LB_background;
        private System.Windows.Forms.TextBox Register_TB_username;
        private System.Windows.Forms.Label Register_LB_username;
        private System.Windows.Forms.Label Register_LB_password;
        private System.Windows.Forms.Label Register_LB_password2;
        private System.Windows.Forms.TextBox Register_TB_password;
        private System.Windows.Forms.TextBox Register_TB_password2;
        private System.Windows.Forms.Button Register_BT_login;
        private System.Windows.Forms.Button Register_BT_register;
    }
}