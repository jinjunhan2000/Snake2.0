namespace Snake
{
    partial class menu
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
            this.Menu_background = new System.Windows.Forms.Label();
            this.Menu_start = new System.Windows.Forms.Button();
            this.Menu_select = new System.Windows.Forms.Button();
            this.Menu_RankingList = new System.Windows.Forms.Button();
            this.Menu_exit = new System.Windows.Forms.Button();
            this.Menu_gamename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Menu_background
            // 
            this.Menu_background.Image = global::Snake.Properties.Resources.background;
            this.Menu_background.Location = new System.Drawing.Point(-8, -1);
            this.Menu_background.Name = "Menu_background";
            this.Menu_background.Size = new System.Drawing.Size(400, 281);
            this.Menu_background.TabIndex = 2;
            // 
            // Menu_start
            // 
            this.Menu_start.BackColor = System.Drawing.Color.Transparent;
            this.Menu_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Menu_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Menu_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_start.Location = new System.Drawing.Point(43, 119);
            this.Menu_start.Name = "Menu_start";
            this.Menu_start.Size = new System.Drawing.Size(75, 23);
            this.Menu_start.TabIndex = 14;
            this.Menu_start.Text = "开始游戏";
            this.Menu_start.UseVisualStyleBackColor = false;
            this.Menu_start.Click += new System.EventHandler(this.Menu_start_Click);
            // 
            // Menu_select
            // 
            this.Menu_select.BackColor = System.Drawing.Color.Transparent;
            this.Menu_select.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Menu_select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Menu_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_select.Location = new System.Drawing.Point(258, 119);
            this.Menu_select.Name = "Menu_select";
            this.Menu_select.Size = new System.Drawing.Size(75, 23);
            this.Menu_select.TabIndex = 14;
            this.Menu_select.Text = "关卡选择";
            this.Menu_select.UseVisualStyleBackColor = false;
            this.Menu_select.Click += new System.EventHandler(this.Menu_select_Click);
            // 
            // Menu_RankingList
            // 
            this.Menu_RankingList.BackColor = System.Drawing.Color.Transparent;
            this.Menu_RankingList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Menu_RankingList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Menu_RankingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_RankingList.Location = new System.Drawing.Point(43, 186);
            this.Menu_RankingList.Name = "Menu_RankingList";
            this.Menu_RankingList.Size = new System.Drawing.Size(75, 23);
            this.Menu_RankingList.TabIndex = 15;
            this.Menu_RankingList.Text = "排行榜";
            this.Menu_RankingList.UseVisualStyleBackColor = false;
            this.Menu_RankingList.Click += new System.EventHandler(this.Menu_RankingList_Click);
            // 
            // Menu_exit
            // 
            this.Menu_exit.BackColor = System.Drawing.Color.Transparent;
            this.Menu_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Menu_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Menu_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_exit.Location = new System.Drawing.Point(258, 186);
            this.Menu_exit.Name = "Menu_exit";
            this.Menu_exit.Size = new System.Drawing.Size(75, 23);
            this.Menu_exit.TabIndex = 16;
            this.Menu_exit.Text = "退出游戏";
            this.Menu_exit.UseVisualStyleBackColor = false;
            this.Menu_exit.Click += new System.EventHandler(this.Menu_exit_Click);
            // 
            // Menu_gamename
            // 
            this.Menu_gamename.AutoSize = true;
            this.Menu_gamename.BackColor = System.Drawing.Color.Transparent;
            this.Menu_gamename.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Menu_gamename.Location = new System.Drawing.Point(84, 33);
            this.Menu_gamename.Name = "Menu_gamename";
            this.Menu_gamename.Size = new System.Drawing.Size(207, 33);
            this.Menu_gamename.TabIndex = 17;
            this.Menu_gamename.Text = "贪吃蛇大作战";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 279);
            this.Controls.Add(this.Menu_gamename);
            this.Controls.Add(this.Menu_exit);
            this.Controls.Add(this.Menu_RankingList);
            this.Controls.Add(this.Menu_select);
            this.Controls.Add(this.Menu_start);
            this.Controls.Add(this.Menu_background);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Menu_background;
        private System.Windows.Forms.Button Menu_start;
        private System.Windows.Forms.Button Menu_select;
        private System.Windows.Forms.Button Menu_RankingList;
        private System.Windows.Forms.Button Menu_exit;
        private System.Windows.Forms.Label Menu_gamename;
    }
}