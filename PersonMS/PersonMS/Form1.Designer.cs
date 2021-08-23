namespace PersonMS
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.人员信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人员信息录入ToolStripMenuItem,
            this.人员信息查询ToolStripMenuItem,
            this.批量导入ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1234, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 人员信息录入ToolStripMenuItem
            // 
            this.人员信息录入ToolStripMenuItem.Name = "人员信息录入ToolStripMenuItem";
            this.人员信息录入ToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.人员信息录入ToolStripMenuItem.Text = "人员信息录入";
            this.人员信息录入ToolStripMenuItem.Click += new System.EventHandler(this.人员信息录入ToolStripMenuItem_Click);
            // 
            // 人员信息查询ToolStripMenuItem
            // 
            this.人员信息查询ToolStripMenuItem.Name = "人员信息查询ToolStripMenuItem";
            this.人员信息查询ToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.人员信息查询ToolStripMenuItem.Text = "人员信息查询";
            this.人员信息查询ToolStripMenuItem.Click += new System.EventHandler(this.人员信息查询ToolStripMenuItem_Click);
            // 
            // 批量导入ToolStripMenuItem
            // 
            this.批量导入ToolStripMenuItem.Name = "批量导入ToolStripMenuItem";
            this.批量导入ToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.批量导入ToolStripMenuItem.Text = "人员批量导入";
            this.批量导入ToolStripMenuItem.Click += new System.EventHandler(this.人员批量导入ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 972);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "校外人员进出信息管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 人员信息录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量导入ToolStripMenuItem;
    }
}

