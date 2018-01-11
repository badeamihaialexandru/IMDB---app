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
    

    public partial class AddOrChangePhoto : Form
    {
        private AdminPage adminPage;

        public AddOrChangePhoto(AdminPage admin)
        {
            InitializeComponent();
            adminPage = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPage.Show();
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {

        }
    }
}
