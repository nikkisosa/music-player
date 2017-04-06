namespace Music_Player
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.btnscann = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnlibraries = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnplaylist = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnexit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDropNote = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnldrop = new System.Windows.Forms.Panel();
            this.lblplaylist = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbllibraries = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblscann = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblopen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnscann)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlibraries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnplaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDropNote)).BeginInit();
            this.pnldrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnscann
            // 
            this.btnscann.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnscann.BackColor = System.Drawing.Color.Transparent;
            this.btnscann.Image = ((System.Drawing.Image)(resources.GetObject("btnscann.Image")));
            this.btnscann.ImageActive = null;
            this.btnscann.Location = new System.Drawing.Point(124, 126);
            this.btnscann.Name = "btnscann";
            this.btnscann.Size = new System.Drawing.Size(176, 168);
            this.btnscann.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnscann.TabIndex = 0;
            this.btnscann.TabStop = false;
            this.btnscann.Zoom = 10;
            // 
            // btnlibraries
            // 
            this.btnlibraries.BackColor = System.Drawing.Color.Transparent;
            this.btnlibraries.Image = ((System.Drawing.Image)(resources.GetObject("btnlibraries.Image")));
            this.btnlibraries.ImageActive = null;
            this.btnlibraries.Location = new System.Drawing.Point(360, 126);
            this.btnlibraries.Name = "btnlibraries";
            this.btnlibraries.Size = new System.Drawing.Size(176, 168);
            this.btnlibraries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnlibraries.TabIndex = 1;
            this.btnlibraries.TabStop = false;
            this.btnlibraries.Zoom = 10;
            // 
            // btnplaylist
            // 
            this.btnplaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnplaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnplaylist.Image")));
            this.btnplaylist.ImageActive = null;
            this.btnplaylist.Location = new System.Drawing.Point(600, 126);
            this.btnplaylist.Name = "btnplaylist";
            this.btnplaylist.Size = new System.Drawing.Size(176, 168);
            this.btnplaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnplaylist.TabIndex = 2;
            this.btnplaylist.TabStop = false;
            this.btnplaylist.Zoom = 10;
            this.btnplaylist.Click += new System.EventHandler(this.btnplaylist_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageActive = null;
            this.btnexit.Location = new System.Drawing.Point(360, 306);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(176, 168);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnexit.TabIndex = 3;
            this.btnexit.TabStop = false;
            this.btnexit.Zoom = 10;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnDropNote
            // 
            this.btnDropNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDropNote.BackColor = System.Drawing.Color.Transparent;
            this.btnDropNote.Image = ((System.Drawing.Image)(resources.GetObject("btnDropNote.Image")));
            this.btnDropNote.ImageActive = null;
            this.btnDropNote.Location = new System.Drawing.Point(8, 8);
            this.btnDropNote.Name = "btnDropNote";
            this.btnDropNote.Size = new System.Drawing.Size(67, 60);
            this.btnDropNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDropNote.TabIndex = 4;
            this.btnDropNote.TabStop = false;
            this.btnDropNote.Zoom = 10;
            this.btnDropNote.Click += new System.EventHandler(this.btnDropNote_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnldrop
            // 
            this.pnldrop.BackColor = System.Drawing.Color.Transparent;
            this.pnldrop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnldrop.BackgroundImage")));
            this.pnldrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnldrop.Controls.Add(this.lblplaylist);
            this.pnldrop.Controls.Add(this.lbllibraries);
            this.pnldrop.Controls.Add(this.lblscann);
            this.pnldrop.Controls.Add(this.lblopen);
            this.pnldrop.Location = new System.Drawing.Point(-1, 64);
            this.pnldrop.Name = "pnldrop";
            this.pnldrop.Size = new System.Drawing.Size(301, 204);
            this.pnldrop.TabIndex = 5;
            this.pnldrop.MouseLeave += new System.EventHandler(this.pnldrop_MouseLeave);
            // 
            // lblplaylist
            // 
            this.lblplaylist.AutoSize = true;
            this.lblplaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblplaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplaylist.ForeColor = System.Drawing.SystemColors.Control;
            this.lblplaylist.Location = new System.Drawing.Point(27, 153);
            this.lblplaylist.Name = "lblplaylist";
            this.lblplaylist.Size = new System.Drawing.Size(72, 18);
            this.lblplaylist.TabIndex = 3;
            this.lblplaylist.Text = "Play List";
            // 
            // lbllibraries
            // 
            this.lbllibraries.AutoSize = true;
            this.lbllibraries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbllibraries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllibraries.ForeColor = System.Drawing.SystemColors.Control;
            this.lbllibraries.Location = new System.Drawing.Point(27, 121);
            this.lbllibraries.Name = "lbllibraries";
            this.lbllibraries.Size = new System.Drawing.Size(73, 18);
            this.lbllibraries.TabIndex = 2;
            this.lbllibraries.Text = "Libraries";
            // 
            // lblscann
            // 
            this.lblscann.AutoSize = true;
            this.lblscann.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblscann.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscann.ForeColor = System.Drawing.SystemColors.Control;
            this.lblscann.Location = new System.Drawing.Point(27, 92);
            this.lblscann.Name = "lblscann";
            this.lblscann.Size = new System.Drawing.Size(103, 18);
            this.lblscann.TabIndex = 1;
            this.lblscann.Text = "Scann folder";
            // 
            // lblopen
            // 
            this.lblopen.AutoSize = true;
            this.lblopen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopen.ForeColor = System.Drawing.SystemColors.Control;
            this.lblopen.Location = new System.Drawing.Point(27, 62);
            this.lblopen.Name = "lblopen";
            this.lblopen.Size = new System.Drawing.Size(96, 18);
            this.lblopen.TabIndex = 0;
            this.lblopen.Text = "Open folder";
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
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
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
            this.bunifuImageButton2.TabIndex = 7;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 612);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnDropNote);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnplaylist);
            this.Controls.Add(this.btnlibraries);
            this.Controls.Add(this.btnscann);
            this.Controls.Add(this.pnldrop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnscann)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlibraries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnplaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDropNote)).EndInit();
            this.pnldrop.ResumeLayout(false);
            this.pnldrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnscann;
        private Bunifu.Framework.UI.BunifuImageButton btnlibraries;
        private Bunifu.Framework.UI.BunifuImageButton btnplaylist;
        private Bunifu.Framework.UI.BunifuImageButton btnexit;
        private Bunifu.Framework.UI.BunifuImageButton btnDropNote;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel pnldrop;
        private Bunifu.Framework.UI.BunifuCustomLabel lblplaylist;
        private Bunifu.Framework.UI.BunifuCustomLabel lbllibraries;
        private Bunifu.Framework.UI.BunifuCustomLabel lblscann;
        private Bunifu.Framework.UI.BunifuCustomLabel lblopen;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}

