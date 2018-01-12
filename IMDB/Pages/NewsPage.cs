using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB
{
    public partial class NewsPage : Form
    {

        public NewsPage(string titlu, string continut)
        {
            InitializeComponent();
            labelNews.Text = continut;
            labelTitle.Text = titlu;
        }

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
