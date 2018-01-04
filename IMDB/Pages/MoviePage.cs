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
    public partial class MoviePage : Form
    {
        public MoviePage(string str1)
        {
            InitializeComponent();
            GuestVisit(str1);
        }

        private void GuestVisit(string str1)
        {
            using (var context = new IMDBEntities())
            {
                IMDBEntities imen = new IMDBEntities();
                var result = (from c in imen.Filmes
                              where c.Nume.Equals(str1)
                              select c).First();
                var result2 = from o in imen.Relatie_Filme_Premii
                              where o.Filme.Nume.Equals(str1)
                              //join o in imen.Relatie_Filme_Premii
                              //on c.ID_Film equals o.ID_Film
                              select o;
                var result3 = from p in imen.Relatie_actor_film
                              where p.Filme.Nume.Equals(str1)
                              select p;

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
    }
}
