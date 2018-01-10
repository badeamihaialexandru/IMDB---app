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
    public partial class UserPage : Form
    {
        private string MemberUserName;
        private IMDProject ParentPageUserPage;
        public UserPage(string UserName, IMDProject startpage)
        {
            InitializeComponent();
            labelUsername.Text = UserName;
            MemberUserName = UserName;
            ParentPageUserPage = startpage;
        }

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentPageUserPage.Show();
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
                if(result.Rights.Contains("admin"))
                {
                    labelGOTOADMINMODE.Visible = true;

                }
            }
            
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            IMDProject startpage = new IMDProject();
            startpage.Show();
        }

        private void labelGOTOADMINMODE_Click(object sender, EventArgs e)
        {
            AdminPage ad = new AdminPage(MemberUserName, ParentPageUserPage);
            ad.Show();
            this.Close();
        }
    }
}
