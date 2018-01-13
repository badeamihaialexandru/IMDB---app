namespace IMDB
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.AdminNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.AddTVSeriesButton = new System.Windows.Forms.Button();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.AddDirectorButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.InsertcheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.DeletecheckBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labelpoza = new System.Windows.Forms.Label();
            this.pictureBoxPoza = new System.Windows.Forms.PictureBox();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.buttonSalveaza = new System.Windows.Forms.Button();
            this.checkBoxMakeAdmin = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoza)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminNameLabel
            // 
            this.AdminNameLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminNameLabel.Location = new System.Drawing.Point(675, 60);
            this.AdminNameLabel.Name = "AdminNameLabel";
            this.AdminNameLabel.Size = new System.Drawing.Size(139, 26);
            this.AdminNameLabel.TabIndex = 0;
            this.AdminNameLabel.Text = "AdminName";
            this.AdminNameLabel.Click += new System.EventHandler(this.AdminNameLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AdminNameLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 87);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Chocolate;
            this.label9.Location = new System.Drawing.Point(94, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Go to User mode";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(604, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Welcome,";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(740, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 57);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Page";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.buttonUser);
            this.panel2.Controls.Add(this.AddTVSeriesButton);
            this.panel2.Controls.Add(this.AddMovieButton);
            this.panel2.Controls.Add(this.AddDirectorButton);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 532);
            this.panel2.TabIndex = 2;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(3, 334);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(129, 59);
            this.button8.TabIndex = 7;
            this.button8.Text = "View         Users";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseCompatibleTextRendering = true;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(12, 274);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 59);
            this.button7.TabIndex = 6;
            this.button7.Text = "News   ";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseCompatibleTextRendering = true;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 465);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 67);
            this.button6.TabIndex = 5;
            this.button6.Text = "Add  Or    Change Photo ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseCompatibleTextRendering = true;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonUser.Image")));
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.Location = new System.Drawing.Point(3, 399);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(143, 59);
            this.buttonUser.TabIndex = 4;
            this.buttonUser.Text = "User    ";
            this.buttonUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUser.UseCompatibleTextRendering = true;
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // AddTVSeriesButton
            // 
            this.AddTVSeriesButton.FlatAppearance.BorderSize = 0;
            this.AddTVSeriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTVSeriesButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTVSeriesButton.Image = ((System.Drawing.Image)(resources.GetObject("AddTVSeriesButton.Image")));
            this.AddTVSeriesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTVSeriesButton.Location = new System.Drawing.Point(3, 210);
            this.AddTVSeriesButton.Name = "AddTVSeriesButton";
            this.AddTVSeriesButton.Size = new System.Drawing.Size(143, 59);
            this.AddTVSeriesButton.TabIndex = 3;
            this.AddTVSeriesButton.Text = "TV        Series";
            this.AddTVSeriesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddTVSeriesButton.UseCompatibleTextRendering = true;
            this.AddTVSeriesButton.UseVisualStyleBackColor = true;
            this.AddTVSeriesButton.Click += new System.EventHandler(this.AddTVSeriesButton_Click);
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.FlatAppearance.BorderSize = 0;
            this.AddMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMovieButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMovieButton.Image = ((System.Drawing.Image)(resources.GetObject("AddMovieButton.Image")));
            this.AddMovieButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMovieButton.Location = new System.Drawing.Point(3, 145);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(129, 59);
            this.AddMovieButton.TabIndex = 2;
            this.AddMovieButton.Text = "Movie";
            this.AddMovieButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddMovieButton.UseCompatibleTextRendering = true;
            this.AddMovieButton.UseVisualStyleBackColor = true;
            this.AddMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // AddDirectorButton
            // 
            this.AddDirectorButton.FlatAppearance.BorderSize = 0;
            this.AddDirectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDirectorButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDirectorButton.Image = ((System.Drawing.Image)(resources.GetObject("AddDirectorButton.Image")));
            this.AddDirectorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDirectorButton.Location = new System.Drawing.Point(3, 80);
            this.AddDirectorButton.Name = "AddDirectorButton";
            this.AddDirectorButton.Size = new System.Drawing.Size(152, 59);
            this.AddDirectorButton.TabIndex = 1;
            this.AddDirectorButton.Text = "Director";
            this.AddDirectorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddDirectorButton.UseCompatibleTextRendering = true;
            this.AddDirectorButton.UseVisualStyleBackColor = true;
            this.AddDirectorButton.Click += new System.EventHandler(this.AddDirectorButton_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 59);
            this.button2.TabIndex = 0;
            this.button2.Text = " Actor";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Label2:";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Label3:";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Label4:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Label:5:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Label:6:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Label7:";
            this.label7.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(365, 294);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(235, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(365, 350);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(235, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(365, 398);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(235, 20);
            this.textBox6.TabIndex = 14;
            this.textBox6.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(365, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Visible = false;
            // 
            // InsertcheckBox
            // 
            this.InsertcheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertcheckBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertcheckBox.Image = ((System.Drawing.Image)(resources.GetObject("InsertcheckBox.Image")));
            this.InsertcheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InsertcheckBox.Location = new System.Drawing.Point(662, 139);
            this.InsertcheckBox.Name = "InsertcheckBox";
            this.InsertcheckBox.Size = new System.Drawing.Size(142, 42);
            this.InsertcheckBox.TabIndex = 16;
            this.InsertcheckBox.Text = "INSERT";
            this.InsertcheckBox.UseVisualStyleBackColor = true;
            this.InsertcheckBox.CheckedChanged += new System.EventHandler(this.InsertcheckBox_CheckedChanged);
            this.InsertcheckBox.CheckStateChanged += new System.EventHandler(this.InsertcheckBox_CheckStateChanged);
            // 
            // UpdateCheckBox
            // 
            this.UpdateCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCheckBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("UpdateCheckBox.Image")));
            this.UpdateCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateCheckBox.Location = new System.Drawing.Point(662, 187);
            this.UpdateCheckBox.Name = "UpdateCheckBox";
            this.UpdateCheckBox.Size = new System.Drawing.Size(142, 42);
            this.UpdateCheckBox.TabIndex = 17;
            this.UpdateCheckBox.Text = "UPDATE";
            this.UpdateCheckBox.UseVisualStyleBackColor = true;
            this.UpdateCheckBox.CheckedChanged += new System.EventHandler(this.UpdateCheckBox_CheckedChanged);
            this.UpdateCheckBox.CheckStateChanged += new System.EventHandler(this.UpdateCheckBox_CheckStateChanged);
            // 
            // DeletecheckBox
            // 
            this.DeletecheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletecheckBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletecheckBox.Image = ((System.Drawing.Image)(resources.GetObject("DeletecheckBox.Image")));
            this.DeletecheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeletecheckBox.Location = new System.Drawing.Point(662, 235);
            this.DeletecheckBox.Name = "DeletecheckBox";
            this.DeletecheckBox.Size = new System.Drawing.Size(142, 42);
            this.DeletecheckBox.TabIndex = 18;
            this.DeletecheckBox.Text = "DELETE";
            this.DeletecheckBox.UseVisualStyleBackColor = true;
            this.DeletecheckBox.CheckedChanged += new System.EventHandler(this.DeletecheckBox_CheckedChanged);
            this.DeletecheckBox.CheckStateChanged += new System.EventHandler(this.DeletecheckBox_CheckStateChanged);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(688, 573);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 46);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(734, 573);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 46);
            this.button4.TabIndex = 20;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(784, 573);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 46);
            this.button5.TabIndex = 21;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(713, 542);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Follow us:";
            // 
            // labelpoza
            // 
            this.labelpoza.AutoSize = true;
            this.labelpoza.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpoza.Location = new System.Drawing.Point(188, 439);
            this.labelpoza.Name = "labelpoza";
            this.labelpoza.Size = new System.Drawing.Size(60, 20);
            this.labelpoza.TabIndex = 29;
            this.labelpoza.Text = "Poza:";
            this.labelpoza.Visible = false;
            // 
            // pictureBoxPoza
            // 
            this.pictureBoxPoza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPoza.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPoza.Image")));
            this.pictureBoxPoza.Location = new System.Drawing.Point(355, 439);
            this.pictureBoxPoza.Name = "pictureBoxPoza";
            this.pictureBoxPoza.Size = new System.Drawing.Size(145, 116);
            this.pictureBoxPoza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPoza.TabIndex = 30;
            this.pictureBoxPoza.TabStop = false;
            this.pictureBoxPoza.Visible = false;
            // 
            // buttonCauta
            // 
            this.buttonCauta.FlatAppearance.BorderSize = 0;
            this.buttonCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCauta.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCauta.Image = ((System.Drawing.Image)(resources.GetObject("buttonCauta.Image")));
            this.buttonCauta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCauta.Location = new System.Drawing.Point(506, 439);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(129, 59);
            this.buttonCauta.TabIndex = 4;
            this.buttonCauta.Text = "Cauta...";
            this.buttonCauta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCauta.UseCompatibleTextRendering = true;
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Visible = false;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // buttonSalveaza
            // 
            this.buttonSalveaza.FlatAppearance.BorderSize = 0;
            this.buttonSalveaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalveaza.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalveaza.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalveaza.Image")));
            this.buttonSalveaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalveaza.Location = new System.Drawing.Point(659, 347);
            this.buttonSalveaza.Name = "buttonSalveaza";
            this.buttonSalveaza.Size = new System.Drawing.Size(145, 59);
            this.buttonSalveaza.TabIndex = 31;
            this.buttonSalveaza.Text = "Salveaza";
            this.buttonSalveaza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalveaza.UseCompatibleTextRendering = true;
            this.buttonSalveaza.UseVisualStyleBackColor = true;
            this.buttonSalveaza.Visible = false;
            this.buttonSalveaza.Click += new System.EventHandler(this.buttonSalveaza_Click);
            // 
            // checkBoxMakeAdmin
            // 
            this.checkBoxMakeAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMakeAdmin.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMakeAdmin.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxMakeAdmin.Image")));
            this.checkBoxMakeAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMakeAdmin.Location = new System.Drawing.Point(662, 282);
            this.checkBoxMakeAdmin.Name = "checkBoxMakeAdmin";
            this.checkBoxMakeAdmin.Size = new System.Drawing.Size(153, 47);
            this.checkBoxMakeAdmin.TabIndex = 32;
            this.checkBoxMakeAdmin.Text = "Make       Admin";
            this.checkBoxMakeAdmin.UseVisualStyleBackColor = true;
            this.checkBoxMakeAdmin.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(383, 103);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(235, 20);
            this.textBox7.TabIndex = 34;
            this.textBox7.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(188, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Label11:";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(658, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Nume Identic?";
            this.label12.Visible = false;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            this.label12.MouseHover += new System.EventHandler(this.label12_MouseHover);
            // 
            // AdminPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(827, 619);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkBoxMakeAdmin);
            this.Controls.Add(this.buttonSalveaza);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.pictureBoxPoza);
            this.Controls.Add(this.labelpoza);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DeletecheckBox);
            this.Controls.Add(this.UpdateCheckBox);
            this.Controls.Add(this.InsertcheckBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddTVSeriesButton;
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.Button AddDirectorButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox InsertcheckBox;
        private System.Windows.Forms.CheckBox UpdateCheckBox;
        private System.Windows.Forms.CheckBox DeletecheckBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelpoza;
        private System.Windows.Forms.PictureBox pictureBoxPoza;
        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.Button buttonSalveaza;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBoxMakeAdmin;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}