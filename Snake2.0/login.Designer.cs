namespace Snake
{
    partial class login
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
            this.LBbackground = new System.Windows.Forms.Label();
            this.LBusername = new System.Windows.Forms.Label();
            this.LBpassword = new System.Windows.Forms.Label();
            this.TBusername = new System.Windows.Forms.TextBox();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.LBgamename = new System.Windows.Forms.Label();
            this.BTregister = new System.Windows.Forms.Button();
            this.BTlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBbackground
            // 
            this.LBbackground.Image = global::Snake.Properties.Resources.background;
            this.LBbackground.Location = new System.Drawing.Point(-8, -2);
            this.LBbackground.Name = "LBbackground";
            this.LBbackground.Size = new System.Drawing.Size(400, 281);
            this.LBbackground.TabIndex = 0;
            // 
            // LBusername
            // 
            this.LBusername.AutoSize = true;
            this.LBusername.BackColor = System.Drawing.Color.Transparent;
            this.LBusername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBusername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBusername.Location = new System.Drawing.Point(66, 94);
            this.LBusername.Name = "LBusername";
            this.LBusername.Size = new System.Drawing.Size(53, 12);
            this.LBusername.TabIndex = 3;
            this.LBusername.Text = "用户名：";
            // 
            // LBpassword
            // 
            this.LBpassword.AutoSize = true;
            this.LBpassword.BackColor = System.Drawing.Color.Transparent;
            this.LBpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBpassword.Location = new System.Drawing.Point(66, 142);
            this.LBpassword.Name = "LBpassword";
            this.LBpassword.Size = new System.Drawing.Size(41, 12);
            this.LBpassword.TabIndex = 4;
            this.LBpassword.Text = "密码：";
            // 
            // TBusername
            // 
            this.TBusername.Location = new System.Drawing.Point(169, 91);
            this.TBusername.Name = "TBusername";
            this.TBusername.Size = new System.Drawing.Size(100, 21);
            this.TBusername.TabIndex = 5;
            // 
            // TBpassword
            // 
            this.TBpassword.Location = new System.Drawing.Point(169, 139);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.PasswordChar = '*';
            this.TBpassword.Size = new System.Drawing.Size(100, 21);
            this.TBpassword.TabIndex = 6;
            // 
            // LBgamename
            // 
            this.LBgamename.AutoSize = true;
            this.LBgamename.BackColor = System.Drawing.Color.Transparent;
            this.LBgamename.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBgamename.Location = new System.Drawing.Point(79, 31);
            this.LBgamename.Name = "LBgamename";
            this.LBgamename.Size = new System.Drawing.Size(207, 33);
            this.LBgamename.TabIndex = 8;
            this.LBgamename.Text = "贪吃蛇大作战";
            // 
            // BTregister
            // 
            this.BTregister.BackColor = System.Drawing.Color.Transparent;
            this.BTregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTregister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTregister.Location = new System.Drawing.Point(211, 201);
            this.BTregister.Name = "BTregister";
            this.BTregister.Size = new System.Drawing.Size(75, 23);
            this.BTregister.TabIndex = 2;
            this.BTregister.Text = "注册";
            this.BTregister.UseVisualStyleBackColor = false;
            this.BTregister.Click += new System.EventHandler(this.BTregister_Click);
            // 
            // BTlogin
            // 
            this.BTlogin.BackColor = System.Drawing.Color.Transparent;
            this.BTlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTlogin.Location = new System.Drawing.Point(68, 201);
            this.BTlogin.Name = "BTlogin";
            this.BTlogin.Size = new System.Drawing.Size(75, 23);
            this.BTlogin.TabIndex = 7;
            this.BTlogin.Text = "登陆";
            this.BTlogin.UseVisualStyleBackColor = false;
            this.BTlogin.Click += new System.EventHandler(this.BTlogin_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 279);
            this.Controls.Add(this.LBgamename);
            this.Controls.Add(this.BTlogin);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.TBusername);
            this.Controls.Add(this.LBpassword);
            this.Controls.Add(this.LBusername);
            this.Controls.Add(this.BTregister);
            this.Controls.Add(this.LBbackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贪吃蛇大作战";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBbackground;
        private System.Windows.Forms.Label LBusername;
        private System.Windows.Forms.Label LBpassword;
        private System.Windows.Forms.TextBox TBusername;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.Label LBgamename;
        private System.Windows.Forms.Button BTregister;
        private System.Windows.Forms.Button BTlogin;
    }
}