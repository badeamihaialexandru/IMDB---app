namespace IMDB
{
    partial class IMDProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMDProject));
            this.Ceas = new System.Windows.Forms.Label();
            this.timerCeas = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.movieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOVIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topRatedMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostRatedMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tVSERIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topRatedTVSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostPopularTVSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.celebsEventPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cELEBSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bornTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celebrityNewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostPopularCelebsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHOTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eVENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.watchlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.AppStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.ContinueAsGuest = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SeacrhcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPictureBox = new System.Windows.Forms.PictureBox();
            this.SearchBy = new System.Windows.Forms.ComboBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelJoinUs = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Status.SuspendLayout();
            this.SeacrhcontextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ceas
            // 
            this.Ceas.AutoSize = true;
            this.Ceas.BackColor = System.Drawing.Color.Transparent;
            this.Ceas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ceas.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ceas.ForeColor = System.Drawing.Color.Black;
            this.Ceas.Location = new System.Drawing.Point(696, 375);
            this.Ceas.Name = "Ceas";
            this.Ceas.Size = new System.Drawing.Size(36, 15);
            this.Ceas.TabIndex = 0;
            this.Ceas.Text = "CEAS";
            this.Ceas.Click += new System.EventHandler(this.Ceas_Click);
            // 
            // timerCeas
            // 
            this.timerCeas.Enabled = true;
            this.timerCeas.Interval = 1;
            this.timerCeas.Tick += new System.EventHandler(this.timerCeas_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieToolStripMenuItem,
            this.celebsEventPhotosToolStripMenuItem,
            this.newsToolStripMenuItem,
            this.watchlistToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // movieToolStripMenuItem
            // 
            this.movieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOVIESToolStripMenuItem,
            this.topRatedMoviesToolStripMenuItem,
            this.mostRatedMoviesToolStripMenuItem,
            this.tVSERIESToolStripMenuItem,
            this.topRatedTVSeriesToolStripMenuItem,
            this.mostPopularTVSeriesToolStripMenuItem,
            this.ExitMenu});
            this.movieToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            this.movieToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.movieToolStripMenuItem.Text = "Movies, TV & Shows";
            this.movieToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.movieToolStripMenuItem.Click += new System.EventHandler(this.movieToolStripMenuItem_Click);
            this.movieToolStripMenuItem.MouseLeave += new System.EventHandler(this.movieToolStripMenuItem_MouseLeave);
            this.movieToolStripMenuItem.MouseHover += new System.EventHandler(this.movieToolStripMenuItem_MouseHover);
            // 
            // mOVIESToolStripMenuItem
            // 
            this.mOVIESToolStripMenuItem.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mOVIESToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mOVIESToolStripMenuItem.Name = "mOVIESToolStripMenuItem";
            this.mOVIESToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.mOVIESToolStripMenuItem.Text = "MOVIES";
            // 
            // topRatedMoviesToolStripMenuItem
            // 
            this.topRatedMoviesToolStripMenuItem.Name = "topRatedMoviesToolStripMenuItem";
            this.topRatedMoviesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.topRatedMoviesToolStripMenuItem.Text = "Top Rated Movies";
            this.topRatedMoviesToolStripMenuItem.Click += new System.EventHandler(this.topRatedMoviesToolStripMenuItem_Click);
            // 
            // mostRatedMoviesToolStripMenuItem
            // 
            this.mostRatedMoviesToolStripMenuItem.Name = "mostRatedMoviesToolStripMenuItem";
            this.mostRatedMoviesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.mostRatedMoviesToolStripMenuItem.Text = "Most Popular Movies";
            // 
            // tVSERIESToolStripMenuItem
            // 
            this.tVSERIESToolStripMenuItem.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tVSERIESToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tVSERIESToolStripMenuItem.Name = "tVSERIESToolStripMenuItem";
            this.tVSERIESToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.tVSERIESToolStripMenuItem.Text = "TV SERIES";
            // 
            // topRatedTVSeriesToolStripMenuItem
            // 
            this.topRatedTVSeriesToolStripMenuItem.Name = "topRatedTVSeriesToolStripMenuItem";
            this.topRatedTVSeriesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.topRatedTVSeriesToolStripMenuItem.Text = "Top Rated TV Series";
            // 
            // mostPopularTVSeriesToolStripMenuItem
            // 
            this.mostPopularTVSeriesToolStripMenuItem.Name = "mostPopularTVSeriesToolStripMenuItem";
            this.mostPopularTVSeriesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.mostPopularTVSeriesToolStripMenuItem.Text = "Most Popular TV Series";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(195, 22);
            this.ExitMenu.Text = "EXIT";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            this.ExitMenu.MouseLeave += new System.EventHandler(this.ExitMenu_MouseLeave);
            this.ExitMenu.MouseHover += new System.EventHandler(this.ExitMenu_MouseHover);
            // 
            // celebsEventPhotosToolStripMenuItem
            // 
            this.celebsEventPhotosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cELEBSToolStripMenuItem,
            this.bornTodayToolStripMenuItem,
            this.celebrityNewsToolStripMenuItem,
            this.mostPopularCelebsToolStripMenuItem,
            this.pHOTOToolStripMenuItem,
            this.eVENTSToolStripMenuItem});
            this.celebsEventPhotosToolStripMenuItem.Name = "celebsEventPhotosToolStripMenuItem";
            this.celebsEventPhotosToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.celebsEventPhotosToolStripMenuItem.Text = "Celebs,Event & Photos";
            this.celebsEventPhotosToolStripMenuItem.MouseLeave += new System.EventHandler(this.celebsEventPhotosToolStripMenuItem_MouseLeave);
            this.celebsEventPhotosToolStripMenuItem.MouseHover += new System.EventHandler(this.celebsEventPhotosToolStripMenuItem_MouseHover);
            // 
            // cELEBSToolStripMenuItem
            // 
            this.cELEBSToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cELEBSToolStripMenuItem.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cELEBSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cELEBSToolStripMenuItem.Name = "cELEBSToolStripMenuItem";
            this.cELEBSToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cELEBSToolStripMenuItem.Text = "CELEBS";
            // 
            // bornTodayToolStripMenuItem
            // 
            this.bornTodayToolStripMenuItem.Name = "bornTodayToolStripMenuItem";
            this.bornTodayToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.bornTodayToolStripMenuItem.Text = "Born Today";
            // 
            // celebrityNewsToolStripMenuItem
            // 
            this.celebrityNewsToolStripMenuItem.Name = "celebrityNewsToolStripMenuItem";
            this.celebrityNewsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.celebrityNewsToolStripMenuItem.Text = "Celebrity News";
            // 
            // mostPopularCelebsToolStripMenuItem
            // 
            this.mostPopularCelebsToolStripMenuItem.Name = "mostPopularCelebsToolStripMenuItem";
            this.mostPopularCelebsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.mostPopularCelebsToolStripMenuItem.Text = "Most Popular Celebs";
            // 
            // pHOTOToolStripMenuItem
            // 
            this.pHOTOToolStripMenuItem.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHOTOToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pHOTOToolStripMenuItem.Name = "pHOTOToolStripMenuItem";
            this.pHOTOToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.pHOTOToolStripMenuItem.Text = "PHOTO";
            // 
            // eVENTSToolStripMenuItem
            // 
            this.eVENTSToolStripMenuItem.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eVENTSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.eVENTSToolStripMenuItem.Name = "eVENTSToolStripMenuItem";
            this.eVENTSToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.eVENTSToolStripMenuItem.Text = "EVENTS";
            // 
            // newsToolStripMenuItem
            // 
            this.newsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWSToolStripMenuItem1});
            this.newsToolStripMenuItem.Name = "newsToolStripMenuItem";
            this.newsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.newsToolStripMenuItem.Text = "News & Community";
            this.newsToolStripMenuItem.MouseLeave += new System.EventHandler(this.newsToolStripMenuItem_MouseLeave);
            this.newsToolStripMenuItem.MouseHover += new System.EventHandler(this.newsToolStripMenuItem_MouseHover);
            // 
            // nEWSToolStripMenuItem1
            // 
            this.nEWSToolStripMenuItem1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nEWSToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nEWSToolStripMenuItem1.Name = "nEWSToolStripMenuItem1";
            this.nEWSToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.nEWSToolStripMenuItem1.Text = "NEWS";
            // 
            // watchlistToolStripMenuItem
            // 
            this.watchlistToolStripMenuItem.Name = "watchlistToolStripMenuItem";
            this.watchlistToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.watchlistToolStripMenuItem.Text = "Watchlist";
            this.watchlistToolStripMenuItem.MouseLeave += new System.EventHandler(this.watchlistToolStripMenuItem_MouseLeave);
            this.watchlistToolStripMenuItem.MouseHover += new System.EventHandler(this.watchlistToolStripMenuItem_MouseHover);
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppStatus});
            this.Status.Location = new System.Drawing.Point(0, 375);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(863, 22);
            this.Status.TabIndex = 3;
            this.Status.Text = "IMDB";
            this.Status.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // AppStatus
            // 
            this.AppStatus.Name = "AppStatus";
            this.AppStatus.Size = new System.Drawing.Size(118, 17);
            this.AppStatus.Text = "toolStripStatusLabel1";
            this.AppStatus.Click += new System.EventHandler(this.AppStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(774, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(711, 27);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.TextBoxUsername.TabIndex = 5;
            this.TextBoxUsername.Visible = false;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(711, 58);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPassword.TabIndex = 6;
            this.TextBoxPassword.Visible = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Image = ((System.Drawing.Image)(resources.GetObject("Username.Image")));
            this.Username.Location = new System.Drawing.Point(650, 31);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(58, 13);
            this.Username.TabIndex = 7;
            this.Username.Text = "Username:";
            this.Username.Visible = false;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Image = ((System.Drawing.Image)(resources.GetObject("Password.Image")));
            this.Password.Location = new System.Drawing.Point(652, 58);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 13);
            this.Password.TabIndex = 8;
            this.Password.Text = "Password:";
            this.Password.Visible = false;
            // 
            // ContinueAsGuest
            // 
            this.ContinueAsGuest.AutoSize = true;
            this.ContinueAsGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueAsGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueAsGuest.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ContinueAsGuest.Image = ((System.Drawing.Image)(resources.GetObject("ContinueAsGuest.Image")));
            this.ContinueAsGuest.Location = new System.Drawing.Point(664, 81);
            this.ContinueAsGuest.Name = "ContinueAsGuest";
            this.ContinueAsGuest.Size = new System.Drawing.Size(94, 13);
            this.ContinueAsGuest.TabIndex = 9;
            this.ContinueAsGuest.Text = "Continue as Guest";
            this.ContinueAsGuest.Visible = false;
            this.ContinueAsGuest.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.SeacrhcontextMenuStrip;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SeacrhcontextMenuStrip
            // 
            this.SeacrhcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sToolStripMenuItem});
            this.SeacrhcontextMenuStrip.Name = "SeacrhcontextMenuStrip";
            this.SeacrhcontextMenuStrip.Size = new System.Drawing.Size(123, 114);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sToolStripMenuItem.Text = "Select All";
            // 
            // SearchPictureBox
            // 
            this.SearchPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchPictureBox.Location = new System.Drawing.Point(465, 29);
            this.SearchPictureBox.Name = "SearchPictureBox";
            this.SearchPictureBox.Size = new System.Drawing.Size(23, 20);
            this.SearchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchPictureBox.TabIndex = 11;
            this.SearchPictureBox.TabStop = false;
            // 
            // SearchBy
            // 
            this.SearchBy.FormattingEnabled = true;
            this.SearchBy.Items.AddRange(new object[] {
            "Movies",
            "TV Series",
            "Actors",
            "Directors",
            "Gender"});
            this.SearchBy.Location = new System.Drawing.Point(338, 28);
            this.SearchBy.Name = "SearchBy";
            this.SearchBy.Size = new System.Drawing.Size(121, 21);
            this.SearchBy.TabIndex = 13;
            this.SearchBy.Text = "All";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLog.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelLog.Image = ((System.Drawing.Image)(resources.GetObject("labelLog.Image")));
            this.labelLog.Location = new System.Drawing.Point(774, 81);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(37, 13);
            this.labelLog.TabIndex = 14;
            this.labelLog.Text = "Log In";
            this.labelLog.Visible = false;
            this.labelLog.Click += new System.EventHandler(this.labelLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(863, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // labelJoinUs
            // 
            this.labelJoinUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelJoinUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelJoinUs.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelJoinUs.Image = ((System.Drawing.Image)(resources.GetObject("labelJoinUs.Image")));
            this.labelJoinUs.Location = new System.Drawing.Point(687, 106);
            this.labelJoinUs.Name = "labelJoinUs";
            this.labelJoinUs.Size = new System.Drawing.Size(124, 29);
            this.labelJoinUs.TabIndex = 16;
            this.labelJoinUs.Text = "Don\'t have an account?               Join us!";
            this.labelJoinUs.Visible = false;
            this.labelJoinUs.Click += new System.EventHandler(this.labelJoinUs_Click);
            // 
            // IMDProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 397);
            this.Controls.Add(this.labelJoinUs);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.SearchBy);
            this.Controls.Add(this.SearchPictureBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ContinueAsGuest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.Ceas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "IMDProject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.SeacrhcontextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ceas;
        private System.Windows.Forms.Timer timerCeas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celebsEventPhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topRatedMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostRatedMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topRatedTVSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostPopularTVSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOVIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tVSERIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cELEBSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bornTodayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celebrityNewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostPopularCelebsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHOTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eVENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWSToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel AppStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label ContinueAsGuest;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox SearchPictureBox;
        private System.Windows.Forms.ContextMenuStrip SeacrhcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ComboBox SearchBy;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelJoinUs;
    }
}

