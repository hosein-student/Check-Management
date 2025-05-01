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
using System.Net.Mail;
using System.Net;
using Microsoft.Win32;
namespace Check_Management
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string messagelog = "The login information is invalid";
        string kk = "Please enter the email you registered with.";
        void persian()
        {
            kk = "لطفا ایمیلی که با آن ثبت نام کرده اید را وارد کنید ";
             messagelog = "نام کاربری وجود ندارد";
            label3.Visible = false;
            label4.Visible = true;
            label1.Visible = false;
            label2.Visible = true;
            glassButton1.Text = "دریافت";
            englishToolStripMenuItem.Checked = false;
            فارسیToolStripMenuItem.Checked = true;
            File.WriteAllText("language.txt", "2");

        }
        void english()
        {
            kk = "Please enter the email you registered with.";
            messagelog = "Username does not exist";
            label3.Visible = true;
            label4.Visible = false;
            label1.Visible = true;
            label2.Visible = false;
            glassButton1.Text = "receive";
            englishToolStripMenuItem.Checked = true;
            فارسیToolStripMenuItem.Checked = false;
            File.WriteAllText("language.txt", "1");
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            

            string language = File.ReadAllText("language.txt");
            if (language == "1")
            {
                english();
            }
            else
            {
                persian();
            }
        }

        private void فارسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            persian();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            english();
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            string usr = "", pasw = "", emal = "";
            string keypath = string.Format(@"Software\{0}", textBox2.Text);
            RegistryKey keu = Registry.CurrentUser.OpenSubKey(keypath);

            if (keu != null)
            {
                usr = keu.GetValue("username").ToString();
                pasw = keu.GetValue("password").ToString();
                emal = keu.GetValue("email").ToString();


            }
            else
            {
                MessageBox.Show(messagelog);
                return;
            }

            if (textBox1.Text == emal)
            {
                string subject = string.Format("User Name: {0}{1}Password: {2}", usr, Environment.NewLine, pasw);
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("chek3461@gmail.com");
                    mail.To.Add(textBox1.Text); // ایمیل گیرنده
                    mail.Subject = "return information"; // موضوع ایمیل
                    mail.Body = subject; // متن ایمیل

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("chek3461@gmail.com", "e k s m v b z m o y a n v n o i");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);

                    if (MessageBox.Show("ایمیل ارسال شد!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در ارسال ایمیل: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(kk);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if (email.IndexOf("@gmail.com") > -1)
            {
               
                glassButton1.Visible = true;
            }
        }

        private void Form5_Shown(object sender, EventArgs e)
        {
            textBox2.Focus();
        }
    }
}
