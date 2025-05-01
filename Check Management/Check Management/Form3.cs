using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using Microsoft.Win32;

namespace Check_Management
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string s = "Enter the code correctly.";
        void persian()
        {
            فارسیToolStripMenuItem.Checked = true;
            englishToolStripMenuItem.Checked = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label8.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            glassButton2.Text = ":دریافت کد";
            label4.Text = ".کد به ایمیل شما ارسال شد";
            glassButton1.Text = "ثبت نام";
            tologin = "عملیات با موفقیت انجام شد.آیا میخواهید به صفحه ی ورود بروید؟";
            label10.Text = "رمز عبور ها با یک دیگر مطابقت ندارد ";
            tologin1 = "پیام سیستم";
            sign = "نام کاربری تکراری است";
            File.WriteAllText("language.txt", "2");
            s = "کد را درست وارد کنید";
        }
        void english()
        {
            فارسیToolStripMenuItem.Checked = false;
            englishToolStripMenuItem.Checked = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label8.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            glassButton2.Text = "Get code";
            label4.Text = "The code has been sent to your email.";
            glassButton1.Text = "Sign Up";
            tologin = "Operation successful. Would you like to proceed to the login page?";
            label10.Text = "Passwords do not match";
            tologin1 = "System message";
            File.WriteAllText("language.txt", "1");
            s = "Enter the code correctly.";
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string language = File.ReadAllText("language.txt");
            if (language == "1")
            {
                english();
            }
            else
                persian();
        }
        string tologin = "Operation successful. Would you like to proceed to the login page?";
        string tologin1 = "System message";
        string sign = "The username is duplicated";
        private void فارسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            persian();

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            english();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string email = textBox3.Text;
            if(email.IndexOf("@gmail.com")>-1)
            {
                textBox4.Visible = true;
                glassButton2.Enabled = true;
            }
        }
        int f;
        private void glassButton2_Click(object sender, EventArgs e)
        {
            Random s = new Random();
                f = s.Next(5555, 9999);
                string subject = "Verification code:  " + f.ToString();
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("chek3461@gmail.com");
                mail.To.Add(textBox3.Text); // ایمیل گیرنده
                mail.Subject = "cood"; // موضوع ایمیل
                mail.Body = subject; // متن ایمیل

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("chek3461@gmail.com", "e k s m v b z m o y a n v n o i");
                smtp.EnableSsl = true;
                smtp.Send(mail);

               if( MessageBox.Show("ایمیل ارسال شد!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
               {
                   label4.Visible = true;
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ارسال ایمیل: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if(f.ToString().IndexOf(textBox4.Text)>-1)
            {

            }
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {

            if (textBox4.Text == f.ToString())
            {
                string ap = textBox1.Text;

                string keypath = string.Format(@"Software\{0}", ap);
                string valunameus = "username";
                string username = textBox1.Text;
                string valunamepas = "password";
                string password = textBox2.Text;
                string valunameema = "email";
                string email = textBox3.Text;
                RegistryKey Key;
                if ((Key = Registry.CurrentUser.OpenSubKey(keypath)) != null)
                {
                    MessageBox.Show(sign, tologin1);
                    return;
                }
                Key = Registry.CurrentUser.CreateSubKey(keypath);
                Key.SetValue(valunameus, username);

                Key.SetValue(valunamepas, password);

                Key.SetValue(valunameema, email);

                if (MessageBox.Show(tologin, tologin1, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Form2 o = new Form2();
                    this.Hide();
                    o.ShowDialog();
                }

                glassButton1.Enabled = false;
                glassButton2.Enabled = false;
                textBox4.Visible = false;
                label4.Visible = false;


                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
                MessageBox.Show(s, tologin1);

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(!(e.KeyCode>=Keys.A&&e.KeyCode<=Keys.Z||e.KeyCode==Keys.Back||e.KeyCode>=Keys.D0&&e.KeyCode<=Keys.D9))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z || e.KeyCode == Keys.Back || e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z || e.KeyCode == Keys.Back || e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox5.Text)
            {
                glassButton1.Enabled = true;
                textBox3.ReadOnly = false;
                label10.Visible = false;
            }
            else
            {
                glassButton1.Enabled = false;
                textBox3.ReadOnly = true;
                label10.Visible = true;

            }
             if ( textBox2.Text == "" && textBox5.Text == "")
             {
                 glassButton1.Enabled = false;
                 textBox3.ReadOnly = true;
                 label10.Visible = false;
             }
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            label10.Visible = false;
            textBox1.Focus();
        }

        private void Form3_Leave(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
