using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB
{
    public partial class AdminPage : Form
    {
        public AdminPage(string AdminName)
        {
            InitializeComponent();
            AdminNameLabel.Text = "Welcome, " + AdminName + " !";
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Nume";
            label2.Visible = true;
            textBox1.Visible = true;
            label7.Text = "Prenume";
            label7.Visible = true;
            textBox2.Visible = true;
            label6.Text = "Anul Nasterii";
            label6.Visible = true;
            textBox3.Visible = true;
            label5.Text = "Nume";
            label5.Visible = true;
            textBox4.Visible = true;
            label4.Text = "Tara";
            label4.Visible = true;
            textBox5.Visible = true;
            label3.Text = "Nationalitate";
            label3.Visible = true;
            textBox6.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddDirectorButton_Click(object sender, EventArgs e)
        {
            label2.Text = "Nume";
            label2.Visible = true;
            textBox1.Visible = true;
            label7.Text = "Prenume";
            label7.Visible = true;
            textBox2.Visible = true;
            label6.Text = "Data Nasterii";
            label6.Visible = true;
            textBox3.Visible = true;
            label5.Text = "Nume";
            label5.Visible = true;
            textBox4.Visible = true;
            label4.Text = "Tara";
            label4.Visible = true;
            textBox5.Visible = true;
            label3.Text = "Nationalitate";
            label3.Visible = true;
            textBox6.Visible = true;
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            label2.Text = "Nume";
            label2.Visible = true;
            textBox1.Visible = true;
            label7.Text = "An aparitie";
            label7.Visible = true;
            textBox2.Visible = true;
            label6.Text = "Nota";
            label6.Visible = true;
            textBox3.Visible = true;
             label5.Visible = false;
            textBox4.Visible = false;
            label4.Visible = false;
            textBox5.Visible = false;
            label3.Visible = false;
            textBox6.Visible = false;
        }

        private void AddTVSeriesButton_Click(object sender, EventArgs e)
        {
            label2.Text = "Nume";
            label2.Visible = true;
            textBox1.Visible = true;
            label7.Text = "An aparitie";
            label7.Visible = true;
            textBox2.Visible = true;
            label6.Text = "Numar sezoane";
            label6.Visible = true;
            textBox3.Visible = true;
            label5.Text = "Total episoade";
            label5.Visible = true;
            textBox4.Visible = true;
            label4.Text = "Nota";
            label4.Visible = true;
            textBox5.Visible = true;            
            label3.Visible = false;
            textBox6.Visible = false;
        }

        private void InsertcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
