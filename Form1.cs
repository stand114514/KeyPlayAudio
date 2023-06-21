using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;

namespace 音频绑定按键
{
    public partial class Form1 : Form
    {
        private ArrayList keyList = new ArrayList();
        private ArrayList pathList = new ArrayList();
        private String CONFIG_PATH = "配置.txt";
        [DllImport("winmm.dll")]//音频播放相关
        public static extern uint mciSendString(string lpstrCommand, string lpstrReturnString, uint uReturnLength, uint hWndCallback);
        public Form1()
        {
            InitializeComponent();
        }

        private void createBox()
        {
            keyList.Clear();
            pathList.Clear();
            if (!File.Exists(CONFIG_PATH))
            {
                FileStream fs = File.Create(CONFIG_PATH);//创建文件
                fs.Close();
                return;
            }
            string[] Config_Filelist = File.ReadAllLines(CONFIG_PATH);
            int y = 0;
            for (int i = 0; i < Config_Filelist.Length; i++)
            {
                String[] boxmsg = Config_Filelist[i].Split('-');
                keyList.Add(boxmsg[0]);
                pathList.Add(boxmsg[1]);

                Panel panel = new Panel();
                panel.Name = "keybox" + i.ToString();
                panel.Location = new Point(0, y);
                panel.Size = testkeybox.Size;
                panel.BackColor = testkeybox.BackColor;

                Label label = new Label();
                label.Text = $"按键{i+1}";
                label.Location = textlab.Location;
                label.Size = textlab.Size;
                label.ForeColor = textlab.ForeColor;
                label.BackColor = textlab.BackColor;
                panel.Controls.Add(label);

                TextBox textbox = new TextBox();
                textbox.Text = boxmsg[0];
                textbox.Location = testtextbox.Location;
                textbox.Size = testtextbox.Size;
                textbox.ReadOnly = true;
                textbox.KeyDown += new KeyEventHandler(textBox1_KeyDown);
                textbox.Name = "keycode" + i.ToString();
                textbox.Tag = i;
                panel.Controls.Add(textbox);

                Label label1 = new Label();
                label1.Text = boxmsg[1];
                label1.Location = testfile_lab.Location;
                label1.Size = new Size(300, 17);
                label1.Name = "filetext" + i.ToString();
                panel.Controls.Add(label1);

                Button button1 = new Button();
                button1.Text = sefile_btn.Text;
                button1.Size = sefile_btn.Size;
                button1.Location = sefile_btn.Location;
                button1.BackColor = sefile_btn.BackColor;
                button1.ForeColor = sefile_btn.ForeColor;
                button1.FlatStyle = sefile_btn.FlatStyle;
                button1.FlatAppearance.BorderSize = 0;
                button1.FlatAppearance.MouseOverBackColor = sefile_btn.FlatAppearance.MouseOverBackColor;
                button1.FlatAppearance.MouseDownBackColor = sefile_btn.FlatAppearance.MouseDownBackColor;
                button1.Click += new EventHandler(selectfile_click);
                button1.Tag = i;
                panel.Controls.Add(button1);

                Button button2 = new Button();
                button2.Text = testkill_btn.Text;
                button2.Size = testkill_btn.Size;
                button2.Location = testkill_btn.Location;
                button2.BackColor = testkill_btn.BackColor;
                button2.ForeColor = testkill_btn.ForeColor;
                button2.FlatStyle = testkill_btn.FlatStyle;
                button2.FlatAppearance.BorderSize = 0;
                button2.FlatAppearance.MouseOverBackColor = testkill_btn.FlatAppearance.MouseOverBackColor;
                button2.FlatAppearance.MouseDownBackColor = testkill_btn.FlatAppearance.MouseDownBackColor;
                button2.Tag = i;
                button2.Click += new EventHandler(killbox_click);
                panel.Controls.Add(button2);


                mainlist.Controls.Add(panel);
                y += 37;
            }
        }
        /// <summary>
        /// 播放音乐文件
        /// </summary>
        /// <param name="p_FileName">音乐文件名称</param>
        public static void PlayMusic(string p_FileName)
        {
            try
            {
                mciSendString(@"close temp_music", " ", 0, 0);
                //mciSendString(@"open " + p_FileName + " alias temp_music", " ", 0, 0);
                mciSendString(@"open """ + p_FileName + @""" alias temp_music", null, 0, 0);
                mciSendString(@"play temp_music", " ", 0, 0);
            }
            catch
            { }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            String key = e.KeyCode.ToString();
            if (((IList)keyList).Contains(key))
            {
                MessageBox.Show("这个按键已经存在", "key");
                return;
            }
            textBox.Text = key;
            String[] Config_Filelist = File.ReadAllLines(CONFIG_PATH);
            int index = (int)textBox.Tag;
            Config_Filelist[index] = $"{textBox.Text}-{Config_Filelist[index].Split('-')[1]}";
            File.WriteAllLines(CONFIG_PATH, Config_Filelist);
            mainlist.Controls.Clear();
            createBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createBox();
            start_btn.Tag = 0;
            this.KeyDown -= new KeyEventHandler(Form1_KeyDown);
        }

        private void selectfile_click(object sender, EventArgs e)
        {
            selectfile.ShowDialog();
            if (selectfile.FileName != "")
            {
                Control control = (Control)sender;
                TextBox textBox = (TextBox)Controls.Find("keycode" + control.Tag.ToString(),true)[0];
                String[] Config_Filelist = File.ReadAllLines(CONFIG_PATH);
                Config_Filelist[(int)control.Tag] = $"{textBox.Text}-{selectfile.FileName}";
                File.WriteAllLines(CONFIG_PATH, Config_Filelist);
                mainlist.Controls.Clear();
                createBox();
            }
        }

        private void killbox_click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            ArrayList Config_Filelist = new ArrayList(File.ReadAllLines(CONFIG_PATH));
            Config_Filelist.RemoveAt((int)control.Tag);
            String[] savefile = new String[Config_Filelist.Count];
            int num = 0;
            foreach(String i in Config_Filelist)
            {
                savefile[num] = i;
                num++;
            }
            File.WriteAllLines(CONFIG_PATH, savefile);
            mainlist.Controls.Clear();
            createBox();
        }

        private void addkey_btn_Click(object sender, EventArgs e)
        {
            File.AppendAllText(CONFIG_PATH, " -未绑定音频文件\r\n");
            mainlist.Controls.Clear();
            createBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(start_btn.Tag.Equals(0))
            {
                start_btn.Tag = 1;
                start_btn.BackColor = Color.FromArgb(48, 187, 94);
                start_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 233, 130);
                this.KeyDown += new KeyEventHandler(Form1_KeyDown);
                start_btn.Text = "关闭按键检测";
                return;
            }
            start_btn.BackColor = Color.FromArgb(130, 43, 43);
            start_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 100, 100);
            this.KeyDown -= new KeyEventHandler(Form1_KeyDown);
            start_btn.Tag = 0;
            start_btn.Text = "启动按键检测";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            String key = e.KeyCode.ToString();
            label2.Text = key;
            for(int i = 0; i < keyList.Count; i++)
            {
                if (key.Equals(keyList[i]))
                {
                    if (!pathList[i].Equals("未绑定音频文件"))
                    {
                        PlayMusic(pathList[i].ToString());
                    }
                    return;
                }
                continue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能：给你键盘上的按键绑定声音\r\n这个按键按下时，播放对应的音频\r\n作者：stand","stand");
        }

        private void 打开软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }

        private void 关闭软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void stopplay_btn_Click(object sender, EventArgs e)
        {
            try
            {
                mciSendString(@"close temp_music", " ", 0, 0);
            }
            catch
            {
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //最小化
            this.ShowInTaskbar = false; //在任务栏中不显示窗体
            this.notifyIcon1.Visible = true; //托盘图标可见
        }
    }
}
