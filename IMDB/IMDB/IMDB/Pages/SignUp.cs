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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            
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

        private void button2_Click(object sender, EventArgs e) //pt creare cont
        {
            if (verify(textBoxUserName.Text, textBoxEmail.Text,textBoxPhoneNR.Text).Equals("OK"))
            {
                var context = new IMDBEntities();
                var newUser = new User
                {
                    Username = textBoxUserName.Text,
                    Password = textBoxPassword.Text,
                    E_mail = textBoxEmail.Text,
                    PhoneNumber = textBoxPhoneNR.Text,
                    Rights = "user",
                    DateofRegister = DateTime.Now
                };
                context.Users.Add(newUser);
                context.SaveChanges();
                MessageBox.Show("Welcome to our site!");

            }
            else MessageBox.Show(verify(textBoxUserName.Text, textBoxEmail.Text, textBoxPhoneNR.Text));
        }
    }
}
