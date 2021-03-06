﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;

namespace IMDB
{
    public partial class SignUp : Form
    {
        private Form ParentForm;

        public SignUp(Form ParentParameter)
        {
            InitializeComponent();
            ParentForm = ParentParameter;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            PanelSignUp.BackColor = Color.FromArgb(50, 242, 85, 44);
            panel2.BackColor = Color.FromArgb(50, 242, 85, 44);
           // textBoxName.BackColor = Color.FromArgb(50, 242, 85, 44);
        }

        private void buttonPowerOffTop_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private string verify(string username,string email,string phonenumeber)
        {
            if (!textBoxUserName.Text.Equals(""))
            {
                if (!textBoxPassword.Text.Equals(""))
                {
                    if (!textBoxReEnterPass.Text.Equals(""))
                    {
                        if (!textBoxPhoneNR.Text.Equals(""))
                        {
                            if (textBoxPhoneNR.Text.Length != 10)
                                return "Please enter a correct number phone!";
                            if (!textBoxEmail.Text.Equals(""))
                            {
                                if (!textBoxEmail.Text.Contains("@"))
                                    return "Please introduce a valid E-mail";
                            }
                            else return "Please enter an E-mail address";

                        }
                        else return "Please enter a phone number";
                    }
                    else return "Please re-enter the password";
                }
                else return "Please enter a password";
            }
            else return "Please enter an username";


            using (var context= new IMDBEntities())
            {
                var resultname = (from a in context.Users
                                  where a.Username.Equals(username)
                                  select a).FirstOrDefault();
                var resultemail = (from b in context.Users
                                  where b.E_mail.Equals(email)
                                  select b).FirstOrDefault();
                var resultphonenumber = (from c in context.Users
                                  where c.PhoneNumber.Equals(phonenumeber)
                                  select c).FirstOrDefault();
                if(resultname!=null)
                {
                    return "Users exists in our database. Please try other username";
                }
                if(resultemail!=null)
                {
                    return "E-mail is already used! Please try another E-mail address";
                }
                if(resultphonenumber!=null)
                {
                    return "Phone number is already used! Please try another phonenumber";
                }
                if(!textBoxPassword.Text.Equals(textBoxReEnterPass.Text))
                {
                    return "The content from password field and re-enter password field are not the same! Please try re-type password";
                }
            }

                return "OK";
        }

        public string CalculateMD5Hash(string input)

        {

            // step 1, calculate MD5 hash from input

            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);


            // step 2, convert byte array to hex string

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {

                sb.Append(hash[i].ToString("x2"));

            }

            return sb.ToString();

        }



        private void button2_Click(object sender, EventArgs e) //pt creare cont
        {
            //if (verify(textBoxUserName.Text, textBoxEmail.Text,textBoxPhoneNR.Text).Equals("OK"))
            //{
            //    var context = new IMDBEntities();
            //    var newUser = new User
            //    {
            //        Username = textBoxUserName.Text,
            //        Password = CalculateMD5Hash(textBoxPassword.Text),
            //        E_mail = textBoxEmail.Text,
            //        PhoneNumber = textBoxPhoneNR.Text,
            //        Rights = "user",
            //        DateofRegister = DateTime.Now
            //    };
            //    context.Users.Add(newUser);
            //    context.SaveChanges();
            //    MessageBox.Show("Welcome to our site!");

            //}
            //else MessageBox.Show(verify(textBoxUserName.Text, textBoxEmail.Text, textBoxPhoneNR.Text));
            StartOwnTransactionWithinContext();
        }

        private void StartOwnTransactionWithinContext()
        {
            using (var context = new IMDBEntities())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {

                        if (verify(textBoxUserName.Text, textBoxEmail.Text, textBoxPhoneNR.Text).Equals("OK"))
                        {
                          
                            var newUser = new User
                            {
                                Username = textBoxUserName.Text,
                                Password = CalculateMD5Hash(textBoxPassword.Text),
                                E_mail = textBoxEmail.Text,
                                PhoneNumber = textBoxPhoneNR.Text,
                                Rights = "user",
                                DateofRegister = DateTime.Now
                            };
                            context.Users.Add(newUser);
                            
                            
                        }
                        else MessageBox.Show(verify(textBoxUserName.Text, textBoxEmail.Text, textBoxPhoneNR.Text));





                        context.SaveChanges();
                        dbContextTransaction.Commit();
                        MessageBox.Show("Welcome to our site!");

                    }

                    catch (Exception)
                    {
                        Console.WriteLine("Nu exista nume!!!");
                        dbContextTransaction.Rollback();
                    }
                }
            }
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
