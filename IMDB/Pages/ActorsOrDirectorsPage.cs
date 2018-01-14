using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace IMDB
{
    public partial class ActorsOrDirectorsPage : Form
    {
        public ActorsOrDirectorsPage()
        {
            InitializeComponent();
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
