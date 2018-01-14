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
        //private bool PressButton;
        private IMDProject parentform;
        public AdminOrUser(string NumeUser, IMDProject startpage)
        {
            InitializeComponent();
            labelWelcomeUserName.Text = "Welcome, " + NumeUser + "!";
            MemberUsername = NumeUser;
            parentform = startpage;
        }

        private void AddDirectorButton_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage(MemberUsername,parentform);
            admin.Show();
            SoundPlayer log = new SoundPlayer(@"C:\Users\Mosu\Desktop\proiect_utile\sound.wav");
            log.Play();
            this.Close();
            parentform.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserModeButton_Click(object sender, EventArgs e)
        {

            UserPage uspg = new UserPage(MemberUsername,parentform);
            uspg.Show();


            this.Close();
            parentform.Hide();
        }
    }
}
