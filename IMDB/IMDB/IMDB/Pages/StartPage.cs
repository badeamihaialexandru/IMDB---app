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

        

        private void Form1_Load(object sender, EventArgs e)
        {
          //  Image image = Image.FromFile(@"C:\Users\Mosu\Desktop\imdb_pictures\images.png");
            pictureBox1.ImageLocation = @"C:\Users\Mosu\Desktop\proiect_utile\imdb_pictures\imdb2.png";
            SearchPictureBox.ImageLocation = @"C:\Users\Mosu\Desktop\proiect_utile\imdb_pictures\src.png";
            AppStatus.Text = "IMDB Project";
            textBox1.Text = SearchStatus;
            SoundPlayer p = new SoundPlayer(@"C:\Users\Mosu\Desktop\proiect_utile\start.wav");
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
            textBox1.Enabled = true;
            if (textBox1.Text.Equals(SearchStatus))
            { textBox1.Text = ""; }
            textBox1.ForeColor = Color.Black;
            
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
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("The password or username aren't correct!");
                }
            }
        }

        private void topRatedMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("TopRatedMovies");
            form.Show();
        }

        private void labelJoinUs_Click(object sender, EventArgs e)
        {
            SignUp sgu = new SignUp();
            sgu.Show();

        }

        private void textBox1_CursorChanged_1(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(""))
            {
                textBox1.Text = SearchStatus;
            }
        }

        private void topRatedTVSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("TopRatedTVSeries");
            form.Show();
        }

        private void watchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need an account if you want to add movies in your Watchlist!", "InfoMessage");
        }

        private void SearchPictureBox_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(SearchStatus) || textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please enter a keyword for search!","InfoMessage");
            }
        }

        private void newsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("News");
            form.Show();
        }
    }

}
