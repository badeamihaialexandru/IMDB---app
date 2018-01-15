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
        private string MemberUserName;
        private string MemberMovieName;
        private string MemberMovieOrTvSeries;
        private string[] DirectorLastNames=new string[2];
        private string[] DirectorFirstNames = new string[2];
        private string[] ActorLastNames=new string[5];
        private string[] ActorFirstNames=new string[5];
        private string[] ActorsinFilm = new string[5];

        public MoviePage(string str1,Form Parent,string movieortvseries)
        {
            InitializeComponent();
            MemberUserName = "";
            MemberMovieName = str1;
            MemberMovieOrTvSeries = movieortvseries;
            if (MemberMovieOrTvSeries.Equals("Movie") || MemberMovieOrTvSeries.Equals("Movies"))
            {
                Movie(str1);
            }
            else TVSeriesPage(str1);
            ParentForm = Parent;
           
        }

        public MoviePage(string str1, Form Parent,string UserName, string movieortvseries)
        {
            InitializeComponent();
            MemberUserName = UserName;
            MemberMovieName = str1;
            MemberMovieOrTvSeries = movieortvseries;
            if (MemberMovieOrTvSeries.Equals("Movie"))
            {
                Movie(str1);
            }
            else TVSeriesPage(str1);
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

        private void TVSeriesPage(string str1)
        {
            label2.Visible = false;
            label4.Visible = false;
            labelNameofDirector.Visible = false;
            labelNameofDirector2.Visible = false;
            labelWins.Visible = false;
            labelNumarEpisoade.Visible = true;
            labelNumarSezoane.Visible = true;
            labelBagaNumarEpisoade.Visible = true;
            labelBagaNumarSezoane.Visible = true;
            using (var context = new IMDBEntities())
            {
                var serial = (from a in context.Seriales
                              where a.Nume.Equals(str1)
                              select a).First();
                var serial2 = from p in context.Relatie_Actor_Serial
                              where p.Seriale.Nume.Equals(str1)
                              select p;
                var serial3 = from p in context.Relatie_Actor_Serial
                              where p.Seriale.Nume.Equals(str1)
                              select new { p.Actori.Nume, p.Actori.Prenume};
                labelBagaNumarSezoane.Text = serial.Numar_sezoane.ToString();
                labelBagaNumarEpisoade.Text = serial.Total_episoade.ToString();
                try
                {
                    pictureBoxPhoto.Image = ConvertByteToImage(serial.Photo);
                }
                catch
                {
                    MessageBox.Show("Can't load this movie's photo!", "ErrorPhoto");
                    pictureBoxPhoto.ImageLocation = @"C:\Users\Mosu\Desktop\proiect_utile\imdb_pictures\unknown.jpg";
                }
                labelNameandYear.Text = serial.Nume + " " + " ( " + serial.An_aparitie.ToString() + ")";
                labelGender.Text = "";
                int count = serial.Genuris.Count;
                foreach (var a in serial.Genuris)
                {
                    if (count != 1)
                    {
                        labelGender.Text += a.Nume_Gen.ToString() + ",";
                        count--;
                    }
                    else labelGender.Text += a.Nume_Gen.ToString();
                }
                count = serial2.ToList().Count;
                var aif = serial2.ToList();
                if (count == 0)
                {
                    labelActorsinFilm1.Visible = false;
                    labelActorsinFilm2.Visible = false;
                    labelActorsinFilm3.Visible = false;
                    labelActorsinFilm4.Visible = false;
                }
                else if (count == 1)
                {
                    labelActorsinFilm1.Visible = true;
                    labelActorsinFilm1.Text = "as " + aif[0].Nume_in_Serial;
                    labelActorsinFilm2.Visible = false;
                    labelActorsinFilm3.Visible = false;
                    labelActorsinFilm4.Visible = false;
                }
                else if (count == 2)
                {
                    labelActorsinFilm1.Visible = true;
                    labelActorsinFilm1.Text = "as " + aif[0].Nume_in_Serial;
                    labelActorsinFilm2.Visible = true;
                    labelActorsinFilm2.Text = "as " + aif[1].Nume_in_Serial;
                    labelActorsinFilm3.Visible = false;
                    labelActorsinFilm4.Visible = false;
                }
                else if (count == 3)
                {
                    labelActorsinFilm1.Visible = true;
                    labelActorsinFilm1.Text = "as " + aif[0].Nume_in_Serial;
                    labelActorsinFilm2.Visible = true;
                    labelActorsinFilm2.Text = "as " + aif[1].Nume_in_Serial;
                    labelActorsinFilm3.Visible = true;
                    labelActorsinFilm3.Text = "as " + aif[2].Nume_in_Serial;
                    labelActorsinFilm4.Visible = false;
                }
                else if (count == 4)
                {
                    labelActorsinFilm1.Visible = true;
                    labelActorsinFilm1.Text = "as " + aif[0].Nume_in_Serial;
                    labelActorsinFilm2.Visible = true;
                    labelActorsinFilm2.Text = "as " + aif[1].Nume_in_Serial;
                    labelActorsinFilm3.Visible = true;
                    labelActorsinFilm3.Text = "as " + aif[2].Nume_in_Serial;
                    labelActorsinFilm4.Visible = true;
                    labelActorsinFilm4.Text = "as " + aif[3].Nume_in_Serial;
                }
                labelRating.Text = serial.Nota.ToString();
                count = serial3.ToList().Count;
                var nif = serial3.ToList();
                if (count == 0)
                {
                    labelActor2.Visible = false;
                    labelActor3.Visible = false;
                    labelActor4.Visible = false;
                    labelActor1.Visible = false;
                }
                else if (count == 1)
                {
                    labelActor2.Visible = false;
                    labelActor3.Visible = false;
                    labelActor4.Visible = false;
                    labelActor1.Visible = true;
                    labelActor1.Text = nif[0].Prenume + " " + nif[0].Nume;
                    ActorFirstNames[0] = nif[0].Prenume;
                    ActorLastNames[0] = nif[0].Nume;
                }
                else if (count == 2)
                {
                    labelActor2.Visible = true;
                    labelActor3.Visible = false;
                    labelActor4.Visible = false;
                    labelActor1.Visible = true;
                    labelActor1.Text = nif[0].Prenume + " " + nif[0].Nume;
                    ActorFirstNames[0] = nif[0].Prenume;
                    ActorLastNames[0] = nif[0].Nume;
                    labelActor2.Text = nif[1].Prenume + " " + nif[1].Nume;
                    ActorFirstNames[1] = nif[1].Prenume;
                    ActorLastNames[1] = nif[1].Nume;
                }
                else if (count == 3)
                {
                    labelActor2.Visible = true;
                    labelActor3.Visible = true;
                    labelActor4.Visible = false;
                    labelActor1.Visible = true;
                    labelActor1.Text = nif[0].Prenume + " " + nif[0].Nume;
                    ActorFirstNames[0] = nif[0].Prenume;
                    ActorLastNames[0] = nif[0].Nume;
                    labelActor2.Text = nif[1].Prenume + " " + nif[1].Nume;
                    ActorFirstNames[1] = nif[1].Prenume;
                    ActorLastNames[1] = nif[1].Nume;
                    labelActor3.Text = nif[2].Prenume + " " + nif[2].Nume;
                    ActorFirstNames[2] = nif[2].Prenume;
                    ActorLastNames[2] = nif[2].Nume;
                }
                else if (count == 4)
                {
                    labelActor2.Visible = true;
                    labelActor3.Visible = true;
                    labelActor4.Visible = true;
                    labelActor1.Visible = true;
                    labelActor1.Text = nif[0].Prenume + " " + nif[0].Nume;
                    ActorFirstNames[0] = nif[0].Prenume;
                    ActorLastNames[0] = nif[0].Nume;
                    labelActor2.Text = nif[1].Prenume + " " + nif[1].Nume;
                    ActorFirstNames[1] = nif[1].Prenume;
                    ActorLastNames[1] = nif[1].Nume;
                    labelActor3.Text = nif[2].Prenume + " " + nif[2].Nume;
                    ActorFirstNames[2] = nif[2].Prenume;
                    ActorLastNames[2] = nif[2].Nume;
                    labelActor4.Text = nif[3].Prenume + " " + nif[3].Nume;
                    ActorFirstNames[3] = nif[3].Prenume;
                    ActorLastNames[3] = nif[3].Nume;
                }
                if (!MemberUserName.Equals(""))
                {
                    labelYourRating.Visible = true;
                    labeNoteYourRating.Visible = true;
                    watchlistToolStripMenuItem.Visible = true;
                    NameOfUser.Visible = true;
                    NameOfUser.Text = MemberUserName;


                    var resultuser = (from m in context.Users
                                      where m.Username.Equals(MemberUserName)
                                      select m).First();

                    var verifynote = (from a in context.YourRatingsSerials
                                      where a.Seriale.ID_Serial == serial.ID_Serial && a.ID_User == resultuser.ID_User
                                      select a).FirstOrDefault();
                    if (verifynote == null)
                    {
                        labelYourRating.Text = "Vote!";
                        labeNoteYourRating.Visible = false;

                        //aici baga stele
                    }
                    else
                    {
                        labelYourRating.Text = "Your rating";
                        labeNoteYourRating.Text = verifynote.Nota.ToString();
                    }
                    //vezi daca e in watchlist
                    var verifyviewed = (from b in context.WatchlistSeriales
                                        where b.Seriale.ID_Serial == serial.ID_Serial && b.ID_User == resultuser.ID_User
                                        select b).FirstOrDefault();
                    if (verifyviewed == null)
                    {
                        pictureBoxWatchlistFilled.Visible = true;
                    }
                    else pictureBoxWatchlistEmpty.Visible = true;
                }
            }
        }

        private void Movie(string str1)
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
                var result4 = from p in imen.Relatie_actor_film
                               where p.Filme.Nume.Equals(str1)
                               select new { p.Actori.Nume, p.Actori.Prenume }
                               ;
                try
                {
                    pictureBoxPhoto.Image = ConvertByteToImage(result.Photo);
                }
                catch
                {
                    MessageBox.Show("Can't load this movie's photo!", "ErrorPhoto");
                   // pictureBoxPhoto.ImageLocation=
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
               
                var result5=context.Filmes.Where(c=>c.Nume.Equals(str1)).SelectMany(c=>c.Regizoris);
                count = result5.ToList().Count;
                var mn = result5.ToList();
              
                if (count==1)
                {
                    labelNameofDirector.Text = mn[0].Nume + " "+ mn[0].Prenume;
                    DirectorLastNames[0] = mn[0].Nume;
                    DirectorFirstNames[0] = mn[0].Prenume;
                    labelNameofDirector2.Visible = false;
                }
                else if(count==2)
                {
                    labelNameofDirector.Text = mn[0].Nume + " " + mn[0].Prenume + " , ";
                    DirectorLastNames[0] = mn[0].Nume;
                    DirectorFirstNames[0] = mn[0].Prenume;
                    labelNameofDirector2.Text = mn[1].Nume + " " + mn[1].Prenume;
                    DirectorLastNames[1] = mn[1].Nume;
                    DirectorFirstNames[1] = mn[1].Prenume;
                }
                labelActorsinFilm1.Text = "";
                //foreach (var d in result3)
                //{
                //    labelActorsinFilm1.Text += /*d.Actori.Prenume.ToString() + " " + d.Actori.Nume.ToString() +*/ "\t as  " + d.Nume_in_film.ToString() + "\n";
                //}
                count = result3.ToList().Count;
                var aif = result3.ToList();
                if(count==0)
                {
                    labelActorsinFilm1.Visible = false;
                    labelActorsinFilm2.Visible = false;
                    labelActorsinFilm3.Visible = false;
                    labelActorsinFilm4.Visible = false;
                }
                else if(count ==1)
                {
                    labelActorsinFilm1.Visible = true;
                    labelActorsinFilm1.Text = "as " + aif[0].Nume_in_film;
                    labelActorsinFilm2.Visible = false;
                    labelActorsinFilm3.Visible = false;
                    labelActorsinFilm4.Visible = false;
                }
                else if (count == 2)
                {
                    labelActorsinFilm1.Visible = true;
                    labelActorsinFilm1.Text = "as " + aif[0].Nume_in_film;
                    labelActorsinFilm2.Visible = true;
                    labelActorsinFilm2.Text = "as " + aif[1].Nume_in_film;
                    labelActorsinFilm3.Visible = false;
                    labelActorsinFilm4.Visible = false;
                }
                else if (count == 3)
                {
                    labelActorsinFilm1.Visible = true;
                    labelActorsinFilm1.Text = "as " +  aif[0].Nume_in_film;
                    labelActorsinFilm2.Visible = true;
                    labelActorsinFilm2.Text = "as " + aif[1].Nume_in_film;
                    labelActorsinFilm3.Visible = true;
                    labelActorsinFilm3.Text = "as " + aif[2].Nume_in_film;
                    labelActorsinFilm4.Visible = false;
                }
                else if (count == 4)
                {
                    labelActorsinFilm1.Visible = true;
                    labelActorsinFilm1.Text = "as " + aif[0].Nume_in_film;
                    labelActorsinFilm2.Visible = true;
                    labelActorsinFilm2.Text = "as " +aif[1].Nume_in_film;
                    labelActorsinFilm3.Visible = true;
                    labelActorsinFilm3.Text = "as " +aif[2].Nume_in_film;
                    labelActorsinFilm4.Visible = true;
                    labelActorsinFilm4.Text = "as " +aif[3].Nume_in_film;
                }
                else if (count == 5)
                {
                    labelActorsinFilm1.Visible = true;
                    labelActorsinFilm1.Text = "as " + aif[0].Nume_in_film;
                    labelActorsinFilm2.Visible = true;
                    labelActorsinFilm2.Text = "as " + aif[1].Nume_in_film;
                    labelActorsinFilm3.Visible = true;
                    labelActorsinFilm3.Text = "as " + aif[2].Nume_in_film;
                    labelActorsinFilm4.Visible = true;
                    labelActorsinFilm4.Text = "as " + aif[3].Nume_in_film;
                    labelActorsinFilm5.Visible = true;
                    labelActorsinFilm5.Text = "as " + aif[4].Nume_in_film;
                }
                labelRating.Text = result.Nota_finala.ToString();
               // var result6 = context.Relatie_actor_film.Where(c => c.Filme.Nume.Equals(str1)).SelectMany(c => c.Actori.Nume);
                count = result4.ToList().Count;
                var nif = result4.ToList();
                if(count==0)
                {
                    labelActor2.Visible = false;
                    labelActor3.Visible = false;
                    labelActor4.Visible = false;
                    labelActor1.Visible = false;
                }
                else if (count==1)
                {
                    labelActor2.Visible = false;
                    labelActor3.Visible = false;
                    labelActor4.Visible = false;
                    labelActor1.Visible = true;
                    labelActor1.Text = nif[0].Prenume + " " + nif[0].Nume;
                    ActorFirstNames[0] = nif[0].Prenume;
                    ActorLastNames[0] = nif[0].Nume;
                }
                else if (count == 2)
                {
                    labelActor2.Visible = true;
                    labelActor3.Visible = false;
                    labelActor4.Visible = false;
                    labelActor1.Visible = true;
                    labelActor1.Text = nif[0].Prenume + " " + nif[0].Nume;
                    ActorFirstNames[0] = nif[0].Prenume;
                    ActorLastNames[0] = nif[0].Nume;
                    labelActor2.Text = nif[1].Prenume + " " + nif[1].Nume;
                    ActorFirstNames[1] = nif[1].Prenume;
                    ActorLastNames[1] = nif[1].Nume;
                }
                else if (count == 3)
                {
                    labelActor2.Visible = true;
                    labelActor3.Visible = true;
                    labelActor4.Visible = false;
                    labelActor1.Visible = true;
                    labelActor1.Text = nif[0].Prenume + " " + nif[0].Nume;
                    ActorFirstNames[0] = nif[0].Prenume;
                    ActorLastNames[0] = nif[0].Nume;
                    labelActor2.Text = nif[1].Prenume + " " + nif[1].Nume;
                    ActorFirstNames[1] = nif[1].Prenume;
                    ActorLastNames[1] = nif[1].Nume;
                    labelActor3.Text = nif[2].Prenume + " " + nif[2].Nume;
                    ActorFirstNames[2] = nif[2].Prenume;
                    ActorLastNames[2] = nif[2].Nume;
                }
                else if (count == 4)
                {
                    labelActor2.Visible = true;
                    labelActor3.Visible = true;
                    labelActor4.Visible = true;
                    labelActor1.Visible = true;
                    labelActor1.Text = nif[0].Prenume + " " + nif[0].Nume;
                    ActorFirstNames[0] = nif[0].Prenume;
                    ActorLastNames[0] = nif[0].Nume;
                    labelActor2.Text = nif[1].Prenume + " " + nif[1].Nume;
                    ActorFirstNames[1] = nif[1].Prenume;
                    ActorLastNames[1] = nif[1].Nume;
                    labelActor3.Text = nif[2].Prenume + " " + nif[2].Nume;
                    ActorFirstNames[2] = nif[2].Prenume;
                    ActorLastNames[2] = nif[2].Nume;
                    labelActor4.Text = nif[3].Prenume + " " + nif[3].Nume;
                    ActorFirstNames[3] = nif[3].Prenume;
                    ActorLastNames[3] = nif[3].Nume;
                }
                else if (count == 5 || count>=5)
                {
                    labelActor2.Visible = true;
                    labelActor3.Visible = true;
                    labelActor4.Visible = true;
                    labelActor1.Visible = true;
                    labelActor5.Visible = true;
                    labelActor1.Text = nif[0].Prenume + " " + nif[0].Nume;
                    ActorFirstNames[0] = nif[0].Prenume;
                    ActorLastNames[0] = nif[0].Nume;
                    labelActor2.Text = nif[1].Prenume + " " + nif[1].Nume;
                    ActorFirstNames[1] = nif[1].Prenume;
                    ActorLastNames[1] = nif[1].Nume;
                    labelActor3.Text = nif[2].Prenume + " " + nif[2].Nume;
                    ActorFirstNames[2] = nif[2].Prenume;
                    ActorLastNames[2] = nif[2].Nume;
                    labelActor4.Text = nif[3].Prenume + " " + nif[3].Nume;
                    ActorFirstNames[3] = nif[3].Prenume;
                    ActorLastNames[3] = nif[3].Nume;
                    labelActor5.Text = nif[4].Prenume + " " + nif[4].Nume;
                    ActorFirstNames[4] = nif[4].Prenume;
                    ActorLastNames[4] = nif[4].Nume;
                }

                if(!MemberUserName.Equals(""))
                {
                    labelYourRating.Visible = true;
                    labeNoteYourRating.Visible = true;
                    watchlistToolStripMenuItem.Visible = true;
                    NameOfUser.Visible = true;
                    NameOfUser.Text = MemberUserName;
                    

                    var resultuser = (from m in context.Users
                                      where m.Username.Equals(MemberUserName)
                                      select m).First();

                    var verifynote = (from a in context.YourRatings
                                     where a.Filme.ID_Film == result.ID_Film && a.ID_User == resultuser.ID_User
                                     select a).FirstOrDefault();
                    if(verifynote==null)
                    {
                        labelYourRating.Text = "Vote!";
                        labeNoteYourRating.Visible = false;
                        
                        //aici baga stele
                    }
                    else
                    {
                        labelYourRating.Text = "Your rating";
                        labeNoteYourRating.Text = verifynote.Nota.ToString();
                    }
                    //vezi daca e in watchlist
                    var verifyviewed = (from a in context.WatchLists
                                      where a.Filme.ID_Film == result.ID_Film && a.ID_User == resultuser.ID_User
                                      select a).FirstOrDefault();
                    if (verifyviewed == null)
                    {
                        pictureBoxWatchlistFilled.Visible = true;
                    }
                    else pictureBoxWatchlistEmpty.Visible = true;
                }
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

        private void label_MouseHover(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.ForeColor = Color.CornflowerBlue;
            Font myFont = new Font("Palatino Linotype", 12, FontStyle.Underline | FontStyle.Bold);
            l.Font = myFont;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.ForeColor = Color.Black;
            Font myFont = new Font("Palatino Linotype", 12, FontStyle.Bold);
            l.Font = myFont;
        }

        private void labelNameofDirector_Click(object sender, EventArgs e)
        {
            ActorsOrDirectorsPage aodp = new ActorsOrDirectorsPage(this, "Regizor", DirectorFirstNames[0], DirectorLastNames[0]);
            aodp.Show();
            this.Hide();
        }

        private void labelNameofDirector2_Click(object sender, EventArgs e)
        {
            ActorsOrDirectorsPage aodp = new ActorsOrDirectorsPage(this, "Regizor", DirectorFirstNames[1], DirectorLastNames[1]);
            aodp.Show();
            this.Hide();
        }

        
        private void labelActor_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            ActorsOrDirectorsPage actor1page = new ActorsOrDirectorsPage(this, "Actor", ActorFirstNames[0], ActorLastNames[0]);
            actor1page.Show();
            this.Hide();
        }

        private void labelActor2_Click(object sender, EventArgs e)
        {
            ActorsOrDirectorsPage actor2page = new ActorsOrDirectorsPage(this, "Actor", ActorFirstNames[1], ActorLastNames[1]);
            actor2page.Show();
            this.Hide();
        }

        private void labelActor3_Click(object sender, EventArgs e)
        {
            ActorsOrDirectorsPage actor3page = new ActorsOrDirectorsPage(this, "Actor", ActorFirstNames[2], ActorLastNames[2]);
            actor3page.Show();
            this.Hide();
        }

        private void labelActor4_Click(object sender, EventArgs e)
        {
            ActorsOrDirectorsPage actor4page = new ActorsOrDirectorsPage(this, "Actor", ActorFirstNames[3], ActorLastNames[3]);
            actor4page.Show();
            this.Hide();
        }

        private void labelActor5_Click(object sender, EventArgs e)
        {
            ActorsOrDirectorsPage actor5page = new ActorsOrDirectorsPage(this, "Actor", ActorFirstNames[4], ActorLastNames[4]);
            actor5page.Show();
            this.Hide();
        }

        private void bornTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("BornToday", this);
            form.Show();
            this.Hide();
        }

        private void pictureBoxWatchlistFilled_Click(object sender, EventArgs e) //asta e de fapt empty
        {
            using (var context = new IMDBEntities())
            {
                if (MemberMovieOrTvSeries.Equals("Movie"))
                {
                    var resultuserid = (from a in context.Users
                                        where a.Username.Equals(MemberUserName)
                                        select a).First();
                    var resultfilmid = (from c in context.Filmes
                                        where c.Nume.Equals(MemberMovieName)
                                        select c).First();
                    var addWatch = new WatchList()
                    {
                        ID_User = resultuserid.ID_User,
                        ID_Film = resultfilmid.ID_Film,
                        Watched = 1
                    };
                    context.WatchLists.Add(addWatch);
                    context.SaveChanges();
                    pictureBoxWatchlistFilled.Visible = false;  //butoanele sunt inversate ca si denumire
                    pictureBoxWatchlistEmpty.Visible = true;
                    MessageBox.Show("Filmul " + MemberMovieName + " a fost adaugat in watchlist!");

                }
                else
                {
                    var resultuserid = (from a in context.Users
                                        where a.Username.Equals(MemberUserName)
                                        select a).First();
                    var resultfilmid = (from c in context.Seriales
                                        where c.Nume.Equals(MemberMovieName)
                                        select c).First();
                    var addWatch = new WatchlistSeriale()
                    {
                        ID_User = resultuserid.ID_User,
                        ID_Serial = resultfilmid.ID_Serial,
                        Watched = 1
                    };
                    context.WatchlistSeriales.Add(addWatch);
                    context.SaveChanges();
                    pictureBoxWatchlistFilled.Visible = false;  //butoanele sunt inversate ca si denumire
                    pictureBoxWatchlistEmpty.Visible = true;
                    MessageBox.Show("Serialul " + MemberMovieName + " a fost adaugat in watchlist!");
                }
            }
        }

        private void pictureBoxWatchlistEmpty_Click(object sender, EventArgs e)  //asta e de fapt filled
        {
            using (var context = new IMDBEntities())
            {
                var resultuserid = (from a in context.Users
                                    where a.Username.Equals(MemberUserName)
                                    select a).First();
                if (MemberMovieOrTvSeries.Equals("Movie"))

                {
                    var resultfilmid = (from c in context.Filmes
                                        where c.Nume.Equals(MemberMovieName)
                                        select c).First();
                    var removewatch = (from b in context.WatchLists
                                       where b.ID_Film == resultfilmid.ID_Film && b.ID_User == resultuserid.ID_User
                                       select b).First();
                    context.WatchLists.Remove(removewatch);
                    context.SaveChanges();
                    pictureBoxWatchlistFilled.Visible = true;  //butoanele sunt inversate ca si denumire
                    pictureBoxWatchlistEmpty.Visible = false;
                    MessageBox.Show("Filmul " + MemberMovieName + " a fost sters in watchlist!");
                }
                else
                {
                    var resultfilmid = (from c in context.Seriales
                                        where c.Nume.Equals(MemberMovieName)
                                        select c).First();
                    var removewatch = (from b in context.WatchlistSeriales
                                       where b.ID_Serial == resultfilmid.ID_Serial && b.ID_User == resultuserid.ID_User
                                       select b).First();
                    context.WatchlistSeriales.Remove(removewatch);
                    context.SaveChanges();
                    pictureBoxWatchlistFilled.Visible = true;  //butoanele sunt inversate ca si denumire
                    pictureBoxWatchlistEmpty.Visible = false;
                    MessageBox.Show("Serialul " + MemberMovieName + " a fost sters in watchlist!");
                }
            }
        }

        private void allActorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("AllActorsCelebs", this);
            form.Show();
            this.Hide();
        }

        private void watchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id;
            using(var con= new IMDBEntities())
            {
                var result = (from a in con.Users
                              where a.Username.Contains(MemberUserName)
                              select a).First();
                id = result.ID_User;
            }
            AdminOrUser aou = new AdminOrUser(MemberUserName, this, id, "Watchlist");
            aou.Show();
            this.Hide();
        }

        private void SearchPictureBox_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals(""))
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
                            UniversalPage searchbymovies = new UniversalPage("SearchByMovies", textBoxSearch.Text, this);
                            searchbymovies.Show();
                            this.Hide();
                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corespunda textului introdus!"); }
                    }
                    else if (SearchBy.Text.Equals("TV Series"))
                    {
                        if (ResultTVSeries != null)
                        {
                            UniversalPage searchbytvseries = new UniversalPage("SearchByTVSeries", textBoxSearch.Text, this);
                            searchbytvseries.Show();
                            this.Hide();
                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corepunda textului introdus!"); }
                    }
                    else if (SearchBy.Text.Equals("Actors"))
                    {
                        if (ResultActors != null)
                        {
                            UniversalPage searchbyactors = new UniversalPage("SearchByActors", textBoxSearch.Text, this);
                            searchbyactors.Show();
                            this.Hide();
                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corepunda textului introdus!"); }
                    }
                    else if (SearchBy.Text.Equals("Directors"))
                    {
                        if (ResultDirectors != null)
                        {
                            UniversalPage searchbydirectors = new UniversalPage("SearchByDirectors", textBoxSearch.Text, this);
                            searchbydirectors.Show();
                            this.Hide();
                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corepunda textului introdus!"); }
                    }
                    else if (SearchBy.Text.Equals("Gender"))
                    {
                        if (ResultGender != null)
                        {
                            UniversalPage searchbygender = new UniversalPage("SearchByGender", textBoxSearch.Text, this);
                            searchbygender.Show();
                            this.Hide();

                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corepunda textului introdus!"); }
                    }
                }
            }
        }
    }
}

