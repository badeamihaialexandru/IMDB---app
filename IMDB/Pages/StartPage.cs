using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Security.Cryptography;

namespace IMDB
{
    public partial class IMDProject : Form
    {
        private string StatusState="IMDB Project";
        private string SearchStatus = "Find Movies, TV shows, Celebrities and more ...";

        public IMDProject()
        {
            InitializeComponent();
        
        }

        public string CalculateMD5Hash(string input)

        {

            // step 1, calculate MD5 hash from input

            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);


            // step 2, convert byte array to hex string

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {

                sb.Append(hash[i].ToString("x2"));

            }

            return sb.ToString();

        }

        public void schimba_parole()
        {
            using (var context = new IMDBEntities())
            {
                var users = (from a in context.Users
                             where a.ID_User==2
                            select a).First();
                ////  int count = users.Count();
                // // var item = users.ToList();

                //   //for(int i= 0;i<count;i++)
                //  //{
                //      item[i].Password = CalculateMD5Hash(item[i].Password);

                //  }

                users.Password = CalculateMD5Hash(users.Password);
                context.SaveChanges();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  Image image = Image.FromFile(@"C:\Users\Mosu\Desktop\imdb_pictures\images.png");
            pictureBox1.ImageLocation = @"proiect_utile\imdb_pictures\imdb2.png";
            SearchPictureBox.ImageLocation = @"proiect_utile\imdb_pictures\src.png";
            AppStatus.Text = "IMDB Project";
            textBoxSearch.Text = SearchStatus;
            
            SoundPlayer p = new SoundPlayer(@"proiect_utile\start.wav");
            p.Play();
        }

        private void Ceas_Click(object sender, EventArgs e)
        {

        }

        private void timerCeas_Tick(object sender, EventArgs e)
        {
            Ceas.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void AppStatus_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, EventArgs e)
        {

        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void movieToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

            AppStatus.Text = "Movie, TV & Shows";
        }

        private void celebsEventPhotosToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            AppStatus.Text = "Celebs,Event & Photos";
        }

        private void newsToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            AppStatus.Text = "News & Community";
        }

        private void watchlistToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            AppStatus.Text = "Watchlist";
        }

        private void movieToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            AppStatus.Text = StatusState;
        }

        private void celebsEventPhotosToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            AppStatus.Text = StatusState;
        }

        private void newsToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            AppStatus.Text = StatusState;
        }

        private void watchlistToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            AppStatus.Text = StatusState;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            AppStatus.Text = "Log In";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            AppStatus.Text = StatusState;
        }

        private void label1_Click(object sender, EventArgs e) //SIGN IN
        {
           //schimba_parole();
            label1.Visible = false;
            ContinueAsGuest.Visible = true;
            Username.Visible = true;
            Password.Visible = true;
            TextBoxPassword.Visible = true;
            TextBoxUsername.Visible = true;
            labelLog.Visible = true;
            labelJoinUs.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)  //Continue as Guest
        {
            label1.Visible = true;
            ContinueAsGuest.Visible = false;
            Username.Visible = false;
            Password.Visible = false;
            labelJoinUs.Visible = false;
            TextBoxPassword.Visible = false;
            TextBoxUsername.Visible = false;
            labelLog.Visible = false;
        }

        private void ExitMenu_MouseHover(object sender, EventArgs e)
        {
            AppStatus.Text = "Exit";
        }

        private void ExitMenu_MouseLeave(object sender, EventArgs e)
        {
            AppStatus.Text = StatusState;
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //
        {
           
            //if (textBox1.Text.Equals(""))
            //{
            //    textBox1.Text = SearchStatus;
            //}
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBoxSearch.Enabled = true;
            if (textBoxSearch.Text.Equals(SearchStatus))
            { textBoxSearch.Text = ""; }
            textBoxSearch.ForeColor = Color.Black;
            
        }

       

        private void labelLog_Click(object sender, EventArgs e)
        {
            using (var context = new IMDBEntities())
            {
                var result = (from c in context.Users
                              where c.Username.Equals(TextBoxUsername.Text)
                              select c).FirstOrDefault();
                if(result!=null)
                {
                    
                    string parola = result.Password;
                    parola=parola.Replace(" ", string.Empty);
                    string parola2 = CalculateMD5Hash(TextBoxPassword.Text);

                    if (!parola2.Equals(parola))
                    {
                        MessageBox.Show("The password isn't correct!", "Sign in Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (result.Rights.Contains("admin"))
                        {
                            AdminOrUser aou = new AdminOrUser(TextBoxUsername.Text, this);
                            aou.Show();
                        }
                        else
                        {
                            UserPage up = new UserPage(result.Username, this);
                            up.Show();
                        }
                        SoundPlayer log = new SoundPlayer(@"C:\Users\Mosu\Desktop\proiect_utile\sound.wav");
                        log.Play();
                        TextBoxUsername.Text = "";
                        TextBoxPassword.Text = "";
                    }
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("The password or username isn't correct!");
                }
            }
        }

        private void topRatedMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("TopRatedMovies",this);
            form.Show();
            this.Hide();
        }

        private void labelJoinUs_Click(object sender, EventArgs e)
        {
            SignUp sgu = new SignUp(this);
            sgu.Show();
            this.Hide();

        }

        private void textBox1_CursorChanged_1(object sender, EventArgs e)
        {
            if(textBoxSearch.Text.Equals(""))
            {
                textBoxSearch.Text = SearchStatus;
            }
        }

        private void topRatedTVSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("TopRatedTVSeries",this);
            form.Show();
            this.Hide();
        }

        private void watchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need an account if you want to add movies in your Watchlist!", "InfoMessage");
        }

        private void SearchPictureBox_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text.Equals(SearchStatus) || textBoxSearch.Text.Equals(""))
            {
                MessageBox.Show("Please enter a keyword for search!","InfoMessage");
            }
            else {
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
                        if(ResultMovies!=null)
                        {
                            UniversalPage searchbymovies = new UniversalPage("SearchByMovies", textBoxSearch.Text, this);
                            searchbymovies.Show();
                            this.Hide();
                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corespunda textului introdus!"); }
                    }
                    else if(SearchBy.Text.Equals("TV Series"))
                    {
                        if(ResultTVSeries!=null)
                        {
                            UniversalPage searchbytvseries = new UniversalPage("SearchByTVSeries", textBoxSearch.Text, this);
                            searchbytvseries.Show();
                            this.Hide();
                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corepunda textului introdus!"); }
                    }
                    else if(SearchBy.Text.Equals("Actors"))
                    {
                        if(ResultActors!=null)
                        {
                            UniversalPage searchbyactors = new UniversalPage("SearchByActors", textBoxSearch.Text, this);
                            searchbyactors.Show();
                            this.Hide();
                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corepunda textului introdus!"); }
                    }                    
                    else if(SearchBy.Text.Equals("Directors"))
                    {
                        if(ResultDirectors!=null)
                        {
                            UniversalPage searchbydirectors = new UniversalPage("SearchByDirectors", textBoxSearch.Text, this);
                            searchbydirectors.Show();
                            this.Hide();
                        }
                        else { MessageBox.Show("Nu exista nici o inregistrare care sa corepunda textului introdus!"); }
                    }
                    else if(SearchBy.Text.Equals("Gender"))
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

        private void newsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("News",this);
            form.Show();
            this.Hide();
        }

        private void mostRatedMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("MostPopularMovies",this);
            form.Show();
            this.Hide();
        }

        private void mostPopularTVSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("MostPopularTVSeries",this);
            form.Show();
            this.Hide();
        }

        private void celebrityNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("CelebrityNews",this);
            form.Show();
            this.Hide();
        }

        private void bornTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("BornToday",this);
            form.Show();
            this.Hide();
        }

        private void mostPopularCelebsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("MostPopularCelebs",this);
            form.Show();
            this.Hide();
        }

        private void allActorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("AllActorsCelebs", this);
            form.Show();
            this.Hide();
        }

        private void SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
