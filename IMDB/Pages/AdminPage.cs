using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;


namespace IMDB
{
    

    public partial class AdminPage : Form
    {
        private IMDProject ParentPageAdminPage;
        private string MemberUserName;
        private string drepturi;

        public AdminPage(string AdminName, IMDProject startpage)
        {
            InitializeComponent();
            AdminNameLabel.Text = AdminName;
            ParentPageAdminPage = startpage;
            MemberUserName = AdminName;
            using (var context= new IMDBEntities())
            {
                var result = (from a in context.Users
                              where a.Username.Contains(AdminName)
                              select a).First();
                drepturi = result.Rights;
            }
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            if(!drepturi.Contains("superadmin"))
            {
                buttonUser.Visible = false;
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentPageAdminPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Nume";
            label2.Visible = true;
            textBox1.Visible = true;
            label7.Text = "Prenume";
            label7.Visible = true;
            textBox2.Visible = true;
            label6.Text = "Data de Nastere";
            label6.Visible = true;
            textBox3.Visible = true;
            label5.Text = "Oras Natal";
            label5.Visible = true;
            textBox4.Visible = true;
            label4.Text = "Tara";
            label4.Visible = true;
            textBox5.Visible = true;
            label3.Text = "Nationalitate";
            label3.Visible = true;
            textBox6.Visible = true;
            labelpoza.Visible = true;
            pictureBoxPoza.Visible = true;
            buttonCauta.Visible = true;
            buttonSalveaza.Visible = true;
            checkBoxMakeAdmin.Visible = false;
        }  //actor button

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
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

        private void AddDirectorButton_Click(object sender, EventArgs e)
        {
            label2.Text = "Nume";
            label2.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = "";
            label7.Text = "Prenume";
            label7.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "";
            label6.Text = "Data Nasterii";
            label6.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = "";
            label5.Text = "Oras Natal";
            label5.Visible = true;
            textBox4.Visible = true;
            textBox4.Text = "";
            label4.Text = "Tara";
            label4.Visible = true;
            textBox5.Visible = true;
            textBox5.Text = "";
            label3.Text = "Nationalitate";
            label3.Visible = true;
            textBox6.Visible = true;
            textBox6.Text = "";
            labelpoza.Visible = true;
            pictureBoxPoza.Visible = true;
            buttonCauta.Visible = true;
            buttonSalveaza.Visible = true;
            checkBoxMakeAdmin.Visible = false;
        } //director button

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            label2.Text = "Nume";
            label2.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = "";
            label7.Text = "An aparitie";
            label7.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "";
            label6.Text = "Nota";
            label6.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = "";
             label5.Visible = false;
            textBox4.Visible = false;
            textBox4.Text = "";
            label4.Visible = false;
            textBox5.Visible = false;
            textBox5.Text = "";
            label3.Visible = false;
            textBox6.Visible = false;
            textBox6.Text = "";
            labelpoza.Visible = true;
            pictureBoxPoza.Visible = true;
            buttonCauta.Visible = true;
            buttonSalveaza.Visible = true;
            checkBoxMakeAdmin.Visible = false;
        } //movie button

        private void AddTVSeriesButton_Click(object sender, EventArgs e)
        {
            label2.Text = "Nume";
            label2.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = "";
            label7.Text = "An aparitie";
            label7.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "";
            label6.Text = "Numar sezoane";
            label6.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = "";
            label5.Text = "Total episoade";
            label5.Visible = true;
            textBox4.Visible = true;
            textBox4.Text = "";
            label4.Text = "Nota";
            label4.Visible = true;
            textBox5.Visible = true;
            textBox5.Text = "";
            label3.Visible = false;
            textBox6.Visible = false;
            textBox6.Text = "";
            labelpoza.Visible = true;
            pictureBoxPoza.Visible = true;
            buttonCauta.Visible = true;
            buttonSalveaza.Visible = true;
            checkBoxMakeAdmin.Visible = false;
        }  //tvseries button

        private void InsertcheckBox_CheckedChanged(object sender, EventArgs e)
        {
        //    DeletecheckBox.Checked = false;
        //    UpdateCheckBox.Checked = false;
        }

        private void AdminNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)  //GO TO USER MODE
        {
            UserPage uspg = new UserPage(MemberUserName, ParentPageAdminPage);
            uspg.Show();
            this.Close();
        }

        private void UpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        //    InsertcheckBox.Checked = false;
        //    DeletecheckBox.Checked = false;
        }

        private void DeletecheckBox_CheckedChanged(object sender, EventArgs e)
        {
        //    InsertcheckBox.Checked = false;
        //    UpdateCheckBox.Checked = false;
        }

        private void InsertcheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            DeletecheckBox.Checked = false;
            UpdateCheckBox.Checked = false;
            label11.Visible = false;
            textBox7.Visible = false;
            label12.Visible = false;
        }  //insert check

        private void UpdateCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            InsertcheckBox.Checked = false;
            DeletecheckBox.Checked = false;
            label11.Text = "Cauta dupa nume*:";
            label12.Visible = true;
            label11.Visible = true;
            textBox7.Visible = true;
            textBox7.Text = "";
        }  //update check

        private void DeletecheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            InsertcheckBox.Checked = false;
            UpdateCheckBox.Checked = false;
            label11.Text = "Cauta dupa nume*:";
            label12.Visible = true;
            label11.Visible = true;
            textBox7.Visible = true;
            textBox7.Text = "";
        }  //delete check

        private void buttonUser_Click(object sender, EventArgs e)
        {
            label2.Text = "Username:";
            label2.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = "";
            label7.Text = "Password:";
            label7.Visible = true;
            textBox2.Visible = true;
            textBox2.PasswordChar = '*';
            textBox2.Text = "";
            label6.Text = "Re-typePassword:";
            label6.Visible = true;
            textBox3.Visible = true;
            textBox3.PasswordChar = '*';
            textBox3.Text = "";
            label5.Text = "E-mail:";
            label5.Visible = true;
            textBox4.Visible = true;
            textBox4.Text = "";
            label4.Text = "PhoneNumber:";
            label4.Visible = true;
            textBox5.Visible = true;
            textBox5.Text = "";
            labelpoza.Visible = true;
            pictureBoxPoza.Visible = true;
            buttonCauta.Visible = true;
            buttonSalveaza.Visible = true;
            checkBoxMakeAdmin.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddOrChangePhoto aocp = new AddOrChangePhoto(this);
            aocp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/imdb");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/imdb/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/imdb");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Nume" && label7.Text == "Prenume" && label6.Text == "Data de Nastere")
            {
                if (DeletecheckBox.Checked == true)
                {
                    using (IMDBEntities con = new IMDBEntities())
                    {
                        if (label11.Text.Equals("ID*:"))
                        {
                            int b = Convert.ToInt32(textBox7.Text);
                            var results = (from c in con.Actoris
                                           where c.ID_Actor == b
                                           select c).FirstOrDefault();
                            if (results == null)
                            {
                                MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                            }
                            else
                            {
                                con.DeleteActorbyID(b);
                                con.SaveChanges();
                                MessageBox.Show("Actor sters cu succes!");
                            }
                        }
                        else
                        {
                            var results = (from c in con.Actoris
                                           where c.Nume == textBox7.Text
                                           select c).FirstOrDefault();
                            if (results == null)
                            {
                                MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                            }
                            else
                            {
                                con.DeleteActorbyName(textBox7.Text);
                                con.SaveChanges();
                                MessageBox.Show("Actor sters cu succes!");
                            }
                        }
                    }

                }

                else if (!textBox1.Text.Equals(""))
                {
                    if (!textBox2.Text.Equals(""))
                    {
                        if (!textBox3.Text.Equals(""))
                        {
                            if (!textBox4.Text.Equals(""))
                            {
                                if (!textBox5.Text.Equals(""))
                                {
                                    if (!textBox6.Text.Equals(""))
                                    {
                                        using (IMDBEntities context = new IMDBEntities())
                                        {
                                            if (pictureBoxPoza.ImageLocation != null)
                                            {
                                                if (InsertcheckBox.Checked == true)
                                                {
                                                    DateTime a = Convert.ToDateTime(textBox3.Text);
                                                    context.AddActorWithPhoto(textBox1.Text, textBox2.Text, a, textBox4.Text, textBox5.Text, textBox6.Text, ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                    context.SaveChanges();
                                                    MessageBox.Show("Actor adaugat cu succes (cu poza)!");
                                                }
                                                else if (UpdateCheckBox.Checked == true)
                                                {
                                                    if (!label11.Text.Equals("ID*:"))
                                                    {
                                                        var results = (from c in context.Actoris
                                                                       where c.Nume == textBox7.Text
                                                                       select c).FirstOrDefault();
                                                        if (results == null)
                                                        {
                                                            MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                                                        }
                                                        else
                                                        {
                                                            DateTime a = Convert.ToDateTime(textBox3.Text);
                                                            context.UpdateActorWithPhoto(textBox7.Text, textBox1.Text, textBox2.Text, a, textBox4.Text, textBox5.Text, textBox6.Text, ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                            context.SaveChanges();
                                                            MessageBox.Show("Actor updatat cu succes!");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        int b = Convert.ToInt32(textBox7.Text);
                                                        var results = (from c in context.Actoris
                                                                       where c.ID_Actor == b
                                                                       select c).FirstOrDefault();
                                                        if (results == null)
                                                        {
                                                            MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                                                        }
                                                        else
                                                        {
                                                            DateTime a = Convert.ToDateTime(textBox3.Text);
                                                            context.UpdateActoriDupaID(b, textBox1.Text, textBox2.Text, a, textBox4.Text, textBox5.Text, textBox6.Text, ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                            context.SaveChanges();
                                                            MessageBox.Show("Actor updatat cu succes!");
                                                        }
                                                    }
                                                }
                                                else MessageBox.Show("Selecteaza ceea ce vrei sa faci! Insert, update, delete...");
                                            }
                                            else
                                            {
                                                if (InsertcheckBox.Checked == true)
                                                {
                                                    DateTime a = Convert.ToDateTime(textBox3.Text);
                                                    context.AddActorWithoutPhoto(textBox1.Text, textBox2.Text, a, textBox4.Text, textBox5.Text, textBox6.Text);
                                                    context.SaveChanges();
                                                    MessageBox.Show("Actor adaugat cu succes (fara poza)!");
                                                }
                                                else if (UpdateCheckBox.Checked == true)
                                                {
                                                    MessageBox.Show("Selecteaza o imagine mai intai!");
                                                }
                                                else MessageBox.Show("Alege o optiune!Update,Insert,Delete...");
                                            }
                                        }
                                    }
                                    else MessageBox.Show("Trebuie sa introduci nationalitatea!");
                                }
                                else MessageBox.Show("Trebuie sa introduci tara");
                            }
                            else MessageBox.Show("Trebuie sa introduci orasul natal");
                        }
                        else MessageBox.Show("Trebuie sa introduci anul nasterii!");
                    }
                    else MessageBox.Show("Trebuie sa introduci un prenume!");
                }
                else MessageBox.Show("Trebuie sa introduci un nume!");


            }  //asta e pt actori
            else if (label2.Text == "Nume" && label7.Text == "Prenume" && label6.Text == "Data Nasterii")
            {
                if (DeletecheckBox.Checked == true)
                {
                    using (IMDBEntities con = new IMDBEntities())
                    {
                        if (label11.Text.Equals("ID*:"))
                        {
                            int b = Convert.ToInt32(textBox7.Text);
                            var results = (from c in con.Regizoris
                                           where c.ID_Regizor == b
                                           select c).FirstOrDefault();
                            if (results == null)
                            {
                                MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                            }
                            else
                            {
                                con.DeleteDirectorbyID(b);
                                con.SaveChanges();
                                MessageBox.Show("Regizor sters cu succes!");
                            }
                        }
                        else
                        {
                            var results = (from c in con.Regizoris
                                           where c.Nume == textBox7.Text
                                           select c).FirstOrDefault();
                            if (results == null)
                            {
                                MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                            }
                            else
                            {
                                con.DeleteDirectorbyName(textBox7.Text);
                                con.SaveChanges();
                                MessageBox.Show("Regizor sters cu succes!");
                            }
                        }
                    }

                }
                else if (!textBox1.Text.Equals(""))
                {
                    if (!textBox2.Text.Equals(""))
                    {
                        if (!textBox3.Text.Equals(""))
                        {
                            if (!textBox4.Text.Equals(""))
                            {
                                if (!textBox5.Text.Equals(""))
                                {
                                    if (!textBox6.Text.Equals(""))
                                    {

                                        if (pictureBoxPoza.ImageLocation != null)
                                        {
                                            using (IMDBEntities context = new IMDBEntities())
                                            {
                                                if (InsertcheckBox.Checked == true)
                                                {
                                                    DateTime a = Convert.ToDateTime(textBox3.Text);
                                                    context.InsertDirectorWithPhoto(textBox1.Text, textBox2.Text, a, textBox4.Text, textBox5.Text, textBox6.Text, ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                    context.SaveChanges();
                                                    MessageBox.Show("Regizor adaugat cu succes (cu poza)!");
                                                }
                                                else if (UpdateCheckBox.Checked == true)
                                                {
                                                    if (!label11.Text.Equals("ID*:"))
                                                    {
                                                        var results = (from c in context.Regizoris
                                                                       where c.Nume == textBox7.Text
                                                                       select c).FirstOrDefault();
                                                        if (results == null)
                                                        {
                                                            MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                                                        }
                                                        else
                                                        {
                                                            DateTime a = Convert.ToDateTime(textBox3.Text);
                                                            context.UpdateDirectorbyName(textBox7.Text, textBox1.Text, textBox2.Text, a, textBox4.Text, textBox5.Text, textBox6.Text, ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                            context.SaveChanges();
                                                            MessageBox.Show("Regizor updatat cu succes!");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        int b = Convert.ToInt32(textBox7.Text);
                                                        var results = (from c in context.Regizoris
                                                                       where c.ID_Regizor == b
                                                                       select c).FirstOrDefault();
                                                        if (results == null)
                                                        {
                                                            MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                                                        }
                                                        else
                                                        {
                                                            DateTime a = Convert.ToDateTime(textBox3.Text);
                                                            context.UpdateDirectorbyID(b, textBox1.Text, textBox2.Text, a, textBox4.Text, textBox5.Text, textBox6.Text, ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                            context.SaveChanges();
                                                            MessageBox.Show("Regizor updatat cu succes!");
                                                        }
                                                    }
                                                }
                                                else MessageBox.Show("Selecteaza ceea ce vrei sa faci! Insert, update, delete...");
                                            }

                                        }
                                        else MessageBox.Show("Trebuie sa introduci si o poza!");
                                    }
                                    else MessageBox.Show("Trebuie sa introduci nationalitatea!");
                                }
                                else MessageBox.Show("Trebuie sa introduci tara");
                            }
                            else MessageBox.Show("Trebuie sa introduci orasul natal");
                        }
                        else MessageBox.Show("Trebuie sa introduci anul nasterii!");
                    }
                    else MessageBox.Show("Trebuie sa introduci un prenume!");
                }
                else MessageBox.Show("Trebuie sa introduci un nume!");

            } //asta e pt regizori
            else if (label2.Text == "Nume" && label7.Text == "An aparitie" && label6.Text == "Nota")
            {
                if (DeletecheckBox.Checked == true)
                {
                    using (IMDBEntities con = new IMDBEntities())
                    {
                        if (label11.Text.Equals("ID*:"))
                        {
                            int b = Convert.ToInt32(textBox7.Text);
                            var results = (from c in con.Filmes
                                           where c.ID_Film == b
                                           select c).FirstOrDefault();
                            if (results == null)
                            {
                                MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                            }
                            else
                            {
                                con.DeleteMoviesbyID(b);
                                con.SaveChanges();
                                MessageBox.Show("Film sters cu succes!");
                            }
                        }
                        else
                        {
                            var results = (from c in con.Filmes
                                           where c.Nume == textBox7.Text
                                           select c).FirstOrDefault();
                            if (results == null)
                            {
                                MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                            }
                            else
                            {
                                con.DeleteMoviesByName(textBox7.Text);
                                con.SaveChanges();
                                MessageBox.Show("Film sters cu succes!");
                            }
                        }
                    }
                }
                else if(!textBox1.Text.Equals(""))
                {
                    if(!textBox2.Text.Equals(""))
                    {
                        if (!textBox3.Text.Equals(""))
                        {
                            if (pictureBoxPoza.ImageLocation != null)
                            {
                                using (IMDBEntities context = new IMDBEntities())
                                {
                                    if (InsertcheckBox.Checked == true)
                                    {
                                        int a = Convert.ToInt32(textBox2.Text);
                                        
                                        context.InsertMovies(textBox1.Text, a,textBox3.Text, ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                        context.SaveChanges();
                                        MessageBox.Show("Film adaugat cu succes (cu poza)!");
                                    }
                                    else if (UpdateCheckBox.Checked == true)
                                    {
                                        if (!label11.Text.Equals("ID*:"))
                                        {
                                            var results = (from c in context.Filmes
                                                           where c.Nume == textBox7.Text
                                                           select c).FirstOrDefault();
                                            if (results == null)
                                            {
                                                MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                                            }
                                            else
                                            {
                                                int a = Convert.ToInt32(textBox2.Text);
                                                //double c = Convert.ToDouble(textBox3.Text);
                                                context.UpdateMoviesbyName(textBox7.Text, textBox1.Text, a, textBox3.Text,  ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                context.SaveChanges();
                                                MessageBox.Show("Film updatat cu succes!");
                                            }
                                        }
                                        else
                                        {
                                            int b = Convert.ToInt32(textBox7.Text);
                                            var results = (from c in context.Filmes
                                                           where c.ID_Film == b
                                                           select c).FirstOrDefault();
                                            if (results == null)
                                            {
                                                MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                                            }
                                            else
                                            {
                                                int a = Convert.ToInt32(textBox2.Text);
                                                //double c = Convert.ToDouble(textBox3.Text);
                                                context.UpdateMoviesbyID(b, textBox1.Text, a, textBox3.Text,  ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                context.SaveChanges();
                                                MessageBox.Show("Film updatat cu succes!");
                                            }
                                        }
                                    }
                                    else MessageBox.Show("Selecteaza ceea ce vrei sa faci! Insert, update, delete...");
                                }

                            }
                            else MessageBox.Show("Trebuie sa introduceti o fotografie!");
                        }
                        else MessageBox.Show("Trebuie sa introduci o nota!");
                    }
                    else MessageBox.Show("Trebuie sa introduci anul aparitiei!");
                }
                else MessageBox.Show("Trebuie sa introduci un nume!");
            }  //asta e pt filme
            else if(label2.Text == "Nume" && label7.Text == "An aparitie" && label6.Text == "Numar sezoane")
            {
                if (DeletecheckBox.Checked == true)
                {
                    using (IMDBEntities con = new IMDBEntities())
                    {
                        if (label11.Text.Equals("ID*:"))
                        {
                            int b = Convert.ToInt32(textBox7.Text);
                            var results = (from c in con.Seriales
                                           where c.ID_Serial == b
                                           select c).FirstOrDefault();
                            if (results == null)
                            {
                                MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                            }
                            else
                            {
                                con.DeleteTVSeriesById(b);
                                con.SaveChanges();
                                MessageBox.Show("Serial sters cu succes!");
                            }
                        }
                        else
                        {
                            var results = (from c in con.Seriales
                                           where c.Nume == textBox7.Text
                                           select c).FirstOrDefault();
                            if (results == null)
                            {
                                MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                            }
                            else
                            {
                                con.DeleteTVSeriesByName(textBox7.Text);
                                con.SaveChanges();
                                MessageBox.Show("Serial sters cu succes!");
                            }
                        }
                    }
                }
                else if (!textBox1.Text.Equals(""))
                {
                    if (!textBox2.Text.Equals(""))
                    {
                        if (!textBox3.Text.Equals(""))
                        {
                            if (!textBox4.Text.Equals(""))
                            {
                                if (!textBox5.Text.Equals(""))
                                {
                                    
                                        if (pictureBoxPoza.ImageLocation != null)
                                        {
                                            using (IMDBEntities context = new IMDBEntities())
                                            {
                                                if (InsertcheckBox.Checked == true)
                                                {
                                                int a = Convert.ToInt32(textBox2.Text);
                                                int c = Convert.ToInt32(textBox3.Text);
                                                int d = Convert.ToInt32(textBox4.Text);
                                                    context.InsertTVSeries(textBox1.Text, a, c, d, textBox5.Text, ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                    context.SaveChanges();
                                                    MessageBox.Show("Seerial adaugat cu succes (cu poza)!");
                                                }
                                                else if (UpdateCheckBox.Checked == true)
                                                {
                                                    if (!label11.Text.Equals("ID*:"))
                                                    {
                                                        var results = (from c in context.Seriales
                                                                       where c.Nume == textBox7.Text
                                                                       select c).FirstOrDefault();
                                                        if (results == null)
                                                        {
                                                            MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                                                        }
                                                        else
                                                        {
                                                        int a = Convert.ToInt32(textBox2.Text);
                                                        int c = Convert.ToInt32(textBox3.Text);
                                                        int d = Convert.ToInt32(textBox4.Text);
                                                        context.UpdateTVSeriesbyName(textBox7.Text, textBox1.Text,a,c,d , textBox5.Text, ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                            context.SaveChanges();
                                                            MessageBox.Show("Serial updatat cu succes!");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        int b = Convert.ToInt32(textBox7.Text);
                                                        var results = (from c in context.Seriales
                                                                       where c.ID_Serial == b
                                                                       select c).FirstOrDefault();
                                                        if (results == null)
                                                        {
                                                            MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                                                        }
                                                        else
                                                        {
                                                        int a = Convert.ToInt32(textBox2.Text);
                                                        int c = Convert.ToInt32(textBox3.Text);
                                                        int d = Convert.ToInt32(textBox4.Text);
                                                        context.UpdateTVSeriesbyID(b, textBox1.Text, a, c, d, textBox5.Text, ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                        context.SaveChanges();
                                                            MessageBox.Show("Serial updatat cu succes!");
                                                        }
                                                    }
                                                }
                                                else MessageBox.Show("Selecteaza ceea ce vrei sa faci! Insert, update, delete...");
                                            }

                                        }
                                        else MessageBox.Show("Trebuie sa introduci si o poza!");
                                    
                                }
                                else MessageBox.Show("Trebuie sa introduci nota!");
                            }
                            else MessageBox.Show("Trebuie sa introduci numarul total de episoade");
                        }
                        else MessageBox.Show("Trebuie sa introduci numarul de sezoane!");
                    }
                    else MessageBox.Show("Trebuie sa introduci anul aparitiei!");
                }
                else MessageBox.Show("Trebuie sa introduci un nume!");
            } //asta e pt seriale
            else if (label2.Text == "Username:" && label7.Text == "Password:" && label6.Text == "Re-typePassword:")
            {
                if (DeletecheckBox.Checked == true)
                {
                    using (IMDBEntities con = new IMDBEntities())
                    {
                        if (label11.Text.Equals("ID*:"))
                        {
                            int b = Convert.ToInt32(textBox7.Text);
                            var results = (from c in con.Users
                                           where c.ID_User == b
                                           select c).FirstOrDefault();
                            if (results == null)
                            {
                                MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                            }
                            else
                            {
                                con.DeleteUserById(b);
                                con.SaveChanges();
                                MessageBox.Show("User sters cu succes!");
                            }
                        }
                        else
                        {
                            var results = (from c in con.Users
                                           where c.Username == textBox7.Text
                                           select c).FirstOrDefault();
                            if (results == null)
                            {
                                MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                            }
                            else
                            {
                                con.DeleteUserByName(textBox7.Text);
                                con.SaveChanges();
                                MessageBox.Show("User sters cu succes!");
                            }
                        }
                    }
                }
                else if (!textBox1.Text.Equals(""))
                {
                    using (var context = new IMDBEntities())
                    {
                        var ResultUsername = (from reus in context.Users
                                              where reus.Username.Contains(textBox1.Text)
                                              select reus).FirstOrDefault();
                        if ((ResultUsername == null)  || UpdateCheckBox.Checked==true)
                        {
                            if (!textBox2.Text.Equals(""))
                            {
                                if (!textBox3.Text.Equals(""))
                                {
                                    if (textBox2.Text.Equals(textBox3.Text))
                                    {
                                        if (!textBox4.Text.Equals(""))
                                        {
                                            var ResultEmail = (from reem in context.Users
                                                               where reem.E_mail.Contains(textBox4.Text)
                                                               select reem).FirstOrDefault();
                                            if (ResultEmail == null || UpdateCheckBox.Checked == true)
                                            {
                                                if (!textBox5.Text.Equals(""))
                                                {
                                                    var ResultPhoneNumber = (from rnp in context.Users
                                                                             where rnp.PhoneNumber.Equals(textBox5.Text)
                                                                             select rnp).FirstOrDefault();
                                                    if (ResultPhoneNumber == null || UpdateCheckBox.Checked == true)
                                                    {
                                                        if (pictureBoxPoza.ImageLocation != null)
                                                        {
                                                            string rights;
                                                            if (checkBoxMakeAdmin.Checked == true)
                                                                rights = "admin";
                                                            else rights = "user";
                                                            if (InsertcheckBox.Checked == true)
                                                            {
                                                                context.InsertUser(textBox1.Text, textBox2.Text, textBox4.Text,textBox5.Text, rights, DateTime.Now, ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                                context.SaveChanges();
                                                                MessageBox.Show("User adaugat cu succes (cu poza)!");
                                                            }
                                                            else if (UpdateCheckBox.Checked == true)
                                                            {
                                                                if (checkBoxMakeAdmin.Checked == true)
                                                                    rights = "admin";
                                                                else rights = "user";
                                                                if (!label11.Text.Equals("ID*:"))
                                                                {
                                                                    var results = (from c in context.Users
                                                                                   where c.Username == textBox7.Text
                                                                                   select c).FirstOrDefault();
                                                                    if (results == null)
                                                                    {
                                                                        MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                                                                    }
                                                                    else
                                                                    {

                                                                        context.UpdateUserbyName(textBox7.Text, textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text, rights, ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                                        context.SaveChanges();
                                                                        MessageBox.Show("User updatat cu succes!");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    int b = Convert.ToInt32(textBox7.Text);
                                                                    var results = (from c in context.Regizoris
                                                                                   where c.ID_Regizor == b
                                                                                   select c).FirstOrDefault();
                                                                    if (results == null)
                                                                    {
                                                                        MessageBox.Show("Nu exista nici o inregistrare care sa corespunda numelui tastat!");
                                                                    }
                                                                    else
                                                                    {

                                                                        context.UpdateUserbyID(b, textBox1.Text, textBox2.Text, textBox4.Text,textBox5.Text, rights, ConvertFiletoByte(pictureBoxPoza.ImageLocation));
                                                                        context.SaveChanges();
                                                                        MessageBox.Show("User updatat cu succes!");
                                                                    }
                                                                }
                                                            }
                                                            else MessageBox.Show("Trebuie sa alegi o optiune: Insert,Update,Delete..");
                                                        }
                                                        else MessageBox.Show("Trebuie sa introduci si o poza!");
                                                    }
                                                    else MessageBox.Show("Acest numar de telefon a mai fost introdus! Te rugam sa introduci numarul tau de telefon!");
                                                }
                                                else MessageBox.Show("Trebuie sa introduci un numar de telefon!");
                                            }
                                            else MessageBox.Show("Aceasta adresa de E-mail a mai fost introdusa! Te rugam sa introduci alta adresa!");
                                        }
                                        else MessageBox.Show("Trebuie sa introduci o adresa de E-mail!");
                                    }
                                    else MessageBox.Show("Parola din cele doua campuri nu corespund! Te rugam sa introduci o parola valida in ambele campuri!");
                                }
                                else MessageBox.Show("Trebuie sa introduci parola din nou!");
                            }
                            else MessageBox.Show("Trebuie sa introduci o parola!");
                        }
                        else MessageBox.Show("Acest nume de user a mai fost folosit! Te rugam sa introduci alt nume!");
                    }
                }
                else MessageBox.Show("Trebuie sa introduci un nume de user!");
            } //asta e pt useri

        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select a photo!";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif|AllFiles|*.*";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBoxPoza.ImageLocation = ofd.FileName;
            }
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            label12.ForeColor = Color.CornflowerBlue;
            //Font myFont = new Font("Gill Sans Ultra Bold", 11, FontStyle.Underline | FontStyle.Bold);
            //label12.Font = myFont;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = Color.Black;
           // Font myFont = new Font("Gill San Ultra Bold", 11,FontStyle.Bold);
          //  label12.Font = myFont;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label11.Text = "ID*:";
            textBox7.Text = "";
        }
    }
}
