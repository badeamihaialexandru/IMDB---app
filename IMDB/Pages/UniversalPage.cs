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
        private string MemberFieldOption;
        private string MemberField;
        private Form ParentForm;

        private string[] paths;
        public UniversalPage(string option,Form Parent)
        {
            InitializeComponent();
            MemberOptionDisplay = option;
            ParentForm = Parent;
        }

        public UniversalPage(string option,string field, Form Parent)
        {
            InitializeComponent();
            MemberOptionDisplay = option;
            MemberField = field;
            ParentForm = Parent;
        }

    

        private void buttonPowerOffTop_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }

        private void UniversalPage_Load(object sender, EventArgs e)
        {
            if(MemberOptionDisplay.Contains("SearchBy"))
            {
                using (var contextsearch = new IMDBEntities())
                {
                    if (MemberOptionDisplay.Equals("SearchByMovies"))
                    {
                        SearchByMoviesBind();
                    }
                    else if(MemberOptionDisplay.Equals("SearchByTVSeries"))
                    {
                        SearchByTvSeriesBind();
                    }
                    else if(MemberOptionDisplay.Equals("SearchByActors"))
                    {
                        SearchByActors();
                    }
                    else if(MemberOptionDisplay.Equals("SearchByDirectors"))
                    {
                        SearchByDirectors();
                    }
                    else if( MemberOptionDisplay.Equals("SearchByGender"))
                    {
                        SearchByGender();
                    }
                }

            }
            else if(MemberOptionDisplay.Equals("BornToday"))
            {
               MemberFieldOption = "Actors";
                BindByBornToday();
            }
            else if (MemberOptionDisplay.Equals("MostPopularCelebs"))
            {
               MemberFieldOption = "Actors";
                BindByMostPopularCelebs();
            }
            else if(MemberOptionDisplay.Equals("AllActorsCelebs"))
            {
                MemberFieldOption = "Actors";
                BindbyAllActors();
            }
            else if(MemberOptionDisplay.Contains("Movies"))
            {
               MemberFieldOption = "Movies";
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
               
            }
          
            else if(MemberOptionDisplay.Contains("TVSeries"))//asta e pt Seriale!
            {
               MemberFieldOption = "TVSeries";
                
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
               MemberFieldOption = "News";
                if(MemberOptionDisplay.Contains("Celebrity"))
                {
                    BindByCelebrityNews();
                }
                else BindByNews();
            }
        }

        private void remove_column()
        {
            dataGridViewUniversal.Columns.RemoveAt(0);
        }

        private void clear_datagridview()
        {
            dataGridViewUniversal.Columns.Clear();
            dataGridViewUniversal.DataSource = null;
        }

        private void SearchByMoviesBind()
        {
            clear_datagridview();
            using (var context = new IMDBEntities())
            {
                var resultsearchmovies = from a in context.Filmes
                                         where a.Nume.Contains(MemberField)
                                         select new
                                         {
                                             a.ID_Film,
                                             a.Nume
                                         };
                MemberFieldOption = "Movies";
                dataGridViewUniversal.DataSource = resultsearchmovies.ToList();
            }
           
        }

        private void SearchByGender()
        {
            clear_datagridview();
            using (var context = new IMDBEntities())
            {
                var resultsearchgender = from r in context.Genuris
                                         where r.Nume_Gen.Contains(MemberField)
                                         select new { r.Nume_Gen };
                MemberFieldOption = "Gender";
                dataGridViewUniversal.DataSource = resultsearchgender.ToList();
            }
        }

        private void SearchByDirectors()
        {
            clear_datagridview();
            using (var context = new IMDBEntities())
            {
                var resultsearchdirectors = from d in context.Regizoris
                                            where d.Nume.Contains(MemberField) || d.Prenume.Equals(MemberField)
                                            select new
                                            {
                                                d.ID_Regizor,
                                                d.Nume,
                                                d.Prenume
                                            };
                MemberFieldOption = "Directors";
                dataGridViewUniversal.DataSource = resultsearchdirectors.ToList();
            }
        }

        private void SearchByActors()
        {
            clear_datagridview();
            using (var context = new IMDBEntities())
            {
                var resultsearchactors = from c in context.Actoris
                                         where c.Nume.Contains(MemberField) || c.Prenume.Equals(MemberField)
                                         select new
                                         {
                                             c.ID_Actor,
                                             c.Nume,
                                             c.Prenume
                                         };
                MemberFieldOption = "Actors";
                dataGridViewUniversal.DataSource = resultsearchactors.ToList();
            }
        }

        private void SearchByTvSeriesBind()
        {
            clear_datagridview();
            using (var context = new IMDBEntities())
            {
                var resultsearchtvseries = from b in context.Seriales
                                           where b.Nume.Contains(MemberField)
                                           select new
                                           {
                                               b.ID_Serial,
                                               b.Nume
                                           };
                MemberFieldOption = "TVSeries";
                dataGridViewUniversal.DataSource = resultsearchtvseries.ToList();
            }
        }

        private void BindbyAllActors()
        {
            clear_datagridview();
            MemberFieldOption = "Actors";
            using (var context = new IMDBEntities())
            {

                var results = from a in context.Actoris
                              select new
                              {
                                  a.ID_Actor,
                                  a.Nume,
                                  a.Prenume
                              };

                dataGridViewUniversal.DataSource = results.ToList();
            }

        }

        private void BindByMostPopularMovies(int limitleft)
        {
            clear_datagridview();
            MemberFieldOption = "Movies";
            //if (dataGridViewUniversal.Columns.Count != 0)
            //{ remove_column(); }
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
            clear_datagridview();
            MemberFieldOption = "Actors";
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
            clear_datagridview();
            MemberFieldOption = "Movies";
            if (dataGridViewUniversal.Columns.Count != 0)
            { remove_column(); }
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
            MemberFieldOption = "Actors";
            //if (dataGridViewUniversal.Columns.Count != 0)
            //{ remove_column(); }
            clear_datagridview();
            using (var context = new IMDBEntities())
            {
                var query = context.WhoIsBornToday(DateTime.Now);
                var res = from a in query
                          select new
                          {
                              a.ID_Actor,
                              a.Prenume,
                              a.Nume
                          };

                dataGridViewUniversal.DataSource = res.ToList();
            }
        }

        private void BindByNews()
        {
            clear_datagridview();
            MemberFieldOption = "News";
            //if (dataGridViewUniversal.DataSource !=null)
            //{
            //    dataGridViewUniversal.DataSource = null;
                
               
            //}
            int count = dataGridViewUniversal.Columns.Count;
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    dataGridViewUniversal.Columns.RemoveAt(i);
                }
            }

            DirectoryInfo dir = new DirectoryInfo(@"News");
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
            clear_datagridview();
            MemberFieldOption = "News";
           
            int count = dataGridViewUniversal.Columns.Count;
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    dataGridViewUniversal.Columns.RemoveAt(i);
                }
            }
            DirectoryInfo dir = new DirectoryInfo(@"CelebrityNews");
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
            clear_datagridview();
            MemberFieldOption = "Movies";
            
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
            clear_datagridview();
            MemberFieldOption = "TVSeries";
            
            using ( var context= new IMDBEntities())
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
            clear_datagridview();
            if (gender.Contains("action") || gender.Contains("Action") || gender.Contains("Actiune") || gender.Contains("actiune"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllActionMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if(gender.Contains("adventure") || gender.Contains("Adventure") || gender.Contains("Aventura") || gender.Contains("aventura"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllAdventureMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("Animation") || gender.Contains("animation") || gender.Contains("Animatie") || gender.Contains("animatie"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllAnimationMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("biography") || gender.Contains("Biography") || gender.Contains("biografie") || gender.Contains("Biografie") )
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllBiographyMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("comedy") || gender.Contains("Comedy") || gender.Contains("comedie") || gender.Contains("Comedie"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllComedyMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("Crime") || gender.Contains("crime") || gender.Contains("Crima") || gender.Contains("crima"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllCrimeMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("documentary") || gender.Contains("Documentary") || gender.Contains("documentar") || gender.Contains("Documentar"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllDocumentaryMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("drama") || gender.Contains("Drama") || gender.Contains("drama") || gender.Contains("Drama"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllDramaMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("family") || gender.Contains("Family") || gender.Contains("familie") || gender.Contains("Familie"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllFamilyMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("fantasy") || gender.Contains("Fantasy")  || gender.Contains("Fantasy") || gender.Contains("Fantasy"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllFantasyMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("filmnoir") || gender.Contains("FilmNoir") || gender.Contains("Filmnoir") || gender.Contains("Film-Noir") )
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllFilmNoirMovies;
                    dataGridViewUniversal.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("History") || gender.Contains("history")  )
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
            else if (gender.Contains("mistery") || gender.Contains("Mistery")  || gender.Contains("mister") || gender.Contains("Mister"))
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
            if (MemberFieldOption.Equals("Movies"))
            {
                MoviePage mp = new MoviePage(dataGridViewUniversal.Rows[e.RowIndex].Cells[1].Value.ToString(), this,"Movie");
                mp.Show();
                this.Hide();
            }
            else if (MemberFieldOption.Equals("TVSeries"))
            {
                MoviePage mp = new MoviePage(dataGridViewUniversal.Rows[e.RowIndex].Cells[1].Value.ToString(), this, "TVSeries");
                mp.Show();
                this.Hide();
            }
            else if(MemberFieldOption.Equals("News"))
            {
                string text = File.ReadAllText(paths[e.RowIndex]);
                NewsPage np=new NewsPage( dataGridViewUniversal.Rows[e.RowIndex].Cells[0].Value.ToString(),text);
                np.Show();
            }
            else if(MemberFieldOption.Equals("Actors"))
            {
                ActorsOrDirectorsPage aodp = new ActorsOrDirectorsPage(this,"Actor",dataGridViewUniversal.Rows[e.RowIndex].Cells[2].Value.ToString(),dataGridViewUniversal.Rows[e.RowIndex].Cells[1].Value.ToString());
                aodp.Show();
                this.Hide();
            }
            else if (MemberFieldOption.Equals("Directors"))
            {
                ActorsOrDirectorsPage aodp = new ActorsOrDirectorsPage(this, "Regizor", dataGridViewUniversal.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridViewUniversal.Rows[e.RowIndex].Cells[1].Value.ToString());
                aodp.Show();
                this.Hide();
            }
            else if(MemberFieldOption.Equals("Gender"))
            {
                BindByGender(dataGridViewUniversal.Rows[e.RowIndex].Cells[0].Value.ToString());
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

        private void bornTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindByBornToday();
        }

        private void pictureBoxAscending_Click(object sender, EventArgs e)
        {
            using (var context = new IMDBEntities())
            { if (MemberFieldOption.Equals("Movies"))
                {
                    if (SearchBy.Text.Equals("ID"))
                    {
                        var resultsortascid = from a in context.Filmes
                                              orderby a.ID_Film ascending
                                              select new
                                              {
                                                  a.ID_Film,
                                                  a.Nume,
                                                  a.Nota
                                              };

                    }
                }
                //else if (MemberFieldOption.Equals("TVSeries"))
                //{
                //    MoviePage mp = new MoviePage(dataGridViewUniversal.Rows[e.RowIndex].Cells[1].Value.ToString(), this, "TVSeries");
                //    mp.Show();
                //    this.Hide();
                //}
                //else if (MemberFieldOption.Equals("News"))
                //{
                //    string text = File.ReadAllText(paths[e.RowIndex]);
                //    NewsPage np = new NewsPage(dataGridViewUniversal.Rows[e.RowIndex].Cells[0].Value.ToString(), text);
                //    np.Show();
                //}
                //else if (MemberFieldOption.Equals("Actors"))
                //{
                //    ActorsOrDirectorsPage aodp = new ActorsOrDirectorsPage(this, "Actor", dataGridViewUniversal.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridViewUniversal.Rows[e.RowIndex].Cells[1].Value.ToString());
                //    aodp.Show();
                //    this.Hide();
                //}
                //else if (MemberFieldOption.Equals("Directors"))
                //{
                //    ActorsOrDirectorsPage aodp = new ActorsOrDirectorsPage(this, "Regizor", dataGridViewUniversal.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridViewUniversal.Rows[e.RowIndex].Cells[1].Value.ToString());
                //    aodp.Show();
                //    this.Hide();
                //}
                //else if (MemberFieldOption.Equals("Gender"))
                //{
                //    BindByGender(dataGridViewUniversal.Rows[e.RowIndex].Cells[0].Value.ToString());
                //}
            }
        }

        private void allActorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindbyAllActors();
        }

        private void dataGridViewUniversal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchPictureBox_Click(object sender, EventArgs e)
        {
            if (  textBoxSearch.Text.Equals(""))
            {
                MessageBox.Show("Please enter a keyword for search!", "InfoMessage");
            }
            else
            {
                using (var context = new IMDBEntities())
                {
                    var ResultMovies = (from rmov in context.Filmes
                                        where rmov.Nume.Contains(textBoxSearch.Text)
                                        select rmov).FirstOrDefault();
                    var ResultTVSeries = (from rtv in context.Seriales
                                          where rtv.Nume.Contains(textBoxSearch.Text)
                                          select rtv).FirstOrDefault();
                    var ResultActors = (from ra in context.Actoris
                                        where ra.Nume.Contains(textBoxSearch.Text) || ra.Prenume.Equals(textBoxSearch.Text)
                                        select ra).FirstOrDefault();
                    var ResultDirectors = (from rd in context.Regizoris
                                           where rd.Nume.Contains(textBoxSearch.Text) || rd.Prenume.Equals(textBoxSearch.Text)
                                           select rd).FirstOrDefault();
                    var ResultGender = (from rg in context.Genuris
                                        where rg.Nume_Gen.Contains(textBoxSearch.Text)
                                        select rg).FirstOrDefault();
                    if (SearchBy.Text.Equals("Movies"))
                    {
                        if (ResultMovies != null)
                        {
                            SearchByMoviesBind();
                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corespunda textului introdus!"); }
                    }
                    else if (SearchBy.Text.Equals("TV Series"))
                    {
                        if (ResultTVSeries != null)
                        {
                            SearchByTvSeriesBind();
                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corepunda textului introdus!"); }
                    }
                    else if (SearchBy.Text.Equals("Actors"))
                    {
                        if (ResultActors != null)
                        {
                            SearchByActors();
                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corepunda textului introdus!"); }
                    }
                    else if (SearchBy.Text.Equals("Directors"))
                    {
                        if (ResultDirectors != null)
                        {
                            SearchByDirectors();
                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corepunda textului introdus!"); }
                    }
                    else if (SearchBy.Text.Equals("Gender"))
                    {
                        if (ResultGender != null)
                        {
                            SearchByGender();
                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corepunda textului introdus!"); }
                    }
                }
            }
        }
    }
}
