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
using System.Data.Entity;
using System.Diagnostics;

namespace IMDB
{
   

    public partial class UniversalPage : Form
    {
        private string MemberOptionDisplay;
        private string MemberMoviesOrTVSeries;
        private Form ParentForm;

        private string[] paths;
        public UniversalPage(string option,Form Parent)
        {
            InitializeComponent();
            MemberOptionDisplay = option;
            ParentForm = Parent;
        }

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPowerOffTop_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }

        private void UniversalPage_Load(object sender, EventArgs e)
        {
            if(MemberOptionDisplay.Equals("BornToday"))
            {
                MemberMoviesOrTVSeries = "Actors";
                BindByBornToday();
            }
            else if (MemberOptionDisplay.Equals("MostPopularCelebs"))
            {
                MemberMoviesOrTVSeries = "Actors";
                BindByMostPopularCelebs();
            }
            else if(MemberOptionDisplay.Contains("Movies"))
            {
                MemberMoviesOrTVSeries = "Movies";
                if(MemberOptionDisplay.Contains("Top") || MemberOptionDisplay.Contains("Most"))
                {
                    if (MemberOptionDisplay.Equals("TopRatedMovies"))
                    {
                        BindByTop(101);
                    }
                    else BindByMostPopularMovies(101);
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
                
                if (MemberOptionDisplay.Contains("Top") || MemberOptionDisplay.Contains("Most"))
                {
                    if (MemberOptionDisplay.Equals("TopRatedTVSeries"))
                    {
                        BindByTopTVSeries();
                    }
                    else BindByMostPopularTVSeries();
                }
            }
            else if(MemberOptionDisplay.Contains("News"))
            {
                MemberMoviesOrTVSeries = "News";
                if(MemberOptionDisplay.Contains("Celebrity"))
                {
                    BindByCelebrityNews();
                }
                else BindByNews();
            }
        }

        private void BindByMostPopularMovies(int limitleft)
        {
            using (var context = new IMDBEntities())
            {
               
                var results = from movies in context.Filmes
                              where movies.ID_Film > limitleft-1 || ( movies.ID_Film<limitleft && movies.An_aparitie>2016 )
                              orderby movies.Nota descending, movies.ID_Film
                              select new
                              {
                                  movies.ID_Film,
                                  movies.Nume,
                                  movies.An_aparitie,
                                  movies.Nota
                              };
                dataGridViewUniversal.DataSource = results.ToList();
            }
        }

        private void BindByMostPopularCelebs()
        {
            using (var context = new IMDBEntities())
            {

                var results = from a in context.Actoris
                              join b in context.Relatie_actor_film
                              on a.ID_Actor equals b.ID_Actor
                              join c in context.Filmes
                              on b.ID_Film equals c.ID_Film
                              where c.An_aparitie>2016
                              select new
                              {
                                  a.ID_Actor,
                                  a.Nume,
                                  a.Prenume
                              };
                

                dataGridViewUniversal.DataSource = results.Distinct().ToList();
            }

        }

        private void BindByMostPopularTVSeries()
        {
            using (var context = new IMDBEntities())
            {
                
                var results = from movies in context.Seriales
                              where  movies.An_aparitie > 2013
                              orderby movies.Nota descending, movies.ID_Serial
                              select new
                              {
                                  movies.ID_Serial,
                                  movies.Nume,
                                  movies.An_aparitie,
                                  movies.Nota
                              };
                dataGridViewUniversal.DataSource = results.ToList();
            }
        }

        private void BindByBornToday()
        {
            using (var context = new IMDBEntities())
            {
                //var query = from adr in context.Actoris
                //            where adr.DataNasterii.ToString().Contains(DateTime.Now.Month.ToString())
                //            select adrr;


              //  dataGridViewUniversal.DataSource = query.ToList();
            }
        }

        private void BindByNews()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Mosu\Desktop\proiectbaze\IMDBbun\IMDB\News");
            FileInfo[] Files = dir.GetFiles("*.txt");
            int a = Files.ToList().Count;
            paths = new string[a]; 
            dataGridViewUniversal.Columns.Add("Title", "Title");
            for(int i=0;i<a;i++)
            {
                dataGridViewUniversal.Rows.Add(Path.GetFileNameWithoutExtension(Files[i].Name));
                paths[i] = Files[i].FullName;
            }
        }

        private void BindByCelebrityNews()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Mosu\Desktop\proiectbaze\IMDBbun\IMDB\CelebrityNews");
            FileInfo[] Files = dir.GetFiles("*.txt");
            int a = Files.ToList().Count;
            paths = new string[a];
            dataGridViewUniversal.Columns.Add("Title", "Title");
            for (int i = 0; i < a; i++)
            {
                dataGridViewUniversal.Rows.Add(Path.GetFileNameWithoutExtension(Files[i].Name));
                paths[i] = Files[i].FullName;
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

        private void BindByTopTVSeries()
        {
            using( var context= new IMDBEntities())
            {
                var results = from tvseries in context.Seriales
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
                MoviePage mp = new MoviePage(dataGridViewUniversal.Rows[e.RowIndex].Cells[1].Value.ToString(), this);
                mp.Show();
                this.Hide();
            }
            else if(MemberMoviesOrTVSeries.Equals("News"))
            {
                string text = File.ReadAllText(paths[e.RowIndex]);
                NewsPage np=new NewsPage( dataGridViewUniversal.Rows[e.RowIndex].Cells[0].Value.ToString(),text);
                np.Show();
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

        private void topRatedMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindByTop(101);
        }

        private void mostRatedMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindByMostPopularMovies(101);
        }

        private void topRatedTVSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindByTopTVSeries();
        }

        private void mostPopularTVSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindByMostPopularTVSeries();
        }

        private void celebrityNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindByCelebrityNews();
        }

        private void mostPopularCelebsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindByMostPopularCelebs();
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
