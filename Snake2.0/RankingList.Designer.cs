namespace Snake
{
    partial class RankingList
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
            this.RankingList_Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RankingList_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "分数";
            // 
            // RankingList_Txt
            // 
            this.RankingList_Txt.Location = new System.Drawing.Point(23, 49);
            this.RankingList_Txt.Multiline = true;
            this.RankingList_Txt.Name = "RankingList_Txt";
            this.RankingList_Txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RankingList_Txt.Size = new System.Drawing.Size(371, 237);
            this.RankingList_Txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "排名";
            // 
            // RankingList_BT
            // 
            this.RankingList_BT.BackColor = System.Drawing.Color.Transparent;
            this.RankingList_BT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RankingList_BT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RankingList_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RankingList_BT.Location = new System.Drawing.Point(399, 298);
            this.RankingList_BT.Margin = new System.Windows.Forms.Padding(4);
            this.RankingList_BT.Name = "RankingList_BT";
            this.RankingList_BT.Size = new System.Drawing.Size(100, 29);
            this.RankingList_BT.TabIndex = 13;
            this.RankingList_BT.Text = "返回主界面";
            this.RankingList_BT.UseVisualStyleBackColor = false;
            this.RankingList_BT.Click += new System.EventHandler(this.RankingList_BT_Click);
            // 
            // RankingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 349);
            this.Controls.Add(this.RankingList_BT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RankingList_Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RankingList";
            this.Text = "排行榜";
            this.Load += new System.EventHandler(this.RankingList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RankingList_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RankingList_BT;
    }
}