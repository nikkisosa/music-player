namespace Music_Player
{
    partial class frmsonglist
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsonglist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblProgress = new System.Windows.Forms.ProgressBar();
            this.lbltitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnpause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnnext = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnplay = new Bunifu.Framework.UI.BunifuImageButton();
            this.bntprevious = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpfolder = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnfile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnshuffle = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnpause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntprevious)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnshuffle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnshuffle);
            this.panel1.Controls.Add(this.lbltime);
            this.panel1.Controls.Add(this.lblProgress);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Controls.Add(this.btnpause);
            this.panel1.Controls.Add(this.btnnext);
            this.panel1.Controls.Add(this.btnplay);
            this.panel1.Controls.Add(this.bntprevious);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 544);
            this.panel1.TabIndex = 0;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(616, 464);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 13);
            this.lbltime.TabIndex = 9;
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(250, 451);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(393, 10);
            this.lblProgress.Step = 2;
            this.lblProgress.TabIndex = 8;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(247, 431);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(0, 13);
            this.lbltitle.TabIndex = 7;
            // 
            // btnpause
            // 
            this.btnpause.BackColor = System.Drawing.Color.Transparent;
            this.btnpause.Image = ((System.Drawing.Image)(resources.GetObject("btnpause.Image")));
            this.btnpause.ImageActive = null;
            this.btnpause.Location = new System.Drawing.Point(380, 468);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(33, 29);
            this.btnpause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnpause.TabIndex = 6;
            this.btnpause.TabStop = false;
            this.btnpause.Zoom = 10;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.Transparent;
            this.btnnext.Image = ((System.Drawing.Image)(resources.GetObject("btnnext.Image")));
            this.btnnext.ImageActive = null;
            this.btnnext.Location = new System.Drawing.Point(475, 468);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(33, 29);
            this.btnnext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnnext.TabIndex = 5;
            this.btnnext.TabStop = false;
            this.btnnext.Zoom = 10;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.Color.Transparent;
            this.btnplay.Image = ((System.Drawing.Image)(resources.GetObject("btnplay.Image")));
            this.btnplay.ImageActive = null;
            this.btnplay.Location = new System.Drawing.Point(427, 468);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(33, 29);
            this.btnplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnplay.TabIndex = 4;
            this.btnplay.TabStop = false;
            this.btnplay.Zoom = 10;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // bntprevious
            // 
            this.bntprevious.BackColor = System.Drawing.Color.Transparent;
            this.bntprevious.Image = ((System.Drawing.Image)(resources.GetObject("bntprevious.Image")));
            this.bntprevious.ImageActive = null;
            this.bntprevious.Location = new System.Drawing.Point(331, 468);
            this.bntprevious.Name = "bntprevious";
            this.bntprevious.Size = new System.Drawing.Size(33, 29);
            this.bntprevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntprevious.TabIndex = 3;
            this.bntprevious.TabStop = false;
            this.bntprevious.Zoom = 10;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Location = new System.Drawing.Point(236, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 397);
            this.panel4.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(418, 397);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(660, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 532);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.flpfolder);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 532);
            this.panel2.TabIndex = 0;
            // 
            // flpfolder
            // 
            this.flpfolder.AutoScroll = true;
            this.flpfolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpfolder.Location = new System.Drawing.Point(0, 0);
            this.flpfolder.Name = "flpfolder";
            this.flpfolder.Size = new System.Drawing.Size(229, 532);
            this.flpfolder.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(780, 10);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(31, 28);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 9;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(836, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(31, 28);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "MP3 Files|*.mp3";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // btnfile
            // 
            this.btnfile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfile.BorderRadius = 0;
            this.btnfile.ButtonText = "Open folder";
            this.btnfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnfile.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnfile.Iconimage")));
            this.btnfile.Iconimage_right = null;
            this.btnfile.Iconimage_right_Selected = null;
            this.btnfile.Iconimage_Selected = null;
            this.btnfile.IconZoom = 90D;
            this.btnfile.IsTab = false;
            this.btnfile.Location = new System.Drawing.Point(102, 29);
            this.btnfile.Name = "btnfile";
            this.btnfile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnfile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnfile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnfile.selected = false;
            this.btnfile.Size = new System.Drawing.Size(127, 31);
            this.btnfile.TabIndex = 10;
            this.btnfile.Textcolor = System.Drawing.Color.White;
            this.btnfile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnshuffle
            // 
            this.btnshuffle.BackColor = System.Drawing.Color.Transparent;
            this.btnshuffle.Image = ((System.Drawing.Image)(resources.GetObject("btnshuffle.Image")));
            this.btnshuffle.ImageActive = null;
            this.btnshuffle.Location = new System.Drawing.Point(524, 468);
            this.btnshuffle.Name = "btnshuffle";
            this.btnshuffle.Size = new System.Drawing.Size(33, 29);
            this.btnshuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnshuffle.TabIndex = 10;
            this.btnshuffle.TabStop = false;
            this.btnshuffle.Zoom = 10;
            this.btnshuffle.Click += new System.EventHandler(this.btnshuffle_Click);
            // 
            // frmsonglist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 612);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsonglist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Song Liist";
            this.Load += new System.EventHandler(this.frmsonglist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnpause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntprevious)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnshuffle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnpause;
        private Bunifu.Framework.UI.BunifuImageButton btnnext;
        private Bunifu.Framework.UI.BunifuImageButton btnplay;
        private Bunifu.Framework.UI.BunifuImageButton bntprevious;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FlowLayoutPanel flpfolder;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltime;
        private System.Windows.Forms.ProgressBar lblProgress;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuImageButton btnshuffle;
    }
}