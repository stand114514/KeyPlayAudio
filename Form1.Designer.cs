
namespace 音频绑定按键
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainlist = new System.Windows.Forms.Panel();
            this.testkeybox = new System.Windows.Forms.Panel();
            this.testfile_lab = new System.Windows.Forms.Label();
            this.sefile_btn = new System.Windows.Forms.Button();
            this.testkill_btn = new System.Windows.Forms.Button();
            this.testtextbox = new System.Windows.Forms.TextBox();
            this.textlab = new System.Windows.Forms.Label();
            this.addkey_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectfile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopplay_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.testkeybox.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainlist
            // 
            this.mainlist.AutoScroll = true;
            this.mainlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainlist.Location = new System.Drawing.Point(2, 36);
            this.mainlist.Margin = new System.Windows.Forms.Padding(2);
            this.mainlist.Name = "mainlist";
            this.mainlist.Size = new System.Drawing.Size(700, 403);
            this.mainlist.TabIndex = 0;
            // 
            // testkeybox
            // 
            this.testkeybox.BackColor = System.Drawing.Color.Silver;
            this.testkeybox.Controls.Add(this.testfile_lab);
            this.testkeybox.Controls.Add(this.sefile_btn);
            this.testkeybox.Controls.Add(this.testkill_btn);
            this.testkeybox.Controls.Add(this.testtextbox);
            this.testkeybox.Controls.Add(this.textlab);
            this.testkeybox.Location = new System.Drawing.Point(54, 93);
            this.testkeybox.Name = "testkeybox";
            this.testkeybox.Size = new System.Drawing.Size(680, 34);
            this.testkeybox.TabIndex = 0;
            this.testkeybox.Visible = false;
            // 
            // testfile_lab
            // 
            this.testfile_lab.AutoSize = true;
            this.testfile_lab.Location = new System.Drawing.Point(171, 9);
            this.testfile_lab.Name = "testfile_lab";
            this.testfile_lab.Size = new System.Drawing.Size(92, 17);
            this.testfile_lab.TabIndex = 4;
            this.testfile_lab.Text = "未设置绑定音频";
            // 
            // sefile_btn
            // 
            this.sefile_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sefile_btn.FlatAppearance.BorderSize = 0;
            this.sefile_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sefile_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sefile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sefile_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sefile_btn.ForeColor = System.Drawing.Color.White;
            this.sefile_btn.Location = new System.Drawing.Point(514, 2);
            this.sefile_btn.Margin = new System.Windows.Forms.Padding(2);
            this.sefile_btn.Name = "sefile_btn";
            this.sefile_btn.Size = new System.Drawing.Size(80, 30);
            this.sefile_btn.TabIndex = 3;
            this.sefile_btn.Text = "选择文件";
            this.sefile_btn.UseVisualStyleBackColor = false;
            this.sefile_btn.Click += new System.EventHandler(this.selectfile_click);
            // 
            // testkill_btn
            // 
            this.testkill_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.testkill_btn.FlatAppearance.BorderSize = 0;
            this.testkill_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.testkill_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.testkill_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testkill_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.testkill_btn.ForeColor = System.Drawing.Color.White;
            this.testkill_btn.Location = new System.Drawing.Point(598, 2);
            this.testkill_btn.Margin = new System.Windows.Forms.Padding(2);
            this.testkill_btn.Name = "testkill_btn";
            this.testkill_btn.Size = new System.Drawing.Size(80, 30);
            this.testkill_btn.TabIndex = 2;
            this.testkill_btn.Text = "删除";
            this.testkill_btn.UseVisualStyleBackColor = false;
            this.testkill_btn.Click += new System.EventHandler(this.killbox_click);
            // 
            // testtextbox
            // 
            this.testtextbox.Location = new System.Drawing.Point(53, 6);
            this.testtextbox.Name = "testtextbox";
            this.testtextbox.ReadOnly = true;
            this.testtextbox.Size = new System.Drawing.Size(100, 23);
            this.testtextbox.TabIndex = 2;
            this.testtextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textlab
            // 
            this.textlab.AutoSize = true;
            this.textlab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textlab.ForeColor = System.Drawing.Color.White;
            this.textlab.Location = new System.Drawing.Point(3, 9);
            this.textlab.Name = "textlab";
            this.textlab.Size = new System.Drawing.Size(39, 17);
            this.textlab.TabIndex = 0;
            this.textlab.Text = "按键0";
            // 
            // addkey_btn
            // 
            this.addkey_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addkey_btn.FlatAppearance.BorderSize = 0;
            this.addkey_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.addkey_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.addkey_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addkey_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addkey_btn.ForeColor = System.Drawing.Color.White;
            this.addkey_btn.Location = new System.Drawing.Point(2, 2);
            this.addkey_btn.Margin = new System.Windows.Forms.Padding(2);
            this.addkey_btn.Name = "addkey_btn";
            this.addkey_btn.Size = new System.Drawing.Size(80, 30);
            this.addkey_btn.TabIndex = 1;
            this.addkey_btn.Text = "添加绑定";
            this.addkey_btn.UseVisualStyleBackColor = false;
            this.addkey_btn.Click += new System.EventHandler(this.addkey_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.start_btn.FlatAppearance.BorderSize = 0;
            this.start_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.start_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(86, 2);
            this.start_btn.Margin = new System.Windows.Forms.Padding(2);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(93, 30);
            this.start_btn.TabIndex = 2;
            this.start_btn.Tag = "0";
            this.start_btn.Text = "启动按键检测";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(622, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "关于软件";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectfile
            // 
            this.selectfile.Filter = "音频文件|*.mp3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "按下的键";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(339, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "无";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "按键绑定音频";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开软件ToolStripMenuItem,
            this.关闭软件ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 48);
            // 
            // 打开软件ToolStripMenuItem
            // 
            this.打开软件ToolStripMenuItem.Name = "打开软件ToolStripMenuItem";
            this.打开软件ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.打开软件ToolStripMenuItem.Text = "打开软件";
            this.打开软件ToolStripMenuItem.Click += new System.EventHandler(this.打开软件ToolStripMenuItem_Click);
            // 
            // 关闭软件ToolStripMenuItem
            // 
            this.关闭软件ToolStripMenuItem.Name = "关闭软件ToolStripMenuItem";
            this.关闭软件ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.关闭软件ToolStripMenuItem.Text = "关闭软件";
            this.关闭软件ToolStripMenuItem.Click += new System.EventHandler(this.关闭软件ToolStripMenuItem_Click);
            // 
            // stopplay_btn
            // 
            this.stopplay_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.stopplay_btn.FlatAppearance.BorderSize = 0;
            this.stopplay_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.stopplay_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.stopplay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopplay_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopplay_btn.ForeColor = System.Drawing.Color.White;
            this.stopplay_btn.Location = new System.Drawing.Point(183, 2);
            this.stopplay_btn.Margin = new System.Windows.Forms.Padding(2);
            this.stopplay_btn.Name = "stopplay_btn";
            this.stopplay_btn.Size = new System.Drawing.Size(80, 30);
            this.stopplay_btn.TabIndex = 7;
            this.stopplay_btn.Text = "停止播放";
            this.stopplay_btn.UseVisualStyleBackColor = false;
            this.stopplay_btn.Click += new System.EventHandler(this.stopplay_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(538, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "最最小化";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stopplay_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.addkey_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testkeybox);
            this.Controls.Add(this.mainlist);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "按键绑定音频";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.testkeybox.ResumeLayout(false);
            this.testkeybox.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainlist;
        private System.Windows.Forms.Button addkey_btn;
        private System.Windows.Forms.Button sefile_btn;
        private System.Windows.Forms.Button testkill_btn;
        private System.Windows.Forms.TextBox testtextbox;
        private System.Windows.Forms.Label textlab;
        private System.Windows.Forms.Label testfile_lab;
        private System.Windows.Forms.Panel testkeybox;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog selectfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开软件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭软件ToolStripMenuItem;
        private System.Windows.Forms.Button stopplay_btn;
        private System.Windows.Forms.Button button1;
    }
}

