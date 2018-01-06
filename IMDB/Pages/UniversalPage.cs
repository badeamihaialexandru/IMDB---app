using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB.Pages
{
    public partial class UniversalPage : Form
    {
        public UniversalPage()
        {
            InitializeComponent();
        }

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
