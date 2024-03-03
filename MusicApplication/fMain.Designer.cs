namespace MusicApplication
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnHS = new Panel();
            txtSearch = new TextBox();
            lbSearch = new Label();
            lbHome = new Label();
            pnLibrary = new Panel();
            listLibrary = new ListView();
            lbLibrary = new Label();
            pnView = new Panel();
            btnRemove = new Button();
            btnBrowse = new Button();
            btnRemoveLib = new Button();
            btnAddLib = new Button();
            listSong = new ListView();
            trackBarTime = new TrackBar();
            trackBarVolume = new TrackBar();
            btnPlay = new PictureBox();
            btnNext = new PictureBox();
            btnLoop = new PictureBox();
            btnBack = new PictureBox();
            btnShuffler = new PictureBox();
            picVolume = new PictureBox();
            lbName = new Label();
            timer = new System.Windows.Forms.Timer(components);
            songDuration = new Label();
            songCurrentDuration = new Label();
            pnHS.SuspendLayout();
            pnLibrary.SuspendLayout();
            pnView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPlay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLoop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnShuffler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVolume).BeginInit();
            SuspendLayout();
            // 
            // pnHS
            // 
            pnHS.BackColor = Color.FromArgb(18, 18, 18);
            pnHS.Controls.Add(txtSearch);
            pnHS.Controls.Add(lbSearch);
            pnHS.Controls.Add(lbHome);
            pnHS.Location = new Point(12, 12);
            pnHS.Name = "pnHS";
            pnHS.Size = new Size(330, 183);
            pnHS.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(18, 18, 18);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(15, 127);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(298, 43);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbSearch
            // 
            lbSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSearch.Image = Properties.Resources.search;
            lbSearch.ImageAlign = ContentAlignment.MiddleLeft;
            lbSearch.Location = new Point(15, 62);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(298, 62);
            lbSearch.TabIndex = 1;
            lbSearch.Text = "Search";
            lbSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbHome
            // 
            lbHome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHome.Image = Properties.Resources.home_clicked;
            lbHome.ImageAlign = ContentAlignment.MiddleLeft;
            lbHome.Location = new Point(15, 0);
            lbHome.Name = "lbHome";
            lbHome.Size = new Size(298, 62);
            lbHome.TabIndex = 0;
            lbHome.Text = "Home";
            lbHome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnLibrary
            // 
            pnLibrary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnLibrary.BackColor = Color.FromArgb(18, 18, 18);
            pnLibrary.Controls.Add(listLibrary);
            pnLibrary.Controls.Add(lbLibrary);
            pnLibrary.Location = new Point(12, 201);
            pnLibrary.Name = "pnLibrary";
            pnLibrary.Size = new Size(330, 394);
            pnLibrary.TabIndex = 1;
            // 
            // listLibrary
            // 
            listLibrary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listLibrary.BackColor = Color.FromArgb(18, 18, 18);
            listLibrary.BorderStyle = BorderStyle.FixedSingle;
            listLibrary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listLibrary.ForeColor = Color.White;
            listLibrary.Location = new Point(15, 65);
            listLibrary.Name = "listLibrary";
            listLibrary.Size = new Size(298, 311);
            listLibrary.TabIndex = 3;
            listLibrary.UseCompatibleStateImageBehavior = false;
            listLibrary.View = View.List;
            listLibrary.MouseDoubleClick += listLibrary_MouseDoubleClick;
            // 
            // lbLibrary
            // 
            lbLibrary.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLibrary.Image = Properties.Resources.library;
            lbLibrary.ImageAlign = ContentAlignment.MiddleLeft;
            lbLibrary.Location = new Point(15, 0);
            lbLibrary.Name = "lbLibrary";
            lbLibrary.Size = new Size(298, 62);
            lbLibrary.TabIndex = 2;
            lbLibrary.Text = "Library";
            lbLibrary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnView
            // 
            pnView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnView.BackColor = Color.FromArgb(18, 18, 18);
            pnView.Controls.Add(btnRemove);
            pnView.Controls.Add(btnBrowse);
            pnView.Controls.Add(btnRemoveLib);
            pnView.Controls.Add(btnAddLib);
            pnView.Controls.Add(listSong);
            pnView.Location = new Point(348, 12);
            pnView.Name = "pnView";
            pnView.Size = new Size(1222, 583);
            pnView.TabIndex = 3;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(1043, 526);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(156, 54);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(881, 526);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(156, 54);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRemoveLib
            // 
            btnRemoveLib.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveLib.FlatStyle = FlatStyle.Flat;
            btnRemoveLib.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveLib.ForeColor = Color.White;
            btnRemoveLib.Location = new Point(181, 526);
            btnRemoveLib.Name = "btnRemoveLib";
            btnRemoveLib.Size = new Size(156, 54);
            btnRemoveLib.TabIndex = 2;
            btnRemoveLib.Text = "Remove library";
            btnRemoveLib.UseVisualStyleBackColor = true;
            btnRemoveLib.Click += btnRemoveLib_Click;
            // 
            // btnAddLib
            // 
            btnAddLib.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddLib.FlatStyle = FlatStyle.Flat;
            btnAddLib.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddLib.ForeColor = Color.White;
            btnAddLib.Location = new Point(19, 526);
            btnAddLib.Name = "btnAddLib";
            btnAddLib.Size = new Size(156, 54);
            btnAddLib.TabIndex = 1;
            btnAddLib.Text = "Add library";
            btnAddLib.UseVisualStyleBackColor = true;
            btnAddLib.Click += btnAddLib_Click;
            // 
            // listSong
            // 
            listSong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listSong.BackColor = Color.FromArgb(18, 18, 18);
            listSong.BorderStyle = BorderStyle.FixedSingle;
            listSong.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listSong.ForeColor = Color.White;
            listSong.FullRowSelect = true;
            listSong.Location = new Point(19, 20);
            listSong.Name = "listSong";
            listSong.Size = new Size(1180, 500);
            listSong.TabIndex = 0;
            listSong.UseCompatibleStateImageBehavior = false;
            listSong.MouseDoubleClick += listSong_MouseDoubleClick;
            // 
            // trackBarTime
            // 
            trackBarTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackBarTime.CausesValidation = false;
            trackBarTime.Cursor = Cursors.Hand;
            trackBarTime.Location = new Point(413, 685);
            trackBarTime.Maximum = 0;
            trackBarTime.Name = "trackBarTime";
            trackBarTime.Size = new Size(756, 56);
            trackBarTime.TabIndex = 4;
            trackBarTime.TickStyle = TickStyle.None;
            trackBarTime.Scroll += trackBarTime_Scroll;
            // 
            // trackBarVolume
            // 
            trackBarVolume.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            trackBarVolume.CausesValidation = false;
            trackBarVolume.Cursor = Cursors.Hand;
            trackBarVolume.Location = new Point(1391, 659);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new Size(156, 56);
            trackBarVolume.TabIndex = 5;
            trackBarVolume.TickStyle = TickStyle.None;
            trackBarVolume.Value = 50;
            trackBarVolume.Scroll += trackBarVolume_Scroll;
            // 
            // btnPlay
            // 
            btnPlay.Anchor = AnchorStyles.Bottom;
            btnPlay.Image = Properties.Resources.play;
            btnPlay.Location = new Point(764, 629);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(50, 50);
            btnPlay.SizeMode = PictureBoxSizeMode.AutoSize;
            btnPlay.TabIndex = 6;
            btnPlay.TabStop = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom;
            btnNext.Image = Properties.Resources.forward;
            btnNext.Location = new Point(836, 639);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 40);
            btnNext.SizeMode = PictureBoxSizeMode.Zoom;
            btnNext.TabIndex = 7;
            btnNext.TabStop = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnLoop
            // 
            btnLoop.Anchor = AnchorStyles.Bottom;
            btnLoop.Image = Properties.Resources.loop;
            btnLoop.Location = new Point(897, 639);
            btnLoop.Name = "btnLoop";
            btnLoop.Size = new Size(40, 40);
            btnLoop.SizeMode = PictureBoxSizeMode.Zoom;
            btnLoop.TabIndex = 8;
            btnLoop.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom;
            btnBack.Image = Properties.Resources.backward;
            btnBack.Location = new Point(702, 639);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(40, 40);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 9;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnShuffler
            // 
            btnShuffler.Anchor = AnchorStyles.Bottom;
            btnShuffler.Image = Properties.Resources.shuffle;
            btnShuffler.Location = new Point(636, 639);
            btnShuffler.Name = "btnShuffler";
            btnShuffler.Size = new Size(40, 40);
            btnShuffler.SizeMode = PictureBoxSizeMode.Zoom;
            btnShuffler.TabIndex = 10;
            btnShuffler.TabStop = false;
            // 
            // picVolume
            // 
            picVolume.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            picVolume.Image = Properties.Resources.low_volume;
            picVolume.Location = new Point(1345, 650);
            picVolume.Name = "picVolume";
            picVolume.Size = new Size(40, 40);
            picVolume.SizeMode = PictureBoxSizeMode.Zoom;
            picVolume.TabIndex = 11;
            picVolume.TabStop = false;
            picVolume.Click += picVolume_Click;
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.Location = new Point(27, 633);
            lbName.Name = "lbName";
            lbName.Size = new Size(298, 82);
            lbName.TabIndex = 12;
            lbName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // songDuration
            // 
            songDuration.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            songDuration.AutoSize = true;
            songDuration.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songDuration.Location = new Point(1175, 685);
            songDuration.Name = "songDuration";
            songDuration.Size = new Size(56, 25);
            songDuration.TabIndex = 13;
            songDuration.Text = "00:00";
            // 
            // songCurrentDuration
            // 
            songCurrentDuration.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            songCurrentDuration.AutoSize = true;
            songCurrentDuration.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songCurrentDuration.Location = new Point(351, 685);
            songCurrentDuration.Name = "songCurrentDuration";
            songCurrentDuration.Size = new Size(56, 25);
            songCurrentDuration.TabIndex = 14;
            songCurrentDuration.Text = "00:00";
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1582, 753);
            Controls.Add(songCurrentDuration);
            Controls.Add(songDuration);
            Controls.Add(lbName);
            Controls.Add(picVolume);
            Controls.Add(btnShuffler);
            Controls.Add(btnBack);
            Controls.Add(btnLoop);
            Controls.Add(btnNext);
            Controls.Add(btnPlay);
            Controls.Add(trackBarVolume);
            Controls.Add(trackBarTime);
            Controls.Add(pnView);
            Controls.Add(pnLibrary);
            Controls.Add(pnHS);
            ForeColor = Color.White;
            MinimumSize = new Size(1400, 700);
            Name = "fMain";
            Text = "Music Application";
            WindowState = FormWindowState.Maximized;
            pnHS.ResumeLayout(false);
            pnHS.PerformLayout();
            pnLibrary.ResumeLayout(false);
            pnView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBarTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPlay).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLoop).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnShuffler).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVolume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnHS;
        private Panel pnLibrary;
        private Panel pnView;
        private Label lbHome;
        private Label lbSearch;
        private TextBox txtSearch;
        private Label lbLibrary;
        private Button btnAddLib;
        private ListView listSong;
        private Button btnRemoveLib;
        private Button btnRemove;
        private Button btnBrowse;
        private ListView listLibrary;
        private TrackBar trackBarTime;
        private TrackBar trackBarVolume;
        private PictureBox btnPlay;
        private PictureBox btnNext;
        private PictureBox btnLoop;
        private PictureBox btnBack;
        private PictureBox btnShuffler;
        private PictureBox picVolume;
        private Label lbName;
        private System.Windows.Forms.Timer timer;
        private Label songDuration;
        private Label songCurrentDuration;
    }
}
