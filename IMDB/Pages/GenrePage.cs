using System;
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
    public partial class GenrePage : Form
    {
        private Form ParentForm;

        public GenrePage(Form Parent)
        {
            InitializeComponent();
            ParentForm = Parent;
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderActionMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonAdventure_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderAdventureMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonAnimation_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderAnimationMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonBiography_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderBiographyMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonComedy_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderComedyMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonCrime_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderCrimeMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonDocumentary_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderDocumentaryMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonDrama_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderDramaMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonFamily_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderFamilyMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonFantasy_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderFantasyMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonFilmNoir_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderFilmNoirMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderHistoryMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonHorror_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderHorrorMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonMistery_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderMisteryMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonMusical_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderMusicalMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderMusicMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonRomance_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderRomanceMovies", this);
            form.Show();
            this.Hide();
        }

        private void buttonSF_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderSFMovies",this);
            form.Show();
            this.Hide();
        }

        private void buttonSport_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderSportMovies",this);
            form.Show();
            this.Hide();
        }

        private void buttonThriller_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderThrillerMovies",this);
            form.Show();
            this.Hide();
        }

        private void buttonWar_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderWarMovies",this);
            form.Show();
            this.Hide();
        }

        private void buttonWestern_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderWesternMovies",this);
            form.Show();
            this.Hide();
        }

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
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
