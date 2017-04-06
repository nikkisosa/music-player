using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music_Player.__classes__;
namespace Music_Player
{
    public partial class frmsonglist : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public frmsonglist()
        {
            InitializeComponent();
        }
        
        string [] files,path;
        public void notif(string Foldername)
        {
            int i = 1;
            Button btn = new Button();
            btn.Parent = this;
            btn.BackColor = Color.LightCyan;
            btn.Name = "btnFlow"+i;
            btn.Click += btn_Click;
            btn.Text = Foldername;

            btn.Font = new Font(btn.Font.FontFamily, 8);
            btn.Size = new Size(120, 20);

            btn.ForeColor = Color.Red;
            flpfolder.Controls.Add(btn);


            
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
        }

        public void folderClick()
        {
            flpfolder.Controls.Clear();
            foreach (string dir in path)
            {
                notif(Path.GetFileName(dir));
            }

        }
        private void frmsonglist_Load(object sender, EventArgs e)
        {
            //folderClick();
            listBox1.BackColor = Color.Black;
        }

        private void btnfile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //listBox1.Items.Clear();
                files = openFileDialog1.SafeFileNames;
                path = openFileDialog1.FileNames;

                for(int i = 0; i < files.Length; i ++)
                {
                    //notif(files[i]);
                    
                    listBox1.Items.Add(files[i]);
                    lbltime.Text = (1 + i).ToString();
                }
            }
        }
        string url;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            url = path[listBox1.SelectedIndex];
            lbltitle.Text = files[listBox1.SelectedIndex];
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            wplayer.controls.pause();
            wplayer.URL = url;
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            double time = wplayer.controls.currentPosition; //return always 0 for you, because you pause first and after get the value
            wplayer.controls.pause();

            wplayer.controls.currentPosition = time;

            lbltime.Text = time.ToString();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            wplayer.controls.next();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            wplayer.controls.pause();
            wplayer.URL = path[listBox1.SelectedIndex];
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            application.appExit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnshuffle_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection list = listBox1.Items;
            Random random = new Random();
            int w = list.Count;
            listBox1.BeginUpdate();
            while (w > 1)
            {
                w--;
                int u = random.Next(w + 1);
                object value = list[u];
                list[u] = list[w];
                list[w] = value;
            }
            listBox1.EndUpdate();
            listBox1.Invalidate();
        }
    }
}
