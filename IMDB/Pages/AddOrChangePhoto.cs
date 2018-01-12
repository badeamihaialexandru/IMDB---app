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

        private byte[] ConvertFiletoByte(string sPath)
        {
            byte[] data = null;
            FileInfo finfo= new FileInfo(sPath);
            long numBytes = finfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            try
            {
                if (!comboBoxTable.Text.Equals("Alege o tabela..."))
                {
                    int lengthtext = textBoxID.TextLength;
                    string digit = "0123456789";
                    for(int i=0;i<lengthtext;i++)
                    {
                        if(!digit.Contains(textBoxID.Text[i]))                          
                            lengthtext = 0;                        
                    }
                    if (lengthtext != 0)
                    {
                        using (IMDBEntities context = new IMDBEntities())
                        {
                            if (comboBoxTable.Text.Equals("Actori"))
                            {
                                int x = Convert.ToInt32(textBoxID.Text);
                                var result = (from b in context.Actoris
                                              where b.ID_Actor.Equals(x)
                                              select b).First();
                                if (result != null)
                                {
                                    result.Photo = ConvertFiletoByte(this.pictureBoxPhoto.ImageLocation);
                                    context.SaveChanges();
                                    MessageBox.Show("Fotografie adaugata cu succes!");
                                }
                                else
                                {
                                    MessageBox.Show("Acest Id nu apartine nici unei inregistrari!");
                                }
                            }
                            else if (comboBoxTable.Text.Equals("Filme"))
                            {
                                int x = Convert.ToInt32(textBoxID.Text);
                                var result = (from b in context.Filmes
                                              where b.ID_Film.Equals(x)
                                              select b).First();
                                if (result != null)
                                {
                                    result.Photo = ConvertFiletoByte(this.pictureBoxPhoto.ImageLocation);
                                    context.SaveChanges();
                                    MessageBox.Show("Fotografie adaugata cu succes!");
                                }
                                else
                                {
                                    MessageBox.Show("Acest Id nu apartine nici unei inregistrari!");
                                }
                            }
                            else if (comboBoxTable.Text.Equals("Regizori"))
                            {
                                int x = Convert.ToInt32(textBoxID.Text);
                                var result = (from b in context.Regizoris
                                              where b.ID_Regizor.Equals(x)
                                              select b).First();
                                if (result != null)
                                {
                                    result.Photo = ConvertFiletoByte(this.pictureBoxPhoto.ImageLocation);
                                    context.SaveChanges();
                                    MessageBox.Show("Fotografie adaugata cu succes!");
                                }
                                else
                                {
                                    MessageBox.Show("Acest Id nu apartine nici unei inregistrari!");
                                }
                            }
                            else if (comboBoxTable.Text.Equals("Seriale"))
                            {
                                int x = Convert.ToInt32(textBoxID.Text);
                                var result = (from b in context.Seriales
                                              where b.ID_Serial.Equals(x)
                                              select b).First();
                                if (result != null)
                                {
                                    result.Photo= ConvertFiletoByte(this.pictureBoxPhoto.ImageLocation);
                                    context.SaveChanges();
                                    MessageBox.Show("Fotografie adaugata cu succes!");
                                }
                                else
                                {
                                    MessageBox.Show("Acest Id nu apartine nici unei inregistrari!");
                                }
                            }
                            else if (comboBoxTable.Text.Equals("Users"))
                            {
                                int x = Convert.ToInt32(textBoxID.Text);
                                var result = (from b in context.Users
                                              where b.ID_User.Equals(x)
                                              select b).First();
                                if (result != null)
                                {
                                    result.Photo = ConvertFiletoByte(this.pictureBoxPhoto.ImageLocation);
                                    context.SaveChanges();
                                    MessageBox.Show("Fotografie adaugata cu succes!");
                                }
                                else
                                {
                                    MessageBox.Show("Acest Id nu apartine nici unei inregistrari!");
                                }
                            }
                        }
                    }
                    else MessageBox.Show("Please insert correct ID!");
                }
                else MessageBox.Show("Selecteaza o tabela!");
            }
            catch
            {
                MessageBox.Show("Can't add this file in " + comboBoxTable.Text + " table!");
            }

        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select a photo!";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif|AllFiles|*.*";
            ofd.Multiselect = false;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBoxPhoto.ImageLocation = ofd.FileName;
            }
        }
    }
}
