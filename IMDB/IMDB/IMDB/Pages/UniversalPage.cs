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

namespace IMDB
{
   

    public partial class UniversalPage : Form
    {
        private string MemberOptionDisplay;
        private string MemberMoviesOrTVSeries;
        private string[] paths;
        public UniversalPage(string option)
        {
            InitializeComponent();
            MemberOptionDisplay = option;
        }

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPowerOffTop_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UniversalPage_Load(object sender, EventArgs e)
        {
            if(MemberOptionDisplay.Contains("Movies"))
            {
                MemberMoviesOrTVSeries = "Movies";
                if(MemberOptionDisplay.Contains("Top"))
                {
                    if (MemberOptionDisplay.Equals("TopRatedMovies"))
                    {
                        BindByTop(101);
                    }
                    else BindByTop(151);
                }
                else if(MemberOptionDisplay.Contains("Gender"))
                {
                    BindByGender(MemberOptionDisplay);
                }
                else if (MemberOptionDisplay.Contains("Win"))
                {

                }
                else if (MemberOptionDisplay.Contains("Director"))
                {

                }
                else if (MemberOptionDisplay.Contains("Actors"))
                {

                }
            }
            else if(MemberOptionDisplay.Contains("TVSeries"))//asta e pt Seriale!
            {
                MemberMoviesOrTVSeries = "TVSeries";
                BindByTopTVSeries(30);
            }
            else if(MemberOptionDisplay.Equals("News"))
            {
                MemberMoviesOrTVSeries = "News";
                BindByNews();
            }
        }

        private void BindByNews()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Mosu\Desktop\proiectbaze\IMDB - cu login - 21.12.17\IMDB\News");
            FileInfo[] Files = dir.GetFiles("*.txt");
            int a = Files.ToList().Count;
            paths = new string[a]; 
            dataGridViewUniversal.Columns.Add("Title", "Title");
            for(int i=0;i<a;i++)
            {
                dataGridViewUniversal.Rows.Add(Path.GetFileNameWithoutExtension(Files[i].Name));
                paths[i] = Path.GetFullPath(Files[i].Name);
            }

        }

        private void BindByTop(int limit) //gandeste-te la most popular bagi filme in aceeasi tabela dar de la id 101
        {
            using (var context = new IMDBEntities())
            {
                var results = from movies in context.Filmes
                              where movies.ID_Film < limit
                              orderby movies.Nota descending, movies.ID_Film
                              select new
                              {
                                  movies.ID_Film,
                                  movies.Nume,
                                  movies.Nota
                              };
                dataGridViewUniversal.DataSource = results.ToList();
            }
        }

        private void BindByTopTVSeries(int limit)
        {
            using( var context= new IMDBEntities())
            {
                var results = from tvseries in context.Seriales
                              where tvseries.ID_Serial <= limit
                              orderby tvseries.Nota descending, tvseries.ID_Serial
                              select new
                              {
                                  tvseries.ID_Serial,
                                  tvseries.Nume,
                                  tvseries.Nota
                              };
                dataGridViewUniversal.DataSource = results.ToList();
            }
        }

        private void BindByGender(string gender)
        {
            if(gender.Contains("action") || gender.Contains("Action"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllActionMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if(gender.Contains("adventure") || gender.Contains("Adventure")) {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllAdventureMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("Animation") || gender.Contains("animation"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllAnimationMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("biography") || gender.Contains("Biography"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllBiographyMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("comedy") || gender.Contains("Comedy"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllComedyMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("Crime") || gender.Contains("crime"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllCrimeMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("documentary") || gender.Contains("Documentary"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllDocumentaryMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("drama") || gender.Contains("Drama"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllDramaMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("family") || gender.Contains("Family"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllFamilyMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("fantasy") || gender.Contains("Fantasy"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllFantasyMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("filmnoir") || gender.Contains("FilmNoir") || gender.Contains("Filmnoir"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllFilmNoirMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("History") || gender.Contains("history"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllHistoryMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("Horror") || gender.Contains("horror"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllHorrorMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("mistery") || gender.Contains("Mistery"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllMisteryMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("Musical") || gender.Contains("musical"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllMusicalMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("music") || gender.Contains("Music"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllMusicMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("Romance") || gender.Contains("romance"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllRomanceMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("SF"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllSFMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("sport") || gender.Contains("Sport"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllSportMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("thriller") || gender.Contains("Thriller"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllThrillerMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("war") || gender.Contains("War"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllWarMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("western") || gender.Contains("Western"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllWesternMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
        }

        private void dataGridViewUniversal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MemberMoviesOrTVSeries.Equals("Movies"))
            {
                MoviePage mp = new MoviePage(dataGridViewUniversal.Rows[e.RowIndex].Cells[1].Value.ToString());
                mp.Show();
            }
            else if(MemberMoviesOrTVSeries.Equals("News"))
            {
                string text = File.ReadAllText(paths[e.RowIndex]);
                MessageBox.Show(text, dataGridViewUniversal.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BindByNews();
        }
    }
}
