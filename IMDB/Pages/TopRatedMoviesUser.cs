﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace IMDB
{
    public partial class TopRatedMovies : Form
    {
        private Form FormParent;
        
        public TopRatedMovies(Form Parent)
        {
            InitializeComponent();
            FormParent = Parent;
        }


        private void BindGrid()
        {
            using (var context = new IMDBEntities())
            {
                var imdb = new IMDBEntities();
                var aux = from c in imdb.Filmes
                          orderby c.ID_Film
                          select new
                          {
                              c.ID_Film,
                              c.Nume,
                              c.Nota 
                          } ;
                dataGridViewTOP.DataSource = aux.ToList();
                

            }


        }

        private void TopRatedMovies_Load(object sender, EventArgs e)
        {
            BindGrid();
            // dataGridViewTOP.RefreshEdit();
            //dataGridViewTOP.Update();
            //dataGridViewTOP.RefreshEdit();
        }

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTOP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTOP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewTOP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            MoviePage moviepage = new MoviePage(dataGridViewTOP.Rows[e.RowIndex].Cells[1].Value.ToString(),this);
            moviepage.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAscending_Click(object sender, EventArgs e)
        {
            pictureBoxDescending.Visible = true;
            pictureBoxAscending.Visible = false;
            using (var context = new IMDBEntities())
            {
                var imdb = new IMDBEntities();
                var aux = from c in imdb.Filmes
                          orderby c.ID_Film ascending
                          select new
                          {
                              c.ID_Film,
                              c.Nume,
                              c.Nota
                          };
                dataGridViewTOP.DataSource = aux.ToList();

            }

        }

        private void pictureBoxDescending_Click(object sender, EventArgs e)
        {
            pictureBoxAscending.Visible = true;
            pictureBoxDescending.Visible = false;
            using (var context = new IMDBEntities())
            {
                var imdb = new IMDBEntities();
                var aux = from c in imdb.Filmes
                          orderby c.ID_Film descending
                          select new
                          {
                              c.ID_Film,
                              c.Nume,
                              c.Nota
                          };
                dataGridViewTOP.DataSource = aux.ToList();

            }

        }

        private void topRatedMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/imdb");
        }

        private void buttonInstagram_Click(object sender, EventArgs e)
        {
             Process.Start("https://www.instagram.com/imdb/");
           
        }

        private void buttonTwitter_Click(object sender, EventArgs e)
        {
             Process.Start("https://twitter.com/imdb");
        }
    }


}
