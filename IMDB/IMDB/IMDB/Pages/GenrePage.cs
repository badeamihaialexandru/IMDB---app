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
    public partial class GenrePage : Form
    {
        public GenrePage()
        {
            InitializeComponent();
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderActionMovies");
            form.Show();
        }

        private void buttonAdventure_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderAdventureMovies");
            form.Show();
        }

        private void buttonAnimation_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderAnimationMovies");
            form.Show();
        }

        private void buttonBiography_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderBiographyMovies");
            form.Show();
        }

        private void buttonComedy_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderComedyMovies");
            form.Show();
        }

        private void buttonCrime_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderCrimeMovies");
            form.Show();
        }

        private void buttonDocumentary_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderDocumentaryMovies");
            form.Show();
        }

        private void buttonDrama_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderDramaMovies");
            form.Show();
        }

        private void buttonFamily_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderFamilyMovies");
            form.Show();
        }

        private void buttonFantasy_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderFantasyMovies");
            form.Show();
        }

        private void buttonFilmNoir_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderFilmNoirMovies");
            form.Show();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderHistoryMovies");
            form.Show();
        }

        private void buttonHorror_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderHorrorMovies");
            form.Show();
        }

        private void buttonMistery_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderMisteryMovies");
            form.Show();
        }

        private void buttonMusical_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderMusicalMovies");
            form.Show();
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderMusicMovies");
            form.Show();
        }

        private void buttonRomance_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderRomanceMovies");
            form.Show();
        }

        private void buttonSF_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderSFMovies");
            form.Show();
        }

        private void buttonSport_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderSportMovies");
            form.Show();
        }

        private void buttonThriller_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderThrillerMovies");
            form.Show();
        }

        private void buttonWar_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderWarMovies");
            form.Show();
        }

        private void buttonWestern_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("GenderWesternMovies");
            form.Show();
        }

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
