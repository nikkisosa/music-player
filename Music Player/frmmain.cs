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
using Music_Player.__classes__;
namespace Music_Player
{
    public partial class frmmain : Form
    {
        frmsonglist songList;
        public frmmain()
        {
            InitializeComponent();
        }
        //WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        //    wplayer.URL = @"C:\Users\niks\Desktop\Zara Larsson - Uncover (Official).mp3";
        //    wplayer.controls.play();
        private void btnexit_Click(object sender, EventArgs e)
        {
            application.appExit();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            pnldrop.Hide();

            pnldrop.Size = new Size(301, 1);
        }

        private void btnDropNote_Click(object sender, EventArgs e)
        {
            if(pnldrop.Size.Height == 1)
            {
                pnldrop.BringToFront();
                pnldrop.Show();
                pnldrop.Size = new Size(301, 204);
            }
            else if (pnldrop.Size.Height == 204)
            {
                pnldrop.Size = new Size(301, 1);
                pnldrop.Hide();
                pnldrop.SendToBack();
            }
        }

        private void pnldrop_MouseLeave(object sender, EventArgs e)
        {
            //if (lblopen.Cursor == Cursors.Hand)
            //{
            //    pnldrop.Size = new Size(301, 204);
            //}
                pnldrop.Size = new Size(301, 1);
                pnldrop.Hide();
            
        }

        private void btnplaylist_Click(object sender, EventArgs e)
        {
           if(songList == null)
           {
               songList = new frmsonglist();
               songList.FormClosed += songList_FormClosed;
               songList.Show();
           }
           else
           {
               songList.Activate();
           }
        }

        void songList_FormClosed(object sender, FormClosedEventArgs e)
        {
            songList = null;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            application.appExit();
        }
    }
}
