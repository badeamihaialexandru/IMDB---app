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
using System.IO;

namespace IMDB
{
  
    
    public partial class ActorsOrDirectorsPage : Form
    {
        private Form ParentForm;
        private string MemberType;
        private string MemberName;
        private string MemberFirstName;
       
        private string[] MemberMovies = new string[4];

        public ActorsOrDirectorsPage(Form Parent,string tip,string prenume,string nume/*, string movieortvseries*/)
        {
            InitializeComponent();
            ParentForm = Parent;
            MemberType = tip;
            MemberName = nume;
            MemberFirstName = prenume;
          //  MemberMovieOrTvSeries = movieortvseries;

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

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }


        private void label_MouseHover(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.ForeColor = Color.CornflowerBlue;
            Font myFont = new Font("Palatino Linotype", 12, FontStyle.Underline | FontStyle.Bold);
            l.Font = myFont;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.ForeColor = Color.Black;
            Font myFont = new Font("Palatino Linotype", 12, FontStyle.Bold);
            l.Font = myFont;
        }

        private void label_click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            char intt = l.Name[10];
            int a=0;//= Convert.ToInt32(intt) -1;
            if(intt.Equals('1'))
            {
                a = 0;
            }
            else if(intt.Equals('2'))
            {
                a = 1;
            }
            else if (intt.Equals('3'))
            {
                a = 2;
            }
            else if (intt.Equals('4'))
            {
                a = 3;
            }
            MoviePage mp = new MoviePage(l.Text,this,MemberMovies[a]);
            mp.Show();
            this.Hide();

        }

        private void ActorsOrDirectorsPage_Load(object sender, EventArgs e)
        {
            labelName.Text = MemberFirstName + " " +MemberName ;
            labelActororDirector.Text = MemberType;
            using (var context = new IMDBEntities())
            {
                if (MemberType.Equals("Actor"))
                {
                    var result = (from a in context.Actoris
                                  where a.Nume.Equals(MemberName) && a.Prenume.Equals(MemberFirstName)
                                  select a).FirstOrDefault();
                if(result.Photo !=null)
                    {
                        pictureBoxPhoto.Image = ConvertByteToImage(result.Photo);
                    }
                 else
                    {
                        pictureBoxPhoto.ImageLocation = @"C:\Users\Mosu\Desktop\proiect_utile\imdb_pictures\unknown.jpg";
                    }
                    labelDATEOFBIRTH.Text = result.DataNasterii.ToString();
                    labelCity.Text = result.Oras_natal;
                    labelCountry.Text = result.Tara;
                    labelNationality.Text = result.Nationalitate;
                    var results2 = from p in context.Relatie_actor_film
                                   where p.Actori.ID_Actor == result.ID_Actor
                                   select new
                                   {
                                       p.Filme.Nume
                                   };
                    var result3 = from p in context.Relatie_Actor_Serial
                                  where p.Actori.ID_Actor == result.ID_Actor
                                  select new { p.Seriale.Nume };

                    int count = results2.ToList().Count;
                    int count2 = result3.ToList().Count;
                    var mn = results2.ToList();
                    var mn2 = result3.ToList();
                    if(count==0)
                    {
                        labelMovie1.Visible = false;
                        labelMovie2.Visible = false;
                        labelMovie3.Visible = false;
                        labelMovie4.Visible = false;
                        if(count2==1)
                        {
                            labelMovie1.Visible = true;
                            labelMovie1.Text = mn2[0].Nume;
                            MemberMovies[0] = "TVSeries";
                        }
                        else if( count2 ==2)
                        {
                            labelMovie1.Visible = true;
                            labelMovie1.Text = mn2[0].Nume;
                            MemberMovies[0] = "TVSeries";
                            labelMovie2.Visible = true;
                            labelMovie2.Text = mn2[1].Nume;
                            MemberMovies[1] = "TVSeries";
                        }
                        else if( count2 ==3)
                        {
                            labelMovie1.Visible = true;
                            labelMovie1.Text = mn2[0].Nume;
                            MemberMovies[0] = "TVSeries";
                            labelMovie2.Visible = true;
                            labelMovie2.Text = mn2[1].Nume;
                            MemberMovies[1] = "TVSeries";
                            labelMovie3.Visible = true;
                            labelMovie3.Text = mn[2].Nume;
                            MemberMovies[2] = "TVSeries";
                        }
                        else if(count2==4)
                        {
                            labelMovie1.Visible = true;
                            labelMovie1.Text = mn2[0].Nume;
                            MemberMovies[0] = "TVSeries";
                            labelMovie2.Visible = true;
                            labelMovie2.Text = mn2[1].Nume;
                            MemberMovies[1] = "TVSeries";
                            labelMovie3.Visible = true;
                            labelMovie3.Text = mn[2].Nume;
                            MemberMovies[2] = "TVSeries";
                            labelMovie4.Visible = true;
                            labelMovie4.Text = mn[3].Nume;
                            MemberMovies[3] = "TVSeries";
                        }
                    }
                    else if(count==1)
                    {
                        labelMovie1.Text = mn[0].Nume;
                        MemberMovies[0] = "Movies";
                        labelMovie2.Visible = false;
                        labelMovie3.Visible = false;
                        labelMovie4.Visible = false;
                        if (count2 == 1)
                        {
                            labelMovie2.Visible = true;
                            labelMovie2.Text = mn2[0].Nume;
                            MemberMovies[1] = "TVSeries";
                        }
                        else if (count2 == 2)
                        {
                            labelMovie2.Visible = true;
                            labelMovie2.Text = mn2[0].Nume;
                            MemberMovies[1] = "TVSeries";
                            labelMovie3.Visible = true;
                            labelMovie3.Text = mn2[1].Nume;
                            MemberMovies[2] = "TVSeries";
                        }
                        else if (count2 == 3)
                        {
                            labelMovie2.Visible = true;
                            labelMovie2.Text = mn2[0].Nume;
                            MemberMovies[1] = "TVSeries";
                            labelMovie3.Visible = true;
                            labelMovie3.Text = mn2[1].Nume;
                            MemberMovies[2] = "TVSeries";
                            labelMovie4.Visible = true;
                            labelMovie4.Text = mn[2].Nume;
                            MemberMovies[3] = "TVSeries";
                        }
                    }
                    else if(count==2)
                    {
                        labelMovie1.Text = mn[0].Nume;
                        MemberMovies[0] = "Movie";
                        labelMovie2.Text = mn[1].Nume;
                        MemberMovies[1] = "Movie";
                        labelMovie3.Visible = false;
                        labelMovie4.Visible = false;
                        if (count2 == 1)
                        {
                            labelMovie3.Visible = true;
                            labelMovie3.Text = mn2[0].Nume;
                            MemberMovies[2] = "TVSeries";
                        }
                        else if (count2 == 2)
                        {
                            labelMovie3.Visible = true;
                            labelMovie3.Text = mn2[0].Nume;
                            MemberMovies[2] = "TVSeries";
                            labelMovie4.Visible = true;
                            labelMovie4.Text = mn2[1].Nume;
                            MemberMovies[3] = "TVSeries";
                        }
                    }
                    else if(count==3)
                    {
                        labelMovie1.Text = mn[0].Nume;
                        MemberMovies[0] = "Movie";
                        labelMovie2.Text = mn[1].Nume;
                        MemberMovies[1] = "Movie";
                        labelMovie3.Text = mn[2].Nume;
                        MemberMovies[2] = "Movie";
                        labelMovie4.Visible = false;
                        if(count2==1)
                        {
                            labelMovie4.Visible = true;
                            labelMovie4.Text = mn2[0].Nume;
                            MemberMovies[3] = "TVSeries";
                        }
                    }
                    else if(count==4)
                    {
                        labelMovie1.Text = mn[0].Nume;
                        MemberMovies[0] = "Movie";
                        labelMovie2.Text = mn[1].Nume;
                        MemberMovies[1] = "Movie";
                        labelMovie3.Text = mn[2].Nume;
                        MemberMovies[2] = "Movie";
                        labelMovie4.Text = mn[3].Nume;
                        MemberMovies[3] = "Movie";
                    }
                }
                else if(MemberType.Equals("Regizor"))
                {
                    var result = (from a in context.Regizoris
                                  where a.Nume.Equals(MemberName)
                                  select a).FirstOrDefault();
                    if (result.Photo != null)
                    {
                        pictureBoxPhoto.Image = ConvertByteToImage(result.Photo);
                    }
                    else
                    {
                        pictureBoxPhoto.ImageLocation = @"C:\Users\Mosu\Desktop\proiect_utile\imdb_pictures\unknown.jpg";
                    }
                    labelDATEOFBIRTH.Text = result.Data_nasterii.ToString();
                    labelCity.Text = result.Locul_nasterii;
                    labelCountry.Text = result.Tara;
                    labelNationality.Text = result.Nationalitate;
                    var results2 = context.Regizoris.Where(c => c.ID_Regizor == result.ID_Regizor).SelectMany(c => c.Filmes);

                    int count = results2.ToList().Count;
                    var mn = results2.ToList();
                    if (count == 0)
                    {
                        labelMovie1.Visible = false;
                        labelMovie2.Visible = false;
                        labelMovie3.Visible = false;
                        labelMovie4.Visible = false;
                    }
                    else if (count == 1)
                    {
                        labelMovie1.Text = mn[0].Nume;
                        labelMovie2.Visible = false;
                        labelMovie3.Visible = false;
                        labelMovie4.Visible = false;
                    }
                    else if (count == 2)
                    {
                        labelMovie1.Text = mn[0].Nume;
                        labelMovie2.Text = mn[1].Nume;
                        labelMovie3.Visible = false;
                        labelMovie4.Visible = false;
                    }
                    else if (count == 3)
                    {
                        labelMovie1.Text = mn[0].Nume;
                        labelMovie2.Text = mn[1].Nume;
                        labelMovie3.Text = mn[2].Nume;
                        labelMovie4.Visible = false;
                    }
                    else if (count == 4)
                    {
                        labelMovie1.Text = mn[0].Nume;
                        labelMovie2.Text = mn[1].Nume;
                        labelMovie3.Text = mn[2].Nume;
                        labelMovie4.Text = mn[3].Nume;
                    }
                }
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {


        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bornTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("BornToday", this);
            form.Show();
            this.Hide();
        }

        private void labelMovie1_Click(object sender, EventArgs e)
        {
            MoviePage mp = new MoviePage(labelMovie1.Text, this, MemberMovies[0]);
            mp.Show();
            this.Hide();
        }

        private void allActorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniversalPage form = new UniversalPage("AllActorsCelebs", this);
            form.Show();
            this.Hide();
        }
    }
}
