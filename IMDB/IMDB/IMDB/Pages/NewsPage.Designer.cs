namespace IMDB
{
    partial class NewsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPowerOffTop = new System.Windows.Forms.Button();
            this.labelNews = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.buttonPowerOffTop);
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 106);
            this.panel2.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(32, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(563, 78);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.labelNews);
            this.panel1.Location = new System.Drawing.Point(0, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 237);
            this.panel1.TabIndex = 5;
            // 
            // buttonPowerOffTop
            // 
            this.buttonPowerOffTop.FlatAppearance.BorderSize = 0;
            this.buttonPowerOffTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPowerOffTop.Image = ((System.Drawing.Image)(resources.GetObject("buttonPowerOffTop.Image")));
            this.buttonPowerOffTop.Location = new System.Drawing.Point(637, 0);
            this.buttonPowerOffTop.Name = "buttonPowerOffTop";
            this.buttonPowerOffTop.Size = new System.Drawing.Size(35, 36);
            this.buttonPowerOffTop.TabIndex = 16;
            this.buttonPowerOffTop.UseVisualStyleBackColor = true;
            this.buttonPowerOffTop.Click += new System.EventHandler(this.buttonPowerOffTop_Click);
            // 
            // labelNews
            // 
            this.labelNews.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNews.Location = new System.Drawing.Point(24, 16);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(616, 202);
            this.labelNews.TabIndex = 0;
            this.labelNews.Text = "News";
            this.labelNews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 337);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewsPage";
            this.Text = "NewsPage";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPowerOffTop;
        private System.Windows.Forms.Label labelNews;
    }
}