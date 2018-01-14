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
        public AdminPage(string AdminName, IMDProject startpage)
        {
            InitializeComponent();
            AdminNameLabel.Text = AdminName;
            ParentPageAdminPage = startpage;
            MemberUserName = AdminName;
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
            label6.Text = "Anul Nasterii";
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
        }

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
            label7.Text = "Prenume";
            label7.Visible = true;
            textBox2.Visible = true;
            label6.Text = "Data Nasterii";
            label6.Visible = true;
            textBox3.Visible = true;
            label5.Text = "Nume";
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
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            label2.Text = "Nume";
            label2.Visible = true;
            textBox1.Visible = true;
            label7.Text = "An aparitie";
            label7.Visible = true;
            textBox2.Visible = true;
            label6.Text = "Nota";
            label6.Visible = true;
            textBox3.Visible = true;
             label5.Visible = false;
            textBox4.Visible = false;
            label4.Visible = false;
            textBox5.Visible = false;
            label3.Visible = false;
            textBox6.Visible = false;
            labelpoza.Visible = true;
            pictureBoxPoza.Visible = true;
            buttonCauta.Visible = true;
            buttonSalveaza.Visible = true;
        }

        private void AddTVSeriesButton_Click(object sender, EventArgs e)
        {
            label2.Text = "Nume";
            label2.Visible = true;
            textBox1.Visible = true;
            label7.Text = "An aparitie";
            label7.Visible = true;
            textBox2.Visible = true;
            label6.Text = "Numar sezoane";
            label6.Visible = true;
            textBox3.Visible = true;
            label5.Text = "Total episoade";
            label5.Visible = true;
            textBox4.Visible = true;
            label4.Text = "Nota";
            label4.Visible = true;
            textBox5.Visible = true;            
            label3.Visible = false;
            textBox6.Visible = false;
            labelpoza.Visible = true;
            pictureBoxPoza.Visible = true;
            buttonCauta.Visible = true;
            buttonSalveaza.Visible = true;
        }

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
        }

        private void UpdateCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            InsertcheckBox.Checked = false;
            DeletecheckBox.Checked = false;
        }

        private void DeletecheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            InsertcheckBox.Checked = false;
            UpdateCheckBox.Checked = false;
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            label2.Text = "Username:";
            label2.Visible = true;
            textBox1.Visible = true;
            label7.Text = "Password:";
            label7.Visible = true;
            textBox2.Visible = true;
            textBox2.PasswordChar = '*';
            label6.Text = "Re-typePassword:";
            label6.Visible = true;
            textBox3.Visible = true;
            textBox3.PasswordChar = '*';
            label5.Text = "E-mail:";
            label5.Visible = true;
            textBox4.Visible = true;
            label4.Text = "PhoneNumber:";
            label4.Visible = true;
            textBox5.Visible = true;
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
            if(label2.Text == "Nume" &&  label7.Text == "Prenume" &&  label6.Text == "Anul Nasterii" )
            {
                
                    if (!textBox1.Text.Equals(""))
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
                                                        
                                                    }
                                                    else if (DeletecheckBox.Checked == true)
                                                    {

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
                                                    else if(UpdateCheckBox.Checked==true)
                                                    {
                                                    MessageBox.Show("Selecteaza o imagine mai intai!");
                                                    }
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
    }
}
