using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;


namespace IMDB
{
    public partial class UniversalUserPage : Form
    {

        private Form FormParent;
        private string MemberOption;
        private string MemberFieldOption;
        private int MemberUserID;
        private string MemberUserName;
        private int MemberCurrentCell;
        private bool VoteState;
        private string[] paths;
        private BindingSource _TopRatedMoviesSource = new BindingSource();
        private string MemberMovieOrTVSeries;
        public UniversalUserPage(string option, Form Parent, int UserID, string movieortvseries)
        {
            InitializeComponent();
            FormParent = Parent;
            MemberOption = option;
            MemberUserID = UserID;
            MemberMovieOrTVSeries = movieortvseries;
            using (var context = new IMDBEntities())
            {
                var result = (from a in context.Users
                              where a.ID_User == UserID
                              select a).First();
                MemberUserName = result.Username;
            }
            NameOfUser.Text = MemberUserName;
        }

        public UniversalUserPage(string option, Form Parent, int UserID)
        {
            InitializeComponent();
            FormParent = Parent;
            MemberOption = option;
            MemberUserID = UserID;
           
            using (var context = new IMDBEntities())
            {
                var result = (from a in context.Users
                              where a.ID_User == UserID
                              select a).First();
                MemberUserName = result.Username;
            }
            NameOfUser.Text = MemberUserName;
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

        private void UniversalUserPage_Load(object sender, EventArgs e)
        {
            if(MemberOption.Contains("Watchlist"))
            {
                if (MemberOption.Equals("WatchlistMovie"))
                {
                    BindByUserWatchlistMovies(MemberUserID);
                }
                else BindByUserWatchlistTVSeries(MemberUserID);
            }
            else if(MemberOption.Contains("YourRating"))
            {
                if (MemberOption.Equals("YourRatingMovie"))
                {
                    BindByUserRatingMovies(MemberUserID);
                }
                else BindByUserRatingTVSeries(MemberUserID);
            }
            else if (MemberOption.Equals("AllActorsCelebs"))
            {
                MemberFieldOption = "Actors";
                BindbyAllActors();
            }
            else if (MemberOption.Equals("MostPopularCelebs"))
            {
                BindByMostPopularCelebs();
            }
          
            else if (MemberOption.Contains("Movies"))
            {
                buttonVote.Visible = true;
                if (MemberOption.Equals("TopRatedMovies"))
                {
                    BindByTopRatedMovies(101);
                }
               
                else BindByMostPopularMovies(101);
            }
            else if (MemberOption.Contains("TVSeries"))
            {
                buttonVote.Visible = true;
                MemberFieldOption = "TVSeries";

                if (MemberOption.Contains("Top") || MemberOption.Contains("Most"))
                {
                    if (MemberOption.Equals("TopRatedTVSeries"))
                    {
                        BindByTopTVSeries();
                    }
                    else BindByMostPopularTVSeries();
                }
            }
            else if (MemberOption.Contains("News"))
            {
                if (MemberOption.Equals("CelebrityNews"))
                {
                    BindByCelebrityNews();
                }
                else BindByNews();
            }
        }

        private void clear_datagridview()
        {
            dataGridView.Columns.Clear();
            dataGridView.DataSource = null;
        }

        private void BindByMostPopularCelebs()
        {
            clear_datagridview();
            MemberFieldOption = "Actor";
            using (var context = new IMDBEntities())
            {

                var results = from a in context.Actoris
                              join b in context.Relatie_actor_film
                              on a.ID_Actor equals b.ID_Actor
                              join c in context.Filmes
                              on b.ID_Film equals c.ID_Film
                              where c.An_aparitie > 2016
                              select new
                              {
                                  a.ID_Actor,
                                  a.Nume,
                                  a.Prenume
                              };


                dataGridView.DataSource = results.Distinct().ToList();
            }

        }

        private void BindByNews()
        {
            clear_datagridview();
            MemberFieldOption = "News";
            if (dataGridView.DataSource != null)
            {
                dataGridView.DataSource = null;
            }
            int count = dataGridView.Columns.Count;
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    dataGridView.Columns.RemoveAt(i);
                }
            }

            DirectoryInfo dir = new DirectoryInfo("News");
            FileInfo[] Files = dir.GetFiles("*.txt");
            int a = Files.ToList().Count;
            paths = new string[a];
            dataGridView.Columns.Add("Title", "Title");
            for (int i = 0; i < a; i++)
            {
                dataGridView.Rows.Add(Path.GetFileNameWithoutExtension(Files[i].Name));
                paths[i] = Files[i].FullName;
            }
        }

        private void BindByCelebrityNews()
        {
            clear_datagridview();
            MemberFieldOption = "News";
            if (dataGridView.DataSource != null)
            {
                dataGridView.DataSource = null;
            }
            int count = dataGridView.Columns.Count;
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    dataGridView.Columns.RemoveAt(i);
                }
            }
            DirectoryInfo dir = new DirectoryInfo("CelebrityNews");
            FileInfo[] Files = dir.GetFiles("*.txt");
            int a = Files.ToList().Count;
            paths = new string[a];
            dataGridView.Columns.Add("Title", "Title");
            for (int i = 0; i < a; i++)
            {
                dataGridView.Rows.Add(Path.GetFileNameWithoutExtension(Files[i].Name));
                paths[i] = Files[i].FullName;
            }
        }

        private void BindByMostPopularTVSeries()
        {
            clear_datagridview();
            MemberFieldOption = "Movie";
         //   if (dataGridView.Columns.Count != 0)
         //   { remove_column(); }
            using (var context = new IMDBEntities())
            {

                var results = from movies in context.Seriales
                              where movies.An_aparitie > 2013
                              orderby movies.Nota descending, movies.ID_Serial
                              select new
                              {
                                  movies.ID_Serial,
                                  movies.Nume,
                                  movies.An_aparitie,
                                  movies.Nota
                              };
                dataGridView.DataSource = results.ToList();
            }
        }

        private void BindByTopTVSeries()
        {
            clear_datagridview();
            MemberFieldOption = "TVSeries";
      
            using (var context = new IMDBEntities())
            {
                var results = from tvseries in context.Seriales
                              orderby tvseries.Nota descending, tvseries.ID_Serial
                              select new
                              {
                                  tvseries.ID_Serial,
                                  tvseries.Nume,
                                  tvseries.Nota
                              };
                dataGridView.DataSource = results.ToList();
            }
        }

        private void BindByMostPopularMovies(int limitleft)
        {
            clear_datagridview();
            MemberFieldOption = "Movie";
            using (var context = new IMDBEntities())
            {

                var results = from movies in context.Filmes
                              where movies.ID_Film > limitleft - 1 || (movies.ID_Film < limitleft && movies.An_aparitie > 2016)
                              orderby movies.Nota descending, movies.ID_Film
                              select new
                              {
                                  movies.ID_Film,
                                  movies.Nume,
                                  movies.An_aparitie,
                                  movies.Nota
                              };
                dataGridView.DataSource = results.ToList();
            }
        }

        private void BindByTopRatedMovies(int limit)
        {
            clear_datagridview();
            MemberFieldOption = "Movie";
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
                dataGridView.DataSource = results.ToList();
            }
        }

        private void BindByBornToday()
        {
            clear_datagridview();
            MemberFieldOption = "Actor";
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

                dataGridView.DataSource = res.ToList();
            }
        }

        private void BindByUserRatingMovies(int IDuser)
        {
            clear_datagridview();
            MemberFieldOption = "Movie";
            using (var context = new IMDBEntities())
            {
                var ratings = from a in context.YourRatings
                              where a.ID_User == IDuser
                              select new
                              {
                                  a.ID_Film,
                                  a.Filme.Nume,
                                  a.Nota
                              };

                _TopRatedMoviesSource.DataSource = ratings.ToList();
                dataGridView.DataSource = _TopRatedMoviesSource;

            }
        }

        private void BindByUserRatingTVSeries(int IDuser)
        {
            clear_datagridview();
            MemberFieldOption = "TVSeries";
            using (var context = new IMDBEntities())
            {
                var ratings = from a in context.YourRatingsSerials
                              where a.ID_User == IDuser
                              select new
                              {
                                  a.ID_Serial,
                                  a.Seriale.Nume,
                                  a.Nota
                              };

                _TopRatedMoviesSource.DataSource = ratings.ToList();
                dataGridView.DataSource = _TopRatedMoviesSource;

            }
        }

        private void BindByUserWatchlistMovies(int IDuser)
        {
            clear_datagridview();
            MemberFieldOption = "Movie";
            using (var context = new IMDBEntities())
            {
                var watchlist = from a in context.WatchLists
                              where a.ID_User == IDuser
                              select new
                              {
                                  a.ID_Film,
                                  a.Filme.Nume                                
                              };
                dataGridView.DataSource = watchlist.ToList();
            }
        }

        private void BindByUserWatchlistTVSeries(int IDuser)
        {
            clear_datagridview();
            MemberFieldOption = "TVSeries";
            using (var context = new IMDBEntities())
            {
                var watchlist = from a in context.WatchlistSeriales
                                where a.ID_User == IDuser
                                select new
                                {
                                    a.ID_Serial,
                                    a.Seriale.Nume
                                };
                dataGridView.DataSource = watchlist.ToList();
            }
        }

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            FormParent.Show();
            this.Close();
        }

        private void buttonVote_Click(object sender, EventArgs e)
        {
            VoteState = false;
            pictureBoxStar1.Visible = true;
            pictureBoxStar2.Visible = true;
            pictureBoxStar3.Visible = true;
            pictureBoxStar4.Visible = true;
            pictureBoxStar5.Visible = true;
            pictureBoxStar6.Visible = true;
            pictureBoxStar7.Visible = true;
            pictureBoxStar8.Visible = true;
            pictureBoxStar9.Visible = true;
            pictureBoxStar10.Visible = true;
        }

        private void pictureBoxStar1_MouseHover(object sender, EventArgs e)
        {
            pictureBoxStar1.Visible = false;
            StarFilled1.Visible = true;
        }

        private void StarFilled1_MouseLeave(object sender, EventArgs e)
        {
            if (VoteState == false)
            {
                StarFilled1.Visible = false;
                pictureBoxStar1.Visible = true;
            }
        }

        private void pictureBoxStar2_MouseHover(object sender, EventArgs e)
        {
            pictureBoxStar1.Visible = false;
            StarFilled1.Visible = true;
            pictureBoxStar2.Visible = false;
            StarFilled2.Visible = true;
        }

        private void StarFilled2_MouseLeave(object sender, EventArgs e)
        {
            if (VoteState == false)
            {
                StarFilled1.Visible = false;
                pictureBoxStar1.Visible = true;
                StarFilled2.Visible = false;
                pictureBoxStar2.Visible = true;
            }
        }

        private void pictureBoxStar3_MouseHover(object sender, EventArgs e)
        {
            pictureBoxStar1.Visible = false;
            StarFilled1.Visible = true;
            pictureBoxStar2.Visible = false;
            StarFilled2.Visible = true;
            pictureBoxStar3.Visible = false;
            StarFilled3.Visible = true;
        }

        private void StarFilled3_MouseLeave(object sender, EventArgs e)
        {
            if (VoteState == false)
            {
                StarFilled1.Visible = false;
                pictureBoxStar1.Visible = true;
                StarFilled2.Visible = false;
                pictureBoxStar2.Visible = true;
                StarFilled3.Visible = false;
                pictureBoxStar3.Visible = true;
            }
        }

        private void pictureBoxStar4_MouseHover(object sender, EventArgs e)
        {
            pictureBoxStar1.Visible = false;
            StarFilled1.Visible = true;
            pictureBoxStar2.Visible = false;
            StarFilled2.Visible = true;
            pictureBoxStar3.Visible = false;
            StarFilled3.Visible = true;
            pictureBoxStar4.Visible = false;
            StarFilled4.Visible = true;
        }

        private void StarFilled4_MouseLeave(object sender, EventArgs e)
        {
            if (VoteState == false)
            {
                StarFilled1.Visible = false;
                pictureBoxStar1.Visible = true;
                StarFilled2.Visible = false;
                pictureBoxStar2.Visible = true;
                StarFilled3.Visible = false;
                pictureBoxStar3.Visible = true;
                StarFilled4.Visible = false;
                pictureBoxStar4.Visible = true;
            }
        }

        private void pictureBoxStar5_MouseHover(object sender, EventArgs e)
        {
            pictureBoxStar1.Visible = false;
            StarFilled1.Visible = true;
            pictureBoxStar2.Visible = false;
            StarFilled2.Visible = true;
            pictureBoxStar3.Visible = false;
            StarFilled3.Visible = true;
            pictureBoxStar4.Visible = false;
            StarFilled4.Visible = true;
            pictureBoxStar5.Visible = false;
            StarFilled5.Visible = true;
        }

        private void StarFilled5_MouseLeave(object sender, EventArgs e)
        {
            if (VoteState == false)
            {
                StarFilled1.Visible = false;
                pictureBoxStar1.Visible = true;
                StarFilled2.Visible = false;
                pictureBoxStar2.Visible = true;
                StarFilled3.Visible = false;
                pictureBoxStar3.Visible = true;
                StarFilled4.Visible = false;
                pictureBoxStar4.Visible = true;
                StarFilled5.Visible = false;
                pictureBoxStar5.Visible = true;
            }
        }

        private void pictureBoxStar6_MouseHover(object sender, EventArgs e)
        {
            pictureBoxStar1.Visible = false;
            StarFilled1.Visible = true;
            pictureBoxStar2.Visible = false;
            StarFilled2.Visible = true;
            pictureBoxStar3.Visible = false;
            StarFilled3.Visible = true;
            pictureBoxStar4.Visible = false;
            StarFilled4.Visible = true;
            pictureBoxStar5.Visible = false;
            StarFilled5.Visible = true;
            pictureBoxStar6.Visible = false;
            StarFilled6.Visible = true;
        }

        private void StarFilled6_MouseLeave(object sender, EventArgs e)
        {
            if (VoteState == false)
            {
                StarFilled1.Visible = false;
                pictureBoxStar1.Visible = true;
                StarFilled2.Visible = false;
                pictureBoxStar2.Visible = true;
                StarFilled3.Visible = false;
                pictureBoxStar3.Visible = true;
                StarFilled4.Visible = false;
                pictureBoxStar4.Visible = true;
                StarFilled5.Visible = false;
                pictureBoxStar5.Visible = true;
                StarFilled6.Visible = false;
                pictureBoxStar6.Visible = true;
            }
        }

        private void pictureBoxStar7_MouseHover(object sender, EventArgs e)
        {
            pictureBoxStar1.Visible = false;
            StarFilled1.Visible = true;
            pictureBoxStar2.Visible = false;
            StarFilled2.Visible = true;
            pictureBoxStar3.Visible = false;
            StarFilled3.Visible = true;
            pictureBoxStar4.Visible = false;
            StarFilled4.Visible = true;
            pictureBoxStar5.Visible = false;
            StarFilled5.Visible = true;
            pictureBoxStar6.Visible = false;
            StarFilled6.Visible = true;
            pictureBoxStar7.Visible = false;
            StarFilled7.Visible = true;
        }

        private void StarFilled7_MouseLeave(object sender, EventArgs e)
        {
            if (VoteState == false)
            {
                StarFilled1.Visible = false;
                pictureBoxStar1.Visible = true;
                StarFilled2.Visible = false;
                pictureBoxStar2.Visible = true;
                StarFilled3.Visible = false;
                pictureBoxStar3.Visible = true;
                StarFilled4.Visible = false;
                pictureBoxStar4.Visible = true;
                StarFilled5.Visible = false;
                pictureBoxStar5.Visible = true;
                StarFilled6.Visible = false;
                pictureBoxStar6.Visible = true;
                StarFilled7.Visible = false;
                pictureBoxStar7.Visible = true;
            }
        }

        private void pictureBoxStar8_MouseHover(object sender, EventArgs e)
        {
            pictureBoxStar1.Visible = false;
            StarFilled1.Visible = true;
            pictureBoxStar2.Visible = false;
            StarFilled2.Visible = true;
            pictureBoxStar3.Visible = false;
            StarFilled3.Visible = true;
            pictureBoxStar4.Visible = false;
            StarFilled4.Visible = true;
            pictureBoxStar5.Visible = false;
            StarFilled5.Visible = true;
            pictureBoxStar6.Visible = false;
            StarFilled6.Visible = true;
            pictureBoxStar7.Visible = false;
            StarFilled7.Visible = true;
            pictureBoxStar8.Visible = false;
            StarFilled8.Visible = true;
        }

        private void StarFilled8_MouseLeave(object sender, EventArgs e)
        {
            if (VoteState == false)
            {
                StarFilled1.Visible = false;
                pictureBoxStar1.Visible = true;
                StarFilled2.Visible = false;
                pictureBoxStar2.Visible = true;
                StarFilled3.Visible = false;
                pictureBoxStar3.Visible = true;
                StarFilled4.Visible = false;
                pictureBoxStar4.Visible = true;
                StarFilled5.Visible = false;
                pictureBoxStar5.Visible = true;
                StarFilled6.Visible = false;
                pictureBoxStar6.Visible = true;
                StarFilled7.Visible = false;
                pictureBoxStar7.Visible = true;
                StarFilled8.Visible = false;
                pictureBoxStar8.Visible = true;
            }
        }

        private void pictureBoxStar9_MouseHover(object sender, EventArgs e)
        {
            pictureBoxStar1.Visible = false;
            StarFilled1.Visible = true;
            pictureBoxStar2.Visible = false;
            StarFilled2.Visible = true;
            pictureBoxStar3.Visible = false;
            StarFilled3.Visible = true;
            pictureBoxStar4.Visible = false;
            StarFilled4.Visible = true;
            pictureBoxStar5.Visible = false;
            StarFilled5.Visible = true;
            pictureBoxStar6.Visible = false;
            StarFilled6.Visible = true;
            pictureBoxStar7.Visible = false;
            StarFilled7.Visible = true;
            pictureBoxStar8.Visible = false;
            StarFilled8.Visible = true;
            pictureBoxStar9.Visible = false;
            StarFilled9.Visible = true;
        }

        private void StarFilled9_MouseLeave(object sender, EventArgs e)
        {
            if (VoteState == false)
            {
                StarFilled1.Visible = false;
                pictureBoxStar1.Visible = true;
                StarFilled2.Visible = false;
                pictureBoxStar2.Visible = true;
                StarFilled3.Visible = false;
                pictureBoxStar3.Visible = true;
                StarFilled4.Visible = false;
                pictureBoxStar4.Visible = true;
                StarFilled5.Visible = false;
                pictureBoxStar5.Visible = true;
                StarFilled6.Visible = false;
                pictureBoxStar6.Visible = true;
                StarFilled7.Visible = false;
                pictureBoxStar7.Visible = true;
                StarFilled8.Visible = false;
                pictureBoxStar8.Visible = true;
                StarFilled9.Visible = false;
                pictureBoxStar9.Visible = true;
            }
        }

        private void pictureBoxStar10_MouseHover(object sender, EventArgs e)
        {
            pictureBoxStar1.Visible = false;
            StarFilled1.Visible = true;
            pictureBoxStar2.Visible = false;
            StarFilled2.Visible = true;
            pictureBoxStar3.Visible = false;
            StarFilled3.Visible = true;
            pictureBoxStar4.Visible = false;
            StarFilled4.Visible = true;
            pictureBoxStar5.Visible = false;
            StarFilled5.Visible = true;
            pictureBoxStar6.Visible = false;
            StarFilled6.Visible = true;
            pictureBoxStar7.Visible = false;
            StarFilled7.Visible = true;
            pictureBoxStar8.Visible = false;
            StarFilled8.Visible = true;
            pictureBoxStar9.Visible = false;
            StarFilled9.Visible = true;
            pictureBoxStar10.Visible = false;
            StarFilled10.Visible = true;
        }

        private void StarFilled10_MouseLeave(object sender, EventArgs e)
        {
            if (VoteState == false)
            {
                StarFilled1.Visible = false;
                pictureBoxStar1.Visible = true;
                StarFilled2.Visible = false;
                pictureBoxStar2.Visible = true;
                StarFilled3.Visible = false;
                pictureBoxStar3.Visible = true;
                StarFilled4.Visible = false;
                pictureBoxStar4.Visible = true;
                StarFilled5.Visible = false;
                pictureBoxStar5.Visible = true;
                StarFilled6.Visible = false;
                pictureBoxStar6.Visible = true;
                StarFilled7.Visible = false;
                pictureBoxStar7.Visible = true;
                StarFilled8.Visible = false;
                pictureBoxStar8.Visible = true;
                StarFilled9.Visible = false;
                pictureBoxStar9.Visible = true;
                StarFilled10.Visible = false;
                pictureBoxStar10.Visible = true;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (buttonVote.Visible == true)
            {
                MemberCurrentCell = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);
                VoteState = false;
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MemberFieldOption.Equals("Movie"))
            {
                MoviePage mp = new MoviePage(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), this, MemberUserName, "Movie");
                mp.Show();
                this.Hide();
            }
            else if(MemberFieldOption.Equals("News"))
            {
                string text = File.ReadAllText(paths[e.RowIndex]);
                NewsPage np = new NewsPage(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), text,MemberUserName);
                np.Show();
            }
             else if(MemberFieldOption.Equals("Actors"))
            {
                ActorsOrDirectorsPage aodp = new ActorsOrDirectorsPage(this,"Actor",dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(),dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                aodp.Show();
                this.Hide();
            }
            else if (MemberFieldOption.Equals("Directors"))
            {
                ActorsOrDirectorsPage aodp = new ActorsOrDirectorsPage(this, "Regizor", dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                aodp.Show();
                this.Hide();
            }
            else if (MemberFieldOption.Equals("TVSeries"))
            {
                MoviePage mp = new MoviePage(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), this,MemberUserName, "TVSeries");
                mp.Show();
                this.Hide();
            }
            else if(MemberFieldOption.Equals("Gender"))
            {
                BindByGender(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
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
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("adventure") || gender.Contains("Adventure") || gender.Contains("Aventura") || gender.Contains("aventura"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllAdventureMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("Animation") || gender.Contains("animation") || gender.Contains("Animatie") || gender.Contains("animatie"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllAnimationMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("biography") || gender.Contains("Biography") || gender.Contains("biografie") || gender.Contains("Biografie"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllBiographyMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("comedy") || gender.Contains("Comedy") || gender.Contains("comedie") || gender.Contains("Comedie"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllComedyMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("Crime") || gender.Contains("crime") || gender.Contains("Crima") || gender.Contains("crima"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllCrimeMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("documentary") || gender.Contains("Documentary") || gender.Contains("documentar") || gender.Contains("Documentar"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllDocumentaryMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("drama") || gender.Contains("Drama") || gender.Contains("drama") || gender.Contains("Drama"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllDramaMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("family") || gender.Contains("Family") || gender.Contains("familie") || gender.Contains("Familie"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllFamilyMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("fantasy") || gender.Contains("Fantasy") || gender.Contains("Fantasy") || gender.Contains("Fantasy"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllFantasyMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("filmnoir") || gender.Contains("FilmNoir") || gender.Contains("Filmnoir") || gender.Contains("Film-Noir"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllFilmNoirMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("History") || gender.Contains("history"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllHistoryMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("Horror") || gender.Contains("horror"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllHorrorMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("mistery") || gender.Contains("Mistery") || gender.Contains("mister") || gender.Contains("Mister"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllMisteryMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("Musical") || gender.Contains("musical"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllMusicalMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("music") || gender.Contains("Music"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllMusicMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("Romance") || gender.Contains("romance"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllRomanceMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("SF"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllSFMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("sport") || gender.Contains("Sport"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllSportMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("thriller") || gender.Contains("Thriller"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllThrillerMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("war") || gender.Contains("War"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllWarMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
            else if (gender.Contains("western") || gender.Contains("Western"))
            {
                using (var context = new IMDBEntities())
                {
                    var results = context.AllWesternMovies;
                    dataGridView.DataSource = results.ToList();
                }
            }
        }

        private void MedieFILM(int idfilm)
        {
            double medie;
            using (var context = new IMDBEntities())
            {
                var res = from a in context.YourRatings
                          where a.ID_Film == idfilm
                          select a;
                int count = res.Count();
                var res2 = (from b in context.Filmes
                            where b.ID_Film == idfilm
                            select b).First();
                double nota_finala = Convert.ToDouble(res2.Nota);
            

                foreach (var item in res)
                {
                    nota_finala += Convert.ToDouble( item.Nota);
                }
                medie = nota_finala / (count + 1);

                res2.Nota_finala = Math.Round(medie,2);

                context.SaveChanges();
                MessageBox.Show("Media a fost actualizata!");
            }

        }

        private void StarFilled1_Click(object sender, EventArgs e)
        {
            using (var context = new IMDBEntities())
            {
                if (MemberMovieOrTVSeries.Equals("Movie"))
                {
                    var verify = (from a in context.YourRatings
                                  where a.ID_User == MemberUserID && a.ID_Film == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 1;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");
                        MedieFILM(MemberCurrentCell);
                    }
                    else
                    {
                        var RatingRow = new YourRating()
                        {
                            ID_User = MemberUserID,
                            ID_Film = MemberCurrentCell,
                            Nota = 1
                        };

                        context.YourRatings.Add(RatingRow);
                    }
                    context.SaveChanges();
                    MedieFILM(MemberCurrentCell);
                }
                else
                {
                    var verify = (from a in context.YourRatingsSerials
                                  where a.ID_User == MemberUserID && a.ID_Serial == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 1;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");

                    }
                    else
                    {
                        var RatingRow = new YourRatingsSerial()
                        {
                            ID_User = MemberUserID,
                            ID_Serial = MemberCurrentCell,
                            Nota = 1
                        };

                        context.YourRatingsSerials.Add(RatingRow);
                        context.SaveChanges();
                    }
                }

                MessageBox.Show("Nota adaugata cu succes!");
                VoteState = true;
            }
        }

        private void StarFilled2_Click(object sender, EventArgs e)
        {
            using (var context = new IMDBEntities())
            {
                if (MemberMovieOrTVSeries.Equals("Movie"))
                {
                    var verify = (from a in context.YourRatings
                                  where a.ID_User == MemberUserID && a.ID_Film == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 2;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");
                        MedieFILM(MemberCurrentCell);
                    }
                    else
                    {
                        var RatingRow = new YourRating()
                        {
                            ID_User = MemberUserID,
                            ID_Film = MemberCurrentCell,
                            Nota = 2
                        };

                        context.YourRatings.Add(RatingRow);
                    }
                    context.SaveChanges();
                    MedieFILM(MemberCurrentCell);
                }
                else
                {
                    var verify = (from a in context.YourRatingsSerials
                                  where a.ID_User == MemberUserID && a.ID_Serial == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 2;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");

                    }
                    else
                    {
                        var RatingRow = new YourRatingsSerial()
                        {
                            ID_User = MemberUserID,
                            ID_Serial = MemberCurrentCell,
                            Nota = 2
                        };

                        context.YourRatingsSerials.Add(RatingRow);
                        context.SaveChanges();
                    }
                }

                MessageBox.Show("Nota adaugata cu succes!");
                VoteState = true;
            }
        }

        private void StarFilled3_Click(object sender, EventArgs e)
        {
            using (var context = new IMDBEntities())
            {
                if (MemberMovieOrTVSeries.Equals("Movie"))
                {
                    var verify = (from a in context.YourRatings
                                  where a.ID_User == MemberUserID && a.ID_Film == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 3;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");
                        MedieFILM(MemberCurrentCell);
                    }
                    else
                    {
                        var RatingRow = new YourRating()
                        {
                            ID_User = MemberUserID,
                            ID_Film = MemberCurrentCell,
                            Nota = 3
                        };

                        context.YourRatings.Add(RatingRow);
                    }
                    context.SaveChanges();
                    MedieFILM(MemberCurrentCell);
                }
                else
                {
                    var verify = (from a in context.YourRatingsSerials
                                  where a.ID_User == MemberUserID && a.ID_Serial == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 3;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");

                    }
                    else
                    {
                        var RatingRow = new YourRatingsSerial()
                        {
                            ID_User = MemberUserID,
                            ID_Serial = MemberCurrentCell,
                            Nota = 3
                        };

                        context.YourRatingsSerials.Add(RatingRow);
                        context.SaveChanges();
                    }
                }

                MessageBox.Show("Nota adaugata cu succes!");
                VoteState = true;
            }
        }

        private void StarFilled4_Click(object sender, EventArgs e)
        {
            using (var context = new IMDBEntities())
            {
                if (MemberMovieOrTVSeries.Equals("Movie"))
                {
                    var verify = (from a in context.YourRatings
                                  where a.ID_User == MemberUserID && a.ID_Film == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 4;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");
                        MedieFILM(MemberCurrentCell);
                    }
                    else
                    {
                        var RatingRow = new YourRating()
                        {
                            ID_User = MemberUserID,
                            ID_Film = MemberCurrentCell,
                            Nota = 4
                        };

                        context.YourRatings.Add(RatingRow);
                    }
                    context.SaveChanges();
                    MedieFILM(MemberCurrentCell);
                }
                else
                {
                    var verify = (from a in context.YourRatingsSerials
                                  where a.ID_User == MemberUserID && a.ID_Serial == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 4;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");

                    }
                    else
                    {
                        var RatingRow = new YourRatingsSerial()
                        {
                            ID_User = MemberUserID,
                            ID_Serial = MemberCurrentCell,
                            Nota = 4
                        };

                        context.YourRatingsSerials.Add(RatingRow);
                        context.SaveChanges();
                    }
                }

                MessageBox.Show("Nota adaugata cu succes!");
                VoteState = true;
            }
        }

        private void StarFilled5_Click(object sender, EventArgs e)
        {
            using (var context = new IMDBEntities())
            {
                if (MemberMovieOrTVSeries.Equals("Movie"))
                {
                    var verify = (from a in context.YourRatings
                                  where a.ID_User == MemberUserID && a.ID_Film == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 5;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");
                        MedieFILM(MemberCurrentCell);
                    }
                    else
                    {
                        var RatingRow = new YourRating()
                        {
                            ID_User = MemberUserID,
                            ID_Film = MemberCurrentCell,
                            Nota = 5
                        };

                        context.YourRatings.Add(RatingRow);
                    }
                    context.SaveChanges();
                    MedieFILM(MemberCurrentCell);
                }
                else
                {
                    var verify = (from a in context.YourRatingsSerials
                                  where a.ID_User == MemberUserID && a.ID_Serial == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 5;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");

                    }
                    else
                    {
                        var RatingRow = new YourRatingsSerial()
                        {
                            ID_User = MemberUserID,
                            ID_Serial = MemberCurrentCell,
                            Nota = 5
                        };

                        context.YourRatingsSerials.Add(RatingRow);
                        context.SaveChanges();
                    }
                }

                MessageBox.Show("Nota adaugata cu succes!");
                VoteState = true;
            }
        }

        private void StarFilled7_Click(object sender, EventArgs e)
        {
            using (var context = new IMDBEntities())
            {
                if (MemberMovieOrTVSeries.Equals("Movie"))
                {
                    var verify = (from a in context.YourRatings
                                  where a.ID_User == MemberUserID && a.ID_Film == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 7;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");
                        MedieFILM(MemberCurrentCell);
                    }
                    else
                    {
                        var RatingRow = new YourRating()
                        {
                            ID_User = MemberUserID,
                            ID_Film = MemberCurrentCell,
                            Nota = 7
                        };

                        context.YourRatings.Add(RatingRow);
                    }
                    context.SaveChanges();
                    MedieFILM(MemberCurrentCell);
                }
                else
                {
                    var verify = (from a in context.YourRatingsSerials
                                  where a.ID_User == MemberUserID && a.ID_Serial == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 7;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");
                    
                    }
                    else
                    {
                        var RatingRow = new YourRatingsSerial()
                        {
                            ID_User = MemberUserID,
                            ID_Serial = MemberCurrentCell,
                            Nota = 7
                        };

                        context.YourRatingsSerials.Add(RatingRow);
                        context.SaveChanges();
                    }
                }
                
                MessageBox.Show("Nota adaugata cu succes!");
                VoteState = true;
            }
        }

        private void StarFilled6_Click(object sender, EventArgs e)
        {
            using (var context = new IMDBEntities())
            {
                if (MemberMovieOrTVSeries.Equals("Movie"))
                {
                    var verify = (from a in context.YourRatings
                                  where a.ID_User == MemberUserID && a.ID_Film == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 6;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");
                        MedieFILM(MemberCurrentCell);
                    }
                    else
                    {
                        var RatingRow = new YourRating()
                        {
                            ID_User = MemberUserID,
                            ID_Film = MemberCurrentCell,
                            Nota = 6
                        };

                        context.YourRatings.Add(RatingRow);
                    }
                    context.SaveChanges();
                    MedieFILM(MemberCurrentCell);
                }
                else
                {
                    var verify = (from a in context.YourRatingsSerials
                                  where a.ID_User == MemberUserID && a.ID_Serial == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 6;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");

                    }
                    else
                    {
                        var RatingRow = new YourRatingsSerial()
                        {
                            ID_User = MemberUserID,
                            ID_Serial = MemberCurrentCell,
                            Nota = 6
                        };

                        context.YourRatingsSerials.Add(RatingRow);
                        context.SaveChanges();
                    }
                }

                MessageBox.Show("Nota adaugata cu succes!");
                VoteState = true;
            }
        }

        private void StarFilled8_Click(object sender, EventArgs e)
        {
            using (var context = new IMDBEntities())
            {
                if (MemberMovieOrTVSeries.Equals("Movie"))
                {
                    var verify = (from a in context.YourRatings
                                  where a.ID_User == MemberUserID && a.ID_Film == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 8;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");
                        MedieFILM(MemberCurrentCell);
                    }
                    else
                    {
                        var RatingRow = new YourRating()
                        {
                            ID_User = MemberUserID,
                            ID_Film = MemberCurrentCell,
                            Nota = 8
                        };

                        context.YourRatings.Add(RatingRow);
                    }
                    context.SaveChanges();
                    MedieFILM(MemberCurrentCell);
                }
                else
                {
                    var verify = (from a in context.YourRatingsSerials
                                  where a.ID_User == MemberUserID && a.ID_Serial == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 8;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");

                    }
                    else
                    {
                        var RatingRow = new YourRatingsSerial()
                        {
                            ID_User = MemberUserID,
                            ID_Serial = MemberCurrentCell,
                            Nota = 8
                        };

                        context.YourRatingsSerials.Add(RatingRow);
                        context.SaveChanges();
                    }
                }

                MessageBox.Show("Nota adaugata cu succes!");
                VoteState = true;
            }
        }

        private void StarFilled9_Click(object sender, EventArgs e)
        {
            using (var context = new IMDBEntities())
            {
                if (MemberMovieOrTVSeries.Equals("Movie"))
                {
                    var verify = (from a in context.YourRatings
                                  where a.ID_User == MemberUserID && a.ID_Film == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 9;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");
                        MedieFILM(MemberCurrentCell);
                    }
                    else
                    {
                        var RatingRow = new YourRating()
                        {
                            ID_User = MemberUserID,
                            ID_Film = MemberCurrentCell,
                            Nota = 9
                        };

                        context.YourRatings.Add(RatingRow);
                    }
                    context.SaveChanges();
                    MedieFILM(MemberCurrentCell);
                }
                else
                {
                    var verify = (from a in context.YourRatingsSerials
                                  where a.ID_User == MemberUserID && a.ID_Serial == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 9;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");

                    }
                    else
                    {
                        var RatingRow = new YourRatingsSerial()
                        {
                            ID_User = MemberUserID,
                            ID_Serial = MemberCurrentCell,
                            Nota = 9
                        };

                        context.YourRatingsSerials.Add(RatingRow);
                        context.SaveChanges();
                    }
                }

                MessageBox.Show("Nota adaugata cu succes!");
                VoteState = true;
            }
        }

        private void StarFilled10_Click(object sender, EventArgs e)
        {
            using (var context = new IMDBEntities())
            {
                if (MemberMovieOrTVSeries.Equals("Movie"))
                {
                    var verify = (from a in context.YourRatings
                                  where a.ID_User == MemberUserID && a.ID_Film == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 10;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");
                        MedieFILM(MemberCurrentCell);
                    }
                    else
                    {
                        var RatingRow = new YourRating()
                        {
                            ID_User = MemberUserID,
                            ID_Film = MemberCurrentCell,
                            Nota = 10
                        };

                        context.YourRatings.Add(RatingRow);
                    }
                    context.SaveChanges();
                    MedieFILM(MemberCurrentCell);
                }
                else
                {
                    var verify = (from a in context.YourRatingsSerials
                                  where a.ID_User == MemberUserID && a.ID_Serial == MemberCurrentCell
                                  select a).FirstOrDefault();
                    if (verify != null)
                    {
                        verify.Nota = 10;
                        context.SaveChanges();
                        MessageBox.Show("Nota Updatata cu succes!");

                    }
                    else
                    {
                        var RatingRow = new YourRatingsSerial()
                        {
                            ID_User = MemberUserID,
                            ID_Serial = MemberCurrentCell,
                            Nota = 10
                        };

                        context.YourRatingsSerials.Add(RatingRow);
                        context.SaveChanges();
                    }
                }

                MessageBox.Show("Nota adaugata cu succes!");
                VoteState = true;
            }
        }

        private void bornTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindByBornToday();
        }

        private void topRatedMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonVote.Visible = true;
            MemberMovieOrTVSeries = "Movie";
            BindByTopRatedMovies(101);
        }

        private void mostRatedMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonVote.Visible = true;
            MemberMovieOrTVSeries = "Movie";
            BindByMostPopularMovies(101);
        }

        private void topRatedTVSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonVote.Visible = true;
            MemberMovieOrTVSeries = "TvSeries";
            BindByTopTVSeries();
        }

        private void mostPopularTVSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonVote.Visible = true;
            MemberMovieOrTVSeries = "TvSeries";
            BindByMostPopularTVSeries();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void celebrityNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindByCelebrityNews();
        }

        private void mostPopularCelebsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindByMostPopularCelebs();
        }

        private void newsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BindByNews();
        }

        private void buttonYourRatings_Click(object sender, EventArgs e)
        {
            AdminOrUser aou = new AdminOrUser(MemberUserName, this, MemberUserID, "Rating");
            aou.Show();
            this.Hide();
        }

        private void buttonYourWatchlist_Click(object sender, EventArgs e)
        {
            AdminOrUser aou = new AdminOrUser(MemberUserName, this, MemberUserID, "Watchlist");
            aou.Show();
            this.Hide();
        }

        private void watchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminOrUser aou = new AdminOrUser(MemberUserName, this, MemberUserID, "Watchlist");
            aou.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            if(comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Trebuie sa selectezi in ce anume vrei sa exporti!");
            }
            if (comboBox1.Text.Equals("PDF"))
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));

                doc.Open();//Open Document to write


                Paragraph paragraph = new Paragraph("data Exported From DataGridview!");

                //Create table by setting table value

                Table t1 = new Table(2);
                //DataTable dt = new DataTable();
                //dt = (DataTable)dataGridView.DataSource;


                //Create Table Header

                iTextSharp.text.Cell cid = new iTextSharp.text.Cell("ID");
                iTextSharp.text.Cell cname = new iTextSharp.text.Cell("Name");

                t1.AddCell(cid);
                t1.AddCell(cname);

                foreach (DataGridViewRow rows in dataGridView.Rows)
                {

                    string id = dataGridView.Rows[rows.Index].Cells[0].Value.ToString();
                    string name = dataGridView.Rows[rows.Index].Cells[1].Value.ToString();
                    //Create Cells
                    iTextSharp.text.Cell c2 = new iTextSharp.text.Cell(id);
                    iTextSharp.text.Cell c1 = new iTextSharp.text.Cell(name);
                    //Adding cells
                    t1.AddCell(c1);
                    t1.AddCell(c2);

                }
                doc.Add(paragraph);
                doc.Add(t1);
                doc.Close(); //Close document
                             //
                MessageBox.Show("PDF Created!");
            }
            ///////////////////
            else if (comboBox1.Text.Equals("Excel"))
            {
                DataSet ds = new DataSet("New_DataSet");
                ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                // sda.Fill(dbdataset);
                ds.Tables.Add(dt);
                ExcelLibrary.DataSetHelper.CreateWorkbook("MyExcelFile.xls", ds);
                MessageBox.Show("Excel  Created!");
            }
            //////////////////
            else if (comboBox1.Text.Equals("CSV"))
            {
                ToCsV(dataGridView, "CSV");
                MessageBox.Show("CSV Created!");
            }
        }  //EXPORT

        private void ToCsV(DataGridView dGV, string filename)
        {
            StringBuilder stOutput = new StringBuilder();
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
            stOutput.Append(sHeaders + "\r\n");
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                //string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                {
                    if (dGV[j, i] is DataGridViewImageCell)
                    {
                        stOutput.AppendFormat("\"{0}\"", Convert.ToString(dGV.Rows[i].Cells[j].Tag));
                    }
                    else
                    {
                        stOutput.AppendFormat("\"{0}\"", Convert.ToString(dGV.Rows[i].Cells[j].Value));
                    }
                    stOutput.Append(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator);

                }
                stOutput.Append("\r\n");
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput.ToString());
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
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

                dataGridView.DataSource = results.ToList();
            }

        }

        private void allActorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindbyAllActors();
        }
    }
}
