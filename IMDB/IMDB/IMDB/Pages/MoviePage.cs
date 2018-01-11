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

namespace IMDB
{
    public partial class MoviePage : Form
    {
        public MoviePage(string str1)
        {
            InitializeComponent();
            GuestVisit(str1);
        }

        private Image ConvertByteToImage(byte[] photo)
        {
            Image newImage;
            using (MemoryStream ms=new MemoryStream(photo,0,photo.Length))
            {
                ms.Write(photo, 0, photo.Length);
                newImage = Image.FromStream(ms, true);
            }
            return newImage;
        }

        private void GuestVisit(string str1)
        {
            using (var context = new IMDBEntities())
            {
                IMDBEntities imen = new IMDBEntities();
                var result = (from c in imen.Filmes
                              where c.Nume.Equals(str1)
                              select c).Single();
                var result2 = from o in imen.Relatie_Filme_Premii
                              where o.Filme.Nume.Equals(str1)
                              select o;
                var result3 = from p in imen.Relatie_actor_film
                              where p.Filme.Nume.Equals(str1)
                              select p;
                try
                {
                    pictureBoxPhoto.Image = ConvertByteToImage(result.Photo);
                }
                catch
                {
                    MessageBox.Show("Can't load this movie's photo!", "ErrorPhoto");
                }
                labelNameandYear.Text = result.Nume + " " + " ( " + result.An_aparitie.ToString() + ")";
                labelGender.Text = "";
                int count = result.Genuris.Count;
                foreach (var a in result.Genuris)
                {
                    if (count != 1)
                    {
                        labelGender.Text += a.Nume_Gen.ToString() + ",";
                        count--;
                    }
                    else labelGender.Text += a.Nume_Gen.ToString();
                }
                labelWins.Text = "";
                count = 1;
                foreach (var b in result2)
                {
                    if (count != result2.Count())
                    {
                        labelWins.Text += b.Premii.Nume.ToString() + ", ";
                        count++;
                    }
                    else labelWins.Text += b.Premii.Nume.ToString();
                }
                labelNameofDirector.Text = "";
                count = result.Regizoris.Count;
                foreach (var c in result.Regizoris)
                {
                    if (count != 1)
                    {
                        labelNameofDirector.Text += c.Prenume.ToString() + " " + c.Nume.ToString() + ",";
                        count--;
                    }
                    else { labelNameofDirector.Text += c.Prenume.ToString() + " " + c.Nume.ToString(); }
                }
                labelActors.Text = "";
                foreach (var d in result3)
                {
                    labelActors.Text += d.Actori.Prenume.ToString() + " " + d.Actori.Nume.ToString() + "\t as  " + d.Nume_in_film.ToString() + "\n";
                }
                labelRating.Text = result.Nota.ToString();

            }
        }

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFacebook_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelGender_Click(object sender, EventArgs e)
        {
            GenrePage gen = new GenrePage();
            gen.Show();
        }

        private void labelGender_MouseHover(object sender, EventArgs e)
        {
            labelGender.ForeColor = Color.CornflowerBlue;
            Font myFont = new Font("Palatino Linotype",12, FontStyle.Underline| FontStyle.Bold);
            labelGender.Font = myFont;
        }

        private void labelGender_MouseLeave(object sender, EventArgs e)
        {
            labelGender.ForeColor = Color.FromArgb(121, 121, 134);
            Font myFont = new Font("Palatino Linotype", 12,FontStyle.Bold);
            labelGender.Font = myFont;
        }
    }
}
