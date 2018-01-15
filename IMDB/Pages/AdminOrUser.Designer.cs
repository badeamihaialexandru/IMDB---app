namespace IMDB
{
    partial class AdminOrUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOrUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMovie = new System.Windows.Forms.Button();
            this.buttonTVSeries = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UserModeButton = new System.Windows.Forms.Button();
            this.AdminModeButton = new System.Windows.Forms.Button();
            this.labelWelcomeUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.buttonMovie);
            this.panel1.Controls.Add(this.buttonTVSeries);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.UserModeButton);
            this.panel1.Controls.Add(this.AdminModeButton);
            this.panel1.Controls.Add(this.labelWelcomeUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 231);
            this.panel1.TabIndex = 0;
            // 
            // buttonMovie
            // 
            this.buttonMovie.FlatAppearance.BorderSize = 0;
            this.buttonMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovie.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMovie.Image = ((System.Drawing.Image)(resources.GetObject("buttonMovie.Image")));
            this.buttonMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMovie.Location = new System.Drawing.Point(241, 82);
            this.buttonMovie.Name = "buttonMovie";
            this.buttonMovie.Size = new System.Drawing.Size(130, 59);
            this.buttonMovie.TabIndex = 6;
            this.buttonMovie.Text = "Movie";
            this.buttonMovie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMovie.UseCompatibleTextRendering = true;
            this.buttonMovie.UseVisualStyleBackColor = true;
            this.buttonMovie.Visible = false;
            this.buttonMovie.Click += new System.EventHandler(this.buttonMovie_Click);
            // 
            // buttonTVSeries
            // 
            this.buttonTVSeries.FlatAppearance.BorderSize = 0;
            this.buttonTVSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTVSeries.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTVSeries.Image = ((System.Drawing.Image)(resources.GetObject("buttonTVSeries.Image")));
            this.buttonTVSeries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTVSeries.Location = new System.Drawing.Point(34, 82);
            this.buttonTVSeries.Name = "buttonTVSeries";
            this.buttonTVSeries.Size = new System.Drawing.Size(130, 59);
            this.buttonTVSeries.TabIndex = 5;
            this.buttonTVSeries.Text = "TV       Series";
            this.buttonTVSeries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTVSeries.UseCompatibleTextRendering = true;
            this.buttonTVSeries.UseVisualStyleBackColor = true;
            this.buttonTVSeries.Visible = false;
            this.buttonTVSeries.Click += new System.EventHandler(this.buttonTVSeries_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(377, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 29);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserModeButton
            // 
            this.UserModeButton.FlatAppearance.BorderSize = 0;
            this.UserModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserModeButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserModeButton.Image = ((System.Drawing.Image)(resources.GetObject("UserModeButton.Image")));
            this.UserModeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserModeButton.Location = new System.Drawing.Point(241, 135);
            this.UserModeButton.Name = "UserModeButton";
            this.UserModeButton.Size = new System.Drawing.Size(130, 59);
            this.UserModeButton.TabIndex = 3;
            this.UserModeButton.Text = "User       Mode";
            this.UserModeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserModeButton.UseCompatibleTextRendering = true;
            this.UserModeButton.UseVisualStyleBackColor = true;
            this.UserModeButton.Click += new System.EventHandler(this.UserModeButton_Click);
            // 
            // AdminModeButton
            // 
            this.AdminModeButton.FlatAppearance.BorderSize = 0;
            this.AdminModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminModeButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminModeButton.Image = ((System.Drawing.Image)(resources.GetObject("AdminModeButton.Image")));
            this.AdminModeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminModeButton.Location = new System.Drawing.Point(34, 135);
            this.AdminModeButton.Name = "AdminModeButton";
            this.AdminModeButton.Size = new System.Drawing.Size(130, 59);
            this.AdminModeButton.TabIndex = 2;
            this.AdminModeButton.Text = "Admin       Mode";
            this.AdminModeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminModeButton.UseCompatibleTextRendering = true;
            this.AdminModeButton.UseVisualStyleBackColor = true;
            this.AdminModeButton.Click += new System.EventHandler(this.AddDirectorButton_Click);
            // 
            // labelWelcomeUserName
            // 
            this.labelWelcomeUserName.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeUserName.Image = ((System.Drawing.Image)(resources.GetObject("labelWelcomeUserName.Image")));
            this.labelWelcomeUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWelcomeUserName.Location = new System.Drawing.Point(51, 52);
            this.labelWelcomeUserName.Name = "labelWelcomeUserName";
            this.labelWelcomeUserName.Size = new System.Drawing.Size(320, 66);
            this.labelWelcomeUserName.TabIndex = 0;
            this.labelWelcomeUserName.Text = "Welcome,";
            this.labelWelcomeUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdminOrUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 231);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminOrUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminOrUser";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AdminModeButton;
        public System.Windows.Forms.Label labelWelcomeUserName;
        private System.Windows.Forms.Button UserModeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMovie;
        private System.Windows.Forms.Button buttonTVSeries;
    }
}