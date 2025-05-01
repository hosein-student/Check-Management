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

namespace Check_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
     void persian()
        {
            فارسیToolStripMenuItem.Checked = true;
            englishToolStripMenuItem.Checked = false;
            btnlog.Text = "ورود";
            btnsign.Text = "ثبت نام";
            File.WriteAllText("language.txt", "2");
         
        }
        void english()
        {
            فارسیToolStripMenuItem.Checked = false;
            englishToolStripMenuItem.Checked = true;
            btnlog.Text = "Login";
            btnsign.Text = "Sign Up";
            
            
                File.WriteAllText("language.txt", "1");
            
            

        }

        private void فارسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            persian();

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            english();
        }
       
        private void btnlog_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.sin = this;
            this.Hide();
            s.Show();


        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            Form3 ff = new Form3();
            this.Hide();
            ff.Show();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!(File.Exists("language.txt")))
            {
                File.WriteAllText("language.txt", "1");
            }
            else
            {
                string language = File.ReadAllText("language.txt");
                if(language=="1")
                {
                    english();
                }
                else
                {
                    persian();
                }
            }
        }
    }
}
