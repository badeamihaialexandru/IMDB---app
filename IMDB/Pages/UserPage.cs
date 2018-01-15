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
    public partial class UserPage : Form
    {
        private string MemberUserName;
        private Form ParentPageUserPage;
        private int MemberUserID;
        public UserPage(string UserName, Form startpage)
        {
            InitializeComponent();
            labelUsername.Text = UserName;
            MemberUserName = UserName;
            ParentPageUserPage = startpage;
            using(var context = new IMDBEntities())
            {
                var res = (from a in context.Users
                           where a.Username.Equals(UserName)
                           select new
                           {
                               a.ID_User
                           }).First();
                MemberUserID = res.ID_User;
            }
        }

        private byte[] ConvertFiletoByte(string sPath)
        {
            byte[] data = null;
            FileInfo finfo = new FileInfo(sPath);
            long numBytes = finfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        private Image ConvertByteToImage(byte[] photo)
        {
            Image newImage;
            using (MemoryStream ms = new MemoryStream(photo, 0, photo.Length))
            {
                ms.Write(photo, 0, photo.Length);
                newImage = Image.FromStream(ms, true);
            }
            return newImage;
        }

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            ParentPageUserPage.Show();
            this.Close();
            
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            using (var context= new IMDBEntities())
            {
                var result = (from c in context.Users
                              where c.Username.Equals(MemberUserName)
                              select c).First();
                labelRegister.Text += " " +result.DateofRegister.Value.ToShortDateString();
                labelRights.Text += " " + result.Rights.ToString();
                try
                {
                    pictureBoxUser.Image = ConvertByteToImage(result.Photo);
                }
                catch
                {
                    MessageBox.Show("Can't load this user's photo!", "ErrorPhoto");
                }
                
                if(result.Rights.Contains("admin"))
                {
                    labelGOTOADMINMODE.Visible = true;

                }
            }
            
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentPageUserPage.Show();
        }

        private void labelGOTOADMINMODE_Click(object sender, EventArgs e)
        {
            AdminPage ad = new AdminPage(MemberUserName, ParentPageUserPage);
            ad.Show();
            this.Close();
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

        private void topRatedMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalUserPage trm = new UniversalUserPage("TopRatedMovies",this,MemberUserID,"Movie");
            trm.Show();
            this.Hide();
        }

        private void mostRatedMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalUserPage trm = new UniversalUserPage("MostPopularMovies", this,MemberUserID, "Movie");
            trm.Show();
            this.Hide();
        }

        private void UserRatingButton_Click(object sender, EventArgs e)
        {
            AdminOrUser aou = new AdminOrUser(MemberUserName, this, MemberUserID, "Rating");
            aou.Show();
            this.Hide();
        }

        private void bornTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalUserPage form = new UniversalUserPage("BornToday", this,MemberUserID);
            form.Show();
            this.Hide();
        }

        private void topRatedTVSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalUserPage form = new UniversalUserPage("TopRatedTVSeries",this,MemberUserID,"TVSeries");
            form.Show();
            this.Hide();
        }

        private void mostPopularTVSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalUserPage form = new UniversalUserPage("MostPopularTVSeries", this, MemberUserID,"TVSeries");
            form.Show();
            this.Hide();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void celebrityNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalUserPage form = new UniversalUserPage("CelebrityNews", this, MemberUserID);
            form.Show();
            this.Hide();
        }

        private void mostPopularCelebsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalUserPage form = new UniversalUserPage("MostPopularCelebs", this, MemberUserID);
            form.Show();
            this.Hide();
        }

        private void newsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UniversalUserPage form = new UniversalUserPage("News", this, MemberUserID);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminOrUser aou = new AdminOrUser(MemberUserName, this, MemberUserID, "Watchlist");
            aou.Show();
            this.Hide();
        }

        private void watchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalUserPage form = new UniversalUserPage("UserWatchlist", this, MemberUserID);
            form.Show();
            this.Hide();
        }

        private void allActorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalUserPage form = new UniversalUserPage("AllActorsCelebs", this, MemberUserID);
            form.Show();
            this.Hide();
        }
    }
}
