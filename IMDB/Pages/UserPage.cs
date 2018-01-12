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
        private IMDProject ParentPageUserPage;
        public UserPage(string UserName, IMDProject startpage)
        {
            InitializeComponent();
            labelUsername.Text = UserName;
            MemberUserName = UserName;
            ParentPageUserPage = startpage;
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
                pictureBoxUser.Image = ConvertByteToImage(result.Photo);
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
