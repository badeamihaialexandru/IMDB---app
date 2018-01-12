using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace IMDB
{
    public partial class MoviePage : Form
    {
        private Form ParentForm;


        public MoviePage(string str1,Form Parent)
        {
            InitializeComponent();
            GuestVisit(str1);
            ParentForm = Parent;
        }

        private Image ConvertByteToImage(byte[] photo)
        {
            Image newImage;
            using (MemoryStream ms=new MemoryStream(photo,0,photo.Length))
            {
                ms.Write(photo, 0, photo.Length);
                newImage = Image.FromStream(ms, true);
            }
            return newImage;
        }

        private void GuestVisit(string str1)
        {
            using (var context = new IMDBEntities())
            {
                IMDBEntities imen = new IMDBEntities();
                var result = (from c in imen.Filmes
                              where c.Nume.Equals(str1)
                              select c).Single();
                var result2 = from o in imen.Relatie_Filme_Premii
                              where o.Filme.Nume.Equals(str1)
                              select o;
                var result3 = from p in imen.Relatie_actor_film
                              where p.Filme.Nume.Equals(str1)
                              select p;
                var result4 = (from p in imen.Relatie_actor_film
                              where p.Filme.Nume.Equals(str1)
                              select p).Count();
                try
                {
                    pictureBoxPhoto.Image = ConvertByteToImage(result.Photo);
                }
                catch
                {
                    MessageBox.Show("Can't load this movie's photo!", "ErrorPhoto");
                }
                labelNameandYear.Text = result.Nume + " " + " ( " + result.An_aparitie.ToString() + ")";
                labelGender.Text = "";
                int count = result.Genuris.Count;
                foreach (var a in result.Genuris)
                {
                    if (count != 1)
                    {
                        labelGender.Text += a.Nume_Gen.ToString() + ",";
                        count--;
                    }
                    else labelGender.Text += a.Nume_Gen.ToString();
                }
                labelWins.Text = "";
                count = 1;
                foreach (var b in result2)
                {
                    if (count != result2.Count())
                    {
                        labelWins.Text += b.Premii.Nume.ToString() + ", ";
                        count++;
                    }
                    else labelWins.Text += b.Premii.Nume.ToString();
                }
                labelNameofDirector.Text = "";
                count = result.Regizoris.Count;
                foreach (var c in result.Regizoris)
                {
                    if (count != 1)
                    {
                        labelNameofDirector.Text += c.Prenume.ToString() + " " + c.Nume.ToString() + ",";
                        count--;
                    }
                    else { labelNameofDirector.Text += c.Prenume.ToString() + " " + c.Nume.ToString(); }
                }
                labelActors.Text = "";
                foreach (var d in result3)
                {
                    labelActors.Text += d.Actori.Prenume.ToString() + " " + d.Actori.Nume.ToString() + "\t as  " + d.Nume_in_film.ToString() + "\n";
                }
                labelRating.Text = result.Nota.ToString();

            }
        }

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }

        private void buttonFacebook_Click(object sender, EventArgs e)
        {
           
             Process.Start("https://www.facebook.com/imdb");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelGender_Click(object sender, EventArgs e)
        {
            GenrePage gen = new GenrePage(this);
            gen.Show();
            this.Hide();
        }

        private void labelGender_MouseHover(object sender, EventArgs e)
        {
            labelGender.ForeColor = Color.CornflowerBlue;
            Font myFont = new Font("Palatino Linotype",12, FontStyle.Underline| FontStyle.Bold);
            labelGender.Font = myFont;
        }

        private void labelGender_MouseLeave(object sender, EventArgs e)
        {
            labelGender.ForeColor = Color.FromArgb(121, 121, 134);
            Font myFont = new Font("Palatino Linotype", 12,FontStyle.Bold);
            labelGender.Font = myFont;
        }

        private void labelActors_Click(object sender, EventArgs e)
        {

        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void topRatedMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("TopRatedMovies", this);
            form.Show();
            this.Hide();
        }

        private void mostRatedMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("MostPopularMovies", this);
            form.Show();
            this.Hide();
        }

        private void topRatedTVSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("TopRatedTVSeries", this);
            form.Show();
            this.Hide();
        }

        private void mostPopularTVSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("MostPopularTVSeries", this);
            form.Show();
            this.Hide();
        }

        private void celebrityNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("CelebrityNews", this);
            form.Show();
            this.Hide();
        }

        private void mostPopularCelebsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("MostPopularCelebs", this);
            form.Show();
            this.Hide();
        }

        private void newsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("News", this);
            form.Show();

            this.Hide();
        }

        private void topRatedMoviesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelNameandYear_Click(object sender, EventArgs e)
        {

        }

        private void MoviePage_Load(object sender, EventArgs e)
        {

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

