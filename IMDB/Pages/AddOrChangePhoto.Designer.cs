namespace IMDB
{
    partial class AddOrChangePhoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrChangePhoto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.buttonSalveaza = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 77);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(548, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 53);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add, Change Photo..";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 285);
            this.panel2.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 67);
            this.button6.TabIndex = 6;
            this.button6.Text = "Photo :           ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseCompatibleTextRendering = true;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = " ID  :  ";
            this.button3.UseCompatibleTextRendering = true;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "Table:";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxTable.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Items.AddRange(new object[] {
            "Actori",
            "Filme",
            "Seriale",
            "Regizori",
            "Users"});
            this.comboBoxTable.Location = new System.Drawing.Point(198, 97);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(234, 26);
            this.comboBoxTable.TabIndex = 2;
            this.comboBoxTable.Text = "Alege o tabela...";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxID.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxID.Location = new System.Drawing.Point(198, 164);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(234, 21);
            this.textBoxID.TabIndex = 3;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto.Image")));
            this.pictureBoxPhoto.Location = new System.Drawing.Point(210, 209);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(131, 138);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 4;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonCauta
            // 
            this.buttonCauta.FlatAppearance.BorderSize = 0;
            this.buttonCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCauta.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCauta.Image = ((System.Drawing.Image)(resources.GetObject("buttonCauta.Image")));
            this.buttonCauta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCauta.Location = new System.Drawing.Point(366, 209);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(129, 59);
            this.buttonCauta.TabIndex = 5;
            this.buttonCauta.Text = "Cauta...";
            this.buttonCauta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCauta.UseCompatibleTextRendering = true;
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // buttonSalveaza
            // 
            this.buttonSalveaza.FlatAppearance.BorderSize = 0;
            this.buttonSalveaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalveaza.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalveaza.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalveaza.Image")));
            this.buttonSalveaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalveaza.Location = new System.Drawing.Point(366, 274);
            this.buttonSalveaza.Name = "buttonSalveaza";
            this.buttonSalveaza.Size = new System.Drawing.Size(145, 59);
            this.buttonSalveaza.TabIndex = 32;
            this.buttonSalveaza.Text = "Salveaza";
            this.buttonSalveaza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalveaza.UseCompatibleTextRendering = true;
            this.buttonSalveaza.UseVisualStyleBackColor = true;
            this.buttonSalveaza.Click += new System.EventHandler(this.buttonSalveaza_Click);
            // 
            // AddOrChangePhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 359);
            this.Controls.Add(this.buttonSalveaza);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.comboBoxTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrChangePhoto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrChangePhoto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.Button buttonSalveaza;
    }
}