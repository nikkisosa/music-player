using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Text.RegularExpressions;

namespace Music_Player
{
    public partial class test : Form
    {
        bool repeatMode = false;
        string config = Application.StartupPath + @"\config\config.txt";
        static string txtFile = "";
        static string path = Application.StartupPath + @"\playlist\";
        string createPath = Application.StartupPath + @"\Playlist\";

        public string fileToOpen;
        WMPLib.WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
        List<string> PlayList = new List<string>();
        public test()
        {
            InitializeComponent();
            ReadVirtualList();
        }
        private void test_Load(object sender, EventArgs e)
        {
            trackBar1.Value = 50;
            foreach (var line in System.IO.File.ReadLines(config))
            {
                if (line.Contains("[default]:"))
                {

                    string myString = line.Split(':')[1].ToString();

                    listBox1.Items.Add(myString);
                }
            }
            string[] files = Directory.GetFiles(createPath);
            for (int iFile = 0; iFile < files.Length; iFile++)
            {
                string fn = new FileInfo(files[iFile]).Name;
                if (fn.Contains(".txt"))
                {
                    listBox2.Items.Add(fn);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(fileToOpen != null && fileToOpen.EndsWith(".mp3"))
            {
                wplayer.URL = fileToOpen;
                wplayer.controls.play();
                textBox1.Text = "Playing: " + fileToOpen;
                timer1.Start();
            }
            else if(fileToOpen == null)
            {
                //textBox1.Text = "no selected";
                if (PlayList.Count == 0)
                {
                    ReadVirtualList();
                }
                else
                {
                    fileToOpen = GetPreviousChoice();
                    wplayer.URL = fileToOpen;
                    wplayer.controls.next();
                    textBox1.Text = textBox1.Text = "Playing: " + fileToOpen;
                    timer1.Start();
                }
                
            }
            else if (!fileToOpen.EndsWith(".mp3"))
            {
                textBox1.Text = "cannot be played";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            FD.Filter = "MP3 |*.mp3";
            if(FD.ShowDialog() == DialogResult.OK)
            {
                fileToOpen = FD.FileName;
                if (!fileToOpen.EndsWith(".mp3"))
                {
                    textBox1.Text = "cannot be played";
                }
                else
                {
                    textBox1.Text = "file selected:" + fileToOpen;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double position = wplayer.controls.currentPosition;
            if(wplayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wplayer.controls.pause();
                position = wplayer.controls.currentPosition;
                textBox1.Text = "Current pause on: " + fileToOpen;
                button3.Text = "Resume";
            }
            else
            {
                wplayer.controls.play();
                wplayer.controls.currentPosition = position;
                textBox1.Text = "Current pause on: " + fileToOpen;
                button3.Text = "Pause";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fileToOpen != null && fileToOpen.EndsWith(".mp3"))
            {
               if(!PlaylistContainsFile())
               {
                   System.IO.File.WriteAllText(path, GetContent() + fileToOpen +  "@" + Environment.NewLine);
                   textBox1.Text = "File: " + fileToOpen + ": was addedd to the playlist";
                   PlayList.Add(fileToOpen);
               }
            }
            else
            {
                textBox1.Text = "You need to select a valid file";
            }
        }

        public bool PlaylistContainsFile()
        {
            string content = "";
            if(File.Exists(path))
            {
                content = File.ReadAllText(path);
                if(content.Contains(fileToOpen))
                {
                    textBox1.Text = "the selected file is already in the ply list";
                    return true;
                }
            }
            return false;
        }

        public string GetContent()
        {
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                content += "\n";
                return content;
            }
            return "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(PlayList.Count == 0)
            {
                ReadVirtualList();
            }
            else
            {
                fileToOpen = GetPreviousChoice();
                wplayer.URL = fileToOpen;
                wplayer.controls.play();
                textBox1.Text = textBox1.Text = "Playing: " + fileToOpen;
                timer1.Start();
            }
        }

        private string GetNextChoice()
        {
            foreach(string k in PlayList)
            {
                if(k == fileToOpen)
                {
                    try
                    {
                        if (PlayList.IndexOf(k) < PlayList.Count + 1)
                        {
                            return PlayList[PlayList.IndexOf(k) + 1];
                        }
                        else
                        {
                            return PlayList[0];
                        }
                    }
                    catch(Exception e)
                    {

                    }
                    
                }
            }
            return PlayList[0];
        }

        private string GetPreviousChoice()
        {
            foreach (string k in PlayList)
            {
                if (k == fileToOpen)
                {
                    try
                    {
                        if (PlayList.IndexOf(k) < PlayList.Count - 1)
                        {
                            return PlayList[PlayList.IndexOf(k) - 1];
                        }
                        else
                        {
                            return PlayList[0];
                        }
                    }
                    catch(Exception e)
                    {

                    }
                    
                }
            }
            return PlayList[0];
        }

        private void ReadVirtualList()
        {
            string content;
            if(File.Exists(path+txtFile))
            {
                content = File.ReadAllText(path + txtFile);
                if(content !=string.Empty)
                {
                    string songname = "";
                    char[] temp = content.ToCharArray();
                    for(int i=0;i<temp.Length;i++)
                    {
                        if(temp[i] == '@')
                        {
                            if(songname!=string.Empty)
                            {
                                PlayList.Add(songname);
                                textBox1.Text = songname + " was added to list";
                                songname = "";
                            }
                        }
                        else
                        {
                            songname += @temp[i];
                        }
                    }
                }
                else
                {
                    textBox1.Text = "Your playlist is emplty";
                }
            }
            else
            {
                textBox1.Text = "Your playlist does not exist";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Enabled = true;
            if(PlayList.Count == 0)
            {
                ReadVirtualList();
            }
            else
            {
                fileToOpen = GetNextChoice();
                wplayer.URL = fileToOpen;
                wplayer.controls.play();
                textBox1.Text = textBox1.Text = "Playing: " + fileToOpen;
                timer1.Interval = 1000;
                timer1.Start();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(PlayList.Count > 2)
            {
                Random i = new Random();
                int choice = i.Next(0, PlayList.Count);
                while(PlayList[choice] == fileToOpen)
                {
                    choice = i.Next(0, PlayList.Count);
                }
                fileToOpen = PlayList[choice];
                wplayer.URL = fileToOpen;
                wplayer.controls.play();
                textBox1.Text = "Playing: " + fileToOpen;
                
            }
            else if (PlayList.Count < 2 && PlayList.Count!=0)
            {
                textBox1.Text = "Shuffle requires atleast 3 song in the playlist";
            }
            else
            {
                textBox1.Text = "cannot shuffle empty playlist";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(button9.Text ==  "Repeat mode is off")
            {
                button9.Text = "Repeat mode is on";
                wplayer.settings.setMode("Loop", true);
            }
            else
            {
                button9.Text = "Repeat mode is off";
                wplayer.settings.setMode("Loop", true);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            wplayer.settings.volume += 10;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            wplayer.settings.volume -= 10;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(wplayer.settings.mute == true)
            {
                wplayer.settings.mute = false;
                button12.Text = "Mute";
            }
            else
            {
                wplayer.settings.mute = true;
                button12.Text = "UnMute";
            }
        }
        static int duration = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblstart.Text = wplayer.currentMedia.durationString;

            int seconds = Convert.ToInt32(wplayer.controls.currentPosition) % 60;
            int totalMinutes = Convert.ToInt32(wplayer.controls.currentPosition) / 60;
            int minutes = totalMinutes % 60;

            double t = Math.Floor(wplayer.currentMedia.duration - wplayer.controls.currentPosition);
            lbltotal.Text = (t.ToString());     
            if(duration == 0)
            {
                duration = Convert.ToInt32(t);
            }

            progressBar1.Maximum = (int)Math.Round(wplayer.currentMedia.duration);
            progressBar1.Step = (int)wplayer.controls.currentPosition;
            
            progressBar1.Value = (int)Math.Round(wplayer.controls.currentPosition);
            int c = Convert.ToInt32(wplayer.currentMedia.durationString) - progressBar1.Value;
            label5.Text = c.ToString();
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                progressBar1.PerformStep();
                progressBar1.Value = 0;
                timer1.Stop();
                timer1.Enabled = false;
                timer1.Enabled = true;
                button7.PerformClick();
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            //lbltotal.Text = DateTime.Now.ToString("h:m:s");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            wplayer.settings.volume = trackBar1.Value;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string c = createPath+@"\"+textBox2.Text+".txt";
            if(File.Exists(c))
            {
                MessageBox.Show("Play List is already exist");
            }
            else
            {
                File.CreateText(c);
                MessageBox.Show("Play List is successcully created");
            }
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFile = listBox2.SelectedItem.ToString();
            listBox3.Items.Clear();
            //MessageBox.Show(txtFile.ToString());
            foreach (var line in File.ReadLines(path+txtFile))
            {
                if (line.Contains("@"))
                {
                    string title = line.Substring(0, line.Length - 1);
                    listBox3.Items.Add(title);
                }
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var line in File.ReadLines(path + txtFile))
            {
                if (line.Contains("@"))
                {
                    string title = line.Substring(0, line.Length - 1);
                    fileToOpen = listBox3.SelectedItem.ToString();
                    wplayer.URL = fileToOpen;
                    wplayer.controls.play();
                    textBox1.Text = textBox1.Text = "Playing: " + fileToOpen;
                    timer1.Enabled = false;
                    timer1.Enabled = true;
                }
            }
            
            
        }
    }
}
