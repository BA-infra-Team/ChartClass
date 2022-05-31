namespace ChartClass
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.차트데이터추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.차트데이터추가ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.차트데이터삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.차트숨기기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.차트보이기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.차트데이터추가ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 차트데이터추가ToolStripMenuItem
            // 
            this.차트데이터추가ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.차트데이터추가ToolStripMenuItem1,
            this.차트데이터삭제ToolStripMenuItem,
            this.차트숨기기ToolStripMenuItem,
            this.차트보이기ToolStripMenuItem});
            this.차트데이터추가ToolStripMenuItem.Name = "차트데이터추가ToolStripMenuItem";
            this.차트데이터추가ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.차트데이터추가ToolStripMenuItem.Text = "메뉴";
            // 
            // 차트데이터추가ToolStripMenuItem1
            // 
            this.차트데이터추가ToolStripMenuItem1.Name = "차트데이터추가ToolStripMenuItem1";
            this.차트데이터추가ToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.차트데이터추가ToolStripMenuItem1.Text = "차트데이터추가";
            this.차트데이터추가ToolStripMenuItem1.Click += new System.EventHandler(this.차트데이터추가ToolStripMenuItem1_Click);
            // 
            // 차트데이터삭제ToolStripMenuItem
            // 
            this.차트데이터삭제ToolStripMenuItem.Name = "차트데이터삭제ToolStripMenuItem";
            this.차트데이터삭제ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.차트데이터삭제ToolStripMenuItem.Text = "차트데이터삭제";
            this.차트데이터삭제ToolStripMenuItem.Click += new System.EventHandler(this.차트데이터삭제ToolStripMenuItem_Click);
            // 
            // 차트숨기기ToolStripMenuItem
            // 
            this.차트숨기기ToolStripMenuItem.Name = "차트숨기기ToolStripMenuItem";
            this.차트숨기기ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.차트숨기기ToolStripMenuItem.Text = "차트숨기기";
            this.차트숨기기ToolStripMenuItem.Click += new System.EventHandler(this.차트숨기기ToolStripMenuItem_Click);
            // 
            // 차트보이기ToolStripMenuItem
            // 
            this.차트보이기ToolStripMenuItem.Name = "차트보이기ToolStripMenuItem";
            this.차트보이기ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.차트보이기ToolStripMenuItem.Text = "차트보이기";
            this.차트보이기ToolStripMenuItem.Click += new System.EventHandler(this.차트보이기ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1058, 495);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 차트데이터추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 차트데이터추가ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 차트데이터삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 차트숨기기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 차트보이기ToolStripMenuItem;
    }
}

