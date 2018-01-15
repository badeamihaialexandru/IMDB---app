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
    public partial class AdminOrUser : Form
    {
        private string MemberUsername;
        private int MemberUserId;
        private string MemberMode;
        //private bool PressButton;
      //  private IMDProject parentform;
        private Form ParentFoorm;
        public AdminOrUser(string NumeUser, Form startpage)
        {
            InitializeComponent();
            labelWelcomeUserName.Text = "Welcome, " + NumeUser + "!";
            MemberUsername = NumeUser;
            ParentFoorm = startpage;
        }

        public AdminOrUser(string NumeUser, Form parentform,int userid,string mode)
        {
            InitializeComponent();
            MemberMode = mode;
            MemberUsername = NumeUser;
            MemberUserId = userid;
            labelWelcomeUserName.Visible = false;
            AdminModeButton.Visible = false;
            UserModeButton.Visible = false;
            buttonTVSeries.Visible = true;
            buttonMovie.Visible = true;
            ParentFoorm = parentform;
        }

        private void AddDirectorButton_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage(MemberUsername,ParentFoorm);
            admin.Show();
            SoundPlayer log = new SoundPlayer(@"C:\Users\Mosu\Desktop\proiect_utile\sound.wav");
            log.Play();
            this.Close();
            ParentFoorm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentFoorm.Show();
        }

        private void UserModeButton_Click(object sender, EventArgs e)
        {

            UserPage uspg = new UserPage(MemberUsername,ParentFoorm);
            uspg.Show();


            this.Close();
            ParentFoorm.Hide();
        }

        private void buttonTVSeries_Click(object sender, EventArgs e)
        {
            UniversalUserPage uup;
            if (MemberMode.Equals("Rating"))
            {
                 uup = new UniversalUserPage("YourRatingTVSeries", ParentFoorm, MemberUserId);
            }
            else { uup = new UniversalUserPage("WatchlistTVSeries", ParentFoorm, MemberUserId); }
            uup.Show();
            this.Close();

        }

        private void buttonMovie_Click(object sender, EventArgs e)
        {
            UniversalUserPage uup;
            if (MemberMode.Equals("Rating"))
            {
                uup = new UniversalUserPage("YourRatingMovie", ParentFoorm, MemberUserId);
            }
            else { uup = new UniversalUserPage("WatchlistMovie", ParentFoorm, MemberUserId); }
            uup.Show();
            this.Close();
        }
    }
}
