using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;


namespace Check_Management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void persian()
        {
            فارسیToolStripMenuItem.Checked = true;
            englishToolStripMenuItem.Checked = false;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = true;
            label6.Visible = true;
            checkBox1.Text = "نمایش رمز عبور";
            btnLogin.Text = "ورود";
            glassButton1.Text = "ثبت نام";
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            messagelog = "اطلاعات ورود نامعتبر است";
            File.WriteAllText("language.txt", "2");
            label3.Text = "رمز را فراموش کردید؟";

        }
        void english()
        {فارسیToolStripMenuItem.Checked = false;
            englishToolStripMenuItem.Checked = true;
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = false;
            label6.Visible = false;
            checkBox1.Text = "Show Password";
            btnLogin.Text = "Login";
            checkBox1.CheckAlign = ContentAlignment.MiddleLeft;
            glassButton1.Text = "Sign Up";
            messagelog = "The login information is invalid";
            File.WriteAllText("language.txt", "1");
            label3.Text = "Forgot password?";

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '+';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        string messagelog = "The login information is invalid";
        private void فارسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            persian();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            english();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public Form1 sin;
        private void glassButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sin.Show();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string keypath =string.Format( @"Software\{0}", textBox2.Text);
            RegistryKey keu = Registry.CurrentUser.OpenSubKey(keypath);
            
            if(keu!=null)
            {
                string usr = keu.GetValue("username").ToString();
                string pasw = keu.GetValue("password").ToString();
                if(usr==textBox2.Text&&pasw==textBox1.Text)
                {
                    Form4 form4 = new Form4();
                    form4.usersave = textBox2.Text;
                    this.Hide();
                    form4.Show();


                }
                else
                {
                    MessageBox.Show(messagelog);
                    textBox1.Clear();
                    textBox2.Clear();
                }
                        
            }
            else
                MessageBox.Show(messagelog);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             string language = File.ReadAllText("language.txt");
             if (language == "1")
             {
                 english();
             }
             else
                 persian();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
                btnLogin.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
                btnLogin.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
        
    }
}
