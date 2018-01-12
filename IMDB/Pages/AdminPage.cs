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
        private string continutTextbox1;

        public AdminPage(string AdminName, IMDProject startpage)
        {
            InitializeComponent();
            AdminNameLabel.Text = AdminName;
            ParentPageAdminPage = startpage;
            MemberUserName = AdminName;
            continutTextbox1 = textBox1.Text;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            
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
            label5.Text = "Nume";
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
            if(label2.Text == "Nume" &&  label7.Text == "Prenume" &&  label6.Text == "Data de Nastere")
            {
                if(DeletecheckBox.Checked==true)
                {
                    using (IMDBEntities con=new IMDBEntities())
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
                                           using (IMDBEntities context=new IMDBEntities())
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
                                                        {   var results = (from c in context.Actoris
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
                                                                       where c.ID_Actor ==b 
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
            else if(label2.Text == "Nume" && label7.Text == "Prenume" && label6.Text == "Data Nasterii")
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

            }


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
